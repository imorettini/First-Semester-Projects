using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_1TIN_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;

            do
            {

                Console.Clear();

                // código feito por Amanda Morettini e Giovane Vitorio

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(33, 0);
                Console.Write("Menu Principal");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(10, 12);
                Console.Write("Criado por Amanda Morettini e Giovane Vitorio - 1ºTIN");
                Console.SetCursorPosition(3, 14);
                Console.Write("Caso a letra azul fique escura, aumente a luminosidade do monitor! :)");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 3);
                Console.Write("[1] Cálculos");
                Console.SetCursorPosition(34, 4);
                Console.Write("[2] Matematica Básica");
                Console.SetCursorPosition(34, 5);
                Console.Write("[3] Outros");
                Console.SetCursorPosition(34, 6);
                Console.Write("[4] Sair");
                Console.SetCursorPosition(0, 8);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 9);
                Console.WriteLine("Digite sua opção:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 10);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(52, 9);
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        {
                            Cálculos();
                            break;
                        }
                    case 2:
                        {
                            MatemáticaBásica();
                            break;
                        }
                    case 3:
                        {
                            Outros();
                            break;

                        }
                } 

            } 

            while (opc != 4);

        }

        static void Cálculos()
        {
            int a;
            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 33)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 0);   
                Console.Write("Menu De Cálculo");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 31));


                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 3);
                Console.Write("[1] Calculadora");
                Console.SetCursorPosition(34, 4);
                Console.Write("[2] Área do Triangulo");
                Console.SetCursorPosition(34, 5);
                Console.Write("[3] Sucessor Antecessor");
                Console.SetCursorPosition(34, 6);
                Console.Write("[4] Média");
                Console.SetCursorPosition(34, 7);
                Console.Write("[5] Equação de 2º grau");
                Console.SetCursorPosition(34, 8);
                Console.Write("[6] Voltar");
                Console.SetCursorPosition(0, 9);

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 10);
                Console.WriteLine("Digite sua opção:");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 11);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(52, 10);
                a = int.Parse(Console.ReadLine());
                Console.Clear();

                if (a == 1)
                {
                    MenuCalculadora();
                }
                else if (a == 2)

                {
                    AreaTriangulo();
                }

                else if (a == 3)
                {
                    SucessorAntecessor();
                }

                else if(a == 4)
                {
                    Media();
                }

                else if(a == 5)
                {
                    Equação2grau();
                }
            } while (a != 6);
        } 

        static void MatemáticaBásica()
        {
            int x;
            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Menu Matematica Básica");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 25));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 3);
                Console.Write("[1] Comparar números");
                Console.SetCursorPosition(34, 4);
                Console.Write("[2] Impar ou Par");
                Console.SetCursorPosition(34, 5);
                Console.Write("[3] Negativo Positivo");
                Console.SetCursorPosition(34, 6);
                Console.Write("[4] Tabuada");
                Console.SetCursorPosition(34, 7);
                Console.Write("[5] Dez Números");
                Console.SetCursorPosition(34, 8);
                Console.Write("[6] Sair");
                
                Console.SetCursorPosition(0, 9);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 10);
                Console.WriteLine("Digite sua opção:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 11);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(52, 10);
                x = int.Parse(Console.ReadLine());
                Console.Clear();

                if (x == 1)
                {
                    ComparaNumeros();
                }

                if (x == 2)
                {
                    ParOuImpar();
                }

                if (x == 3)
                {
                    NegativoPositivo();
                }

                if (x == 4)
                {
                    Tabuada();
                }
                if (x == 5)
                {
                    Deznumeros();
                }

                
            }
            while (x != 6);
        }

        static void Outros()
        {
            int x;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 0);
                Console.Write("Menu Outros");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 3);
                Console.Write("[1] Sorteia Números");
                Console.SetCursorPosition(34, 4);
                Console.Write("[2] Veja Sua Idade");
                Console.SetCursorPosition(34, 5);
                Console.Write("[3] Adivinhe o Número");
                Console.SetCursorPosition(34, 6);
                Console.Write("[4] Cálculo de IMC");
                Console.SetCursorPosition(34, 7);
                Console.Write("[5] Dias da Semana e Meses");
                Console.SetCursorPosition(34, 8);
                Console.Write("[6] Número Extenso");
                Console.SetCursorPosition(34, 9);
                Console.Write("[7] Sigla do Estado");
                Console.SetCursorPosition(34, 10);
                Console.Write("[8] Sair");
                Console.SetCursorPosition(0, 10);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 11);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 12);
                Console.WriteLine("Digite sua opção:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 13);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(52, 12);
                x = int.Parse(Console.ReadLine());
                Console.Clear();

                if (x == 1)
                {
                    SorteiaNumeros();
                }

                if (x == 2) 
                {
                    VejaIdade();
                }

                if (x == 3)
                {
                    Adivinhanumero();

                }

                if (x == 4) 
                {
                    CalculoIMC();
                }
                if(x == 5)
                {
                    Diadomes();
                }
                if (x == 6)
                {
                    Numeroextenso();
                }
                if (x == 7)
                {
                    Sigladoestado();
                }
               

            } while (x != 8);
        }

        static void SorteiaNumeros()
        {
            int resposta = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Sorteia Número");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Random rand = new Random();
                int name = rand.Next(1, 100);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 2);
                Console.WriteLine("Aperte ENTER para sortear um número");


                Console.WriteLine(rand.Next(1, 100));
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 6);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 8);

                Console.Clear();
                break;
            } while (resposta == 1);
        }

        static void VejaIdade()
        {
            int resposta = 0;
            do
            {
                double a, b;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Veja a idade");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 2);
                Console.WriteLine("Digite o ano atual: ");
                Console.SetCursorPosition(53, 2);
                a = double.Parse(Console.ReadLine());



                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.WriteLine("Digite o ano do seu nascimento: ");
                Console.SetCursorPosition(63, 6);
                b = double.Parse(Console.ReadLine());


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));



                double r = a - b;
                if (r <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 10);
                    Console.WriteLine("Você tem " + r + " anos, então é criança");
                }
                if (r <= 15)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 10);
                    Console.WriteLine("Você tem " + r + " anos,então é pre-adolescente");
                }
                if (r <= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 10);
                    Console.WriteLine("Você tem " + r + " anos, então é adolescente");
                }
                if (r <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 10);
                    Console.WriteLine("Você tem " + r + " anos, então é jovem");
                }
                else if (r <= 60)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 10);
                    Console.WriteLine("Você tem " + r + " anos, então é adulto");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 10);
                    Console.WriteLine("Você tem " + r + " anos, então é um idoso");
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 14);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 16);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 14);

                Console.Clear();
            } while (resposta == 1);
        }

        static void MenuCalculadora()
        {
            int resposta = 0;
            do
            {
                int A, B;
                int R = 0;

                Console.ForegroundColor = ConsoleColor.Green;

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 33)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 0);  
                Console.Write("Calculadora");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(31, 2);  
                Console.Write("Digite um número: ");
                A = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;  
                Console.SetCursorPosition(31, 3);  
                Console.Write("Digite outro número: ");

                B = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 78)); 



             
                
                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.SetCursorPosition(31, 5);  
                    Console.WriteLine("Para somar digite 1");

                    Console.SetCursorPosition(31, 6);  
                    Console.WriteLine("Para subtrair digite 2");

                    Console.SetCursorPosition(31, 7);  
                    Console.WriteLine("Para dividir digite 3");

                    Console.SetCursorPosition(31, 8);  
                    Console.WriteLine("Para multiplicar digite 4");

                    Console.SetCursorPosition(31, 9); 
                    Console.WriteLine("Para exponenciar digite 5");

                    Console.SetCursorPosition(31, 10);  
                    Console.WriteLine("Para ver o resto digite 6");

                    Console.SetCursorPosition(31, 11);  
                    Console.WriteLine("Digite sua opção:");

                    Console.ForegroundColor = ConsoleColor.Magenta; 
                    Console.Write(new string('=', 80)); 

                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.SetCursorPosition(49, 11);
                    R = int.Parse(Console.ReadLine());

                    if (R == 1)

                    {
                        Console.SetCursorPosition(36, 13); 
                        Console.WriteLine("Soma = {0}", A + B);

                    }

                    if (R == 2)

                    {
                        Console.SetCursorPosition(36, 13); 
                        Console.WriteLine("Subtração = {0}", A - B);

                    }

                    if (R == 3)

                    {
                 
                   if (B != 0)
                    {
                        Console.SetCursorPosition(36, 13);
                        Console.WriteLine("Divisão = {0}", A / B);
                    }

                    else
                    {
                        Console.SetCursorPosition(31, 13);
                        Console.WriteLine("Não é possivel dividir por zero");
                    }

                }

                    if (R == 4)

                    {
                        Console.SetCursorPosition(36, 13);  
                        Console.WriteLine("Multiplicação = {0}", A * B);

                    }

                    if (R == 5)

                    {
                        Console.SetCursorPosition(36, 13);   
                        Console.WriteLine("Exponenciação = {0}", A ^ B);

                    }


                    if (R == 6)

                    {
                        Console.SetCursorPosition(36, 13); 
                        Console.WriteLine("Resto = {0}", A % B);

                    }

                    if (R > 7)

                    {
                        Console.SetCursorPosition(31, 13); 
                        Console.WriteLine("Comando Inválido");

                    }
                    
                
                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 15);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 17);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 19);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 17);

                Console.Clear();

            } while (resposta == 1);

        }

        static void AreaTriangulo()
        {
            int resposta = 0;
            do
            {
                double H, B;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Área do triângulo");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 30));

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 3);  
                Console.Write("Digite o valor da altura: ");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 6);
                Console.Write(new string('=', 80)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(60, 3);
                H = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 4);  
                Console.Write("Digite o valor da base: ");

                B = double.Parse(Console.ReadLine());



                Console.ForegroundColor = ConsoleColor.Blue;  
                Console.SetCursorPosition(5, 8);  
                Console.WriteLine("Para descobrirmos a área do triângulo aplicamos a seguinte fórmula: H*B/2");
                double R = H * B / 2;

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 10);
                Console.Write(new string('=', 80)); 


                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 12);   
                Console.WriteLine("O resultado é " + R);

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 14);
                Console.Write(new string('=', 80)); 

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 16);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 18);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 16);

                Console.Clear();
            } while (resposta == 1);
        }

        static void SucessorAntecessor()
        {
            int resposta = 0;
            do
            {
                int N;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 33)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.Write("Sucessor e Antecessor");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 27)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(34, 2);  
                Console.Write("Digite um número: ");


                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80)); 

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(52, 2);
                N = int.Parse(Console.ReadLine());
                int a = N - 1;
                int r = N + 1;
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(27, 6);  
                Console.WriteLine("O número sucessor de " + N + " é " + r + " e o antecessor é " + a);

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 10);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 10);

                Console.Clear();

            } while (resposta == 1);

            

        }

        static void ComparaNumeros()
        {
            int resposta = 0;
            do
            {
                int A, B;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 33)); 

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Compara Números");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.Write(new string('=', 33)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(32, 2);  
                Console.Write("Digite um número: ");
                A = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(32, 3);  
                Console.WriteLine("Digite outro número: ");


                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 5);  
                Console.Write(new string('=', 80)); 

                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.SetCursorPosition(52, 3);


                B = int.Parse(Console.ReadLine());

                if (A < B)
                {


                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.SetCursorPosition(32, 7);  
                    Console.WriteLine(A + " é menor que " + B);

                    Console.ForegroundColor = ConsoleColor.Magenta; 
                    Console.SetCursorPosition(0, 9);  
                    Console.Write(new string('=', 80)); 
                }
                else if (B > A)
                {


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 7);
                    Console.WriteLine(A + " é maior que " + B);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 11);
                    Console.Write(new string('=', 80));
                }
                else
                {


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 7);
                    Console.WriteLine(" Os números são iguais");

                    Console.SetCursorPosition(54, 7);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 9);
                    Console.Write(new string('=', 80));


                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 11);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 13);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 11);

                Console.Clear();
            } while (resposta == 1);

        }

        static void ParOuImpar()
        {
            int resposta = 0;
            do
            {
                int A;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Par ou Impar");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 35));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 2);
                Console.Write("Digite um número: ");

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80)); 

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(50, 2);

                A = int.Parse(Console.ReadLine());
                if (A % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 6);
                    Console.WriteLine(A + " É Par!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 6);
                    Console.WriteLine(A + " É Impar!");
                }
                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80)); 


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 10);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 10);

                Console.Clear();

            } while (resposta == 1);

        }

        static void NegativoPositivo()
        {
            int resposta = 0;
            do
            {
                int N;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Negativo positivo");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 2);
                Console.Write("Digite um número: ");

                Console.SetCursorPosition(50, 2);

                N = int.Parse(Console.ReadLine());


                if (N < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string('=', 80));

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 6);
                    Console.WriteLine(N + " É negativo!");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 8);
                    Console.Write(new string('=', 80));
                }
                else if (N > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string('=', 80));

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 6);
                    Console.WriteLine(N + " É positivo!");


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 8);
                    Console.Write(new string('=', 80));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string('=', 80));

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 6);
                    Console.WriteLine("Zero");


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(0, 8);
                    Console.Write(new string('=', 80));



                }
               
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 10);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 10);

                Console.Clear();

            } while (resposta == 1);
        }

        static void Adivinhanumero()
        {
            int resposta = 0;
            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Adivinhe o número");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 30));

                int tentativas = 0;
                int num = 0;
                Random r = new Random();
                int a = r.Next(0, 100);
                while (true)

                {
                    tentativas++;


                    Console.ForegroundColor = ConsoleColor.Blue;
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                    }

                    catch
                    {

                        Console.WriteLine("Eu disse número bonita."); 

                    }

                    Console.ForegroundColor = ConsoleColor.Blue;

                    if (num < a)

                    {
                        Console.WriteLine("Maior...");
                    }


                    else if (num > a)
                    {
                        Console.WriteLine("Menor...");
                    }

                    if (num == a)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Acertô mizeravi!");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDepois de {0} tentativas.", tentativas);


                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(new string('=', 80));

                        Console.ForegroundColor = ConsoleColor.Blue;
                        
                        Console.WriteLine("Você quer continuar? (1 para Sim / 2 para Não)");
                        resposta = int.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.Magenta;
                       
                        Console.Write(new string('=', 80));

                        Console.SetCursorPosition(43, 16);

                        
                        Console.Clear();

                        break;
                    }
                    
                }
            } while (resposta == 1);
           
        }

        static void CalculoIMC()
        {
            int resposta = 0;
            do
            {


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Calculo de IMC");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 34));

                double kg, h;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 2);
                Console.Write("Digite seu peso em Kg: ");
                kg = double.Parse(Console.ReadLine());


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.Write("Digite sua altura em metros: ");
                h = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(21, 10);
                Console.WriteLine("Para descobrirmos seu IMC usamos a seguinte fórmula KG/H²");
                double y = kg / (h * h);

                Console.SetCursorPosition(32, 10);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 14);
                Console.WriteLine("Seu IMC é: " + y);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 16);
                Console.Write(new string('=', 80));
                if (y < 17)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Você está muito abaixo do peso");
                }

                if (y < 18.49)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Você está muito abaixo do peso");
                }

                if (y < 24.99)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Parabéns, seu peso está normal!");
                }

                else if (y < 29.99)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Você está acima do peso");
                }

                else if (y < 34.99)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Você está com Obesidade I");
                }

                else if (y < 39.99)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Você está com Obesidade II (severa)");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(32, 18);
                    Console.WriteLine("Cuidado! Você está com Obesidade III (mórbida)");
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 20);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 22);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 24);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 22);

                Console.Clear();
            } while (resposta == 1);
        }

        static void Media()
        {
            int resposta = 0;
            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 35));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Média");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 39));

                int a, b, x;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 2);
                Console.Write("Digite o primeiro número: ");
                a = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(42, 2);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.Write("Digite o segundo número: ");
                b = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(42, 6);

                x = (a + b) / 2;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 10);
                Console.WriteLine("A média destes números é igual a " + x);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 14);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 16);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 16);

                Console.Clear();


            }
            while (resposta == 1);
        }   

        static void Equação2grau()
        {
            int resposta = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Equação de 2º grau");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 27));

                double delta, a, b, c, x1, x2;
               

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 2);
                Console.Write("Digite o valor de a: ");
                a = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.Write("Digite o valor de b: ");
                b = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 10);
                Console.Write("Digite o valor de c: ");
                c = double.Parse(Console.ReadLine());

                delta = Math.Pow(b, 2) - (4 * a * c);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.WriteLine(delta);
                if (delta < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(30, 14);
                    Console.Write("Delta não pode ser maior que zero");
                   
                }
                else
                {

                    
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(22, 14);
                    Console.WriteLine("O resultado da equação de segundo grau é : " + x1 + " e " + x2);
                    

                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 16);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 18);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 20);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 20);

                Console.Clear();


            }
            while (resposta == 1);
        }

        static void Diadomes()
        {
            int X = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(33, 0);
                Console.Write("Verificar Dia ou Mês");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 26));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 2);
                Console.Write("[1] Dia");
                Console.SetCursorPosition(34, 3);
                Console.Write("[2] Mês");
                Console.SetCursorPosition(34, 4);
                Console.Write("[3] Sair");


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 5);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34, 6);
                Console.WriteLine("Digite sua opção:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 7);
                Console.Write(new string('-', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(52, 6);

                X = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (X)
                {
                    case 1:
                        {
                            Dia();
                            break;
                        }
                    case 2:
                        {
                            Mes();
                            break;
                        }
                } 
            } 
            while (X != 3);
        } 

        static void Dia()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(new string('=', 33));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Verificar Dia ou Mês");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(new string('=', 26));

            int D = 0;
            string[] dia = { "", "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" }; 


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(30, 2);
            Console.Write("Digite um número para ver o dia: ");
            D = int.Parse(Console.ReadLine());

            if (D < 1 || D > 7)
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0 ,4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.WriteLine("Dia Inválido!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.WriteLine("{0} Corresponde a {1}", D, dia[D]);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(0, 8);
            Console.Write(new string('=', 80));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Aperte ENTER para voltar");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(0, 10);
            Console.Write(new string('=', 80));

            Console.ReadKey();
            Console.Clear();
        } 

        static void Mes()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(new string('=', 33));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Verificar Dia ou Mês");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(new string('=', 25));

            int M = 0;

            string[] mes = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }; 
            string[] feriado = { "", "01/01 -> Ano Novo", "13/02 -> Carnaval; 14/02 -> Quarta-feira de cinzas", "30/03 -> Sexta-feira Santa",
            "01/04 -> Páscoa; -> 21/04 -> Tiradentes", "Dia do Trabalhador; 31/05 -> Corpus Christi",
            "não há feriados :(", "não há feriados, porém estaremos de férias! :)", "não há feriados :(",
            "07/09 -> Independência do Brasil", "12/10 -> Nossa Senhora Aparecida/Dia das Crianças",
            "02/11 -> Finados; 15/11 -> Proclamação da República", "25/12 -> Natal; FÉRIAS! :)" };


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(22, 2);
            Console.Write("Digite um número para ver o mês correspondente: ");
            M = int.Parse(Console.ReadLine());

            if (M < 1 || M > 12)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(32, 6);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Mês Inválido!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("{0} Corresponde a {1} e seus feriados são {2}", M, mes[M], feriado[M]);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(0, 8);
            Console.Write(new string('=', 80));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Aperte ENTER para voltar");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(0, 12);
            Console.Write(new string('=', 80));

            Console.ReadKey();
            Console.Clear();
        }

        static void Numeroextenso()
        {
            int resposta = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Número Extenso");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                int N, ND, NE, NC;
                string[] unidade = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
                string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
                string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quintos", "seiscentos", "setecentos", "oitocentos", "novecentos" };


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(20, 2);
                Console.Write("Digite um número e ele aparecerá em extenso: ");
                N = int.Parse(Console.ReadLine());
                ND = N % 10;
                NE = N / 10;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 4);
                Console.Write(new string('=', 80));

                if (N < 20)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine(unidade[N]);
                }

                else if (N < 100)
                {
                    ND = N % 10;
                    NE = N / 10;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(20, 6);
                    Console.WriteLine(dezena[NE] + " e " + unidade[ND]);

                }

                else if (N == 100)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("cem");
                }
                else if (N < 1000)
                {
                    NC = N / 100;
                    NE = N % 100;
                    NE = NE / 10;
                    ND = N % 100;
                    ND = ND % 10;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(18, 6);
                    Console.Write(centena[NC]);
                    if (NE > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(24, 6);
                        Console.Write(" e " + dezena[NE]);
                    }
                    if (N > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(37, 6);
                        Console.Write(" e " + unidade[ND]);
                    }
                }

                else if (N > 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Digite um número até 999");
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 8);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 10);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 10);

                Console.Clear();
            } while (resposta == 1);
        }

        static void Sigladoestado()
        {
            int resposta = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Sigla Estado");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                string chave;
                int x;
                string[,] estado = new string[27, 2];
                estado[0, 0] = "AC";
                estado[0, 1] = "Acre";
                estado[1, 0] = "AL";
                estado[1, 1] = "Alagoas";
                estado[2, 0] = "AP";
                estado[2, 1] = "Amapá";
                estado[3, 0] = "AM";
                estado[3, 1] = "Amazonas";
                estado[4, 0] = "BA";
                estado[4, 1] = "Bahia";
                estado[5, 0] = "CE";
                estado[5, 1] = "Ceará";
                estado[6, 0] = "DF";
                estado[6, 1] = "Distrito Federal";
                estado[7, 0] = "ES";
                estado[7, 1] = "Espírito Santo";
                estado[8, 0] = "GO";
                estado[8, 1] = "Goiás";
                estado[9, 0] = "MA";
                estado[9, 1] = "Maranhão";
                estado[10, 0] = "MT";
                estado[10, 1] = "Mato Grosso";
                estado[11, 0] = "MG";
                estado[11, 1] = "Minas Gerais";
                estado[12, 0] = "PA";
                estado[12, 1] = "Pará";
                estado[13, 0] = "PB";
                estado[13, 1] = "Paraíba";
                estado[14, 0] = "PR";
                estado[14, 1] = "Paraná";
                estado[15, 0] = "PE";
                estado[15, 1] = "Pernambuco";
                estado[16, 0] = "PI";
                estado[16, 1] = "Piauí";
                estado[17, 0] = "RJ";
                estado[17, 1] = "Rio de Janeiro";
                estado[18, 0] = "RN";
                estado[18, 1] = "Rio Grande do Norte";
                estado[19, 0] = "RS";
                estado[19, 1] = "Rio Grande do Sul";
                estado[20, 0] = "RO";
                estado[20, 1] = "Rondônia";
                estado[21, 0] = "RR";
                estado[21, 1] = "Roraima";
                estado[22, 0] = "SC";
                estado[22, 1] = "Santa Catarina";
                estado[23, 0] = "SP";
                estado[23, 1] = "São Paulo";
                estado[24, 0] = "SE";
                estado[24, 1] = "Sergipe";
                estado[25, 0] = "TO";
                estado[25, 1] = "Tocantins";
                estado[26, 0] = "MS";
                estado[26, 1] = "Mato Grosso do Sul";

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 2);
                Console.Write("Digite a sigla: ");
                chave = Console.ReadLine();
                for (x = 0; x <= 26; x++)
                {
                    if (chave == estado[x, 0])
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(0, 4);
                        Console.Write(new string('=', 80));

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(30, 6);
                        Console.WriteLine(chave + " Corresponde a " + estado[x, 1]);

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(0, 8);
                        Console.Write(new string('=', 80));
                        break;

                    }

                    if (x > 26)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(0, 4);
                        Console.Write(new string('=', 80));

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(30, 6);
                        Console.WriteLine("Sigla ou Estado não existente ou não cadastrado");

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(0, 8);
                        Console.Write(new string('=', 80));
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 10);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 12);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 10);

                Console.Clear();
            } while (resposta == 1);
        }

        static void Tabuada()
        {
            int resposta = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Tabuada");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 38));

                int num, resp;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(22, 2);
                Console.Write("Informe um número para tabuada: ");
                num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    resp = num * i;

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine(num + " x " + i + " = " + resp);

                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 14);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 18);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 16);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(43, 16);

                Console.Clear();

            } while (resposta == 1);
        }
        
        static void Deznumeros()
            {
            int resposta = 0;
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, maior = 0, menor, total, opc1;
            do
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 33));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Dez Números");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(new string('=', 36));


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 2);
                Console.WriteLine("Digite o 1° Numero: ");
                Console.SetCursorPosition(50, 2);
                n1 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("Digite o 2° Numero: ");
                Console.SetCursorPosition(50, 3);
                n2 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 4);
                Console.WriteLine("Digite o 3° Numero: ");
                Console.SetCursorPosition(50, 4);
                n3 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 5);
                Console.WriteLine("Digite o 4° Numero: ");
                Console.SetCursorPosition(50, 5);
                n4 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 6);
                Console.WriteLine("Digite o 5° Numero: ");
                Console.SetCursorPosition(50, 6);
                n5 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 7);
                Console.WriteLine("Digite o 6° Numero: ");
                Console.SetCursorPosition(50, 7);
                n6 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("Digite o 7° Numero: ");
                Console.SetCursorPosition(50, 8);
                n7 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 9);
                Console.WriteLine("Digite o 8° Numero: ");
                Console.SetCursorPosition(50, 9);
                n8 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("Digite o 9° Numero: ");
                Console.SetCursorPosition(50, 10);
                n9 = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 11);
                Console.WriteLine("Digite o 10° Numero: ");
                Console.SetCursorPosition(50, 11);
                n10 = int.Parse(Console.ReadLine());


                
            
                
                if (maior < n1)
                {
                    maior = n1;
                }
                if (maior < n2)
                {
                    maior = n2;
                }
                if (maior < n3)
                {
                    maior = n3;
                }
                if (maior < n4)
                {
                    maior = n4;
                }
                if (maior < n5)
                {
                    maior = n5;

                }
                if (maior < n6)
                {
                    maior = n6;

                }
                if (maior < n7)
                {
                    maior = n7;
                }
                if (maior < n8)
                {
                    maior = n8;
                }
                if (maior < n9)
                {
                    maior = n9;
                }
                if (maior < n10)
                {
                    maior = n10;
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 13);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 15);
                Console.WriteLine("o maior número é : " + maior);
                menor = n1;
                if (n2 < menor)
                {
                    menor = n2;
                }
                if (n3 < menor)
                {
                    menor = n3;
                }
                if (n4 < menor)
                {
                    menor = n4;
                }
                if (n5 < menor)
                {
                    menor = n5;
                }
                if (n6 < menor)
                {
                    menor = n6;
                }
                if (n7 < menor)
                {
                    menor = n7;
                }
                if (n8 < menor)
                {
                    menor = n8;
                }
                if (n9 < menor)
                {
                    menor = n9;
                }
                if (n10 < menor)
                {
                    menor = n10;
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 17);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 19);
                Console.WriteLine("O menor número é: " + menor);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 21);
                Console.Write(new string('=', 80));

                total = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 23);
                Console.WriteLine("A somatória total dos valores digitados é: " + total);
               
                if (n1 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 25);
                    Console.WriteLine(n1 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 26);
                    Console.WriteLine(n1 + " É Impar!");
                }
                if (n2 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 27);
                    Console.WriteLine(n2 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 28);
                    Console.WriteLine(n2 + " É Impar!");
                }
                if (n3 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 29);
                    Console.WriteLine(n3 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 30);
                    Console.WriteLine(n3 + " É Impar!");
                }
                if (n4 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 31);
                    Console.WriteLine(n4 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 32);
                    Console.WriteLine(n4 + " É Impar!");
                }
                if (n5 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 33);
                    Console.WriteLine(n5 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 34);
                    Console.WriteLine(n5 + " É Impar!");
                }
                if (n6 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 35);
                    Console.WriteLine(n6 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 36);
                    Console.WriteLine(n6 + " É Impar!");
                }
                if (n7 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 37);
                    Console.WriteLine(n7 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 38);
                    Console.WriteLine(n7 + " É Impar!");
                }
                if (n8 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 39);
                    Console.WriteLine(n8 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 40);
                    Console.WriteLine(n8 + " É Impar!");
                }
                if (n9 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 41);
                    Console.WriteLine(n9 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 42);
                    Console.WriteLine(n9 + " É Impar!");
                }
                if (n10 % 2 == 0)
                {
                    Console.SetCursorPosition(30, 43);
                    Console.WriteLine(n10 + " É Par!");
                }
                else
                {
                    Console.SetCursorPosition(30, 44);
                    Console.WriteLine(n10 + " É Impar!");
                }



                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 46);
                Console.Write(new string('=', 80));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 48);
                Console.Write("Você quer continuar? (1 para Sim / 2 para Não)");
                resposta = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 50);
                Console.Write(new string('=', 80));

                Console.SetCursorPosition(43, 48);

                Console.Clear();
            }
            while (resposta == 1);
        }
      
    }
    
}

