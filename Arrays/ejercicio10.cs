using System;
using System.Text;
using System.Xml.Serialization;




namespace ejercicio1_toma2


{
    class Program
    {

        public static void IntroduceNota()
        {
            int alumnos = 25;
            int[] notasAlumnos = new int[25];
            int validacion = 0;

            Console.WriteLine("Inserte las notas: ");
            for (int i = 0; i < alumnos && validacion >= 0 && validacion <= 10; i++)
            {

                validacion = int.Parse(Console.ReadLine()); ;

                if (validacion >= 0 && validacion <= 10)
                {
                    notasAlumnos[i] = validacion;
                }


                Console.WriteLine(notasAlumnos[i]);


            }


            





        }


        static void Main(string[] args)
        {

            IntroduceNota();


        }


    }
}
