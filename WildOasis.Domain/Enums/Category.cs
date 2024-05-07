using Ardalis.SmartEnum;

namespace WildOasis.Domain.Enums;

//dodajemo clasu kako bi mogli da dodajemo bilo koji properi za enum i bilo koju funkciju za njega
public abstract class Category : SmartEnum<Category>
{
    public static Category Bungalow = new BungalowCategory();
    public static Category Hotel = new HotelCategory();

    public static Category AutoCamp = new AutoCampCategory();

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

        public override string Description => "Najpovoljiniji Bungalow trenutno";
        public override List<Category> Subcategory => new () { AutoCamp, Hotel };
    }
    
    private sealed class HotelCategory : Category
    {
        public HotelCategory() : base( nameof(Hotel), 2)
        {
        }

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