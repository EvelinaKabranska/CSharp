namespace HotelReservation
{
   public class PriceCalculator
    {
        public static decimal CalculatePrice(decimal pricePerDay,int numberOfDays, Seasons season, Discount discount)
        {
            int multiplaier = (int)season;
            decimal disc = (decimal)discount / 100;

            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplaier;
            decimal discAmount = priceBeforeDiscount * disc;
            decimal finalPrice = priceBeforeDiscount - discAmount;

            return finalPrice;
        }
    }
}
