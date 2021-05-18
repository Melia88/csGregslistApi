using System;
using System.ComponentModel.DataAnnotations;

namespace csGregslistApi.Models
{
  public class House
  {
    public House(string address, int bedrooms, int bathrooms, int price)
    {
      Id = Guid.NewGuid().ToString();
      Address = address;
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Price = price;

    }

    public string Id { get; set; }
    public string Address { get; set; }
    public int Bedrooms { get; set; }
    [Range(1, int.MaxValue)]
    public int Bathrooms { get; set; }
    [Range(1, int.MaxValue)]
    public int Price { get; set; }
  }
}