namespace ShopBackEnd.DTOs
{
    public class BasketDto : BasketItemDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}
