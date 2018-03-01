namespace Composition.State
{
    public class Specialized: IIDoThings
    {
        readonly Common _common;

        public Specialized(Common common)
        {
            _common = common;
        }

        public void DoSpecializedThings()
        {
            // Do things my way
        }

        public void DoCommonThings()
        {
            //Re-uses the common way of doing things
            _common.DoCommonThings();
        }
    }
}