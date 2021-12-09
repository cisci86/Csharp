// See https://aka.ms/new-console-template for more information
using Exercise_3;
using Exercise_3.Animals;

//var Lasse = new Person();
//Lasse.Age = 30;

PersonHandler pHandler = new PersonHandler();
//To catch the exception that might be cast in the Person class.
try
{
    //Just trying out the code by creating a fake person. Testing the other methods in the PersonHandler.
 var lisa = pHandler.CreatePerson(23, "Lisa", "Svensson", 163, 75);
    Console.WriteLine(pHandler.GetFullName(lisa));
    Console.WriteLine(pHandler.GetAge(lisa));
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
  var adam = pHandler.CreatePerson(30, "Adam", "Avensson", 180, 83);
    Console.WriteLine($"Name: {adam.FName} {adam.LName}, age: {adam.Age}years");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
    //Testing the Try/Catch part.
{
    var lotta = pHandler.CreatePerson(38, "Lisa", "P", 171, 74);
    Console.WriteLine($"Name: {lotta.FName} {lotta.LName}, age: {lotta.Age}years");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

var animalList = new List<Animal>();
animalList.Add(new Horse("Bilbo", 800, 8, 23));
animalList.Add(new Swan("Ove", 1.5, 2, 150, "Red"));
animalList.Add(new Worm("Nisse", 0.023, 1, 15));
animalList.Add(new Hedgehog("Hedda", 0.8, 3, "Snails"));
animalList.Add(new Wolfman("Lasse", 80, 26, 1));
animalList.Add(new Dog("Shiva", 32, 11, "White swiss Shepard"));
foreach (var item in animalList)
{
    Console.WriteLine(item.GetType().Name);
    item.DoSound();
    if(item is IPerson) //If the animals also is a IPerson it is cast to one and the Talk method is called.
    {
        IPerson animalAsPerson = item as IPerson;
        animalAsPerson.Talk();
    }
}

var dogsList = new List<Dog>();
//dogsList.Add(new Horse("Stisse", 750, 7, 18));
//F: För att listan bara kan innehålla objekt av typen hund och häst är inte av typen hund.
//F: Nu antar jag att ni menar alla djur och inte även Person, då behöver listan vara av typen Animal.
//Lägga till även Person i samma lista är vad jag vet inte möjligt just nu då Person och Animal inte är länkade på något sätt.

foreach (var item in animalList)
{
    Console.WriteLine(item.Stats());
}
//F: Den printar den mest specialicerade metoden för varje klass, därför printar den olika saker för alla typer av djur.
foreach (var item in animalList) //Only prints the Stats method if the animal is a Dog.
{
    if(item is Dog)
    {
        Console.WriteLine(item.Stats());
        //Console.WriteLine(item.ReturnString());
        Dog itemAsDog = item as Dog;
        Console.WriteLine(itemAsDog.ReturnString());
    }
}
//F: Det funkar inte då Animals inte kommer år methoder som bara ligger i Dog klassen.
//Vi kommer bara åt det som ligger i Anmila klassen när objektet ligger i en Animal "behållare".