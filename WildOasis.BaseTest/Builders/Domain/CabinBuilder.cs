using WildOasis.Domain.Entities;

namespace WildOasis.BaseTest.Builders.Domain;

public class CabinBuilder
{
    private  string _name = "-";
    private  string _description = "testtesttshysb";
    private int _maxCapacity = 3;
    private int _regularPrice = 80;
    private int _discount = 10;
    private string _image = "imagestring";
    public WildOasis.Domain.Entities.Cabin Build() => new(_name, _description, _maxCapacity, _regularPrice, _discount, _image);
    
    public CabinBuilder withName(string name)
    {
        _name = name;
        return this;
    }
    
    public CabinBuilder withDescription(string description)
    {
        _description = description;
        return this;
    }
    public CabinBuilder WithMaxCapacity(int maxCapacity)
    {
        _maxCapacity = maxCapacity;
        return this;
    }

    public CabinBuilder WithRegularPrice(int regularPrice)
    {
        _regularPrice = regularPrice;
        return this;
    }

    public CabinBuilder WithDiscount(int discount)
    {
        _discount = discount;
        return this;
    }

    public CabinBuilder WithImage(string image)
    {
        _image = image;
        return this;
    }
    
}