using amem.models;


string opcao;
bool exibirMenu = true;


while(exibirMenu)

{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

     opcao = Console.ReadLine();

    
    switch (opcao)


    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;

    }
}
Console.WriteLine("O programa se encerrou");

























// ----------------------------------------------------------------------------------------


// exercicio 1
// using System.IO;
// using System.Linq;

// class amemEx{

//     static void Main(string[] args)
//     {
//         int qt = int.Parse(Console.ReadLine());
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (                 )
//         {

//             string a = v[0];
//             string b = v[1];

//             if (0 > 1000)                  
//                 Console.WriteLine("nao encaixa");
//             else if (0 <= 1000 || 1 <= 1000)                                )
//                 Console.WriteLine("encaixa");
//             else
//                 Console.WriteLine("nao encaixa");

//         }

//     }

// }


// ---------------------------------------------------------------------------


// while (true)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;


//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;



//     }
// }
















// -----------------------------------------------------------------------


/*
sumary = habilitar vscode preferences>editor:format on type> controls on >tic< /// 

///> sumary comentario para descrever a classe
*/
//ou  métodos /// <summary>
/// 
/// </summary>
/// <param name="x">Um numero para somar </param> 
/// <param name="y">Um numero para somar </param>

//comentar somente genericos/necessários



// lista array for e foreach 

// List<string> listaString = new List<string>();

// Vantagem da lista: adicionar e remover sem precisar usar comando Resize & automaticamente redimenciona o tamanho da lista.

// List<string> listaString = new List<string>();

//  listaString.Add("SP");
//  listaString.Add("BA");
//  listaString.Add("MG");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

// listaString.Add("TO");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

// listaString.Remove("BA");

// para obter o tamanho de um array e a quantidade de elementos em uma lista, respectivamente
// Lengh e Count


// ---------------------------------------------------------------


// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");

// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)

// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// // foreach

// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//     contadorForeach++;
// }





















// -----------------------------------------------------------------------------
// copiando um array:  



//  int[] arrayInteiros = new int[4];

//  arrayInteiros[0] = 72;
//  arrayInteiros[1] = 74;
//  arrayInteiros[2] = 85;
//  arrayInteiros[3] = 15;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//  for(int contador = 0; contador < arrayInteiros.Length; contador++)
//  {
//      Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
//  }


// -----------------------------------------------------------------

// foreach acessar a uma lista sem depender de um contador 

// aumentar a capacidade de um array:
// Array.Resize(Ref arrayInteiros, arrayInteiros.Lengh * 2); <dobrar capacidade



// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 74;
// arrayInteiros[2] = 85;

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }




// foreach ----------- Abaixo:

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     contadorForeach++;
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
// }





// array0

// Array: uma variável que pode armazenar diversos valores

// índice: posição de um determinado valor de um array, sempre começando com 0 

// -------------------------------------------------------------------------------


// adicionar extensão: vs code solution.
// ->aba solution add empy file -> name 
// >adicionar projeto existente 



// arquivos csharp

// .csproj: build, debug e versão.
//     .sln(solution): contém informações que carregam um agrupamento de projetos./ordem 

// ---------------------------------------------------------

// do while
// executaOcodigo antes da verificação
// terminal só vai parar após usar um numero


// int soma = 0, numero = 0; = variavel de mesmo atributo pode usar na mesma linha.

// do
// {
//     Console.WriteLine("Digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());  Convert.ToInt32 para converter para string

// soma += numero; = soma + numero, e o valor do numero entra na variavel soma. 0 += 5 = soma = 5. 5 += 10 = soma = 15.


// }while(numero != 0);
//     Console.WriteLine($"Total da soma dos números digitados é {soma}"); = misturar variavel com texto usa o $.






// --------------------------------------------------------


// Interrompendo execução


//  int numero =5;
//  int contador = 0;



// while (contador <= 10)
//  {
//     Console.WriteLine($"{contador + 1}º Execução: x {numero} = {numero * contador}");
//      contador++;

//      if (contador == 6)           observação: quando chegar ao 6 ele para. pode ser usado no for tambem.

//      break;
//  }




// -----------------------------------------------

// contador 01

// int numero =5;
// int contador = 0;



// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}º Execução: x {numero} = {numero * contador}"); 
//     contador++;
// }

// Observação: contador + 1 é para iniciar apartir do 1º
// while = enquanto for 






// -------------------------------------------------------------
// contador0


// int numero = 5;

// contador 3 blocos. no primeiro a declaração da variavel 
// segundo: a condição de parada.
// terceiro: e enquanto meu contador vai ser considerado, nesse caso foi incrementado em 1.

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }





// -----------------------------------------------------------------

// Calculadora calc = new Calculadora();

// calculo 01
// Math.Round arredondar
// int numero = 10;


// numero ++;
// Console.WriteLine("incrementando o 10");
// Console.WriteLine(numero);


// // numero = numero + 1; = 11 ambos iguais a numero ++; = 11

// int numerodecremento = 20;
// numerodecremento --;
// Console.WriteLine(numerodecremento);
// Console.WriteLine("decrementando");

// calc.Raiz(9);

// ------------------------------------------



// Calculos 00
// calc.Somar(10, 30);
// calc.Subtrair(10, 50); = -40
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// calc.Potencia(3, 3);


// calc.Seno(30);   = Seno de 30° = 0,49999999999999994 usando o comando {Math.Round(seno, 4)} em que seno = variável e 4 digitos 
// calc.Seno(30);
// calc.Coseno(30);    
// calc.Tangente(30);




// --------------------------------------------------------------------


// Operador NOT 0

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }

// Obs: Se não choveu e nao esta tarde vou pedalar. 
// !inverte

// operador seguro tryparse aceita null


// int -2.147.483.648 ~ 2.147.483.647
// uint 2.147.483.648 x2 
// long = - 9.223.372.036.854.775.808 ~ 9.223.372.036.854.775.807

// double = coordenadas 
// float menos preciso
// decimal = monetario / preciso

// Toint32 = bilhoes
// Toint64 = trilhoes
// ----------------------------------------
// cast = casting

// int a = Convert.Toint32("5"); = virou string

// int a = int.Parse("5"); = transformou string em numero inteiro


// int a = Convert.Toint32(null); = 0
// já o
// int a = int.Parse(null); = error 
// -------------------------------------------
// String

// int inteiro = 5;
// string a = inteiro.ToString(); = 5; ToString transforma qualquer tipo em string
// -------------------------------------------
// Cast implícito
// {
// int a = 5;
// double b = a; = 5 ou 

// int a = 5; int < long
// long b = a;
// }já
// long > int 
// long a = long.MaxValue; 
// int b - Convert.Toint32(a); = Error. 
// Para dar certo ->
// int a = int.MaxValue;
// long b = a; = exceção da certo.

// ------------------------------------------------ Tryparse
// ex: string a = "15";
// int b = Convert.ToInt32(a); = converteu para string. = 15 
// tryparse
// ex: string a = "15-";
// int b = Convert.ToInt32(a)

// Console.WriteLine(b); 


// Console.WriteLine(a);

// --------------------------------------------------------------------

// Operador And &&
// No caso do && Se uma falhar as 2 falham
// validação

// bool possuiPresencaMinima = true;
// double media = 7.5;
// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// Obs: No caso do && Se uma falhar as 2 falham

// https://drive.google.com/file/d/1ofWoOF1kjrWzNSSJZkohvGkx66ENiFbI/view

// ----------------------------------------------------------------

// OPERADOR OR- PIPE 0

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("entrada não liberada!");
// }

// Obs: false / false = entrada não liberada
// true/false liberada.

// || = Pipe ou/OR 

// ---------------------------------------------------------------



// switch 3 REAL 
// Alternativa para muitos ifs 


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();



// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break; -> parar sua execução. sai do switch
//         default:
//         Console.WriteLine("não é uma vogal");
//         break;
// }





// switch CASO 2

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// if (letra == "a" ||

// letra == "e" ||

// letra == "i" ||

// letra == "o" ||

// letra == "u")
// {
//     Console.WriteLine("é uma vogal");
// }
// else
// {
//     Console.WriteLine("não é uma vogal");
// }


// || PIPE SINAL DE VERIFICAÇÃO



// EXEMPLOS SWITCH CASE1

// Console.WriteLine("Digite uma letra.");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "u")
// {
//    Console.WriteLine("vogal"); 
// }
// else
// {
//     Console.WriteLine("não é uma vogal");
// }

// R = "Digite uma letra" -> a = vogal.
// -------------------------------------------------------------------


// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"é possivel realizar a venda? : {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda)
// {
// Console.WriteLine("Venda realizada");
// }
// else
// {

// }

// DEPURAÇÃO -> Clica na bola ao lado esquerdo da linha. f5, e depois f5.  f10 avan~ça

// if (quantidadeCompra == 0); = comprar se o valor da direita '0' é = ao valor da esqueda 'quantidadeCompra'










// int a = 10;
// int b = 20;
// int c = a + b;
// c += 5;
// // c += 5; === c = c + 5;
// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Denis";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();

