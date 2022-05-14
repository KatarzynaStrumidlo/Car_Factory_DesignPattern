using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_factory
{
    internal class FastCar : ICar
    {
        public CarType Type { get; } = CarType.fast;
    }
}
