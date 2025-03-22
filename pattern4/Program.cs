// See https://aka.ms/new-console-template for more information
using pattern4.Factory;

Console.WriteLine("Hello, World!");

var FactoryRussia = new FacilityRussia();
var carRussia = FactoryRussia.BuildCar();

var FactoryTurkey = new FacilityTurkey();
var carTurkey = FactoryTurkey.BuildCar();