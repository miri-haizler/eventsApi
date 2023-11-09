namespace lesson2_calendar
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        //public Event(DateTime Start)
        //{
        //    this.Start = Start;
        //}
    }
}
