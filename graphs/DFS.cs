using System;
using System.Collections.Generic;

namespace graphs
{
    class DFS{
        //number of nodes in graph
        static int n = 0;
        static int vertices = 0,count = 0;
        static AdjacencyList g;
        static List<bool> visited = new List<bool>();
        static List<int> components = new List<int>();

        public static Dictionary<int,List<int>> findComponents(){
            
            for(int i = 0; i < n; i++){
            Console.WriteLine($"visited in {visited[i]} Nodo : {i} ");
                if(!visited[i]){
                    count++;
                    exploration(i);
                }
            }
            Dictionary<int,List<int>> dict = new Dictionary<int, List<int>>();
            dict.Add(count,components);
            return dict;
        }

        public static void exploration(int at){
            if(visited[at]){
              return;
            } 
            visited[at] = true;

            var vecinos = g[at];
            
            foreach(Tuple<int,int> i in vecinos){
                
                if(!visited[at]){
                    exploration(i.Item1);
                }
            }
        }
        public static void initializeValues(){
            
            Console.WriteLine("Ingresa los nodos");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa los vertices");
            vertices = int.Parse(Console.ReadLine());
            g = new AdjacencyList(n);
            //inicializa la lista de nodos visitados con falso
            for(int i= 0; i < n; i++){
                visited.Add(false);
            }
            g.mostrarListaAdyacencia();

            //inicializar la lista de adyacencia
            Console.WriteLine($"Usar valor default? (0/1)");
            var def = int.Parse(Console.ReadLine());
            if(def == 0){
                for(int j = 0; j < vertices; j++){

                    Console.WriteLine($"Ingresa el nodo {j}");
                    int nodo = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ingresa hacia donde va {nodo}");
                    int nodoHacia = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ingresa el peso");
                    int peso = int.Parse(Console.ReadLine());
                    g.agregaVertice(nodo,nodoHacia,peso);
                }
            }
            else{
                g.agregaVertice(0,1,8);
                g.agregaVertice(1,4,4);
                g.agregaVertice(4,0,0);
                g.agregaVertice(1,2,14);
                g.agregaVertice(2,3,13);
                g.agregaVertice(3,0,0);
                g.agregaVertice(2,0,0);
            }

            
        }
        static bool[] initVisitados(){
            bool[] visitados = new bool[n];
            for(int i = 0; i < n; i++){
                visitados[i] = false;
            }
            return visitados;
        }
        static List<int> nVisitados = new List<int>();
        //My approach, of how to solve it : look for a path
        static bool solve(AdjacencyList g, int nI, int nF,bool[] visitados){
            int at = nI;
            var vecinos = g[at];
            if(at == nF){
                Console.WriteLine($"Se cumple");
                return true;
            }
            foreach(var i in vecinos){
                if(!visitados[i.Item1]){
                    Console.WriteLine($"Vecino de {at} : {i.Item1}");
                    visitados[i.Item1] = true;
                    nVisitados.Add(i.Item1);
                    return solve(g,i.Item1,nF,visitados);
                }
            }
            return false;
        }
        public static void Init(){
            n = 8;
            bool[] visitados = initVisitados();
            AdjacencyList g =  Program.initializeDAG();
            int nodoInicial = 3, nodoFinal= 7;
            bool hasPath = solve(g,nodoInicial,nodoFinal,visitados);
            Console.WriteLine($"so has it? {hasPath}");
            foreach(int i in nVisitados){
                Console.WriteLine(i);
            }
        }
    }
}