using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Registration_System {
  internal class Car {
    public string Brand { get; set; }
    public string Model { get; set; }
    public string LicencePlate { get; set; }
    public string FirstRegistration { get; set; }

    

    public string Mileage { get; set; }


    public Car(string brand, string model, string licencePlate, string firstRegistration, string mileage) {

      this.Brand = brand;
      this.Model = model;
      this.LicencePlate = licencePlate;
      this.FirstRegistration = firstRegistration;
      this.Mileage = mileage;
    }

    public Car() {

    }

    public static List<Car> WriteDataToList() {

      List<Car> listOfCars = new List<Car>();
      String[] data = null;
      StreamReader reader = new(RegistrationPage.txtAdress, Encoding.UTF8);
      
      while (!reader.EndOfStream)
      {
        data = reader.ReadLine().Split("-");
        listOfCars.Add(new Car(data[0], data[1], data[2], data[3], data[4]));
      }
      reader.Close();
      

      return listOfCars;
      
    }

    public override string ToString() {

      this.Brand = this.Brand.Substring(0, 1).ToUpper() + this.Brand.Substring(1).ToLower();
      this.Model = this.Model.Substring(0, 1).ToUpper() + this.Model.Substring(1).ToLower();
      this.LicencePlate = this.LicencePlate.Substring(0, 1).ToUpper() + this.LicencePlate.Substring(1).ToLower();
      this.Mileage = this.Mileage.Substring(0, 1).ToUpper() + this.Mileage.Substring(1).ToLower();

      return $"{this.Brand}-{this.Model}-{this.LicencePlate}-{this.FirstRegistration.Trim()}-{this.Mileage}";
    }

   
  }
}
