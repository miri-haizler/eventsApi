using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson2_calendar.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public  class EventController : ControllerBase
    {
        private static List<Event> events = new List<Event> {
            new Event() { Start = new DateTime(2023, 12, 5) },
            new Event() { Start = new DateTime(2022, 03, 15) } ,
            new Event() { Start = new DateTime(2005, 04, 25) },
            new Event() { Start = new DateTime(2023, 11, 22) }
        }; 

        //הצגה
        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return events;
        }

             //הוספה
        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            events.Add(newEvent);
            return ;
        }

        //עדכון
        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event upDateEvent)
        {
            var eve =events.Find(e=>e.Id == id);
            eve.Title=upDateEvent.Title;
            return;
        }
        //מחיקה
        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            events.Remove(eve);
            return;
        }

    }
}
