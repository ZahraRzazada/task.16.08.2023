using System;
namespace _16._08._2023
{
	internal class Order
	{
		public List<Product> Products { get; set; }
		public int TotalPrice
		{
			get
			{
				int totalPrice;
				int total = default;
				foreach (Product product in Products)
				{
					totalPrice = product.Count * product.Price;
					total += totalPrice;

				}
				return total;
			}
		}
        public DateTime Data;
        public Order()
		{
			//TotalPrice = totalPrice;
			//Data = data;
            Products = new List<Product>();
        }
		public void AddOrder(Product product)
		{
			Products.Add(product);
		}
	}
}

