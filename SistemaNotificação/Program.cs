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

            Console.WriteLine("Digite opção de envio 1-EMAIL, 2-SMS ou 3-Voice:");
            var modoEnvio = Console.ReadLine();
            if (modoEnvio == "1")
            {
                (new Email()).Enviar(CodCliente, Mensagem);
            }
            else
                if (modoEnvio == "2")
            {
                (new SMS()).Enviar(CodCliente, Mensagem);
            }
            else
                 if (modoEnvio == "3")
            {
                (new VoiceMail()).Enviar(CodCliente, Mensagem);
            }
            Console.ReadLine();

        }
    }
}