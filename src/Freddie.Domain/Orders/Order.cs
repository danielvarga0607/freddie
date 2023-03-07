using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();

    private Order()
    {

    }

    public Guid Id { get; private set; }

    public Guid CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            CustomerId = customer.Id
        };
    }

    public void Add(Product product)
    {
        LineItem lineItem = new(Guid.NewGuid(), Id, product.Id, product.Price);

        _lineItems.Add(lineItem);
    }
}