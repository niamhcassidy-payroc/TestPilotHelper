namespace TestPilotHelper.Models
{
    public class DeploymentInventoryItemInstance
    {
        public string InventoryItemId { get; set; } =
            "{{ reference.query('IPSMSPRotate', 'dbo.DeploymentInventoryItem') | reference.get_primary_key() }}";

        public short InventoryItemInstanceConditionId { get; set; } = 1;

        public short InventoryItemInstanceStatusId { get; set; } = 1;

        public int? PurchaseOrderId { get; set; }

        public int? PurchaseOrderItemInventoryItemId { get; set; }

        public string SerialNumber { get; set; } = "Test-{{ guid.new() }}";

        public short? PaymentTermId { get; set; } = null;

        public int CreatedBy { get; set; } = 495;

        public string CreatedDate { get; set; } = "{{ datetime.now() }}";

        public int? UpdatedBy { get; set; } = 495;

        public string? UpdatedDate { get; set; } = "{{ datetime.now() }}";

        public int? DeletedBy { get; set; } = null;

        public DateTime? DeletionDate { get; set; } = null;

        public int? AllocatedBy { get; set; } = null;

        public int? AllocatedTo { get; set; } = null;

        public DateTime? AllocatedDate { get; set; } = null;

        public string AllocationNotes { get; set; } = null;

        public int? AllocatedToISCId { get; set; } = null;

        public int? AllocatedToVendorId { get; set; } = null;

        public bool? AllocatedItemToBeReturned { get; set; } = null;
    }

}