namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30 ,40 ,50 ,60 ,70 ,80 ,90 ,100};
            int total = 0;
            
            for (int i = 0; i<numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Total= "+total);
            double average= total/numbers.Length;
            Console.WriteLine("Average= " + average);


            
        }
       


    }
}
