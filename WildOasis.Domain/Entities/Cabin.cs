namespace WildOasis.Domain.Entities;

public class Cabin
{
    public Cabin(
        string name,
        string description,
        int maxCapacity,
        int regularPrice,
        int discount,
        string image)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        MaxCapacity = maxCapacity;
        RegularPrice = regularPrice;
        Discount = discount;
        Image = image;

    }

    private Cabin()
    {
    }

    public Guid Id { get;  set; }
    public string Name { get;  set; }
    public string Description { get;  set; }
    public int MaxCapacity { get; set; }
    public int RegularPrice { get;  set; }
    public int Discount { get; set; }
    public string Image { get;  set; }
    public Resort Resort
    {
        get;
         set;
    } 

    public Cabin AddResort(Resort resort)
    {
        Resort = resort;
        return this;

    }
}