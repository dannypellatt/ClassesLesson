using ClassesLesson;

Car myCurrentCar = new Car();

myCurrentCar.Make = "Mercedes";
myCurrentCar.Model = "GL450";
myCurrentCar.Year = 2015;

Car myFirstCar = new Car();

myFirstCar.Make = "Mini";
myFirstCar.Model = "Cooper";
myFirstCar.Year = 1967;

Console.WriteLine($"My first car was a {myFirstCar.Make} " +
    $"{myFirstCar.Model} made in the year {myFirstCar.Year}");

Console.WriteLine($"My current car is a {myCurrentCar.Make} " +
    $"{myCurrentCar.Model} made in the year {myCurrentCar.Year}.");