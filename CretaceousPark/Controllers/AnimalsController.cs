using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CretaceousPark.Models;
using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private CretaceousParkContext _db;

    public AnimalsController(CretaceousParkContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
    return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    // PUT api / animal / 5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }
  }
}