using System.Security.Principal;

namespace FluentFinancialFormulae.API.Banking;

public interface IBankingBuilder
{
    public static abstract IStatedInterestRate AnnualPercentageYield();
    public static abstract IPresentValue BalloonLoanPayment();
    public static abstract IPrincipalValue CompoundInterest();
    /*public IPrincipalValue ContinuousCompounding();
    public IMonthlyDebt DebtToIncomeRatio();
    public IPresentValue BalloonBalanceOfLoan();
    public IPresentValue LoanPayment();
    public IPresentValue RemainingBalanceOnLoan();
    public ILoans LoanToDepositRatio();
    public ILoanAmount LoanToValueRatio();
    public IPrincipalValue SimpleInterest();
    public IPrincipalValue SimpleInterestRate();
    public IInterest SimpleInterestPrincipal();
    public IPrincipalValue SimpleInterestTime();*/
}

#region AnnualPercentageYield

public interface IStatedInterestRate
{
    public ICompoundingPeriods WithInterestRate(decimal _);
}

public interface ICompoundingPeriods
{
    public IAnnualPercentageYield WithCompoundingPeriods(decimal _);
}

public interface IAnnualPercentageYield
{
    public decimal CalculateAnnualPercentageYield();
}

#endregion

#region BalloonLoanPayment

public interface IPresentValue
{
    public IBalloonAmount WithPresentValue(decimal _);
}

public interface IBalloonAmount
{
    public IRatePerPeriod WithBaloonAmount(decimal _);
}

public partial interface IRatePerPeriod
{
    public INumberOfPeriods WithPeriodRate(decimal _);
}

public interface INumberOfPeriods
{
    public IBalloonLoanPayment WithPeriods(decimal _);
}

public interface IBalloonLoanPayment
{
    public decimal CalculateBalloonLoanPayment();
}

#endregion

#region CompoundInterest

public interface IPrincipalValue
{
    public IRatePerPeriod WithPrincipal(decimal _);
}

public partial interface IRatePerPeriod
{
    //located in another method
}


#endregion