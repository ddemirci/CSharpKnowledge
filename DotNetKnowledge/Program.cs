using BenchmarkDotNet.Running;

#region Deconstruction

#region Deconstruction in Classes

var vehicle = new DotNetKnowledge.Deconstruction.Vehicle
{
    Make = "Renault",
    Model = "Clio",
    Year = 2020
};

// Instead of these lines below, use deconstruction if there is be a method named as "Deconstruct" in the class
// var make = vehicle.Make;
// var model = vehicle.Model;
// var year = vehicle.Year;

// Deconstruction v1
// (var make, var model, var year) = vehicle;

// Deconstruction v2
// Even you can discard not required properties by "_"
var (make, model, year) = vehicle;
Console.WriteLine($"Your car is {make} {model}, {year}");

#endregion

#region Deconstruction in Records

var company = new DotNetKnowledge.Deconstruction.Company("iChoosr", 2008);
var (name, founded) = company;
Console.WriteLine($"Company named {name} was founded in {founded}");

#endregion

#region Deconstruction in Dictionary<TKey,TValue>

var dict = new Dictionary<string, int>
{
    {"Pencil",1}
};

// Instead of the below lines, use deconstruction. It is a default functionality for the dictionary collection.
// var firstKeyValue = dict.FirstOrDefault();
// var key = firstKeyValue.Key;
// var value = firstKeyValue.Value;

var (key, value) = dict.FirstOrDefault();
Console.WriteLine($"The first key value pair in the dictionary is {key}: {value}");

#endregion

#endregion

#region Boxing&Unboxing

BenchmarkRunner.Run<DotNetKnowledge.BoxingAndUnboxing.BenchmarkForBoxingAndUnboxing>();

#endregion