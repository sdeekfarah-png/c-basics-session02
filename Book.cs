using System;
using System.Collections.Generic;
using System.Text;

namespace session1Task
{
   public class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
           
            return $"Title: {Title}, Pages: {Pages}";
       
         }

        public override bool Equals(object? obj)
        {
            if (obj is Book other)
            {
                return Title == other.Title && Pages == other.Pages;
            }

            return false;
        }

    }
}
