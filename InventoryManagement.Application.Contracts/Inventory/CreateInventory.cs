namespace InventoryManagement.Application.Contracts.Inventory
{
    public class CreateInventory
    {
        public long ProductId { get; set; }
        public long UnitPrice { get; set; }
    }
}