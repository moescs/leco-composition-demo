namespace Composition.Template
{
    /// <summary>
    /// Like <see cref="Base"/>
    /// </summary>
    public class Common
    {
        readonly ISpecializedBeverageMaker _specialized;

        public Common(
            ISpecializedBeverageMaker specialized)
        {
            _specialized = specialized;
        }

        public Beverage MakeBeverage()
        {
            var brewed = _specialized.Brew();
            var beverage = _specialized.AddCondiments(brewed);
            return beverage;
        }
    }
}