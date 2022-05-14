using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_factory
{
    public class CarShowroom
    {
        private readonly ICarFactory _carFactory;

        public CarShowroom(ICarFactory factory)
        {
            this._carFactory = factory;
        }
        public ICar createSpecialCar(IClient client)
        {
            ICar car = _carFactory.CreateCar(client);
            return car;
        }
    }
}
