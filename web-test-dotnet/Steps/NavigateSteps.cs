using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using web_test_dotnet.PageObjects;

namespace web_test_dotnet.Steps;

[Binding]
public class NavigateSteps
{
    private readonly HomePageObject _pageObject;

    public NavigateSteps(HomePageObject pageObject)
    {
        _pageObject = pageObject;
    }

    [Given(@"I am on the home page")]
    public async Task GivenIAmOnTheHomePage()
    {
        await _pageObject.NavigateAsync();
    }

    [When(@"I click the ""(.*)"" link")]
    public async Task WhenIClickTheLink(string about)
    {
        await _pageObject.GotoAboutPageViaNavbar();
    }

    [Then(@"I should be on the ""(.*)"" page")]
    public void ThenIShouldBeOnThePage(string about)
    {
        var url = _pageObject.Page.Url;
        Assert.That(url, Is.EqualTo(_pageObject.PagePath + "about"));
    }
}