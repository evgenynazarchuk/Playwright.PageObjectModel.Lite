using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Lite.Models;

public class LocatorModel
{
    public ILocator Locator { get; protected set; }

    public LocatorModel(ILocator locator)
    { 
        this.Locator = locator;
    }

    public async Task<IPage> GetPage()
    {
        var elementHandle = await this.Locator.ElementHandleAsync();
        var ownerFrame = await elementHandle.OwnerFrameAsync();
        if (ownerFrame is null) throw new ArgumentNullException(nameof(ownerFrame));
        return ownerFrame.Page;
    }
}
