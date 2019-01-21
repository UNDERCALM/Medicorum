using AutoMapper;

namespace Medicorum.Core.Interactors.Interfaces.Mapping
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
