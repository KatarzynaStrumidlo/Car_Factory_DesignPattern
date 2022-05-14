using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_factory
{
    internal class PrettyCar : ICar
    {
        public CarType Type { get; } = CarType.pretty;

    }
}
