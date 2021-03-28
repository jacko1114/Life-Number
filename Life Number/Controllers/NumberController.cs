using Life_Number.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Life_Number.Controllers
{
  [Route("api/[controller]/[action]")]
  [ApiController]
  public class NumberController : ControllerBase
  {
    private readonly INumberService _service;
    public NumberController(INumberService service)
    {
      _service = service;
    }

    public IActionResult GetNumerology(string constellation, int? number)
    {
      if (string.IsNullOrEmpty(constellation) || number == null)
      {
        return BadRequest();
      }

      var result = _service.GetLifeNumberData(constellation, (int)number);

      return result != null ? Ok(result.Info) : Problem();
    }

    public IActionResult GetNumberData()
    {
      var result = _service.GetLifeNumberDatas();

      return Ok(result);
    }
  }
}
