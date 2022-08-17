using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaNotificacao
{
    public class Email
   {
       public void Enviar(string CodCliente, string Mensagem)
       {
           // Simula envio de um email
           Console.WriteLine("Enviando EMAIL para o cliente {0}", CodCliente);
           Console.WriteLine("EMAIL: {0}", Mensagem);
       }
   }
}