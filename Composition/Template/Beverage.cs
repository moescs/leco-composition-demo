namespace Composition.Template
{
    using System.Collections.Generic;

    public class Beverage
    {
        public Beverage() {}

        public Beverage(params string[] ingredients) {}

        public List<string> Condiments { get; } = new List<string>();
    }
}