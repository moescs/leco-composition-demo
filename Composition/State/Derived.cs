namespace Composition.State
{
    /// <remarks>
    /// Just need to implement interface
    /// I still like to do common things the common way
    /// so I don't override <see cref="IIDoThings.DoCommonThings"/>
    /// </remarks>>
    public class Derived: Base
    {
        public override void DoSpecializedThings()
        {
            //Do things my way
        }
    }
}