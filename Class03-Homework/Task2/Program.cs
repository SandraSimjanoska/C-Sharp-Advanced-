//Create a class Vehicle that has one method DisplayInfo().
//Create classes Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method.

//Extended from class04 homework
//From the previos homework get the implementation and do not change the implementation of the classes. Now we need to add couple methods
//Car class should have Drive() method;
//MotorBike should have Wheelie() method;
//Boat should have Sail() method;
//Airplane should habe Fly() method;

using Task2.Vehicles;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

Car car2 = new Car();
MotorBike motorBike2 = new MotorBike();
Boat boat2 = new Boat();
Airplane plane2 = new Airplane();

car2.Drive();
motorBike2.Wheelie();
boat2.Sail();
plane2.Fly();