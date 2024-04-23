using Microsoft.Playwright;
namespace CalculatorEndToEndTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]

public class Tests : PageTest
{
    [Test]
    //preq-E2E-TEST-5
    public async Task CalculatorWebUi_PageTitle_IsCalculator()
    {
        const string pageTitle = "Calculator";

        await Page.GotoAsync("http://localhost:5000/");
        
        await Expect(Page).ToHaveTitleAsync(pageTitle);
    }

    [Test]
    //preq-E2E-TEST-6
    public async Task CalculatorWebUi_AddNumbers_IsExpectedOutput()
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByRole(AriaRole.Textbox).First.ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).First.FillAsync("5");
        await Page.GetByRole(AriaRole.Textbox).Nth(1).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).Nth(1).FillAsync("10");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();
        await Expect(Page.Locator("#calculator-result")).ToContainTextAsync("15");
    }

    [Test]
    //preq-E2E-TEST-7
    public async Task CalculatorWebUi_DivideByZero_ReturnsError()
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByRole(AriaRole.Textbox).First.ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).First.FillAsync("10");
        await Page.GetByRole(AriaRole.Textbox).Nth(1).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).Nth(1).FillAsync("0");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A / B" }).ClickAsync();
        await Expect(Page.Locator("#calculator-result")).ToContainTextAsync("Not a Number");
    }

    [Test]
    //preq-E2E-TEST-8 NEEDS WORK
    public async Task CalculatorWebUi_AddWithText_ReturnsError()
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByRole(AriaRole.Textbox).First.ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).First.FillAsync("10");
        await Page.GetByRole(AriaRole.Textbox).Nth(1).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).Nth(1).FillAsync("abc");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();
        await Expect(Page.Locator("#calculator-result")).ToContainTextAsync("Invalid Input, Numbers Only");
    }

    [Test]
    //preq-E2E-TEST-9 NEEDS WORK
    public async Task CalculatorWebUi_AddAndClearValues_ReturnsEmptyString()
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByRole(AriaRole.Textbox).First.ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).First.FillAsync("20");
        await Page.GetByRole(AriaRole.Textbox).Nth(1).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox).Nth(1).FillAsync("10");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Clear" }).ClickAsync(); 
        await Expect(Page.Locator("#calculator-result")).ToContainTextAsync("0");
    }
}