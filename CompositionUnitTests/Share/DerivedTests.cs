namespace CompositionUnitTests.Share
{
    using Composition.Share;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DerivedTests
    {
        [TestMethod]
        public void VerifyOffsetsMuByFive()
        {
            //Thing we're testing
            var sut = new Derived();

            //Get actual result;
            //These numbers were difficult to fabricate
            //Mu should be 0
            var actual = sut.GetOffset(0.484, .798, 0.484);

            //Verify meets expectations
            Assert.IsTrue(
                4.999 < actual && actual < 5.001,
                "Should have added offset of 5 to mu of 0");
        }
    }
}