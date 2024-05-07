using Riok.Mapperly.Abstractions;
using WildOasis.Application.Common.Dto.Cabin;
using WildOasis.Domain.Entities;
using WildOasis.Domain.Enums;

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

    public static  Domain.Entities.Cabin ToEntity(this CabinCreateDto entity)
    {
        var cabin = new Domain.Entities.Cabin(entity.Name, entity.Description, entity.MaxCapacity, entity.RegularPrice,
            entity.Discount, entity.Image, Category.FromValue(entity.Category));
        return cabin;
    }




    public static Domain.Entities.Cabin ToCustomDto(this CabinCreateDto dto, Domain.Entities.Resort resort,Category category)
    {
        var cabin = new Domain.Entities.Cabin(dto.Name, dto.Description,dto.MaxCapacity,dto.RegularPrice,dto.Discount,dto.Image,category);
        return cabin;
    }

}