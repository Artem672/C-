using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Homework
{
    class Event
    {
        public string EventName { get; set; }
        public string Place { get; set; }
        public uint MaxPersons { get; set; }

        DateTime EventDate;

        static uint EventId = 0;

        public Event(string EventName, string Place, uint MaxPersons, DateTime Date)
        {
            this.EventName = EventName;
            this.Place = Place;
            this.MaxPersons = MaxPersons;
            this.EventDate = Date;
            EventId++;
        }

        public override string ToString()
        {
            return $"Назва: {this.EventName}\nМісце: {this.Place}\nМаксимальна кількість людей: {this.MaxPersons}\nДата проведення: {this.EventDate}";
        }

        void AddDays(double DayNumber)
        {
            if (DayNumber > 0)
            {
                this.EventDate.AddDays(DayNumber);
            }          
        }

        void AddWeeks(double WeekNumber)
        {
            if(WeekNumber > 0)
            {
                double Days = WeekNumber * 7;
                this.EventDate.AddDays(Days);
            }        
        }
    }
}
