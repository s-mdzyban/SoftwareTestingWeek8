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
        //Navigate to Let's use data
        await page.GotoAsync("https://www.letsusedata.com/index.html");

        //Enter credentials in text boxes - TEST 2
        await page.FillAsync("#txtUser", "Test2");
        await page.FillAsync("#txtPassword", "iF3sBF7c");                             
        // Press Click Login
        var response = await page.RunAndWaitForNavigationAsync(async () => await page.ClickAsync("#javascriptLogin"));
        //Verify Page URL
        Assert.Equal("https://www.letsusedata.com/CourseSelection.html", page.Url);

        await page.GotoAsync("https://www.letsusedata.com/index.html");

        //Enter credentials in text boxes - TEST 2
        await page.FillAsync("#txtUser", "Test1");
        await page.FillAsync("#txtPassword", "12345678");   
        
        // Press Click Login
        await page.ClickAsync("#javascriptLogin");
        
        //Verify Login Fail
        page.GetByText("Invalid Password", new() { Exact = true });
     
       
    }
}
