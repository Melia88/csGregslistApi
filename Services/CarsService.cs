using System;
using System.Collections.Generic;
using csGregslistApi.DB;
using csGregslistApi.Models;

namespace csGregslistApi.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> GetAll()
    {
      return FakeDB.Cars;
    }

    internal Car GetById(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }

    internal void DeleteCar(string id)
    {
      Car found = GetById(id);
      FakeDB.Cars.Remove(found);
    }
  }
}