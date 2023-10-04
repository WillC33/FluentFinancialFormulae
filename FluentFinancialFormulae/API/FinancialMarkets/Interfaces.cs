namespace FluentFinancialFormulae.API.FinancialMarkets;

public interface IFinancialMarketsBuilder
{
    public static abstract IFinancialMarketsCalculations Init();
}

public interface IFinancialMarketsCalculations
{
    public IInitialPriceIndex RateOfInflation();
    public INominalRate RealRateOfReturn();
}

#region RateOfInflation

public interface IInitialPriceIndex
{
    public IEndingPriceIndex WithInitialConsumerPriceIndex(decimal _);
}

public interface IEndingPriceIndex
{
    public IRateOfInflation WithEndingConsumerPriceIndex(decimal _);
}

public interface IRateOfInflation
{
    public decimal CalculateRateOfInflation();
}

#endregion


#region RealRateOfReturn

public interface INominalRate
{
    public IInflationRate WithNominalRate(decimal _);
}

public interface IInflationRate
{
    public IRateOfReturn WithInflationRate(decimal _);
}

public interface IRateOfReturn
{
    public decimal CalculateRealRateOfReturn();
}

#endregion