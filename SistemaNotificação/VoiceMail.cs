using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaNotificacao
{
    public class VoiceMail
   {
       public void Enviar(string CodCliente, string Mensagem)
       {
           // Simula gravação de um VoiceMail
           Console.WriteLine("Enviando VoiceMail para o cliente {0}", CodCliente);
           Console.WriteLine("VoiceMail: {0}", Mensagem);
       }
   }
}