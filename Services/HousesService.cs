using System;
using System.Collections.Generic;
using csGregslistApi.DB;
using csGregslistApi.Models;

namespace csGregslistApi.Services
{
  public class HousesService
  {
    internal IEnumerable<House> GetAll()
    {
      return FakeDB.Houses;
    }

    internal House GetById(string id)
    {
      House found = FakeDB.Houses.Find(h => h.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }

    internal void DeleteHouse(string id)
    {
      House found = GetById(id);
      FakeDB.Houses.Remove(found);
    }
  }
}