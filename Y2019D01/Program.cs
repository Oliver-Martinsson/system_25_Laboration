// See https://aka.ms/new-console-template for more information

using AdventOfCode.Common;
using Y2019D01;




Console.WriteLine("Hello, World!");
var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
var text = File.ReadAllText(path);

var masses = Input.Numbers(text);
var requiredFuel = new RequiredFuel();
var fuelRequired = requiredFuel.CalculateRequiredFuel(masses);
var fuelRequiredWithFuel = requiredFuel.CalculateRequiredFuelWithFuel(masses);

Console.WriteLine($"The file contained {masses.Length} entries, The total fuel required is {fuelRequired}.");
Console.WriteLine($"The total fuel required is {fuelRequiredWithFuel}.");