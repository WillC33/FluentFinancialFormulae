using FluentFinancialFormulae.API.FinancialMarkets;

namespace FluentFinancialFormulae.API.Banking;

public partial class Banking : IBankingBuilder
{
    
    private decimal _presentValue;
    private decimal _balloonAmount;
    private decimal _ratePerPeriod;
    private decimal _numberOfPeriods;
    private decimal _principal;
    private decimal _rate;
    private decimal _time;
    private decimal _monthlyDebtPayments;
    private decimal _grossMonthlyIncome;
    private decimal _ratePerPayment;
    private decimal _numberOfPayments;
    private decimal _loans;
    private decimal _deposits;
    private decimal _loanAmount;
    private decimal _valueOfCollateral;
    private decimal _payment;
    private decimal _interest;
    
    //private constructor
    private Banking(){ }
}