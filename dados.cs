using System;

namespace examen3
{
    class MainClass
    {
        /// <summary>
        /// Funcion que se encarga de generar numeros
        /// aleatorios de 2 al 12
        /// </summary>
        /// <returns> numAl = al numero aleatorio</returns>
        static int lanzarDados()
        {
            Random rand = new Random();
            int numAl = rand.Next(2, 13);
            return numAl;
            
        }
        public static void Main(string[] args)
        {

            int jugadas;
            int[] numAleatorios = new int[5];
            Random rand2 = new Random();
            int premio = 0;
            int cont = 0;
            int puntos = 0;
            bool play = true;

            do
            {
                Console.WriteLine("Ingresa el numero de jugadas permitidas: ");
                jugadas = Convert.ToInt32(Console.ReadLine());

                premio = rand2.Next(2, 13);

                for (int i = 0; i < numAleatorios.Length; i++)
                {
                    numAleatorios[i] = lanzarDados();

                }
                
                for(int j = 0; j<numAleatorios.Length; j++)
                {
                    if(numAleatorios[j] == premio) {

                        puntos++;
                    }
                    
                    
                }
               
                
                Console.WriteLine("Desea jugar de nuevo t/f: ");
                play = Convert.ToBoolean(Console.ReadLine());
                cont++;
                Console.WriteLine("La cantidad de puntos en la partida " + cont + " : " + puntos);

            } while (cont < jugadas && play != false);


        }
    }
}
