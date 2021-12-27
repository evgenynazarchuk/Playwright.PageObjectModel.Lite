using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Lite.Models;

public class ElementModel
{
    public IElementHandle ElementHandle { get; protected set; }

    public ElementModel(IElementHandle elementHandle)
    {
        this.ElementHandle = elementHandle;
    }

    public async Task<IPage> GetPage()
    {
        var ownerFrame = await this.ElementHandle.OwnerFrameAsync();
        if(ownerFrame is null) throw new ArgumentNullException(nameof(ownerFrame));
        return ownerFrame.Page;
    }
}
