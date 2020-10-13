using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace graphs
{
    class Viajero{
        static AdjacencyList g;
        static AdjencyMatrix matrix;
        static int costo = 0;
        static bool[] visitados;
        static int?[] path;
        static void initializeArrays(int n){
            visitados = new bool[n];
            path = new int?[n];
            for(int i =0; i < n;i++){
                visitados[i] = false;
                path[i] = null;
            }
        }
        /*Función que busca el camino más corto en un grafo
        /* basándose en los pesos de cada nodo al que visita*/
        static List<Tuple<int,int>> camino = new List<Tuple<int, int>>();
        static void greedySearch(int nI,int nF){
            if(nI == nF){
                Console.WriteLine("No puedes visitarte a ti mismo");
                return;
            }
            int at = nI,costoMinimo = int.MaxValue;
            //Toma los vecinos de ese nodo
            var vecinos = g[at];
            Tuple<int,int> cm = new Tuple<int, int>(0,0);
            foreach(var i in vecinos){
                Console.WriteLine($" nodo : {i.Item1} costo: {i.Item2} visit? {visitados[i.Item1]}");
                //verifica si no se ha visitado ese nodo
                if(!visitados[i.Item1]){
                    //Si encuentra el valor primero, se detiene el programa y se agrega al camino
                    if(i.Item1 == nF){
                        camino.Add(new Tuple<int, int>(i.Item1,i.Item2));
                        return;
                    }
                    //marca el nodo como visitado
                    visitados[at] = true;
                    //verifica el costo menor
                    if(i.Item2 < costoMinimo){
                        cm = new Tuple<int, int>(i.Item1,i.Item2);
                    }
                }
            }
            Console.WriteLine($"nodo {cm.Item1} costo {cm.Item2}");
            //se agrega al camino el nodo con el menor costo
            camino.Add(cm);
            at = camino.Last().Item1;
            greedySearch(at,nF);
        }

        static void tsp(int startNode){
            int N = matrix.Longitud();
        }

        //Saleman
        public static void InitSalesman(){
            matrix = Program.matrizEjemplo();
            tsp(0);
            //usa un greedy algorithm
        }

        //Busca el camino más corto entre dos nodos
        public static void Init(){
            g = Program.initializeDAG();
            initializeArrays(8);
            greedySearch(0,7);
            costo = 0;
            Console.WriteLine($"Recorrido");
            foreach(var i in camino){
                Console.WriteLine($"nodo : {i.Item1} peso: {i.Item2}");
                costo += i.Item2;
            }
            Console.WriteLine($"Costo Final {costo}");
        }
    }
}
