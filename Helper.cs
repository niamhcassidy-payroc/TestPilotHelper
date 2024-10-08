using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestPilotHelper;

public static class Helper
{
    public static string GenerateTestPilotFile(Dictionary<string, string> tables, string fileName)
    {
        //Create test pilot json content
        var testPilotContent = AddTestPilotWrapper(tables);
        
        //Create the file
        return CreateJsonFile(testPilotContent, fileName);
    }

    private static string AddTestPilotWrapper(Dictionary<string, string> tables)
    {
        var wrapper = new JObject
        {
            ["IPSMSPRotate"] = new JObject
            {
                ["tables"] = new JObject(),
                ["type"] = "SqlServer"
            }
        };

        foreach (var table in tables)
        {
            ((JObject)wrapper["IPSMSPRotate"]?["tables"]!)[table.Key] = new JObject
            {
                ["data"] = new JArray
                {
                    JObject.Parse(table.Value)
                }
            };
        }
        
        // Convert the entire wrapped structure to a JSON string
        return wrapper.ToString(Formatting.Indented);
    }

    private static string CreateJsonFile(string jsonContent, string fileName)
    {
        var projectDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
        const string relativePath = "Output";
        var fullPath = Path.Combine(projectDirectory, relativePath);
        
        // Combine directory path and filename to get the full path
        var filePath = Path.Combine(fullPath, $"{fileName}.json");

        try
        {
            //Write or overwrite the contents of the test file
            File.WriteAllText(filePath, jsonContent);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error writing file: {ex.Message}");
        }

        return filePath;
    }
}