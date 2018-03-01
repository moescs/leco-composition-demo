namespace Composition.Template
{
    public interface ISpecializedBeverageMaker
    {
        Beverage Brew();

        Beverage AddCondiments(
            Beverage beverage);
    }
}