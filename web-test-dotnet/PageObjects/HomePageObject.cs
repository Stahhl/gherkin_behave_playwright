using System.Threading.Tasks;
using Microsoft.Playwright;

namespace web_test_dotnet.PageObjects;

public class HomePageObject : BasePageObject
{
    public HomePageObject(IBrowser browser)
    {
        Browser = browser;
    }

    public override string PagePath => BasePath + "/";
    public override IPage Page { get; set; }
    public override IBrowser Browser { get; }

    public async Task GotoAboutPageViaNavbar() => await Page.Locator("text=About").ClickAsync();
}