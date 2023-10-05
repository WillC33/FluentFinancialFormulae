using FluentFinancialFormulae.Formulae;

namespace FluentFinancialFormulae.API.Banking;

public partial class Banking : IStatedInterestRate, ICompoundingPeriods, IAnnualPercentageYield
{
    private decimal _statedAnnualInterestRate;
    private decimal _numberOfTimesCompounded;
    
    /// <summary>
    /// Initialises the Banking object for APY
    /// </summary>
    /// <returns></returns>
    public static IStatedInterestRate AnnualPercentageYield()
    {
        return new Banking();
    }
    
    /// <summary>
    /// Sets the stated interest rate
    /// </summary>
    /// <param name="interestRate"></param>
    /// <returns></returns>
    public ICompoundingPeriods WithInterestRate(decimal interestRate)
    {
        _statedAnnualInterestRate = interestRate;
        return this;
    }

    /// <summary>
    /// Sets the number of periods to compound over
    /// </summary>
    /// <param name="periods"></param>
    /// <returns></returns>
    public IAnnualPercentageYield WithCompoundingPeriods(decimal periods)
    {
        _numberOfTimesCompounded = periods;
        return this;
    }

    /// <summary>
    /// Calculates the Annual percentage yield
    /// </summary>
    /// <returns></returns>
    public decimal CalculateAnnualPercentageYield()
    {
        return BankingFormulae.CalcAnnualPercentageYield(_statedAnnualInterestRate, _numberOfTimesCompounded);
    }
}