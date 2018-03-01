namespace CompositionUnitTests.Template
{
    using Composition.Template;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class SpecializedTests
    {
        [TestMethod]
        public void VerifyOnlyAddsChocolate()
        {
            //The thing we're testing
            // with no stuff to brew!
            var sut = new Specialized(null, null, null);

            //The actual result
            var actual = sut.AddCondiments(new Beverage());

            //Verify meets expectations
            CollectionAssert.AreEqual(new [] {"Chocolate"}, actual.Condiments);
        }

    }
}