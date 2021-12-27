using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Lite.Models;

public class FrameModel
{
    public IFrame Frame { get; protected set; }

    public FrameModel(IFrame frame)
    {
        this.Frame = frame;
    }

    public async Task<IPage> GetPage()
    {
        return await Task.FromResult(this.Frame.Page);
    }
}
