namespace FluentFinancialFormulae.API.FinancialMarkets;

public partial class FinancialMarkets: IFinancialMarketsBuilder, ICalculations
{
    //Private constructor
    private FinancialMarkets() { }

    /// <summary>
    /// Initialises a FinancialMarkets that can return:<br></br>
    /// Real rate of return<br></br>
    /// Rate of inflation
    /// </summary>
    /// <returns></returns>
    public static ICalculations Init()
    {
        return new FinancialMarkets();
    }
}