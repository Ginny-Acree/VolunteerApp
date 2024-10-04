using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;


namespace StudentPop;
public class ColumnToList
{
    [Name("FirstName")]
    public string FirstName{ get; set; }
    
    [Name("Class")]
    public string Class { get; set; }
    
    [Name("Block")]
    public string Block { get; set; }
    
    [Name("NumberOfVolHours")]
    public string NumberOfVolHours { get; set; }
    
}
//Class,Block,NumberOfVolHours,,,,,,,,,,,,,,,,,