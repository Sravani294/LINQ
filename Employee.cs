
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace Linqproject
{
    class Employee
    {
        private static int EmployeeID;
        private static string FirstName;
        private static string LastName;
        private static string Title;
        private static DateTime DOB;
        private static DateTime DOJ;
        private static string City;
        private static object emp;

        static void Main(string[] args)
        {
            List<Details> myDetails = new List<Details>();

            myDetails.Add(new Details
            {
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = Convert.ToDateTime("11/16/1984"),
                DOJ = Convert.ToDateTime("06/08/2011"),
                City = "Mumbai",

            });

            myDetails.Add(new Details
            {
                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AssManager",
                DOB = Convert.ToDateTime("08/20/1984"),
                DOJ = Convert.ToDateTime("07/07/2012"),
                City = "Mumbai",
            });



            myDetails.Add(new Details
            {
                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/14/1987"),
                DOJ = Convert.ToDateTime("04/12/2015"),
                City = "Pune",
            });
            myDetails.Add(new Details
            {
                EmployeeID = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("06/03/1990"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Pune",

            });
            myDetails.Add(new Details
            {
                EmployeeID = 1005,
                FirstName = "Nazia",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("03/08/1991"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Mumbai",
            });
            myDetails.Add(new Details
            {
                EmployeeID = 1006,
                FirstName = "Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/07/1989"),
                DOJ = Convert.ToDateTime("08/08/2014"),
                City = "Chennai",
            });
            myDetails.Add(new Details
            {
                EmployeeID = 1007,
                FirstName = "Vijay",
                LastName = "Natarajan",
                Title = "Consultant",
                DOB = Convert.ToDateTime("12/02/1989"),
                DOJ = Convert.ToDateTime("06/01/2015"),
                City = "Mumbai",
            });
            myDetails.Add(new Details
            {
                EmployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = Convert.ToDateTime("11/11/1993"),
                DOJ = Convert.ToDateTime("11/06/2014"),
                City = "Chennai",
            });
            {
                EmployeeID = 1009;
                FirstName = "Suresh";
                LastName = "Mistry";
                Title = "Associate";
                DOB = Convert.ToDateTime("08/12/1992");
                DOJ = Convert.ToDateTime("12/03/2014");
                City = "Chennai";
            };

            myDetails.Add(new Details
            {
                EmployeeID = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOJ = Convert.ToDateTime("01/02/2016"),
                City = "Chennai",
            });

            IEnumerable<Details> DetailsQuery = from Details in myDetails
                                                where Details.EmployeeID > 1000
                                                select Details;
            Console.WriteLine("__________all employee details-------------");
            foreach (Details emp in DetailsQuery)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);


            }
            Console.WriteLine();
            IEnumerable<Details> DetailsQuery2 = from Details in myDetails
                                                 where Details.City != "Mumbai"
                                                 select Details;
            Console.WriteLine("_________employee details who are not in mumbai_______");
            foreach (Details emp in DetailsQuery2)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);


            }
            Console.WriteLine();
            IEnumerable<Details> DetailsQuery3 = from Details in myDetails
                                                 where Details.Title == "AssManager"
                                                 select Details;
            Console.WriteLine("_________employee details whose role is AssManager_______");
            foreach (Details emp in DetailsQuery3)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);


            }
            Console.WriteLine();
            IEnumerable<Details> DetailsQuery4 = from Details in myDetails
                                                 where (Details.LastName.StartsWith("S"))
                                                 select Details;
            Console.WriteLine("_________employee details whose LastName starts with S______");
            foreach (Details emp in DetailsQuery4)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);
            }
            Console.WriteLine();
            IEnumerable<Details> DetailsQuery5 = from Details in myDetails
                                                 where Details.DOJ < Convert.ToDateTime("01/01/2015")

                                                 select Details;

            Console.WriteLine("_________employee details whose DOJ before 01/01/2015______");
            foreach (Details emp in DetailsQuery5)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);


            }
            Console.WriteLine();
            IEnumerable<Details> DetailsQuery6 = from Details in myDetails
                                                 where Details.DOB > Convert.ToDateTime("01/01/1990")

                                                 select Details;

            Console.WriteLine("_________employee details whose DOB after 01/01/1990______");
            foreach (Details emp in DetailsQuery6)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);


            }

            Console.WriteLine();
            IEnumerable<Details> DetailsQuery7 = from Details in myDetails
                                                   where Details.Title=="Consultant "|| Details.Title =="Associate"
                                                   select Details;
            Console.WriteLine("--------------------------------Title = Consultant and Associate");
            foreach (var emp in DetailsQuery7)
            {
             Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp, DOB, emp.DOJ, emp.City);


            }

            Console.WriteLine();
            Console.WriteLine("______Total number of employees :{0}", myDetails.Count);
            int DetailsQuery9 = (from Details in myDetails
                                  where Details.City == "Chennai"
                                  select Details).Count();
            Console.WriteLine("-------------------Chennai Employees:{0}", DetailsQuery9);
            int DetailsQuery10 = myDetails.Max(x => x.EmployeeID);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-------------Highest Employee Id from the List was : {0}", DetailsQuery10);
            Console.WriteLine();
            int DetailsQuery11 = (from Details in myDetails
                                   where Details.DOJ > new DateTime(2015, 01, 1, 0, 0, 0)
                                   select Details).Count();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Total Number of Employees Joined after 1/1/2015 was : {0}", DetailsQuery11);
            Console.WriteLine();



            int DetailsQuery12 = (from Details in myDetails
                                   where Details.Title != "Associate"
                                   select Details).Count();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Total Number of Employess who are not Associates : {0}", DetailsQuery12);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            var DetailsQuery13 = from Details in myDetails
                                  group Details by new

                                  {
                                      Details.City,

                                  } into Details1
                                  select new
                                  {
                                      City = Details1.Key.City,
                                      Count_Cit = Details1.OrderBy(x => x.City)
                                  };

            foreach (var item in DetailsQuery13)
            {
                Console.WriteLine($"City: {item.City} Number of Employees = {item.Count_Cit.Count()}");


            }
            var DetailsQuery14 = from Details in myDetails
                                  group Details by new

                                  {
                                      Details.City,
                                      Details.Title,

                                  } into Details2
                                  select new
                                  {
                                      City = Details2.Key.City,
                                      Count_Cit = Details2.OrderBy(x => x.City),
                                      Title = Details2.Key.Title,
                                      Count_Tit = Details2.OrderBy(x => x.Title)
                                  };

            Console.WriteLine("--------------------------------");

            foreach (var item in DetailsQuery14)
            {

                Console.WriteLine($"City: {item.City},Title: {item.Title} Number of Employees = {item.Count_Cit.Count()}");


                Console.WriteLine("\n");
                var DetailsQuery15 = myDetails.Select(em => em.DOB);
                Console.WriteLine("Youngest Employee DOB : {0}", DetailsQuery15.Max());
                Console.WriteLine("--------------------------------------------------------");


                Console.WriteLine();

            }


        }
        class Details
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }

            public DateTime DOJ { get; set; }
            public string City { get; set; }
        }
    }
}
