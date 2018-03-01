namespace Composition.Share
{
    public class Specialized
    {
        readonly Common _common;

        public Specialized(
            Common common)
        {
            _common = common;
        }

        public double GetOffset(
            double y1,
            double y2,
            double y3)
        {
            var gaussian = _common.Fit(y1, y2, y3);
            return gaussian.Mu + 5;
        }

    }
}