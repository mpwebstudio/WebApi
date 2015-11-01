using AutoMapper;

namespace DataCleansing.Web.Infrastructure
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IConfiguration configuration);
    }
}
