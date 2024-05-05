using Riok.Mapperly.Abstractions;
using WildOasis.Application.Common.Dto.Cabin;
using WildOasis.Domain.Entities;

namespace WildOasis.Application.Common.Mappers;

[Mapper]
public static partial class CabinMapper
{
    public static partial CabinDetailsDto ToDto(this Domain.Entities.Cabin entity);

    public static CabinDetailsDto ToCustomDto(this Domain.Entities.Cabin entity)
    {
        var dto = new CabinDetailsDto(entity.Name, entity.Description, entity.MaxCapacity, entity.RegularPrice,
            entity.Discount, entity.Image, entity.Resort.Name, entity.Resort.Description, entity.Resort.Address,
            entity.Resort.Number);
        return dto;
    }

    public static partial Domain.Entities.Cabin ToEntity(this CabinCreateDto entity);
    public static partial Domain.Entities.Cabin ToEntityUpdate(this CabinUpdateDto entity);

    


    public static Domain.Entities.Cabin ToCustomDto(this CabinCreateDto dto, Domain.Entities.Resort resort)
    {
        var cabin = new Domain.Entities.Cabin(dto.Name, dto.Description,dto.MaxCapacity,dto.RegularPrice,dto.Discount,dto.Image);
        return cabin;
    }

}