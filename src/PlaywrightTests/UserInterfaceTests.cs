// Copyright Information
// ==================================
// SoftwareTesting - PlaywrightTests - UserInterfaceTests.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/07/22
// ==================================

namespace PlaywrightTests;

public class UserInterfaceTests
{
    //https://medium.com/version-1/playwright-a-modern-end-to-end-testing-for-web-app-with-c-language-support-c55e931273ee#:~
    [Fact]
    public static async Task VerifyGoogleSearchForPlaywright()
    {
        using IPlaywright playwright = await Playwright.CreateAsync();
        await using var browser =
            await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = true, SlowMo = 50 });

        IBrowserContext context = await browser.NewContextAsync();

        IPage page = await context.NewPageAsync();
        //Navigate to Google.com
        await page.GotoAsync("https://www.letsusedata.com/index.html");

        
        await page.fillAsync("text=Your Username", "Test2");
       //await page.FillAsync("[aria-label=\"Your Username\"]", "Test2");
        await page.FillAsync("[aria-label=\"Your Password\"]", "iF3sBF7c");                             
        // Press Enter
        var response = await page.RunAndWaitForNavigationAsync(async () => await page.PressAsync("[aria-label=\"Login\"]", "Enter"));
        //Click on the first search option
        await page.ClickAsync("xpath=//h3[contains(text(),'Intro to Data Analytics')]");
        //Verify Page URL
        Assert.Equal("https://www.letsusedata.com/CourseSelection.html", page.Url);
        
    }
}
