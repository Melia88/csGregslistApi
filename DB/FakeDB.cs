using System.Collections.Generic;
using csGregslistApi.Models;


namespace csGregslistApi.DB
{
  public static class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
        new Car("toyota", "FJ Cruiser", 2014, 54000, "Amazing!", "https://cdn.shopify.com/s/files/1/2278/0587/products/IMG_6276_1100x.JPG?v=1571716899")
    };
    public static List<House> Houses { get; set; } = new List<House>(){
        new House("123 thisIsMe", 2, 1, 1220)
    };
  }
}