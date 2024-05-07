using Ardalis.SmartEnum;

namespace WildOasis.Domain.Enums;

<<<<<<< HEAD
//dodajemo clasu kako bi mogli da dodajemo bilo koji properi za enum i bilo koju funkciju za njega
=======
>>>>>>> d97c0336efdef8331a04e8edf1823e0753d0fdc9
public abstract class Category : SmartEnum<Category>
{
    public static Category Bungalow = new BungalowCategory();
    public static Category Hotel = new HotelCategory();

<<<<<<< HEAD
    public static Category AutoCamp = new AutoCampCategory();
=======
    public static Category Motel = new MotelCategory();
    public static Category AutoCamp = new AutoCampCategory();
    
   
>>>>>>> d97c0336efdef8331a04e8edf1823e0753d0fdc9

    public  abstract string Description { get; }

    public abstract List<Category> Subcategory { get; }

    public Category(string name, int value) : base(name, value)
    {
    }
    private sealed class BungalowCategory : Category
    {
        public BungalowCategory() : base( nameof(Bungalow), 1)
        {
        }

<<<<<<< HEAD
        public override string Description => "Najpovoljiniji Bungalow trenutno";
        public override List<Category> Subcategory => new () { AutoCamp, Hotel };
=======
        public override string Description => "Bungalow for a peaceful getaway surrounded by nature's beauty";
        public override List<Category> Subcategory => new () { Bungalow, AutoCamp };
>>>>>>> d97c0336efdef8331a04e8edf1823e0753d0fdc9
    }
    
    private sealed class HotelCategory : Category
    {
        public HotelCategory() : base( nameof(Hotel), 2)
        {
        }

<<<<<<< HEAD
        public override string Description => "Najpovoljiniji hotel trenutno";
        public override List<Category> Subcategory => new List<Category>();
    }
    
    private sealed class AutoCampCategory : Category
    {
        public AutoCampCategory() : base( nameof(AutoCamp), 3)
        {
        }

        public override string Description => "Najpovoljiniji autocamp trenutno";
        public override List<Category> Subcategory => new List<Category>();
    }
    

}
=======
        public override string Description => "hotel one of the best on south coast";
        public override List<Category> Subcategory => new List<Category>();
    }
    
    private sealed class MotelCategory : Category
    {
        public MotelCategory() : base( nameof(Motel), 3)
        {
        }

        public override string Description => "one of the best motel on south coast";
        public override List<Category> Subcategory => new List<Category>();
    }
    private sealed class AutoCampCategory : Category
    {
        public AutoCampCategory() : base( nameof(AutoCamp), 4)
        {
        }

        public override string Description => "AutoCampCategory";
        public override List<Category> Subcategory => new List<Category>();
    }
    
  

}

>>>>>>> d97c0336efdef8331a04e8edf1823e0753d0fdc9
