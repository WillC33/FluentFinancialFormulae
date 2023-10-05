namespace FluentFinancialFormulae.API.FinancialMarkets;

public interface IRealRateOfReturn
{
    public static abstract INominalRate Init();
}

public interface IRateOfInflation
{
    public static abstract IInitialPriceIndex Init();
}

#region RateOfInflation

public interface IInitialPriceIndex
{
    public IEndingPriceIndex WithInitialConsumerPriceIndex(decimal _);
}

public interface IEndingPriceIndex
{
    public ICalcRateOfInflation WithEndingConsumerPriceIndex(decimal _);
}

public interface ICalcRateOfInflation
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