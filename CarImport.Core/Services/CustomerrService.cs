using CarImport.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarImport.Core.Services
{
    public class CustomerrService
    {

        ////Get user from DB
        //public customerDTO addCustomer(customerDTO customer)
        //{
        //    var checkedCustomer = from c in DB.CarFleets
        //                     where car.number == c.CarNumber
        //                     select car.number;

        //    if (!checkedCar.Any())
        //    {
        //        CarFleet carToAdd = new CarFleet
        //        {
        //            CarTypeID = car.typeId,
        //            CarMileage = car.mileage,
        //            CarImage = car.image,
        //            IsOK2Rent = car.properForRent,
        //            CarNumber = car.number,
        //            CarBranchPlace = car.branchPlace
        //        };
        //        DB.CarFleets.Add(carToAdd);
        //        DB.SaveChanges();
        //        message = "Car successfuly created";
        //        return message;
        //    }
        //    else
        //    {
        //        message = "Car with this paramiters is already exist! please choose another parameters";
        //        return message;
        //    }
        //}
    }
}
