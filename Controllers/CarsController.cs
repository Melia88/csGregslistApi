using System;
using System.Collections.Generic;
using csGregslistApi.DB;
using csGregslistApi.Models;
using csGregslistApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace csGregslistApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _service;

    public CarsController(CarsService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Cars);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Car> GetById(string id)
    {
      try
      {
        Car found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _service.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCar(string id)
    {
      try
      {
        _service.DeleteCar(id);
        return Ok("Deleted Successfully");
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}