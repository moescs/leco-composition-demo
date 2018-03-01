namespace Composition.State
{
    using System;

    public class UserOfCommon
    {
        public void UseThingsAndStuff(
            Common thingsWithStuff)
        {
            thingsWithStuff.DoSpecializedThings();

            var stuff = thingsWithStuff.Stuff;
            Use(stuff);
        }

        /// <summary>
        /// Details are not important
        /// </summary>
        void Use(Stuff stuff)
        {
            Console.WriteLine(stuff.Value);
        }
    }
}