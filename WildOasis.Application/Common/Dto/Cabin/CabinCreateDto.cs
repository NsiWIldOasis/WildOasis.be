using WildOasis.Domain.Enums;

namespace WildOasis.Application.Common.Dto.Cabin;

public record CabinCreateDto(Guid ResortId, string Name,string Description,int MaxCapacity, int RegularPrice, 
<<<<<<< HEAD
    int Discount, string Image,int Category )
=======
    int Discount, string Image, int Category)
>>>>>>> d97c0336efdef8331a04e8edf1823e0753d0fdc9
{
    
}