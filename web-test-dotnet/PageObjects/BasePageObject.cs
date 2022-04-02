using System.Threading.Tasks;
using Microsoft.Playwright;

namespace web_test_dotnet.PageObjects;

public abstract class BasePageObject
{
    protected const string BasePath = "http://localhost:3000";

    public abstract string PagePath { get; }
    public abstract IPage Page { get; set; }
    public abstract IBrowser Browser { get; }

    public async Task NavigateAsync()
    {
        Page = await Browser.NewPageAsync();
        await Page.GotoAsync(PagePath);
    }
}