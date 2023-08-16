using _16._08._2023;

Order order = new Order();

Product product1 = new Product("Chocolate",3,15);
Product product2 = new Product("Bread",1,10);
Product product3 = new Product("Soup",2,20);
Product product4 = new Product("Shampon",8,10);
Product product5 = new Product("Icecream",4,25);

order.AddOrder(product1);
order.AddOrder(product2);
order.AddOrder(product3);
order.AddOrder(product4);
order.AddOrder(product5);

Console.WriteLine("Total price:");
Console.WriteLine(order.TotalPrice);