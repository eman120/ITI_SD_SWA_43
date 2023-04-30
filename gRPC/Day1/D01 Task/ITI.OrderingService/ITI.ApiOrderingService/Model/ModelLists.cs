namespace ITI.ApiOrderingService.Model
{
    public class ModelLists
    {

        //public static List<Order> Orders = new()
        //{
        //   new Order
        //    {
        //        OrderId = 1,
        //        //Products = new List<Product>
        //        //{
        //        //    new Product { ProductId = 1, Name = "Iphone" , InStock = 10 , Price = 100, OrderId = 1 },
        //        //    new Product { ProductId = 2, Name = "Huawei" , InStock = 10 , Price = 10, OrderId = 1 },
        //        //},
        //        Products = new List<Product>(),
        //        Balance = 0 // the balance will be calculated in the next line
        //    },
        //    //new Order { OrderId = 2, 
        //    //    Products = ProductsList.Where(p => p.OrderId == 2).ToList(),
        //    //    Balance = ProductsList.Where(p => p.OrderId == 2).ToList().Sum(p => p.Price)
        //    //}
        //};

        public static List<Product> ProductsList = new()
        {
            new Product {
                ProductId = 1,
                Name = "Iphone" ,
                InStock = 10 ,
                Price = 100
            },
            new Product {
                ProductId = 2,
                Name = "Huawei" ,
                InStock = 10 ,
                Price = 10
            },
            new Product {
                ProductId = 3,
                Name = "Samsung" ,
                InStock = 20 ,
                Price = 20
            }
        };


        public static List<Order> Orders = new()
        {
            new Order
            {
                OrderId = 1,
                ProductsIds = ProductsList.Select(product => product.ProductId).ToList(),
                Balance = 0, // the balance will be calculated in the next line
                clientId = 1
            },
            new Order
            {
                OrderId = 2,
                ProductsIds = ProductsList.Select(product => product.ProductId).ToList(),
                Balance = 0, // the balance will be calculated in the next line
                clientId = 2
            }
            // Add more orders here
        };
 
        public static List<Client> Clients = new()
        {
            new Client { Id = 1, Name = "Eman" , Balance = 1000},
            new Client { Id = 2, Name = "Esraa" , Balance = 2000}
        };

        // calculate the balance of products in the order
        static ModelLists()
        {
            foreach (var order in Orders)
            {
                var products = ProductsList.Where(p => order.ProductsIds.Contains(p.ProductId)).ToList();
                order.Balance = products.Sum(p => p.Price);
            }
        }

        public static int CalculateBalance(Order order)
        {
            var products = ProductsList.Where(p => order.ProductsIds.Contains(p.ProductId)).ToList();
            order.Balance = products.Sum(p => p.Price);
            return order.Balance;
        }

    }
}
