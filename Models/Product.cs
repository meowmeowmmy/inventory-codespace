namespace InventoryCSharp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal PriceWithoutVAT { get; set; }
        public decimal PriceWithVAT { get; set; }
        public string Barcode { get; set; }
    }
}