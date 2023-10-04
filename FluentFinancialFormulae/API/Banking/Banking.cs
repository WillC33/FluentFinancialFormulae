using FluentFinancialFormulae.API.FinancialMarkets;

namespace FluentFinancialFormulae.API.Banking;

public partial class Banking : IBankingCalculations
{
    private decimal _statedAnnualInterestRate;
    private decimal _numberOfTimesCompounded;
    private decimal _presentValue;
    private decimal _balloonAmount;
    private decimal _ratePerPeriod;
    private decimal _numberOfPeriods;
    private decimal _principal;
    private decimal _rate;
    private decimal _time;
    private decimal _monthlyDebtPayments;
    private decimal _grossMonthlyIncome;
    //TODO: missing members, check interfaces
    private decimal _loans;
    private decimal _deposits;
    private decimal _loanAmount;
    private decimal _valueOfCollateral;
    private decimal _payment;
    
    //private constructor
    private Banking(){ }

    /// <summary>
    /// Initialises a new banking object from a static context
    /// </summary>
    /// <returns></returns>
    public static IBankingCalculations Init()
    {
        return new Banking();
    }
}