using System.Security.Principal;

namespace FluentFinancialFormulae.API.Banking;

public interface IBankingBuilder
{
    public static abstract IBankingCalculations Init();
}

public interface IBankingCalculations
{
    public IStatedInterestRate AnnualPercentageYield();
    public IPresentValue BalloonLoanPayment();
    public IPrincipalValue CompoundInterest();
    public IPrincipalValue ContinuousCompounding();
    public IMonthlyDebt DebtToIncomeRatio();
    public I BalloonBalanceOfLoan();
    public I LoanPayment();
    public I RemainingBalanceOnLoan();
    public I LoanToDepositRatio();
    public I LoanToValueRatio();
    public I SimpleInterest();
    public I SimpleInterestRate();
    public I SimpleInterestPrincipal();
    public I SimpleInterestTime();

}