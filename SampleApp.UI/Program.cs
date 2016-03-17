using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UI
{
    using Infrastructure;
    using Model.Interface;

    class Program
    {
        static void Main(string[] args)
        {
            var controller = ContainerFactory.GetContainer();
            var sampleCalculator = controller.Resolve<ISampleCalculator>();
            Console.WriteLine(sampleCalculator.GetSeedValue());
        }
    }
}
