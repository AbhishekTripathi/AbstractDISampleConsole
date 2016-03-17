using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Data
{
    using Model.Interface;

    public class SeedValueLocatorService: ISeedValueLocator
    {
        public int GetSeedValue()
        {
            return new Random().Next(9999);
        }
    }
}
