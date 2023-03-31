using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksLookupApiContext _db;

    public ParksController(ParksLookupApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkName, string type, string state)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entery => entery.ParkName == parkName);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      return await query.ToListAsync();
    }

    // [HttpGet("{id}")]

  }
}