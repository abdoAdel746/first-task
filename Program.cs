namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of small rooms:");
            int sRoomPrice = 25;
            int sRoom = int.Parse(Console.ReadLine());

            Console.Write("Number of large rooms:");
            int lRoomPrice = 35;
            int lRoom = int.Parse(Console.ReadLine());

            Console.WriteLine($"Price per small room: ${sRoomPrice}");
            Console.WriteLine($"Price per large room: ${lRoomPrice}");

            int cost = sRoom * 25 + lRoom * 35;
            Double taxPercentage = 0.06;
            Double tax = taxPercentage * cost;
            Double TotalPrice = cost + tax;

            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine("===============================");

            Console.WriteLine($"Total estimate: ${TotalPrice}");
            Console.WriteLine("This estimate is valid for 30 days");



        }
    }
}
