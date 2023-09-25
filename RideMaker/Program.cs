Vehicle Sierra = new("Sierra 1500", 5, "Black", true);
Vehicle Mustang = new("Mustang", 2, "Gray", false);
Vehicle Harley = new("Street Glide", "Forest Green");
Vehicle Camaro = new("Chevy Camaro", "Deep Purple");

List<Vehicle> VehicleList = new() {Sierra, Mustang, Harley, Camaro};


for(int i = 0; i < VehicleList.Count; i++)
{
    VehicleList[i].ShowInfo();
}

Sierra.Travel(100);
Sierra.ShowInfo();