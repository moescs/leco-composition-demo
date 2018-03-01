namespace Composition.TestExample
{
    using System;

    public class Dependency
    {
        public virtual int Bar(double input)
        {
            return (int) (input / Math.PI);
        }
    }
}