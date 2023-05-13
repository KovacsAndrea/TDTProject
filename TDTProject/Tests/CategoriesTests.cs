
namespace TDTProject
{
    public class CategoriesTests
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

        [SetUp]
        public void SetUp()
        {
            setState(Categories.expandedState);
        }
        #endregion

        #region Tests
        [Test(Description = Strings.expandAndCollapseListDescription)]
        public void PRexpandAndCollapse()
        {
            setState(Categories.expandedState);
            int visibleElements = regatulJocurilor.getVisibleElementCount(Categories.sectionXpath);
            Assert.That(visibleElements, Is.EqualTo(28), Strings.expandAndCollapseListErrorMessage);
            setState(Categories.collapsedState);
            visibleElements = regatulJocurilor.getVisibleElementCount(Categories.sectionXpath);
            Assert.That(visibleElements, Is.EqualTo(12), Strings.expandAndCollapseListErrorMessage);
        }

        [Test]
        [TestCase(Categories.categoriesLabelExpectedText, Categories.categoriesLabelXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.essen2022ExpectedText, Categories.essen2022Xpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.essen2020ExpectedText, Categories.essen2020Xpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.essen2019ExpectedText, Categories.essen2019Xpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.deCartiExpectedText, Categories.deCartiXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.tematiceExpectedText, Categories.tematiceXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.cuReguliPutineExpectedText, Categories.cuReguliPutineXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.cooperativeExpectedText, Categories.cooperativeXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.pentruCopiiExpectedText, Categories.pentruCopiiXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.doiJucatoriExpectedText, Categories.doiJucatoriXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.logiceAbstracteExpectedText, Categories.logiceAbstracteXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.razboiExpectedText, Categories.razboiXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.deBuzunarExpectedText, Categories.deBuzunarXpath,Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.inFamilieExpectedText, Categories.inFamilieXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.incepatoriExpectedText, Categories.incepatoriXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.inLimbaRomanaExpectedText, Categories.inLimbaRomanaXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.extensiiExpectedText, Categories.extensiiXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.accesoriiExpectedText, Categories.accesoriiXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.magicTheGatheringExpectedText, Categories.magicTheGatheringXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.RPGsExpectedText, Categories.RPGsXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.puzzleAndHobbyExpectedText, Categories.puzzleAndHobbyXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.legoExpectedText, Categories.legoXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.strategieExpectedText, Categories.strategieXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.educativeExpectedText, Categories.educativeXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.livrareSiPlataExpectedText, Categories.livrareSiPlataXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.fidelizareExpectedText, Categories.fidelizareXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.celMaiBunPretExpectedText, Categories.celMaiBunPretXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.despreNoiExpectedText, Categories.despreNoiXpath, Description = Strings.collapsedListTestDescription)]
        [TestCase(Categories.maiPutineCategoriiExpectedText, Categories.CategoriiXpath, Description = Strings.collapsedListTestDescription)]
        public void PRSectionTextCollapsedList(string expectedText, string Xpath)
        {
            string actualText = regatulJocurilor.getTextFromLabel(Xpath);
            Assert.That(actualText, Is.EqualTo(expectedText), string.Format(Strings.collapsedLIstErrorMessage, expectedText, actualText));
        }
        #endregion

        #region Helpers
        public void setState(string state)
        {
            string currentState = regatulJocurilor.getTextFromLabel(Categories.CategoriiXpath);
            if (currentState == state)
            {
                return;
            }
            regatulJocurilor.click(Categories.CategoriiXpath);
        }
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