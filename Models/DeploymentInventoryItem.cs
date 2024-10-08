namespace TestPilotHelper.Models
{
    public class DeploymentInventoryItem
    {
        public short InventoryItemTypeId { get; set; } = 1;

        public short ManufacturerId { get; set; }

        public int PrimaryVendorId { get; set; }

        public string Model { get; set; } = "Test Model - {{ guid.new() }}";

        public short? HardwareAdvantagePlanId { get; set; } = 2;

        public bool IsBulkItem { get; set; } = true;

        public bool IsStockedItem { get; set; } = true;

        public bool IsEligibleForReorder { get; set; } = true;

        public bool IsSupported { get; set; } = true;

        public bool IsDeployable { get; set; } = true;

        public bool IsAgentDeployable { get; set; } = true;

        public int ReorderLevel { get; set; }

        public int ReorderQty { get; set; }

        public string Notes { get; set; } = "Test inventory item.";

        public bool SupportsPaymentech { get; set; } = true;

        public bool SupportsTSYS { get; set; } = true;

        public bool SupportsFDC { get; set; } = true;

        public bool SupportsIBX { get; set; } = false;

        public bool Active { get; set; } = true;

        public int CreatedBy { get; set; } = 495;

        public string CreatedDate { get; set; } = "{{ datetime.now() }}";

        public int? UpdatedBy { get; set; } = 495;

        public string? UpdatedDate { get; set; } = "{{ datetime.now() }}";

        public int? DeletedBy { get; set; } = null;

        public DateTime? DeletionDate { get; set; } = null;

        public short CallTagShippingAddressTypeId { get; set; } = 6;
    }
}