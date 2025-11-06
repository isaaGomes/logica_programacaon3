// See https://aka.ms/new-console-template for more information



// Peça para o úsuario inserir dois numeros inteiros e mostre-os no console.

int n1;
int n2;


//Escrevi uma mensagem no console
Console.WriteLine("insira um numero inteiro");
// Li o conteudo de uma linha, quando o usuario apertou a tecla ENTER
// O Console so aceita texto (string)
// Logo e preciso converter a string pra int
n1 = int.Parse(Console.ReadLine());

//Escrevi outra mensagem no console 
Console.WriteLine("insira mais um numero inteiro ");
// Novamente li o conteudo da linha,quando o usuario apertou a tecla ENTER
n2 = int.Parse(Console.ReadLine());

//Mostrar os dois numeros no console
Console.WriteLine("voce digitou " + n1 + " e " + n2);


Console.WriteLine("------------");

Console.WriteLine("digite uma senha forte: (prometo que eunao vou te roubar)");
string senha = Console.ReadLine();

Console.WriteLine("zuera,roubei a sua senha: " + senha);

int soma = n1 + n2;
int sub = n1 - n2;
Console.WriteLine("soma " + soma);
Console.WriteLine("subutraçao " + sub); 