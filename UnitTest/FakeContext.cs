//using lesson2_calendar.Controllers;
using lesson2_calendar;

namespace lesson2_calendar
{

    public class FakeContext : IDataContext
    {
        //public List<Event> Events { get; set; }
        public List<Event> events { get; set ; }

        public FakeContext()
        {
            events = new List<Event>()
            {
                new Event{ Id=5,Title="abc" },
                new Event{ Id=4,Title="def" }
            };
        }
    }
}
