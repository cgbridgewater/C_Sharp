// Vehicle(string name, int passengers, string color, bool hasEngine){
// public Car(string name, string color){
// public Truck(string name, string color){


Vehicle Truck = new Vehicle("Dodge Truck", "White");
Vehicle Outback = new Vehicle("Subaru Outback" ,4 ,"Grey",true);
Vehicle MtnBike = new Vehicle("Yeti Mountain Bike", 1, "Black", false);
Vehicle SchoolBus = new Vehicle("School Bus", 30, "Yellow", true);


List<object> MyVehicals = new List<object>();
MyVehicals.Add(Truck);
MyVehicals.Add(Outback);
MyVehicals.Add(MtnBike);
MyVehicals.Add(SchoolBus);

foreach(Vehicle v in MyVehicals){
    v.ShowInfo();
}


Truck.Travel(100);
Truck.ShowInfo();


// Truck.Travel(10);
// Truck.Travel(10);
// Truck.Travel(10);
// Outback.ShowInfo();
// Outback.Travel(40);
// MtnBike.ShowInfo();
// MtnBike.Travel(5);
// SchoolBus.ShowInfo();
// SchoolBus.Travel(50);