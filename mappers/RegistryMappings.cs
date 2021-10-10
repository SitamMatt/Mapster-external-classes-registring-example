using dto;
using Mapster;
using model;
using System;

namespace mappers
{
    public class RegistryMappings : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ModelClass, DtoClass>().GenerateMapper(MapType.Map);
            config.NewConfig<InnerModel, InnerDto>().GenerateMapper(MapType.Map);
        }
    }
}
