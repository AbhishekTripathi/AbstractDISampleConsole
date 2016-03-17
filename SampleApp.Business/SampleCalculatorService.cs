using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Business
{
    using Model.Interface;
    using SampleApp.Data;

    public class SampleCalculatorService: ISampleCalculator
    {
        ISeedValueLocator seedValueLocatorService;
        public SampleCalculatorService(ISeedValueLocator seedValueLocatorService)
        {
            this.seedValueLocatorService = seedValueLocatorService;
        }
        public int GetSeedValue()
        {
            return seedValueLocatorService.GetSeedValue() + 10;
        }
    }
}
