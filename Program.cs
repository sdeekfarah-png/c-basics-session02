namespace assiment1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1
            /* Book b = new Book() { Title = "Nageeb Mahfouz", Pages = 30 };
             Console.WriteLine(b.ToString());
             Console.WriteLine(b.GetHashCode());
             Console.WriteLine(b.GetType());
             Console.WriteLine(b.Equals(b));*/
            #endregion


            #region Q2
            /* try
             {
                 int y = 0;
                 int x = 10 / y;
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("Cannot divide by zero");
             }
             finally
             {
                 Console.WriteLine("Done");
             }*/
            #endregion

            #region Q3
            /*
           int pages = "464"; // Compile-time Error
           int pages = 464;*/

            #endregion

            #region Q4
            /* try
             {
                 int result = 10 / 0;
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("Cannot divide by zero");
             }
             finally
             {
                 Console.WriteLine("Done");
             }*/
            #endregion

            #region Q5
            /*int pages = 300;
            double b = pages;*/
            #endregion

            #region Q6
            /*double price = 49.99;
            int newPrice = (int)price;

            Console.WriteLine(newPrice);*/
            #endregion

            #region Q7
            /*string pagesText = "234";
            int pages = Convert.ToInt32(pagesText);
            Console.WriteLine(pages);*/
            #endregion

            #region Q8
            /*string yearText = "3023";
            int text = int.Parse(yearText);
            Console.WriteLine(text);

            string badText = "abc";
            int number;

            bool isValid = int.TryParse(badText, out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid number");
               }*/
            #endregion

            #region     Q9
            /* int pages = 464;
             string p =pages.ToString();
             Console.WriteLine(p.GetType());*/
            #endregion

            #region Q10
            /*int copies = 100;
            object obj = copies;
            int copi=(int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(copi);*/
            #endregion
        }
    }
}
