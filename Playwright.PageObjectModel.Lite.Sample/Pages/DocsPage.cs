using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Playwright.PageObjectModel.Lite.Models;
using Playwright.PageObjectModel.Lite.Sample.Elements;

namespace Playwright.PageObjectModel.Lite.Sample.Pages;

public class DocsPage : PageModel
{
    public DocsPage(IPage page) : base(page)
    {
    }

    public async Task<Menu> Menu()
    {
        var menu = await this.Page.WaitForSelectorAsync("//nav");
        if (menu is null) throw new ArgumentNullException(nameof(menu));
        return new Menu(menu);
    }
}
