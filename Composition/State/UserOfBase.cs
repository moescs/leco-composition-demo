namespace Composition.State
{
    using System;

    public class UserOfBase
    {
        public void UseThingsAndStuff(
            Base thingsWithStuff)
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