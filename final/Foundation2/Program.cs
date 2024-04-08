using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();

        //customers addresses
        Address _address1 = new Address{
            _streetAddress = "15204 Unbridled Lane",
            _city = "Noblesville",
            _state = "Indiana",
            _country = "USA"
        };
        Address _address2 = new Address{
            _streetAddress = "123 Maganda",
            _city = "Concepcion",
            _state = "Tarlac",
            _country = "Philippines"
        };
        Address _address3 = new Address{
            _streetAddress = "136 New Place",
            _city = "Brooklyn",
            _state = "New York",
            _country = "USA"
        };

        //customers
        Customer _customer1 = new Customer{
            _name = "Angelina Brooke",
            _address = _address1
        };
        Customer _customer2 = new Customer{
            _name = "Princess Richmond",
            _address = _address2
        };
        Customer _customer3 = new Customer{
            _name = "Taylor Swiss",
            _address = _address3
        };

        //products
        Product product1 = new Product{
            _name = "Product 1",
            _productId = 0123,
            _price = 8.50m,
            _quantity = 3
        };
        Product product2 = new Product{
            _name = "Product 2",
            _productId = 0456,
            _price = 10.25m,
            _quantity = 2
        };
        Product product3 = new Product{
            _name = "Product 3",
            _productId = 0789,
            _price = 16.10m,
            _quantity = 2
        };


        //orders
        Order _order1 = new Order{
            _customer = _customer1,
            _products = new List<Product> {product1, product2, product3}
        };
        Order _order2 = new Order{
            _customer = _customer2,
            _products = new List<Product> {product3, product1}
        };
        Order _order3 = new Order{
            _customer = _customer3,
            _products = new List<Product> {product2, product3}
        };

       //Order Summary Display Output
        Console.WriteLine("Order 1 Summary:");
        Console.WriteLine(_order1.PackingLabel());
        Console.WriteLine(_order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${_order1.TotalCost()}");
        Console.WriteLine("_____________________________________________________________________");

        Console.WriteLine("Order 2 Summary:");
        Console.WriteLine(_order2.PackingLabel());
        Console.WriteLine(_order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${_order2.TotalCost()}");
        Console.WriteLine("_____________________________________________________________________");

        Console.WriteLine("Order 3 Summary:");
        Console.WriteLine(_order3.PackingLabel());
        Console.WriteLine(_order3.ShippingLabel());
        Console.WriteLine($"Total Price: ${_order3.TotalCost()}");
        Console.WriteLine("_____________________________________________________________________");

    }
}