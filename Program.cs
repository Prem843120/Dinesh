using System;

namespace TestA
{
    class Program
    {

        static void Main(string[] args)
        {
            string std = null;


            try
            {
                //PrintStudentName(std);

                if (std == null)
                    throw new NullReferenceException("Student object is null.");

                Console.WriteLine("Prem");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                throw ;
                Console.WriteLine("xx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
              
            }

            Console.ReadKey();
        }

        private static void PrintStudentName(string std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine("Prem");
        }

    }
}
