namespace ITI.ApiOrderingService.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public int Price { get; set; }
        //public int? OrderId { get; set; }
    }
}
