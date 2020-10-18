namespace ProductManager.Data
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Units { get; set; }
        public double Cost { get; set; }
        public string? Supplier { get; set; }
        public double? OrderableQuantity { get; set; }
        public string? SupplierItemNumber { get; set; }
        public string? ReorderLink { get; set; }
    }
}