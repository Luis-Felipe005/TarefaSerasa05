using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa
{
     class Program
    {
        static void Main(string[] args)
        {

            string ok;
            string endereco;
            string bairro;
            string cidade;
            string estado;
            string nome_cliente; 
            string sobrenome;
            int viagens, quantidade;
            double soma;
            
            
            

            Console.WriteLine("Olá!!! Somos da agência Cunha Turismo ");
            Console.WriteLine("Digite o seu nome");
            nome_cliente = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Olá, Sr.{nome_cliente}, vamos continuar seu cadastro... Por favor, digite um ok!");
            ok= Console.ReadLine();

            Console.WriteLine("Queremos saber mais um pouco sobre você. Nos fale seu endereço, por favor!");
            endereco = Console.ReadLine();

            Console.WriteLine("Seu bairro?");
            bairro = Console.ReadLine();

            Console.WriteLine("Sua cidade?");
            cidade = Console.ReadLine();

            Console.WriteLine("E agora por fim, seu estado?");
            estado = Console.ReadLine();

            Console.WriteLine($"O Sr.{sobrenome}, mora na cidade de {cidade} - {estado}, no endereço {endereco}, localizado no bairro {bairro}");

            Console.WriteLine($"Agora queremos saber quantas viagens o Sr.{nome_cliente} realizou ano passado?");
            viagens = (int)double.Parse(s: Console.ReadLine());

            Console.WriteLine("Você planejou quantas viagens para esse ano?");
            quantidade = (int)double.Parse(s: Console.ReadLine());

            soma = viagens + quantidade;


            Console.WriteLine($"Vemos aqui no sistema que o Sr.{nome_cliente} realizou no ano passado {viagens} viagens e no ano atual pretende viajar {quantidade} vezes, somando as viagens do ano anterior e o ano atual equivalem a {soma}");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Dessa forma, faltam {soma - 10 } para completar 10 viagens no total ");

            Console.WriteLine($"A sua média de viagens é de {24/soma}");



            Console.WriteLine($"No intervalo de meses de {12/quantidade}");





            Console.ReadKey();







        }
    }
}
