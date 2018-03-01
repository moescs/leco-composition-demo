namespace CompositionUnitTests.TestExample
{
    using Composition.TestExample;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class TestedTests
    {
        [TestMethod]
        public void VerifyFooAddsFiveToBar()
        {
            //Mock all dependencies
            var dependency = new Mock<Dependency>();

            //Create Software Under Test
            var sut = new Tested(dependency.Object);

            //Setup dependencies used in method we're testing
            dependency.Setup(x => x.Bar(3)).Returns(7);

            //Get the actual result from the method we're testing
            var actual = sut.Foo(3);

            //Perform all verifications to meet the singular objective of this test
            Assert.AreEqual(7 + 5, actual);
        }
    }
}