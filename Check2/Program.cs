using Check2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Product>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    Catfood Catfood = new Catfood();

    Console.WriteLine("Enter the value for Name ");
    Catfood.Name = Console.ReadLine();

    Console.WriteLine("Enter the value for Type ");
    Catfood.Type = Console.ReadLine();

    recordList.Add(Catfood);

}

Console.WriteLine("");
Console.WriteLine("The records you entered for each Catfood Name and Catfood Type is:");
Console.WriteLine("");

foreach (Catfood item in recordList)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Type);
    Console.WriteLine("");
}
