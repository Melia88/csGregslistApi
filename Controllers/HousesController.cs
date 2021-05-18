using System;
using System.Collections.Generic;
using csGregslistApi.DB;
using csGregslistApi.Models;
using csGregslistApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace csGregslistApi.Controllers
{
  [ApiController]
  [Route("api.[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _service;
    public HousesController(HousesService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<House>> GetAll()
    {
      try
      {
        return Ok(_service.GetAll());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<House> GetById(string id)
    {
      try
      {
        House found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<House> Create([FromBody] House newHouse)
    {

      try
      {
        House house = _service.Create(newHouse);
        return Ok(newHouse);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteHouse(string id)
    {
      try
      {
        _service.DeleteHouse(id);
        return Ok("Successfully Deleted");
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }

}