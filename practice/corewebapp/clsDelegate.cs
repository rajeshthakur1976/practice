using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegateRealtimeExample
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class clsDelegate
    {
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in lstEmployees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);
                }
            }
        }
    }

    public class CallingClient
    {
        List<Employee> lstEmployess = new List<Employee>();
        public CallingClient()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };
        
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            lstEmployess.Add(emp3);

            EligibleToPromotion eligibleTopromote = new EligibleToPromotion(Promote);
            Employee.PromoteEmployee(lstEmployess, eligibleTopromote);
            Employee.PromoteEmployee(lstEmployess, x => x.Experience > 5);
            Employee.PromoteEmployee(lstEmployess, x => x.Gender=="Male");
        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

//namespace DelegateDemo
//{
//    public class AnonymousMethods
//    {
//        public delegate string GreetingsDelegate(string name);

//        static void Main(string[] args)
//        {
//            GreetingsDelegate gd = delegate (string name)
//            {
//                return "Hello @" + name + " Welcome to Dotnet Tutorials";
//            };
//            string GreetingsMessage = gd.Invoke("Pranaya");
//            Console.WriteLine(GreetingsMessage);
//            Console.ReadKey();
//        }
//    }
//}
//namespace LambdaExpressionDemo
//{
//    public class LambdaExpression
//    {
//        public delegate string GreetingsDelegate(string name);
//        static void Main(string[] args)
//        {
//            GreetingsDelegate obj = new GreetingsDelegate(LambdaExpression.Greetings);
//            string GreetingsMessage = obj.Invoke("Pranaya");
//            Console.WriteLine(GreetingsMessage);
//            Console.ReadKey();
//        }
//        public static string Greetings(string name)
//        {
//            return "Hello @" + name + " welcome to Dotnet Tutorials";
//        }
//    }
//}

//namespace LambdaExpressionDemo
//{
//    public class LambdaExpression
//    {
//        public delegate string GreetingsDelegate(string name);
//        static void Main(string[] args)
//        {
//            Func<int, float, double, double> obj1 = (x, y, z) =>
//            {
//                return x + y + z;
//            };
           
//            GreetingsDelegate obj = (name) =>
//            {
//                return "Hello @" + name + " welcome to Dotnet Tutorials";
//            };
//            string GreetingsMessage = obj.Invoke("Pranaya");
//            Console.WriteLine(GreetingsMessage);
//            Console.ReadKey();
//        }
//        public static string Greetings(string name)
//        {
//            return "Hello @" + name + " welcome to Dotnet Tutorials";
//        }
//    }
//}

//namespace GenericDelegateDemo
//{
//    public class GenericDelegates
//    {
//        static void Main(string[] args)
//        {
//            Func<int, float, double, double> obj10 = (p, q, r) => { return p + q + r; };

//            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);
//            double Result = obj1.Invoke(100, 125.45f, 456.789);
//            Console.WriteLine(Result);

//            Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);
//            obj2.Invoke(50, 255.45f, 123.456);

//            Predicate<string> obj3 = new Predicate<string>(CheckLength);
//            bool Status = obj3.Invoke("Pranaya");
//            Console.WriteLine(Status);
//            Console.ReadKey();
//        }
//        public static double AddNumber1(int no1, float no2, double no3)
//        {
//            return no1 + no2 + no3;
//        }
//        public static void AddNumber2(int no1, float no2, double no3)
//        {
//            Console.WriteLine(no1 + no2 + no3);
//        }
//        public static bool CheckLength(string name)
//        {
//            if (name.Length > 5)
//                return true;
//            return false;
//        }
//    }
//}
