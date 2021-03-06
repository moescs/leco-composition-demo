﻿namespace Composition.Template
{
    /// <summary>
    /// Like <see cref="Derived"/>
    /// </summary>
    public class Specialized: ISpecializedBeverageMaker
    {
        readonly Brewer1 _brewer1;
        readonly Brewer2 _brewer2;
        readonly Brewer3 _brewer3;

        protected Specialized() {}

        public Specialized(
            Brewer1 brewer1,
            Brewer2 brewer2,
            Brewer3 brewer3)
        {
            _brewer1 = brewer1;
            _brewer2 = brewer2;
            _brewer3 = brewer3;
        }

        /// <summary>
        /// Lots of work, details unimportant
        /// </summary>
        public virtual Beverage Brew()
        {
            var step1Result = _brewer1.Brew("Water", "Base");
            var modified1 = step1Result.Replace("Sand", "Sugar");

            var step2Result = _brewer2.Brew(modified1);
            var modified2 = step2Result.Replace("ToxicChemicals", "");

            var step3Result = _brewer3.Brew(modified2, "Cream");
            var modified3 = step3Result.Replace("Curds", "Whey");

            var beverage = new Beverage(modified3);
            return beverage;
        }

        public virtual Beverage AddCondiments(
            Beverage originalBeverage)
        {
            var beverageWithCondiments = originalBeverage;
            beverageWithCondiments.Condiments.Add("Chocolate");
            return beverageWithCondiments;
        }
    }
}