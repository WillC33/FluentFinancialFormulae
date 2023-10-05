using FluentFinancialFormulae.Formulae;

namespace FluentFinancialFormulae.API.Banking;

public partial class Banking : IPresentValue, IBalloonAmount, IRatePerPeriod, INumberOfPeriods, IBalloonLoanPayment
{
    public static IPresentValue BalloonLoanPayment()
    {
        return new Banking();
    }
    
    public IBalloonAmount WithPresentValue(decimal presentValue)
    {
        _presentValue = presentValue;
        return this;
    }

    public IRatePerPeriod WithBaloonAmount(decimal balloonAmount)
    {
        _balloonAmount = balloonAmount;
        return this;
    }

    public INumberOfPeriods WithPeriodRate(decimal periodRate)
    {
        _ratePerPeriod = periodRate;
        return this;
    }
    
    public IBalloonLoanPayment WithPeriods(decimal numberOfPeriods)
    {
        _numberOfPeriods = numberOfPeriods;
        return this;
    }

    public decimal CalculateBalloonLoanPayment()
    {
        return BankingFormulae.CalcBalloonLoanPayment(_presentValue, _balloonAmount, _ratePerPeriod, _numberOfPeriods);
    }
}