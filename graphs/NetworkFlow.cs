using System;
using System.Collections.Generic;
using System.Linq;

namespace graphs
{
    //Edmunds-Karp
    class NetworkFlow{
        static AdjacencyList g;
        static void solve(){
            int numNodos = 8;
            g = Program.initializeCyclicGraph(numNodos);
            int nodoInicial = 7,nodoFinal = 4;
            int at = nodoInicial;
            int?[] camino = new int?[] {null,null,null,null,null,null,null,null};
            int minCosto = int.MaxValue;
            Dictionary<int,int> visitar = new Dictionary<int, int>();
            while(at != nodoFinal){
                var vecinos  = g[at];
                var masPesado = vecinos.Max();
                foreach (Tuple<int,int> i in vecinos)
                {
                    if(i != masPesado){
                        visitar.Add(i.Item1,i.Item2);
                    }
                    
                }
                foreach(int i in visitar.Keys){
                    Console.WriteLine(i);
                }
                at = nodoFinal;
            }
        }
        public static void Init(){
            solve();
        }
    }
}