namespace Composition.Template
{
    public abstract class Base
    {
        public Beverage MakeBeverage()
        {
            var brewed = Brew();

            var beverage = AddCondiments(brewed);

            return beverage;
        }

        protected abstract Beverage Brew();

        protected abstract Beverage AddCondiments(
            Beverage beverage);

    }
}