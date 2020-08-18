using AutoMapper;
using Mapper.Service.AutoMapper;
using NUnit.Framework;

namespace Mapper.NUnitTest
{
    public class MapperTest
    {
        [Test]
        public void ConfigurationIsValid()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapping()));
            IMapper mapper = mapperConfiguration.CreateMapper();
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}