namespace Composition.State
{
    using System;

    /// <summary>
    /// Combines things and stuff
    /// </summary>
    public class Base: IIDoThings
    {
        /// <summary>
        /// I also have stuff
        /// </summary>
        public Stuff Stuff { get; private set; } = new Stuff(0.0);

        public virtual void DoSpecializedThings()
        {
            //Modifies stuff in some meaningful way,
            // the details of which are not important
            Stuff = new Stuff(Stuff.Value + Math.PI);
            //Does things...
        }

        public void DoCommonThings()
        {
            //Ignores stuff
            //Does more things...
        }
    }
}