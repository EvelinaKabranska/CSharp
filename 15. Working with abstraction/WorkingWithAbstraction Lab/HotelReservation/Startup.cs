namespace HotelReservation
{
    using System;
    using System.Linq;
  
   public class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal pricePerDay = decimal.Parse(input[0]);
            int numOfDays = int.Parse(input[1]);
            string season = input[2];
            string discountType = "none";

            if (input.Length > 3) discountType = input[3];

            
            
            decimal total = PriceCalculator.CalculatePrice(pricePerDay, numOfDays, Enum.Parse<Seasons>(season), Enum.Parse<Discount>(discountType));
            Console.WriteLine($"{total:f2}");
        }
    }
}
