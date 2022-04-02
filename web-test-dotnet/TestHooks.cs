using System.Threading.Tasks;
using BoDi;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using web_test_dotnet.PageObjects;

[Binding]
public class TestHooks
{
    [BeforeScenario("Navigate")]
    public async Task BeforeNavigateScenario(IObjectContainer container)
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true,
            SlowMo = 100
        });
        var pageObject = new HomePageObject(browser);
        container.RegisterInstanceAs(playwright);
        container.RegisterInstanceAs(browser);
        container.RegisterInstanceAs(pageObject);
    }

    [AfterScenario]
    public async Task AfterScenario(IObjectContainer container)
    {
        var browser = container.Resolve<IBrowser>();
        await browser.CloseAsync();
        var playwright = container.Resolve<IPlaywright>();
        playwright.Dispose();
    }
}
