using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson2_calendar.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public  class EventController : ControllerBase
    {
     private  DataContext context;
        public EventController(DataContext Mycontext)
        {
            context=Mycontext;
        }
        //הצגה
        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return context.events;
        }

             //הוספה
        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            context.events.Add(newEvent);
            return ;
        }

        //עדכון
        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event upDateEvent)
        {
            var eve = context.events.Find(e=>e.Id == id);
            eve.Title=upDateEvent.Title;
            return;
        }
        //מחיקה
        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = context.events.Find(e => e.Id == id);
            context.events.Remove(eve);
            return;
        }

    }
}
