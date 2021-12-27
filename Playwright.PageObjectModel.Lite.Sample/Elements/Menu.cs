using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Microsoft.Playwright;
using Playwright.PageObjectModel.Lite.Models;
using Playwright.PageObjectModel.Lite.Sample.Pages;

namespace Playwright.PageObjectModel.Lite.Sample.Elements;

public class Menu : ElementModel
{
    public Menu(IElementHandle elementHandle) : base(elementHandle)
    {
    }

    public async Task<StartPage> Logo()
    {
        await Click(".navbar__title");
        var page = await this.GetPage();
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        return new StartPage(page);
    }

    public async Task<ApiPage> Api()
    {
        await Click("//a[text()='API']");
        var page = await this.GetPage();
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        return new ApiPage(page);
    }

    public async Task<DocsPage> Docs()
    {
        await Click("xpath=//a[text()='Docs']");
        var page = await this.GetPage();
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        return new DocsPage(page);
    }
}
