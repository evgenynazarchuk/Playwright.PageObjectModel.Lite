using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Lite.Models;

public class PageModel
{
    public IPage Page { get; }

    public PageModel(IPage page)
    {
        this.Page = page;
    }
}
