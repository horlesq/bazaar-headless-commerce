namespace Bazaar.Domain;

public sealed record Money
{
    public long Amount { get; init; }
    public string Currency { get; init; }

    private Money(long amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Money Create(long amount, string currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.", nameof(amount));

        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency cannot be null or empty.", nameof(currency));

        return new Money(amount, currency);
    }
}