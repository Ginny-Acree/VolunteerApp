using System.Globalization;
using CsvHelper;
using StudentPop;
using System.IO; // Include for StreamReader
using System.Linq;
using Microsoft.VisualBasic; // Include for ToList()


Random rnd = new Random();
int index;
string inputFile = @"/Users/baezej/Desktop/UnityProjects/UnityProjects/Users/baezej/Desktop/UnityProjects/UnityProjects/EricBaezEndlessRunnerWIP0820/ClassroomNamePickerCS/Names.csv";// replace with your csv files name
List<ColumnToList> outputRecords = new(); //creates an empty list where you can store the filtered list

using var reader = new StreamReader(inputFile); //reads the csv file 
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture); // reads the columns from csv file from the link
int i = 0; //intialize with a counter 
var studentsList = csv.GetRecords<ColumnToList>().ToList();// Convert to list if needed
string studentFirstName = studentsList[0].FirstName;
string block= null;
string input;
string theOutput = "There is no students";

//Call the function Here
UserInput();
RandomNamePicker(input);

//Create Your functions here
void UserInput()
{
    Console.WriteLine("Type in the block number you will like to select a random student from");
    input = Console.ReadLine();
    Console.WriteLine("The block you have choosen is " + input);
}

string RandomNamePicker(string input){
    foreach (var student in studentsList)//for loop that goes through a list and creates each element into a variable called student
    {
        if(student.Block == input)
        {
            outputRecords.Add(student);//Adds Student to the filtered list
            i++;//Adds 1 to the counter
            
        }          
        
    }

    if (outputRecords.Count > 0)
        {
            index = rnd.Next(0, ((outputRecords.Count) -1)); //randomly selects a number between 0 and the end of the list
            theOutput = outputRecords[index].FirstName;
            block = outputRecords[index].Class;
            Console.WriteLine("The number of students in the class is " + outputRecords.Count);
            Console.WriteLine("The randomly selected index value is " + index);
            Console.WriteLine("The randomly choosen student is " + theOutput);
            Console.WriteLine(theOutput + " is in " + block);
        }
    else
        {
            Console.WriteLine("Check your spelling or there might not be any students to select in that class");
        }
    return theOutput;

}