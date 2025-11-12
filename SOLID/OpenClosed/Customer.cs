using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    //public enum CardTypes
    //{
    //    Standard,
    //    Silver,
    //    Gold
    //}

    public abstract class CardTypes
    {
        public abstract decimal GetDiscount(decimal value);
       
    }

    public class Standard : CardTypes
    {
        public override decimal GetDiscount(decimal value)
        {
            return value * .95m;
        }
    }

    public class Silver : CardTypes
    {
        public override decimal GetDiscount(decimal value)
        => value * .9m;
    }

    public class Gold : CardTypes
    {
        public override decimal GetDiscount(decimal value)
        => value * .85m;
    }

    public class Premium : CardTypes
    {
        public override decimal GetDiscount(decimal value)
        => value * .8m;
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardTypes Card { get; set; }
    }

    public class OrderManagement
    {

        public Customer Customer { get; set; }
        public decimal GetTotalPayment(decimal value)
        {
            //switch (Customer.Card)
            //{
            //    case CardTypes.Standard:
            //        return value * 0.95m;
            //    case CardTypes.Silver:
            //        return value * 0.9m;
            //    case CardTypes.Gold:
            //        return value * 0.85M;
            //    default:
            //        return value;
                    
            //}
            return Customer.Card.GetDiscount(value);
        }
    }
}
