using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using tpmod9_1302210053;

namespace tpmod9_1302210053.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mahasiswa : ControllerBase
    {
        public static List<Mahasiswaa> _data = new List<Mahasiswaa>
        {
            new Mahasiswaa("Fikri fadhil mustofa", "1302210053"),
            new Mahasiswaa("yosep", "1302210066"),
            new Mahasiswaa("eko ju", "1302210070"),
            new Mahasiswaa("inang ganteng", "1302210000"),
            new Mahasiswaa("hafid sipit", "1302210099"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<Mahasiswaa> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public Mahasiswaa Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mahasiswa>
        [HttpPost]
        public void Post([FromBody] Mahasiswaa value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}