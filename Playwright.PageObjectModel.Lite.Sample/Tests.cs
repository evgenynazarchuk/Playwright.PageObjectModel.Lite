using NUnit.Framework;
using System.Threading.Tasks;
using Playwright.PageObjectModel.Lite.Sample.Support;
using Playwright.PageObjectModel.Lite.Sample.Pages;

namespace Playwright.PageObjectModel.Lite.Sample;

public class Tests : TestBase
{
    [Test]
    public async Task TestApiPageTitle()
    {
        var startPage = await Open();
        var menu = await startPage.Menu();
        var apiPage = await menu.Api();
        var title = await apiPage.Page.TitleAsync();
        Assert.AreEqual("Playwright Library | Playwright", title);
    }

    [Test]
    public async Task TestDocsPageTitle()
    {
        var startPage = await Open();
        var menu = await startPage.Menu();
        var docs = await menu.Docs();
        var title = await docs.Page.TitleAsync();
        Assert.AreEqual("Getting started | Playwright", title);
    }

    [Test]
    public async Task TestGoLogoTitle()
    {
        var startPage = await Open();
        var menu = await startPage.Menu();
        var docs = await menu.Docs();
        menu = await docs.Menu();
        startPage = await menu.Logo();

        var title = await startPage.Page.TitleAsync();
        Assert.AreEqual("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
    }
}