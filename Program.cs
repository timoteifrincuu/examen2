namespace examen2
{

    internal class Program
    {
        static void Main()
        {
            string customerName = Console.ReadLine();
            DateTime orderDate = DateTime.Parse(Console.ReadLine());
            decimal ordereTotal = decimal.Parse(Console.ReadLine());
        
            Order order = new Order(
                customerName = customerName,
                Date = orderDate,
                Total = orderTotal    
                );  
        }
    }
}