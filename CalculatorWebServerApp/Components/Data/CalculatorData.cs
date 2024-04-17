namespace CalculatorWebServerApp.Components.Data;

public class CalculatorData
{
    public CalculatorData(string inputA, string inputB, double result)
    {
        this.inputA = inputA;
        this.inputB = inputB;
        this.result = result;
    }

    public string inputA { get; set; }
    public string inputB { get; set; }
    public double result { get; set; }
}