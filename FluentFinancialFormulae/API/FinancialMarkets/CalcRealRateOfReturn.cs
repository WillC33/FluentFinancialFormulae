using FluentFinancialFormulae.API.FinancialMarkets;
using FluentFinancialFormulae.Formulae;

namespace FluentFinancialFormulae.API;

public class RealRateOfReturn : IRealRateOfReturn, INominalRate, IInflationRate, IRateOfReturn
{
    private decimal _nominalRate { get; set; }
    private decimal _inflationRate { get; set; }
    
    private RealRateOfReturn() { }

    public static INominalRate Init()
    {
        return new RealRateOfReturn();
    }
    
    /// <summary>
    /// Sets the nominal rate to calculate real returns
    /// </summary>
    /// <param name="nominalRate">the nominal return rate</param>
    /// <returns></returns>
    public IInflationRate WithNominalRate(decimal nominalRate)
    {
        _nominalRate = nominalRate;
        return this;
    }

    /// <summary>
    /// Sets the inflation rate to calculate real returns
    /// </summary>
    /// <param name="inflationRate">the inflation rate</param>
    /// <returns></returns>
    public IRateOfReturn WithInflationRate(decimal inflationRate)
    {
        _inflationRate = inflationRate;
        return this;
    }

    /// <summary>
    /// Calculates the real rate of return
    /// </summary>
    /// <returns></returns>
    public decimal CalculateRealRateOfReturn()
    {
        return FinancialMarketsFormulas.CalcRealRateOfReturn(_nominalRate, _inflationRate);
    }
}