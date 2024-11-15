using Autofac;
using AutoMapper;
using AutoMapperEnjoyments.Core;

namespace AutoMapperEnjoyments.MapsUnitTests
{
    public abstract class UnitTestBase
    {
        protected IMapper _mapper;

        [TestInitialize]
        public void TestInitialize()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(MapperConfig.InitializeAutoMapper()).As<IMapper>().SingleInstance();

            var container = builder.Build();

            _mapper = container.Resolve<IMapper>();

            //Ensure all AutoMapper mapping configurations are valid.
            _mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
