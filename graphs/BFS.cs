using System;
using System.Collections.Generic;

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

        static void initializeGraph(){
            g = new AdjacencyList(nodes);
            g.agregaVertice(0,3,12);
            g.agregaVertice(0,1,9);
            g.agregaVertice(0,2,8);
            g.agregaVertice(0,4,25);
            g.agregaVertice(1,0,8);
            g.agregaVertice(1,5,21);
            g.agregaVertice(1,6,6);
            g.agregaVertice(2,0,10);
            g.agregaVertice(2,3,9);
            g.agregaVertice(2,4,10);
            g.agregaVertice(2,5,14);
            g.agregaVertice(2,6,6);
            g.agregaVertice(2,0,10);
            g.agregaVertice(3,0,15);
            g.agregaVertice(3,2,8);
            g.agregaVertice(3,6,18);
            g.agregaVertice(3,5,16);
            g.agregaVertice(3,4,7);
            g.agregaVertice(4,0,27);
            g.agregaVertice(4,2,11);
            g.agregaVertice(4,3,5);
            g.agregaVertice(4,5,8);
            g.agregaVertice(5,1,23);
            g.agregaVertice(5,2,13);
            g.agregaVertice(5,3,14);
            g.agregaVertice(5,4,8);
            g.agregaVertice(5,6,4);
            g.agregaVertice(6,1,8);
            g.agregaVertice(6,2,7);
            g.agregaVertice(6,3,15);
            g.agregaVertice(6,5,8);
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
            int? val = prev[0];
            for(int? i = eN; i is int; i = prev[i.Value]){
                Console.WriteLine($"Nodo visitado: {i.Value}");
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
            reconstructPath(startNode,endNode);
        }
        public static void Init(){
            nodes = 7;
            initializeGraph();
            exploration(0,5);
        }
    }
}