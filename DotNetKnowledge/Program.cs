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

#endregion