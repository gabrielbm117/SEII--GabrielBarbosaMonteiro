using System;

class Aluno
{

    private double nota1, nota2;

    private double media()
    {
        return (nota1+nota2)/2;
    }

    public void mensagem()
    {
        Console.WriteLine("Infome a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Infome a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média é "+media());
    }

}