using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstartctFactory
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
   public interface  VehicleFactort {
       bike Createbike();
       Scooter CreateScooter();

}

    public abstract class HondaBike:VehicleFactort{

        public bike Createbike()
        {
            return new bike();
           



        }

        public Scooter CreateScooter()
        {
            return new Scooter();
        }


      
    }


}