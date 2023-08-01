// 6 - Faça um programa que calcule a área de um quadrado, sendo que o comprimento do lado é informado pelo usuário.
// A área do quadrado é calculada elevando-se o lado ao quadrado.

Console.Write("Informe o tamanho do lado do quadrado: ");
int lado = Convert.ToInt32(Console.ReadLine());

double area = Math.Pow(lado, 2);
Console.WriteLine("O tamanho da área é "+area);