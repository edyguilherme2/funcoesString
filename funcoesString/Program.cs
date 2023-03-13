using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EDY GUILHERME MARINI DIAS
            //CJ3002411 

            //FUNÇÕES DE UMA STRING

            string texto = "Esse-texto-é-um-exemplo!";

            //A Função Length apenas retorna um INT com o tamanho da string, no exemplo abaixo o retorno é o tamanho 24
            int tamanho = texto.Length;

            //A Funcao ToCharArray(), Essa funcao retorna o conteudo de uma string em uma matriz de caracteres unicode, retorna o codigo do caractere de cada indice e o caractere, cada uma em uma posição do array
            //A função aceita sobrecarga de indice inicial até um indice final, ou tamanho total.
            //Exemplo, retorna os caracteres da posição 0 até o tamanho da string;
            char[] array = texto.ToCharArray(0,texto.Length);


            //A Função Trim() aceita parametros array char [], o valor que existir dentro de cada posicao char do array do parametro, será retirado do texto
            //Caso não passe nenhum parametro para esta função, o retorno será o próprio texto
            char[] espaco = new char[' '];
            
            //Trim() sem parameto retorna a string normal sem alteração
            string retorna_texto = texto.Trim();

            //Trim() com parametros de array char, vai subistituir cada posicao do texto igual a posicao do char e vai retornar nada, pois o array do parametro é exatamente os mesmos valores do texto
            string removeu_tudo = texto.Trim(array);

            //A Função SubString() Retorna uma parte de um texto, pode se usar 1 parametro, ou dois parametros um indice inicial e um indice final.
            //Retorne todo o texto da posicao 5 até o final
            string final = texto.Substring(5);

            //Retorne o texto da posição 0 até a posição 5
            string sub = texto.Substring(0, 10); //Esse texto

            //A Função Split() retorna um array com a divisão do texto, pelo parametro informado, por exemplo, divide um texto em partes quando encontrar o caractere '-' 
            // Passando como parametro Split('-');
            //Retorna um array com string ou caracteres separados pelo paramentro de entrada '-'
            //Podemos usar outros parametros como a quantidade maxima que deseja retornar
            string[] split = texto.Split('-');

            //A Funcão Contains() retorna verdadeiro ou falso de acordo com o parametro que foi passado dentro da funcao, dizendo se a string contem o texto informado ou nao
            bool tem_ou_nao = texto.Contains("texto");


            //A Função EndSWith() verifica se a string termina com o parametro informado, por exemplo, verifica se a string termina com . ou com ! ou se termina com "fim";
            //Confirmando se esse texto termina com ! no final;
            var end = texto.EndsWith("!");

            //A Função Equals() verifica se um texto é exatamente igual ao parametro passado, irá retorna um booleano true ou false
            bool igual = texto.Equals("é");

            //A Função GetType() retorna o tipo do objeto ou variével, no caso, retornada se é uma string, int, char, class, array, bollean bool ou outro tipo de dado
            object tipo = tem_ou_nao.GetType(); //Aqui retorna um bool ou bollean


            //A Função IndexOf() verifica em uma string se existe um caractere exspecifico e retorna a posição do primeiro caractere encontrado. pode ser usado outros parametros
            //como char desejado, posicao inicial e tamanho máximo do indice
            var indice = texto.IndexOf('t',0);

            //A Função Insert() insere um conteudo em uma string a partir da posição inicial que deseja;
            //Exemplo inserir o texto Esse texto é meu apartir do indice 0
            string lista = " ";
            lista.Insert(0,"Esse texto é meu!");

            //A Função LastIndexOf() percorre uma string verificando se existe o parametro informado e retorna a ultima posição que foi encontrado esse parametro informado
            var indice_last = texto.LastIndexOf('!');

            //A Função Remove() retorna um pedaço da string que desejar informando um indice inicial e um indice final
            string removed = texto.Remove(0, 3);

            //A Função Replace() Subistitui/troca um caractere ou string por outro informado por parametro
            string trocou = texto.Replace("exemplo", "teste");

            //StartsWith()

            //A Função ToLower() transforma uma string inteira para um texto com caracteres minúsculos

            //A Função ToUpper() transforma uma string inteira para um texto com caracteres maiusculos

            //A Funcção ToString() transforma qualquer tipo de dado ou objeto em uma string


            Console.ReadKey();


        }
    }
}
