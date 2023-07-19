using System.Net.Http;
using Aquality.Selenium.Browsers;
using Web.Forms;
using Web.Forms.Pages;
using Web.Utils;
using System.Net.Http;

namespace Api;

public class Tests
{
    private Web.Forms.Timer timer = new Web.Forms.Timer();
    private Browser browser = AqualityServices.Browser;
    private MainPage mainPage = new MainPage();
    private HelpForm helpForm = new HelpForm();
    private LoginCard loginCard = new LoginCard();
    private InterestCard interestCard = new InterestCard();
    private CoockiesForm coockiesForm = new CoockiesForm();
    private PersonalDetailCard personalDetailCard = new PersonalDetailCard();


    [SetUp]
    public void beforeTest() {
        AqualityServices.Browser.GoTo("https://userinyerface.com/");
        AqualityServices.Browser.Maximize();
    }

    [Test]
    public void Test1()
    {
        Assert.That(mainPage.State.IsDisplayed, "Main page is note open");
        mainPage.ClickOnNextPageButton();
        Assert.That(loginCard.State.IsDisplayed, "Login card is note open");
        loginCard.FillPasswordField(RandomForTests.GeneratePassword(JsonReader.GetIntData("Password.minLength"), JsonReader.GetIntData("Password.maxLength"), RandomForTests.userName+ RandomForTests.domain));
        loginCard.FillEmailField(RandomForTests.userName);
        loginCard.FillDomainField(RandomForTests.domain);
        loginCard.ClickOnDropDownDomainOptionsFlield();
        loginCard.ClickOnRandomDomainOption();
        loginCard.ClickOnTermsAndConditionsChekbox();
        loginCard.ClickOnNextButton();
        Assert.That(interestCard.State.IsDisplayed, "Interest card is note open");
        interestCard.ClickOnUnselectChexkBox();
        interestCard.ClickRandomInterestCheckBoxes(JsonReader.GetIntData("CountOfCheckBoxes"));
        interestCard.ClickOnNextButon();
    }

    [Test]
    public void Test2()
    {
        mainPage.ClickOnNextPageButton();
        helpForm.HideHelpForm();
        helpForm.State.WaitForNotDisplayed();
        Assert.That(helpForm.State.IsDisplayed, Is.EqualTo(false), "Help form is displayed");

    }

    [Test]
    public void Test3()
    {
        mainPage.ClickOnNextPageButton();
        coockiesForm.ClickOnAcceptCookiesButton();
        Assert.That(coockiesForm.State.IsDisplayed, Is.EqualTo(false), "Cookies form is displayed");
    }

    [Test]
    public void Test4()
    {
        mainPage.ClickOnNextPageButton();
        Assert.That(timer.GetTimeFromTimer(), Is.EqualTo(JsonReader.GetStringData("StaetTime")));
    }

    [TearDown]
    public void afterTest()
    {
        if (AqualityServices.IsBrowserStarted)
        {
            AqualityServices.Browser.Quit();
            return;
        }
    }
}