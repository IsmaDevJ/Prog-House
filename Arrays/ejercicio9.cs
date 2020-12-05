using System;
using System.Text;
using System.Xml.Serialization;




namespace ejercicio1_toma2


{
    class Program
    {
        
       
        public static void Menu()
        {

            Console.WriteLine("-----Menú-----");
            Console.WriteLine();
            Console.WriteLine("1. Introducir contraseña");
            Console.WriteLine("2. Pedir contraseña");
            Console.WriteLine("3. Salir del programa");
            String menu = Console.ReadLine();


            switch(menu)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:

                    break;
            }


            
        }


        public static void IntroducirContraseña()
        {
            Console.Clear();

            //Falta que cambien los carácteres a *
            //Guardarla en un array
            //Y validar la contraseña


            Console.WriteLine("Entrada: ");
            Console.WriteLine("Contraseña: ");
            Console.ReadLine();
            Console.WriteLine("Comprobar Contraseña: ");
            Console.ReadLine();


        }

        public static void PedirContraseña()
        {

        }

        public static void SalirPrograma()
        {

        }

      



        static void Main(string[] args)
        {
            




        }


    }
}
