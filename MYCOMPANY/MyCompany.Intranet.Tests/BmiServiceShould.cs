using MyCompany.Intranet.Core.Services;
using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Tests;

public class BmiServiceShould
{
    [Fact]
    public void GetImpuestos_WhenSueldoLessThan7735()
    {
        //arrange
        var expected = 95.999809265136719;
        var person = new Person { Sueldo = 5000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan7735AndLessThan65651()
    {
        //arrange
        var expected = 805.4693603515625;
        var person = new Person { Sueldo = 18000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan65651AndLessThan115375()
    {
        //arrange
        var expected =  7048.302734375;
        var person = new Person { Sueldo = 95000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan115375AndLessThan134119()
    {
        //arrange
        var expected = 10005.0546875;
        var person = new Person { Sueldo = 120000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThann134119AndLessThan160577()
    {
        //arrange
        var expected = 14213.9599609375;
        var person = new Person { Sueldo = 145000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan160577AndLessThan323862()
    {
        //arrange
        var expected = 36106.08203125;
        var person = new Person { Sueldo = 250000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan323862AndLessThan510451()
    {
        //arrange
        var expected = 81550.6640625;
        var person = new Person { Sueldo = 450000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan510451AndLessThan974535()
    {
        //arrange
        var expected = 182633.4375;
        var person = new Person { Sueldo = 800000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan974535AndLessThan1299380()
    {
        //arrange
        var expected = 275142.75;
        var person = new Person { Sueldo = 1100000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan1299380AndLessThan3898140()
    {
        //arrange
        var expected = 577155.125;
        var person = new Person { Sueldo = 2000000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
    
    [Fact]
    public void GetImpuestos_WhenSueldoThan3898140()
    {
        //arrange
        var expected = 1258173.75;
        var person = new Person { Sueldo = 4000000};
        var sut = new IsrService();
        
        //act
        var result = sut.GetISR(person);
        
        //Assert
        Assert.Equal(expected, result.Impuestos);
    }
}