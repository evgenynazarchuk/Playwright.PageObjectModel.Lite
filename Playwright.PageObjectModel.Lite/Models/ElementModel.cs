using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Lite.Models;

public class ElementModel
{
    public IElementHandle ElementHandle { get; }

    public ElementModel(IElementHandle elementHandle)
    {
        this.ElementHandle = elementHandle;
    }

    public virtual async Task<IPage> GetPage()
    {
        var ownerFrame = await this.ElementHandle.OwnerFrameAsync();
        if(ownerFrame is null) throw new ArgumentNullException(nameof(ownerFrame));
        return ownerFrame.Page;
    }

    public virtual async Task Click(string selector)
    {
        var element = await this.ElementHandle.WaitForSelectorAsync(selector);
        if (element is null) throw new ArgumentNullException(nameof(element));
        await element.ClickAsync();
    }
}
