using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netProject
{
    internal class Program
    {
        private static string cityId;

        static void Main(string[] args)
        {
            using (var db = new CableSystemManagementEntities())
            {
                /* Customer result= db.Customers.Where(x=> x.CustomerId==6).FirstOrDefault();

                 Console.WriteLine(result.CustomerFirstName+"\t"+result.CustomerLastName+"\t"+result.CustomerId);
                 Console.ReadLine();*/

                var City = new City();
                {
                    Console.WriteLine("ENTER the city id");
                    City.CityId = int.Parse(Console.ReadLine());

                    Console.WriteLine("ENTER the city name");
                    City.CityName = Console.ReadLine();

                };
                //Create DBContext object
                using (CableSystemManagementEntities context = new CableSystemManagementEntities())
                {
                    //Add Student object into Students DBset
                    context.Cities.Add(City);
                    // call SaveChanges method to save student into database
                    context.SaveChanges();
                    Console.ReadLine();

                }
            }
        }
    }
}
