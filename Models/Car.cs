using System;

namespace csGregslistApi.Models
{
  public class Car
  {
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }

    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public Car(string make, string model, int year, int price, string description, string imgUrl)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      Description = description;
      ImgUrl = imgUrl;
    }
  }
}