using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here

            var that = (Product)obj;
            if (this.Name == that.Name && this.Price == that.Price)
            {
                return true;
            }
            return false;
          
          

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

        public static bool operator ==(Product left, Product right) 
        {
           return Equals(left, right);
        }

        public static bool operator !=(Product left, Product right) {

            return !Equals(left, right);

        }
    }
}
