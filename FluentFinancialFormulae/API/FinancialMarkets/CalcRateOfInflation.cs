using FluentFinancialFormulae.Formulae;

namespace FluentFinancialFormulae.API.FinancialMarkets;

public partial class FinancialMarkets: IInitialPriceIndex, IEndingPriceIndex, ICalcRateOfInflation
{
    private decimal _initialConsumerPriceIndex { get; set; }
    private decimal _endingConsumerPriceIndex { get; set; }

    
    /// <summary>
    /// Initialises the Rate of inflation method
    /// </summary>
    /// <returns></returns>
    public static IInitialPriceIndex RateOfInflation()
    {
        return new FinancialMarkets();
    }
    
    /// <summary>
    /// Sets the initial consumer price index for the inflation
    /// </summary>
    /// <param name="initialPriceIndex">The Initial Consumer Price Index</param>
    /// <returns></returns>
    public IEndingPriceIndex WithInitialConsumerPriceIndex(decimal initialPriceIndex)
    {
        _initialConsumerPriceIndex = initialPriceIndex;
        return this;
    }

    /// <summary>
    /// Sets the ending consumer price index for the inflation
    /// </summary>
    /// <param name="endingPriceIndex">The Ending Consumer Price Index</param>
    /// <returns></returns>
    public ICalcRateOfInflation WithEndingConsumerPriceIndex(decimal endingPriceIndex)
    {
        _endingConsumerPriceIndex = endingPriceIndex;
        return this;
    }

    /// <summary>
    /// Calculates the inflation rate
    /// </summary>
    /// <returns></returns>
    public decimal CalculateRateOfInflation()
    {
        return FinancialMarketsFormulas.CalcRateOfInflation(_initialConsumerPriceIndex, _endingConsumerPriceIndex);
    }
}