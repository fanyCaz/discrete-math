using System;
using System.Collections.Generic;
using System.Linq;

namespace graphs{
    class BFS{
        static int nodes = 0;   //number of nodes
        static AdjacencyList g;
        static bool[] visited;
        static int?[] prev;     // with int? now it can contains null's 
        static void initializeArrays(int nodes){
            visited = new bool[nodes];
            prev = new int?[nodes];
            for(int i = 0; i < nodes; i++){
                visited[i] = false;
                prev[i] = null;
            }
        }
        
        public static int?[] solve(int startNode){
            Queue<int> q = new Queue<int>();
            q.Enqueue(startNode);
            Console.WriteLine($"Cantidad de nodos : {nodes}");
            initializeArrays(nodes);
            visited[startNode] = true;
            while(q.Count > 0){
                int node = q.Dequeue();
                var vecinos = g[node];
                foreach(Tuple<int,int> i in vecinos){
                    if(!visited[i.Item1]){
                        Console.WriteLine($"Nodo visitado : {i.Item1}");
                        q.Enqueue(i.Item1);
                        visited[i.Item1] = true;
                        prev[i.Item1] = node;
                    }
                }
            }
            return prev;
        }

        public static List<int> reconstructPath(int sN, int eN){
            List<int> path = new List<int>();

            for(int? i = eN; i is int; i = prev[i.Value]){
                path.Add(i.Value);
            }
            path.Reverse();

            if(path[0] == sN){                
                return path;
            }
            return new List<int>();
        }

        public static void exploration(int startNode, int endNode){
            var prev = solve(startNode);
            var path = reconstructPath(startNode,endNode);
            foreach(var i in path){
                Console.WriteLine($"Nodo visitado: {i}");
            }
        }
        public static void Init(){
            nodes = 8;
            g = Program.initializeDAG(8);
            exploration(3,7);
        }
    }
}