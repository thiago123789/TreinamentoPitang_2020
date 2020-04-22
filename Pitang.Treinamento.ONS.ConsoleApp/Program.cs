using System;

namespace Pitang.Treinamento.ONS.ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var message = new Message()
            {
                MessageText = "Eu sou uma mensagem"
            };

            var messageText = "Eu sou uma mensage";

            var messageStatus = 1;

            ClasseMae valorGenerico = new ClasseFilhaB()
            {
                Idade = 10  
            };

            var classeFilhaA = valorGenerico as ClasseFilhaA;
            var nome = classeFilhaA.NomeCachorro;

            LacoHorrivel(messageText);

            var messageStatusOk = StatusMessageEnum.VisivelParaDestinatario;

            var statusEntrega = DeliveryStatusEnum.SaiuParaEntrega;

            message.MessageText = messageText;

            var isEqual = 10 == 10;

            Console.WriteLine("Hello World!");

            /*
            foreach (var item in ListaDeInterfacesSingleton)
            {
                services.AddSingleton<item, procurarImplementacao(item) > ();
            }

            foreach (var item in ListaDeInterfacesScoped)
            {
                services.AddScoped<item, procurarImp,>
            }
            */


        }


        
        private static void LacoHorrivel(string messageText)
        {
            /*
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    var mudarText = messageText.Substring(2);
                    //
                    //
                    //
                    //
                    //
                    //
                    //
                    //
                    //
                    //
                    //
                }
            }
            */
        }
        
    }

    public enum PermissionEnum
    {
        Admin,
        Guest
    }

    public enum DeliveryStatusEnum
    {
        SaiuParaEntrega = 1
    }

    public enum StatusMessageEnum
    {
        VisivelParaTodos,
        VisivelParaDestinatario
    }

    public class ClasseMae
    {
        public int Idade { get; set; }
    }

    public class ClasseFilhaA : ClasseMae
    {
        public string NomeCachorro { get; set; }
    }

    public class ClasseFilhaB : ClasseMae
    {

    }

    public interface SingletonLifeCycle
    {

    }

    public interface ScopedLifeCycle
    {

    }

   

    public class Message
    {
        /*
        private string message;

        public string getMessage()
        {
            return this.message;
        }

        public void setMessage(string message)
        {
            this.message = message;
        }
        */

        private string message;

        public PermissionEnum Permission { get; set; }

        public bool IsAdmin
        {
            get
            {
                return this.Permission == PermissionEnum.Admin;
            }
        }

        public string MessageText
        {
            get
            {
                return message;
            }
            set
            {
                this.message = value;
            }
        }

        public Message()
        {
            this.MessageText = "";
        }
    }
}
