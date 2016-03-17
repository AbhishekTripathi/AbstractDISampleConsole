namespace SampleApp.Infrastructure.Container
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Castle.Windsor.Installer;
    using Model.Interface;

    public class WindsorContainer : IDIContainer
    {
        private IWindsorContainer _container;

        public IWindsorContainer Container
        {
            get { return _container ?? (_container = InitializeContainer()); }
            set { _container = value; }
        }

        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
            
        public void Register<I, T>() where  T: class
        {
            Container.Register(Component.For(typeof(I)).ImplementedBy<T>());
        }

        private IWindsorContainer InitializeContainer()
        {
            return new Castle.Windsor.WindsorContainer().Install(Configuration.FromXmlFile("CastleConfiguration.xml"));
        }
    }
}
