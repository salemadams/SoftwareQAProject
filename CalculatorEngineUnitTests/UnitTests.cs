namespace CalculatorEngineUnitTests;

using CalculatorEngine;

public class Tests
{
    [Test]  //preq-UNIT-TEST-2
    public void Add_TwoFloatingPoints_ReturnsSum()
    {
        //arrange
        double x = 10, y = 5;
        
        //act
        double result = CalculatorEngine.Add(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(15));
    }
    
    [Test]  //preq-UNIT-TEST-3
    public void Subtract_TwoFloatingPoints_ReturnsDifference()
    {
        //arrange
        double x = 20, y = 15;
        
        //act
        double result = CalculatorEngine.Subtract(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]  //preq-UNIT-TEST-4	
    public void Multiply_TwoFloatingPoints_ReturnsProduct()
    {
        //arrange
        double x = 5, y = 20;
        
        //act
        double result = CalculatorEngine.Multiply(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]  //preq-UNIT-TEST-5	
    public void Divide_TwoFloatingPoints_ReturnsQuotient()
    {
        //arrange
        double x = 50, y = 2;
        
        //act
        double result = CalculatorEngine.Divide(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(25));
    }

    //MORE WORK
    
    [Test]  //preq-UNIT-TEST-6	
    public void Divide_Zero_ReturnsError()
    {
        //arrange
        double x = 10, y = 0;
        
        //assert
        Assert.Throws<DivideByZeroException>(() => CalculatorEngine.Divide(x, y));
    }
    

    [Test]  //preq-UNIT-TEST-7	
    public void Equals_OverEightPrecision_ReturnsOne()
    {
        //arrange
        double x = 0.888888887, y = 0.888888886;
        
        //act
        bool result = CalculatorEngine.Equals(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]  //preq-UNIT-TEST-7
    public void Equals_UnderEightPrecision_ReturnsZero()
    {
        //arrange
        double x = 0.8888885, y = 0.8888886;
        
        //act
        bool result = CalculatorEngine.Equals(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]  //preq-UNIT-TEST-8	
    public void CalculatorEngine_RaiseXToY_ReturnsProduct()
    {
        //arrange
        double x = 10, y = 2;
        
        //act
        double result = CalculatorEngine.Power(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]  //preq-UNIT-TEST-9	
    public void CalculatorEngine_ALogB_ReturnsExponent()
    {
        //arrange
        double x = 25, y = 5;
        
        //act
        double result = CalculatorEngine.Log(x, y);
        
        //assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]  //preq-UNIT-TEST-10
    public void CalculatorEngine_LogOfNegative_ReturnsError()
    {
        //arrange
        double x = -25, y = 5;
        
        //act
        double result = CalculatorEngine.Log(x, y);

        //assert
        Assert.IsTrue(double.IsNaN(result));
        
    }
    
    [Test]  //preq-UNIT-TEST-11
    public void CalculatorEngine_ALogZero_ReturnsError()
    {
        //arrange
        double x = 2, y = 0;
        
        //act
        double result = CalculatorEngine.Log(x, y);

        //assert
        Assert.IsTrue(double.IsNaN(result));
        
    }

    [Test] //preq-UNIT-TEST-12
    public void CalculatorEngine_ARootB_ReturnsRoot()
    {
        //arrange
        double x = 8, y = 3;
        
        //act
        double result = CalculatorEngine.Root(x, y);

        //assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test] //preq-UNIT-TEST-13 CHECK WITH PROFESSOR
    public void CalculatorEngine_ARootZero_ReturnsError()
    {
        //arrange
        double x = 8, y = 0;
        
        //act
        double result = CalculatorEngine.Root(x, y);

        //assert
        Assert.IsTrue(double.IsNaN(result));
    }

    [Test]  //preq-UNIT-TEST-14	
    public void CalculatorEngine_FactorialOfX_ReturnsProduct()
    {
        //arrange
        double x = 10;
        
        //act
        double result = CalculatorEngine.Factorial(x);
        
        //assert
        Assert.That(result, Is.EqualTo(3628800));
    }

    [Test]  //preq-UNIT-TEST-15	
    public void CalculatorEngine_FactorialOfZero_ReturnsOne()
    {
        //arrange
        double x = 0;
        
        //act
        double result = CalculatorEngine.Factorial(x);
        
        //assert
        Assert.That(result, Is.EqualTo(1));
    }
    //MORE WORK
    /*
    [Test] //preq-UNIT-TEST-16	
    public void CalculatorEngine_SineOfX_ReturnsSine()
    {
        //arrange
        double x = 360;
        
        //act
        double result = CalculatorEngine.Sin(x);
        
        //assert
        Assert.That(result, Is.EqualTo(0));
    }
    */
    
    //preq-UNIT-TEST-17	FILL IN LATER
    //preq-UNIT-TEST-18	FILL IN LATER

    [Test] //preq-UNIT-TEST-19	
    public void CalculatorEngine_DivideOneByX_ReturnsReciprocal()
    {
        //arrange
        double x = 10;
        
        //act
        double result = CalculatorEngine.Reciprocal(x);
        
        //assert
        Assert.That(result, Is.EqualTo(0.1));
    }
    
    //preq-UNIT-TEST-20	FILL IN LATER
}