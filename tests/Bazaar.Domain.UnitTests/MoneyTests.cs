namespace Bazaar.Domain.UnitTests;

public class MoneyTests
{
    [Fact]
    public void Create_WithValidValues_ExposesAmountAndCurrency()
    {
        var money = Money.Create(200, "USD");
        Assert.Equal(200, money.Amount);
        Assert.Equal("USD", money.Currency);
    }

    [Fact]
    public void Create_WithNegativeAmount_ThrowsArgumentException()
    {
        Assert.ThrowsAny<ArgumentException>(() => Money.Create(-1, "USD"));
    }

    [Fact]
    public void Create_WithNullCurrency_ThrowsArgumentException()
    {
        Assert.ThrowsAny<ArgumentException>(() => Money.Create(100, null!));
    }

    [Fact]
    public void Create_WithEmptyCurrency_ThrowsArgumentException()
    {
        Assert.ThrowsAny<ArgumentException>(() => Money.Create(100, ""));
    }

    [Fact]
    public void Create_WithWhitespaceCurrency_ThrowsArgumentException()
    {
        Assert.ThrowsAny<ArgumentException>(() => Money.Create(100, " "));
    }
}
