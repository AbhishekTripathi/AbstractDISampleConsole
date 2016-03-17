using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Infrastructure
{
    using Container;
    using Model.Interface;

    public class ContainerFactory
    {
        public static Func<IDIContainer> GetContainer = () => new WindsorContainer();
    }
}
