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

            Console.WriteLine("Digite opção de envio, 1-EMAIL ou 2-SMS, 3-Voice:");
            var modoEnvio = Console.ReadLine();
            if (modoEnvio == "1")
            {
                // Simula envio de um email
                Console.WriteLine("Enviando EMAIL para o cliente {0}", CodCliente);
                Console.WriteLine("EMAIL: {0}", Mensagem);
            }
            else
                if (modoEnvio == "2")
                {
                // Simula envio de um SMS
                      Console.WriteLine("Enviando SMS para o cliente {0}", CodCliente);
                      Console.WriteLine("SMS: {0}", Mensagem);
                }
            else
                 if (modoEnvio == "3")
                {
                // Simula gravação de um VoiceMail
                    Console.WriteLine("Enviando VoiceMail para o cliente {0}",CodCliente);
                    Console.WriteLine("VoiceMail: {0}", Mensagem);
                }
            Console.ReadLine();

        }
   }
}