namespace CompositionUnitTests.Template
{
    using Composition.Template;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CommonTests
    {
        /// <summary>
        /// This is not even possible using inheritance
        /// </summary>
        [TestMethod]
        public void VerifyAddsCondimentsToWhatsBrewed()
        {
            //Mock dependencies
            var specialized = new Mock<Specialized>();

            //Create the object we're testing
            var sut = new Common(specialized.Object);

            //Setup dependencies used in method
            var brewed = Mock.Of<Beverage>();
            specialized.Setup(x => x.Brew()).Returns(brewed);

            //Invoke the method we're testing
            sut.MakeBeverage();

            //Verify meets expectations
            specialized.Verify(x => x.AddCondiments(brewed), Times.Once);
        }
    }
}