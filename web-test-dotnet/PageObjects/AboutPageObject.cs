using Microsoft.Playwright;

namespace web_test_dotnet.PageObjects;

public class AboutPageObject : BasePageObject
{
    public AboutPageObject(IBrowser browser)
    {
        Browser = browser;
    }

    public override string PagePath => BasePath + "/about";
    public override IPage Page { get; set; }
    public override IBrowser Browser { get; }
}