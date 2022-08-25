using FactPatternBonus;

Console.WriteLine("What database would you like to use: a List, SQL, or Mongo?");
var databaseType = Console.ReadLine();

var response = DataAccessFactory.GetDataAccessType(databaseType);

Console.WriteLine();
Console.WriteLine("Would you like to load or save your data?");
var saveLoad = Console.ReadLine();

if (saveLoad == "save")
{
    response.SaveData();
}
else if (saveLoad == "load")
{
    response.LoadData();
}


