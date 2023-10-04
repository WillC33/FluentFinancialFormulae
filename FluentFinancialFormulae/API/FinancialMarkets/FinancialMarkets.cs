namespace FluentFinancialFormulae.API.FinancialMarkets;

public partial class FinancialMarkets: IFinancialMarketsBuilder, IFinancialMarketsCalculations
{
    //Private constructor
    private FinancialMarkets() { }

    /// <summary>
    /// Initialises a FinancialMarkets that can return:<br></br>
    /// Real rate of return<br></br>
    /// Rate of inflation
    /// </summary>
    /// <returns></returns>
    public static IFinancialMarketsCalculations Init()
    {
        return new FinancialMarkets();
    }
}