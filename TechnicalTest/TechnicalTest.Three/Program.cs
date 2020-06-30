using System;
using static TechnicalTest.Library.Helpers;

/*
 * 
 * There is something wrong with this program that is causing it to throw an exception
 * Please adjust code so that the catch block in Main() function is not being hit.
 * 
 */

namespace TechnicalTest.Three
{
    

    class Program
    {
        public static Action Action = Pass;
        static void Main()
        {
            
            var localRepository = new TestThreeRepository();
            var customers = localRepository.GetCustomers();
            foreach(var customer in customers)
            {
                try
                {
                    Console.WriteLine($"{customer.Name} - {customer.Age} - {customer.Specifics()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Action = Fail;
                }
            }

            Action.Invoke();
        }
    }
}
