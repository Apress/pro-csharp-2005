using System;

namespace Employees
{
    // Ensure that PTSalesPerson cannot act as a base class to others.
    public class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID,
             float currPay, string ssn, int numbOfSales)
          : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
            // Interesting constructor logic...
        }
        // Other interesting members...

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (numberOfSales >= 0 && numberOfSales <= 100)
                salesBonus = 10;
            else if (numberOfSales >= 101 && numberOfSales <= 200)
                salesBonus = 15;
            else
                salesBonus = 20;     // Anything greater than 200.
            base.GiveBonus(amount * salesBonus);
        }
    }
}
