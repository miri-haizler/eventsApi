namespace lesson2_calendar
{
    public class DataContext
    {
        public List<Event> events { get; set; }
        public DataContext()
        {
            events=new List<Event>();
            events.Add(new Event { Id = 1, Title = "hello"}); 
        }
    }
}
