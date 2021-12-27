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
        var logo = await this.ElementHandle.WaitForSelectorAsync(".navbar__title")!;
        if(logo is null) throw new ArgumentNullException(nameof(logo));
        await logo.ClickAsync();
        var page = await this.GetPage();
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        return new StartPage(page);
    }

    public async Task<ApiPage> Api()
    {
        var api = await this.ElementHandle.WaitForSelectorAsync("//a[text()='API']");
        if (api is null) throw new ArgumentNullException(nameof(api));
        await api.ClickAsync();
        var page = await this.GetPage();
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        return new ApiPage(page);
    }

    public async Task<DocsPage> Docs()
    {
        var docs = await this.ElementHandle.WaitForSelectorAsync("//a[text()='Docs']");
        if (docs is null) throw new ArgumentNullException(nameof(docs));
        await docs.ClickAsync();
        var page = await this.GetPage();
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        return new DocsPage(page);
    }
}
