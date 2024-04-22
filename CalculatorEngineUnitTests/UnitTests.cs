namespace CalculatorEngineUnitTests;

using CalculatorEngine;

public class Tests
{
    private CalculatorEngine _calculatorEngine;
    
    [SetUp]
    public void SetUp()
    {
        _calculatorEngine = new CalculatorEngine();
    }

    [TearDown]
    public void TearDown()
    {
        _calculatorEngine = null;
    }
    
    [Test]  //preq-UNIT-TEST-2
    public void Add_TwoFloatingPoints_ReturnsSum()
    {
        //arrange
        double x = 10, y = 5;
        
        //act
        var result = _calculatorEngine.Add(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(15));
    }
    
    [Test]  //preq-UNIT-TEST-3
    public void Subtract_TwoFloatingPoints_ReturnsDifference()
    {
        //arrange
        double x = 20, y = 15;
        
        //act
        var result = _calculatorEngine.Subtract(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(5));
    }

    [Test]  //preq-UNIT-TEST-4	
    public void Multiply_TwoFloatingPoints_ReturnsProduct()
    {
        //arrange
        double x = 5, y = 20;
        
        //act
        var result = _calculatorEngine.Multiply(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(100));
    }

    [Test]  //preq-UNIT-TEST-5	
    public void Divide_TwoFloatingPoints_ReturnsQuotient()
    {
        //arrange
        double x = 50, y = 2;
        
        //act
        var result = _calculatorEngine.Divide(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(25));
    }

    //MORE WORK
    
    [Test]  //preq-UNIT-TEST-6	
    public void Divide_Zero_ReturnsError()
    {
        //arrange
        double x = 10, y = 0;
        
        //act
        var result = _calculatorEngine.Divide(x, y);
        
        //assert
        Assert.That(result.ErrorMessage, Is.EqualTo("Division by Zero"));
    }
    

    [Test]  //preq-UNIT-TEST-7	
    public void Equals_OverEightPrecision_ReturnsOne()
    {
        //arrange
        double x = 0.888888887, y = 0.888888886;
        
        //act
        var result = _calculatorEngine.Equals(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(1));
    }

    [Test]  //preq-UNIT-TEST-7
    public void Equals_UnderEightPrecision_ReturnsZero()
    {
        //arrange
        double x = 0.8888885, y = 0.8888886;
        
        //act
        var result = _calculatorEngine.Equals(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(0));
    }

    [Test]  //preq-UNIT-TEST-8	
    public void Power_XToY_ReturnsProduct()
    {
        //arrange
        double x = 10, y = 2;
        
        //act
        var result = _calculatorEngine.Power(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(100));
    }

    [Test]  //preq-UNIT-TEST-9	
    public void Log_TwoFloatingPoints_ReturnsExponent()
    {
        //arrange
        double x = 25, y = 5;
        
        //act
        var result = _calculatorEngine.Log(x, y);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(2));
    }
    
    [Test]  //preq-UNIT-TEST-10
    public void Log_NegativeFloatingPoint_ReturnsError()
    {
        //arrange
        double x = -25, y = 5;
        
        //act
        var result = _calculatorEngine.Log(x, y);

        //assert
        Assert.That(result.ErrorMessage, Is.EqualTo("Negative Logarithm Input"));
        
    }
    
    [Test]  //preq-UNIT-TEST-11
    public void Log_BaseZero_ReturnsError()
    {
        //arrange
        double x = 2, y = 0;
        
        //act
        var result = _calculatorEngine.Log(x, y);

        //assert
        Assert.That(result.ErrorMessage, Is.EqualTo("Base of Zero"));
        
    }

    [Test] //preq-UNIT-TEST-12
    public void Root_TwoFloatingPoints_ReturnsRoot()
    {
        //arrange
        double x = 8, y = 3;
        
        //act
        var result = _calculatorEngine.Root(x, y);

        //assert
        Assert.That(result.Output, Is.EqualTo(2));
    }

    [Test] //preq-UNIT-TEST-13
    public void Root_OfZero_ReturnsError()
    {
        //arrange
        double x = 8, y = 0;
        
        //act
        var result = _calculatorEngine.Root(x, y);

        //assert
        Assert.That(result.ErrorMessage, Is.EqualTo("Negative Root Value"));
    }

    [Test]  //preq-UNIT-TEST-14	
    public void Factorial_Nonzero_ReturnsProduct()
    {
        //arrange
        double x = 10;
        
        //act
        var result = _calculatorEngine.Factorial(x);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(3628800));
    }

    [Test]  //preq-UNIT-TEST-15	
    public void Factorial_OfZero_ReturnsOne()
    {
        //arrange
        double x = 0;
        
        //act
        var result = _calculatorEngine.Factorial(x);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(1));
    }
    //MORE WORK
    
    [Test] //preq-UNIT-TEST-16	
    public void Sin_InDegrees_ReturnsRadians()
    {
        //arrange
        double x = 90;
        
        //act
        var result = _calculatorEngine.Sin(x);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(1));
    }
    
    
    //preq-UNIT-TEST-17	
    [Test]
    public void Cos_InDegrees_ReturnsRadians()
    {
        //arrange
        double x = 180;
        
        //act
        var result = _calculatorEngine.Cos(x);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(-1));
    }
    
    //preq-UNIT-TEST
    [Test]
    public void Tan_InDegrees_ReturnsRadians()
    {
        //arrange
        double x = 0;

        //act
        var result = _calculatorEngine.Tan(x);

        //assert
        Assert.That(result.Output, Is.EqualTo(0));
    }

    [Test] //preq-UNIT-TEST-19	
    public void Reciprocal_FloatingPoint_ReturnsReciprocal()
    {
        //arrange
        double x = 10;
        
        //act
        var result = _calculatorEngine.Reciprocal(x);
        
        //assert
        Assert.That(result.Output, Is.EqualTo(0.1));
    }

    [Test] //preq-UNIT-TEST-20	
    public void Reciprocal_OfZero_ReturnsError()
    {
        //arrange
        double x = 0;
        
        //act
        var result = _calculatorEngine.Reciprocal(x);
        
        //assert
        Assert.That(result.ErrorMessage, Is.EqualTo("Division by Zero"));
    }
}