using System;

namespace basics
{
    public class DateTimeAndTimeSpan
    {
        public DateTimeAndTimeSpan()
        {
            // var dt = new DateTime(2023, 10, 30);
            // Console.WriteLine(dt);
            // Console.WriteLine(dt.Date);
            // Console.WriteLine(dt.Day);
            // Console.WriteLine(dt.Hour);
            // Console.WriteLine(dt.Millisecond);
            // Console.WriteLine(dt.DayOfWeek);
            
            var ts = new TimeSpan(12, 24, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine(ts);
        }
    }
}