using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Four324.Data;
using Four324.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Four324.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        


        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;



            
        }

        // GET api/values
        //[HttpGet]
        //public async Task<IActionResult> GetValues()
        //{
        //    var values = await _context.Values.ToListAsync();


        //    return Ok(values);
        //}


        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            
                int n = _context.Values.Count();
                var values = await _context.Values.FirstOrDefaultAsync(x => x.Id == n);
                return Ok(values);
 

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id == id);

            return Ok(value);

        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] Value value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
            }


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
