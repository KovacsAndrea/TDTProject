
namespace TDTProject
{
    public class SearchTests
    {
        #region Attributes
        private RegatulJocurilor regatulJocurilor = new RegatulJocurilor();
        #endregion

        #region SetUp
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            regatulJocurilor.setResolution1920x1080();
            regatulJocurilor.goToMainPage();
            regatulJocurilor.waitForPageLoad();
            regatulJocurilor.closeNewsletterPopUp();
            regatulJocurilor.allowCookies();
        }
        #endregion

        #region Tests
        #endregion

        #region Helpers
        #endregion

        #region TearDown
        [OneTimeTearDown]
        public void OneTimeTeardown()
        {
            regatulJocurilor.close();
        }
        #endregion
    }
}
