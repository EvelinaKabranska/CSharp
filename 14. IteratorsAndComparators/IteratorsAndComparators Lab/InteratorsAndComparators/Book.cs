using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors;

        public  Book(string title,int year,params string[] Authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(Authors);
        }
        
        public IReadOnlyCollection<string> authors
        {
            get { return this.Authors.AsReadOnly(); }
        }
    }
}
