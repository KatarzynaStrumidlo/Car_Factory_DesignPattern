using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_factory
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(IClient client)
        {
            ICar car = null;
            if(client is Artist)
            {
                car = new PrettyCar();
            }
            else if (client is Rich)
            {
                car = new LuxuryCar();
            }
            else if (client is Young)
            {
                car = new FastCar();
            }
            return car;
        }
    }
}
