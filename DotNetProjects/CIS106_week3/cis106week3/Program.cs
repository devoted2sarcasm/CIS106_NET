using System.Security.Permissions;
using WeekThree.enums;
using WeekThree.models;

Employee frank = new Employee {
    FirstName = "Frank",
    MiddleName = "J",
    LastName = "Smith",
    Id = "12345"
};

string frankFullName = frank.GenerateFullName();

Console.WriteLine(frankFullName);

string staticFrankFullName = Employee.GenerateFullName("Frank", "J", "Smith");


int buildingNumber = 234;

Building building = Building.TECH_CENTER;

switch(building) {
    case Building.GYMNASIUM:
        //do stuff
        break;
    case Building.TECH_CENTER:
        //do stuff
        break;
    case Building.LIBRARY:
        //do stuff
        break;
    default:
        throw new Exception("Building not found");
        break;
}

string currentBuilding = "TECH_CENTER";
Building parsedBuilding;

if (Enum.TryParse(currentBuilding)) out parsedBuilding) {
    Console.WriteLine($"Our building is {parsedBuilding}");
} else {
    Console.WriteLine("Building not found");
}

foreach (Building newBuilding in Enum.GetValues(typeof(Building))) {
    Console.WriteLine($"Building: {building}");
}


/// <summary>
/// Representation of an employee
/// </summary>
/// <author>Frank Smith</author>
/// 