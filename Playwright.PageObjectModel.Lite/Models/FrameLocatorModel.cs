using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Lite.Models;

public class FrameLocatorModel
{
    public IFrameLocator FrameLocator { get; protected set; }

    public FrameLocatorModel(IFrameLocator frameLocator)
    { 
        this.FrameLocator = frameLocator;
    }
}
