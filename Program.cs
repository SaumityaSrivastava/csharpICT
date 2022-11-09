namespace MetalappsAutomation
{
    public class Metalapps
    {


        public void CalculateNetAmount(SalesDetails details)
        {
            int units = details.NoOfUnits;


            if (units <= 5)
                details.NetAmount = 75350 * units;
            else if (units > 5 && units <= 10)
                details.NetAmount = 75350 * units * 0.98;
            else if (units > 10 && units <= 15)
                details.NetAmount = 75350 * units * 0.95;
            else if (units > 15 && units <= 20)
                details.NetAmount = 75350 * units * 0.92;
            else if (units > 20)
                details.NetAmount = 75350 * units * 0.90;


        }


    }
}