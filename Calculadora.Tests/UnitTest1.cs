namespace Calculadora.Tests;

public class CalculadoraTests
{
    [Fact]
    public void DeveSomarDoisNumeros()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Somar(10, 5);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveCriarHistoricoDeOperacoes()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        calculadora.Somar(10, 5);
        calculadora.Subtrair(20, 10);
        calculadora.Multiplicar(3, 4);
        calculadora.Dividir(20, 5);

        var historico = calculadora.ObterHistorico();

        // Assert
        Assert.Equal(4, historico.Count);
        Assert.Equal("10 + 5 = 15", historico[0]);
        Assert.Equal("20 - 10 = 10", historico[1]);
        Assert.Equal("3 * 4 = 12", historico[2]);
        Assert.Equal("20 / 5 = 4", historico[3]);
    }

    [Fact]
    public void DeveSubtrairDoisNumeros()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Subtrair(10, 5);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveMultiplicarDoisNumeros()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Multiplicar(10, 5);

        // Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DeveDividirDoisNumeros()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Dividir(10, 5);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void NaoDeveDividirPorZero()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act e Assert
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
    }
}