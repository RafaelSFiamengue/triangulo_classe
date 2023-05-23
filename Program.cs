//Biblioteca usada
using System;
//Biblioteca usada
using System.Globalization;
//Biblioteca
namespace Course
{
    //Criação da classe Triangulo
    public class Triangulo
    {
        //Declaração da variável A
        public double A { get; set; }
        //Declaração da variável B
        public double B { get; set; }
        //Declaração da variável C
        public double C { get; set; }

        //Cria o método de calcular área
        public double CalcularArea()
        {
            //Calculo da área
            double p = (A + B + C) / 2.0;
            //Calculo da área
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //retorna para a area para funcionar o programa
            return area;
        }
    }
    //Cria a classe programa
    public class Program
    {
        //Programa principal
        public static void Main(string[] args)
        {
            //Cria o triangulo X para ser lido suas medidas
            Triangulo x = LerTriangulo("X");
            //Cria o triangulo Y para ser lido suas medidas
            Triangulo y = LerTriangulo("Y");

            //Calcula a area do X
            double areaX = x.CalcularArea();
            //Calcula a area do Y
            double areaY = y.CalcularArea();

            //Imprime o valor da área de X transformando-a em string
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Imrpime o valor da área de Y transformando-a em string
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Condicional para área de X ser maior que Y
            if (areaX > areaY)
            {
                //Imprime para o usuário que X é maior
                Console.WriteLine("X tem a maior área");
            }
            //Condicional restante
            else
            {
                //Imprime para o usuário que Y é maior
                Console.WriteLine("Y tem a maior área");
            }
        }

        //Cria a classe para criar cada objeto 
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            //Cria um novo objeto
            Triangulo triangulo = new Triangulo();
            //Pergunta para o usuário as medidas dos triangulos
            Console.WriteLine("Entre com as medidas do triangulo " + nomeTriangulo + ": ");
            //Le os valores da variavel A e atribui para calcular a area
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Le os valores da variavel B e atribui para calcular a area
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Le os valores da variavel C e atribui para calcular a area
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Retorna para o triangulo para o programa rodar
            return triangulo;
        }
            
    }
}