namespace Calculadora;

public class Calculadora
{
    private List<string> historico = new();

    public int Somar(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        historico.Add($"{numero1} + {numero2} = {resultado}");
        return resultado;
    }

    public int Subtrair(int numero1, int numero2)
    {
        int resultado = numero1 - numero2;
        historico.Add($"{numero1} - {numero2} = {resultado}");
        return resultado;
    }

    public int Multiplicar(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        historico.Add($"{numero1} * {numero2} = {resultado}");
        return resultado;
    }

    public int Dividir(int numero1, int numero2)
    {
        if (numero2 == 0)
        {
            throw new DivideByZeroException();
        }

        int resultado = numero1 / numero2;
        historico.Add($"{numero1} / {numero2} = {resultado}");
        return resultado;
    }

    public List<string> ObterHistorico()
    {
        return historico;
    }
}