using System;
using System.Collections.Generic;
using System.Text;
namespace SistemaNotificacao
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("*** Sistema de notificação de clientes***");
           Console.WriteLine("Informe código do cliente:");
           var CodCliente = Console.ReadLine();
           Console.WriteLine("Informe mensagem a ser enviada:");
           var Mensagem = Console.ReadLine();
           // Simula envio de um email
           Console.WriteLine("Enviando EMAIL para o cliente {0}",CodCliente);
           Console.WriteLine("EMAIL: {0}",Mensagem);
           Console.ReadLine();
       }
   }
}