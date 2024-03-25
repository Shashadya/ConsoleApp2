namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Class_Employee employee1 = new Class_Employee();
            employee1.FirstName = "Chamil";
            employee1.LastName = "Jeewantha";
            employee1.BasicSalary = 250000;



         Console.WriteLine(employee1.FirstName+" "+employee1.LastName);  
         Console.WriteLine(employee1.BasicSalary);
        }
       


    }
}
