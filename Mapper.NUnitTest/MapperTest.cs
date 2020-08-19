using AutoMapper;
using Mapper.Api.AutoMapper;
using NUnit.Framework;

namespace Mapper.NUnitTest
{
    public class MapperTest
    {
        [Test]
        public void ConfigurationIsValid()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new ConfigurationMapping()));
            IMapper mapper = mapperConfiguration.CreateMapper();
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}