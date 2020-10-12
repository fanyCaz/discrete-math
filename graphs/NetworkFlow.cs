using System;
using System.Collections.Generic;
using System.Linq;

namespace graphs
{
    //Edmunds-Karp
    class NetworkFlow{
        static AdjacencyList g;
        static int nodes;
        static bool[] initVisited(){
            bool[] visited = new bool[nodes];
            for(int i = 0; i < nodes;i++){
                visited[i] = false;
            }
            return visited;
        }

        static int?[] initPath(){
            int?[] path= new int?[nodes];
            for(int i = 0; i < nodes;i++){
                path[i] = null;
            }
            return path;
        }
        static void busqueda(int startNode,int finalNode){
            bool[] visited = initVisited();
            int?[] pred = initPath();
            Queue<int> q = new Queue<int>();
            q.Enqueue(startNode);
            visited[startNode] = true;
            while(q.Count > 0){
                int node = q.Dequeue();
                var vecinos = g[node];
                foreach(Tuple<int,int> i in vecinos){
                    if(pred[i.Item1] == null && i.Item1 != startNode){
                        Console.WriteLine($"Nodo visitado : {i.Item1}");
                        q.Enqueue(i.Item1);
                        visited[i.Item1] = true;
                        pred[i.Item1] = node;
                    }
                }
                Console.WriteLine($"--------");
            }

            foreach(int? i in pred){
                Console.WriteLine($"recorrido : {i}");
            }
            /* if(pred[finalNode] != null){
                int df = int.MaxValue;
                for(int? i = pred[finalNode]; i.Value != null; i = pred[i.Value]){
                    df = 
                }
            } */
            
        }
        static void solve(){
            nodes = 8;
            //g = Program.initializeCyclicGraph(nodes);
            int nodoInicial = 7,nodoFinal = 4;
            int at = nodoInicial;
            busqueda(nodoInicial,nodoFinal);
            
            
        }
        public static void Init(){
            g = Program.initializeCyclicGraph(8);
            solve();
        }
    }
}