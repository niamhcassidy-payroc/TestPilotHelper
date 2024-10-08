using Newtonsoft.Json;
using TestPilotHelper;
using TestPilotHelper.Models;

async Task GenerateTestPilotFileAsync()
{
    // 1. Create tables needed
    
    var item = new DeploymentInventoryItem
    {
        InventoryItemTypeId = 1,
        ManufacturerId = 12,
        PrimaryVendorId = 2,
        ReorderLevel = 2,
        ReorderQty = 3
    };

    var instance = new DeploymentInventoryItemInstance
    {
        InventoryItemInstanceConditionId = 1,
        InventoryItemInstanceStatusId = 1
    };

    // 2. Serialize to JSON
    
    var jsonItem = JsonConvert.SerializeObject(item, Formatting.Indented);
    var jsonInstance = JsonConvert.SerializeObject(instance, Formatting.Indented);

    // 3. Save tables as Dictionary
    
    var tables = new Dictionary<string, string>
    {
        { "dbo.DeploymentInventoryItem", jsonItem },
        { "dbo.DeploymentInventoryItemInstance", jsonInstance }
    };

    // 4. Generate Test Pilot File
    
    var fileName = "TEST-add-new-item-with-reorder-2-and-1-instance-in-inventory";

    var testPilotFilePath = Helper.GenerateTestPilotFile(tables, fileName);
    Console.WriteLine("The Test Pilot file has been generated at: " + testPilotFilePath);
    
    //5. Done - Now it can be copy and pasted into the TestData folder
}

await GenerateTestPilotFileAsync();