using System;
namespace Exercism
{

    public enum Schedule
    {
        Teenth,
        First,
        Second,
        Third,
        Fourth,
        Last
    }

    public class Meetup
    {
        public readonly DateTime StartOfMonth;

        public Meetup(int month, int year) => StartOfMonth = new DateTime(year, month, 1);

        private DateTime Teenth(DayOfWeek dayOfWeek)
        {
            // This will return a "Teenth" day, e.g. 13 -> 19
            var day = StartOfMonth.AddDays(12);
            while (day.DayOfWeek != dayOfWeek)
                day = day.AddDays(1);
            return day;
        }
        private DateTime First(DayOfWeek dayOfWeek)
        {
            var day = StartOfMonth;
            while (day.DayOfWeek != dayOfWeek)
                day = day.AddDays(1);
            return day;
        }
        private DateTime Last(DayOfWeek dayOfWeek)
        {
            // To get to the last day of the month. We Add 1 month to the current StartOfMonth property
            // then we subtract 1 day from that DateTime property.
            var day = StartOfMonth.AddMonths(1).AddDays(-1);
            while (day.DayOfWeek != dayOfWeek)
                day = day.AddDays(-1);
            return day;
        }
        private DateTime Second(DayOfWeek dayOfWeek) => First(dayOfWeek).AddDays(7);
        private DateTime Third(DayOfWeek dayOfWeek) => First(dayOfWeek).AddDays(14);
        private DateTime Fourth(DayOfWeek dayOfWeek) => First(dayOfWeek).AddDays(21);
        
        public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule) => schedule switch
        {
            // Using the new switch expressions
            Schedule.Teenth => Teenth(dayOfWeek),
            Schedule.First => First(dayOfWeek),
            Schedule.Second => Second(dayOfWeek),
            Schedule.Third => Third(dayOfWeek),
            Schedule.Fourth => Fourth(dayOfWeek),
            Schedule.Last => Last(dayOfWeek),
            _ => throw new ArgumentException("Bad schedule")
        };
    }
}