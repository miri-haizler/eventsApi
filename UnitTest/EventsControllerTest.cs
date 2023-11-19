using lesson2_calendar.Controllers;
using lesson2_calendar;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest
{
    public class EventsControllerTest
    {
        private readonly EventController _controller;
        private readonly IDataContext _dataContext;
        public EventsControllerTest()
        {
            _dataContext = new FakeContext();
            _controller = new EventController(_dataContext);
        }
        [Fact]
        public void Get_GetOkResult()
        {
            var result = _controller.Get();
            Assert.IsType<OkResult>(result);
        }
    }
}

