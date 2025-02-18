/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: OOP Inheritance
*/
namespace COMP003A.LectureActivity6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Vechile object with brand and year
            Vehicle myVehicle = new Vehicle { Brand = "Toyota", Year = 2020 };
            // Create a car object with brand, year, and number of doors
            Car myCar = new Car("Honda", 2022, 4);

            // Display vechile details
            myVehicle.DisplayInfo();
            // Display car details
            myCar.DisplayInfo();
        }
    }
}
