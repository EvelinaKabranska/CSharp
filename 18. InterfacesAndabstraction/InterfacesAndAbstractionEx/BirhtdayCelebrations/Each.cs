namespace BirhtdayCelebrations
{
    using System.Linq;
    using System;
   public class Each : IFormat
    {
        private string kind;
        private string date;

        public Each(string kind,string date)
        {
            this.Kind = kind;
            this.Date = date;
        }
        public string Kind { get; }
        public string Date { get; }
    }
}
