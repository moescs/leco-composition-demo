namespace CompositionUnitTests.Share
{
    using Composition.Share;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class SpecializedTests
    {
        [TestMethod]
        public void VerifyOffsetsMuByFive()
        {
            //Mock dependencies
            var depencency = new Mock<Common>();

            //Thing we're testing
            var sut = new Specialized(depencency.Object);

            //Set up dependencies
            depencency.Setup(x => x.Fit(1, 3, 5))
                .Returns(new GaussianParameters {Mu = 7, Fwhm = 11, Area = 13});

            //Get actual result;
            var actual = sut.GetOffset(1, 3, 5);

            //Verify meets expectations
            Assert.AreEqual(7.0 + 5.0, actual);
        }

    }
}