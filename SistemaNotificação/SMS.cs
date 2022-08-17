using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaNotificacao
{
   public class SMS
   {
       public void Enviar(string CodCliente, string Mensagem)
       {
           // Simula envio de um SMS
           Console.WriteLine("Enviando SMS para o cliente {0}", CodCliente);
           Console.WriteLine("SMS: {0}", Mensagem);
       }
   }
}