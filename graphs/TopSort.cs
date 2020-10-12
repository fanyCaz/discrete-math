using System;
using System.Collections.Generic;

namespace graphs{
    class TopSort{
        static AdjacencyList g;
       
        static bool[] initializeVisited(int n){
            bool[] visited = new bool[n];
            for(int i = 0; i< n; i++){
                visited[i] = false;
            }
            return visited;
        }

        static int[] initializeOrderint(int n){
            int[] ordering = new int[n];
            for(int i = 0; i< n; i++){
                ordering[i] = 0;
            }
            return ordering;
        }
        static int dfsMethod(int i,int at, bool[] visited, int[] ordering, AdjacencyList graph){
            visited[at] = true;
            Console.WriteLine($"{visited[at]}");
            var vecinos = graph[at];
            
            foreach(Tuple<int,int> j in vecinos){
                
                if(!visited[j.Item1]){
                    Console.WriteLine($"Nodo vecino {j.Item1}");
                    return dfsMethod(i,j.Item1, visited, ordering, graph);
                }
            }
            ordering[i] = at;
            return i-1;
        }
        static int[] solve(){
            int numNodos = 8;
            g = Program.initializeDAG();
             bool[] visited = initializeVisited(numNodos);
             int[] ordering = initializeOrderint(numNodos);
            int i = numNodos -1;    //track the position of the next element
            Console.WriteLine($"Valor i : {i}");
            for(int at = 0; at < numNodos; at++){
                if(!visited[at]){
                    Console.WriteLine($"NOdo visitado : {visited[at]}");
                    i = dfsMethod(i,at,visited,ordering,g);
                    Console.WriteLine($"Result de dfs : {i}");
                }
            }
            Console.WriteLine($"--------------");
            foreach(int j in ordering){
                Console.WriteLine($"Nodo Ordenado : {j}");
            }
            return ordering;
        }

        public static void Init(){
            int[] res = solve();
        }
    }
}