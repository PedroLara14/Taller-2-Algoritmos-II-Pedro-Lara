using System;

namespace Taller_2_Algoritmos_Pedro_Lara
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Equipos = new String[17];
            int[] Puntos = new int[17];
            int[] P_Jugados = new int[17];
            int[] P_Ganados = new int[17];
            int[] P_Empatados = new int[17];
            int[] P_Perdidos = new int[17];

            Equipos[0] = "La Tebaida F. C.";
            Equipos[1] = "Valledupar";
            Equipos[2] = "Universitario de Popayán";
            Equipos[3] = "Unión Magdalena";
            Equipos[4] = "Real Santander";
            Equipos[5] = "Real Cartagena";
            Equipos[6] = "Quindío";
            Equipos[7] = "Pereira";
            Equipos[8] = "Orsomarso SC";
            Equipos[9] = "Llaneros FC";
            Equipos[10] = "Leones";
            Equipos[11] = "Fortaleza C.E.I.F";
            Equipos[12] = "Cúcuta";
            Equipos[13] = "Boyacá Chicó";
            Equipos[14] = "Bogotá FC";
            Equipos[15] = "Barranquilla F.C.";
            Equipos[16] = "Atlético FC";

            P_Jugados[0] = 10;
            P_Jugados[1] = 12;
            P_Jugados[2] = 11;
            P_Jugados[3] = 11;
            P_Jugados[4] = 10;
            P_Jugados[5] = 11;
            P_Jugados[6] = 10;
            P_Jugados[7] = 11;
            P_Jugados[8] = 11;
            P_Jugados[9] = 11;
            P_Jugados[10] = 11;
            P_Jugados[11] = 11;
            P_Jugados[12] = 11;
            P_Jugados[13] = 11;
            P_Jugados[14] = 11;
            P_Jugados[15] = 11;
            P_Jugados[16] = 10;

            P_Ganados[0] = 5;
            P_Ganados[1] = 4;
            P_Ganados[2] = 2;
            P_Ganados[3] = 4;
            P_Ganados[4] = 6;
            P_Ganados[5] = 1;
            P_Ganados[6] = 5;
            P_Ganados[7] = 7;
            P_Ganados[8] = 5;
            P_Ganados[9] = 6;
            P_Ganados[10] = 5;
            P_Ganados[11] = 4;
            P_Ganados[12] = 3;
            P_Ganados[13] = 4;
            P_Ganados[14] = 2;
            P_Ganados[15] = 5;
            P_Ganados[16] = 2;

            Puntos[0] = 17;
            Puntos[1] = 13;
            Puntos[2] = 10;
            Puntos[3] = 14;
            Puntos[4] = 20;
            Puntos[5] = 6;
            Puntos[6] = 17;
            Puntos[7] = 24;
            Puntos[8] = 18;
            Puntos[9] = 20;
            Puntos[10] = 16;
            Puntos[11] = 16;
            Puntos[12] = 14;
            Puntos[13] = 16;
            Puntos[14] = 8;
            Puntos[15] = 17;
            Puntos[16] = 10;

            for (int i = 0; i < Equipos.Length; i++)
            {
                P_Empatados[i] = Puntos[i] - (P_Ganados[i] * 3);
                P_Perdidos[i] = P_Jugados[i] - (P_Ganados[i] + P_Empatados[i]);
            }

            int aux;
            string auxNombreProducto;
            for (int z = 1; z < Puntos.Length; z++)
            {
                for (int v = 0; v < (Puntos.Length - z); v++)
                {
                    if (Puntos[v] < Puntos[v + 1])
                    {
                        aux = Puntos[v];
                        Puntos[v] = Puntos[v + 1];
                        Puntos[v + 1] = aux;

                        aux = P_Jugados[v];
                        P_Jugados[v] = P_Jugados[v + 1];
                        P_Jugados[v + 1] = aux;

                        aux = P_Ganados[v];
                        P_Ganados[v] = P_Ganados[v + 1];
                        P_Ganados[v + 1] = aux;

                        aux = P_Empatados[v];
                        P_Empatados[v] = P_Empatados[v + 1];
                        P_Empatados[v + 1] = aux;

                        aux = P_Perdidos[v];
                        P_Perdidos[v] = P_Perdidos[v + 1];
                        P_Perdidos[v + 1] = aux;

                        auxNombreProducto = Equipos[v];
                        Equipos[v] = Equipos[v + 1];
                        Equipos[v + 1] = auxNombreProducto;


                    }
                }
            }

            Console.WriteLine("Equipo    Partidos perdidos   Partidos empatados    Partidos ganados     Puntos");
            for (int i = 0; i < Equipos.Length; i++)
            {
                Console.WriteLine(Equipos[i]
                                    + "     "
                                    + P_Perdidos[i]
                                    + "     "
                                    + P_Empatados[i]
                                    + "     "
                                    + P_Ganados[i]
                                    + "      "
                                    + Puntos[i]);

            }

            for (int z = 1; z < P_Empatados.Length; z++)
            {
                for (int v = 0; v < (P_Empatados.Length - z); v++)
                {
                    if (P_Empatados[v] < P_Empatados[v + 1])
                    {
                        aux = Puntos[v];
                        Puntos[v] = Puntos[v + 1];
                        Puntos[v + 1] = aux;

                        aux = P_Jugados[v];
                        P_Jugados[v] = P_Jugados[v + 1];
                        P_Jugados[v + 1] = aux;

                        aux = P_Ganados[v];
                        P_Ganados[v] = P_Ganados[v + 1];
                        P_Ganados[v + 1] = aux;

                        aux = P_Empatados[v];
                        P_Empatados[v] = P_Empatados[v + 1];
                        P_Empatados[v + 1] = aux;

                        aux = P_Perdidos[v];
                        P_Perdidos[v] = P_Perdidos[v + 1];
                        P_Perdidos[v + 1] = aux;

                        auxNombreProducto = Equipos[v];
                        Equipos[v] = Equipos[v + 1];
                        Equipos[v + 1] = auxNombreProducto;


                    }
                }
            }

            Console.WriteLine("     ");

            Console.WriteLine("El equipo con mas partidos empatados es: ");
            Console.WriteLine(Equipos[0]
                                    + "     "
                                    + P_Empatados[0]);


            Console.WriteLine("     ");

            for (int z = 1; z < P_Perdidos.Length; z++)
            {
                for (int v = 0; v < (P_Perdidos.Length - z); v++)
                {
                    if (P_Perdidos[v] < P_Perdidos[v + 1])
                    {
                        aux = Puntos[v];
                        Puntos[v] = Puntos[v + 1];
                        Puntos[v + 1] = aux;

                        aux = P_Jugados[v];
                        P_Jugados[v] = P_Jugados[v + 1];
                        P_Jugados[v + 1] = aux;

                        aux = P_Ganados[v];
                        P_Ganados[v] = P_Ganados[v + 1];
                        P_Ganados[v + 1] = aux;

                        aux = P_Empatados[v];
                        P_Empatados[v] = P_Empatados[v + 1];
                        P_Empatados[v + 1] = aux;

                        aux = P_Perdidos[v];
                        P_Perdidos[v] = P_Perdidos[v + 1];
                        P_Perdidos[v + 1] = aux;

                        auxNombreProducto = Equipos[v];
                        Equipos[v] = Equipos[v + 1];
                        Equipos[v + 1] = auxNombreProducto;


                    }
                }
            }

            Console.WriteLine("Equipo    Partidos perdidos   Partidos empatados    Partidos ganados     Puntos");
            for (int i = 0; i < Equipos.Length; i++)
            {
                Console.WriteLine(Equipos[i]
                                    + "     "
                                    + P_Perdidos[i]
                                    + "     "
                                    + P_Empatados[i]
                                    + "     "
                                    + P_Ganados[i]
                                    + "      "
                                    + Puntos[i]);


            }
        }
    }





}
