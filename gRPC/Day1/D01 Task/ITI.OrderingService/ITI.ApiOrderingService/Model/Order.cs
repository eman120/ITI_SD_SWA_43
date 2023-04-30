namespace ITI.ApiOrderingService.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Balance { get; set; }
        public ICollection<int> ProductsIds { get; set; }
        public int clientId { get; set; }
    }
}
