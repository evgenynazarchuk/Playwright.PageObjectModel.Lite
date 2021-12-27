using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using Playwright.PageObjectModel.Lite.Sample.Pages;

namespace Playwright.PageObjectModel.Lite.Sample.Support;

public class TestBase : ContextTest
{
    public TestBase()
    { 
    }

    public async Task<StartPage> Open()
    {
        var page = await this.Context.NewPageAsync();
        await page.GotoAsync("https://playwright.dev/");
        return new StartPage(page);
    }
}
