namespace CompositionUnitTests.Template
{
    using Composition.Template;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class DerivedTests
    {
        [TestMethod]
        public void VerifyOnlyAddsChocolate()
        {
            //Mock a bunch of stuff to let Derived Brew...
            var brewer1 = new Mock<Brewer1>();
            brewer1.Setup(x => x.Brew(It.IsAny<string>(), It.IsAny<string>())).Returns("");
            var brewer2 = new Mock<Brewer2>();
            brewer2.Setup(x => x.Brew(It.IsAny<string>())).Returns("");
            var brewer3 = new Mock<Brewer3>();
            brewer3.Setup(x => x.Brew(It.IsAny<string>(), It.IsAny<string>())).Returns("");

            //The thing we're testing
            var sut = new Derived(brewer1.Object, brewer2.Object, brewer3.Object);

            //The actual result
            var actual = sut.MakeBeverage();

            //Verify meets expectations
            CollectionAssert.AreEqual(new [] {"Chocolate"}, actual.Condiments);
        }
    }
}