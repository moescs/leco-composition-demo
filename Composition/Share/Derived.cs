namespace Composition.Share
{
    public class Derived: Base
    {
        public double GetOffset(
            double y1,
            double y2,
            double y3)
        {
            var gaussian = Fit(y1, y2, y3);
            return gaussian.Mean + 5;
        }
    }
}