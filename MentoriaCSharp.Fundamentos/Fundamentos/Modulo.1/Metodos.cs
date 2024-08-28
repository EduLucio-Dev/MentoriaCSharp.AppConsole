using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaCSharp.Fundamentos.Fundamentos.Modulo._1
{
    internal class Metodos
    {
        string cpf = ""; //Variavel global existe em toda extensão da classe.
        
        public string ExemploMetodoComRetorno()
        {
            string carregaCpf = "000.222.444.05"; // variavel local existe apenas enquanto o metodo é executado.
            
            return carregaCpf;
        }

        public void ExemploMetodoComParametros(string? variavel, int valor)
        {
            //Exemplo metodo com passagem de parametros
            cpf = ExemploMetodoComRetorno();
            Console.WriteLine($"{valor}, {variavel}, {cpf}");

        }

    }
}
