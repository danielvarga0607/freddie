namespace Domain.Products;

// Stock Keeping Unit
public record Sku
{
    private const short _defaultLength = 15;

    private Sku(string value) => Value = value;

    public string Value { get; init; }

    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        if (value.Length != _defaultLength)
        {
            return null;
        }

        return new Sku(value);
    }
}
