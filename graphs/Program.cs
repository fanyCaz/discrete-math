using System;

namespace graphs
{
    class Program
    {
        static AdjacencyList g;
        static void Main(string[] args)
        {
            NetworkFlow.Init();
        }

        public static AdjacencyList initializeCyclicGraph(int nodes){
            g = new AdjacencyList(nodes);
            g.agregaVertice(0,1,3);
            g.agregaVertice(0,2,5);
            g.agregaVertice(0,3,2);
            g.agregaVertice(0,7,10);
            g.agregaVertice(1,0,3);
            g.agregaVertice(1,2,5);
            g.agregaVertice(1,4,4);
            g.agregaVertice(1,6,6);
            g.agregaVertice(1,3,8);
            g.agregaVertice(1,7,6);
            g.agregaVertice(2,0,5);
            g.agregaVertice(2,1,5);
            g.agregaVertice(2,6,9);
            g.agregaVertice(2,4,1);
            g.agregaVertice(2,5,7);
            g.agregaVertice(3,7,14);
            g.agregaVertice(3,0,2);
            g.agregaVertice(3,1,8);
            g.agregaVertice(3,4,12);
            g.agregaVertice(4,2,1);
            g.agregaVertice(4,1,4);
            g.agregaVertice(4,3,12);
            g.agregaVertice(4,6,15);
            g.agregaVertice(5,1,7);
            g.agregaVertice(5,7,9);
            g.agregaVertice(6,1,6);
            g.agregaVertice(6,2,9);
            g.agregaVertice(6,4,15);
            g.agregaVertice(6,7,3);
            g.agregaVertice(7,0,10);
            g.agregaVertice(7,5,9);
            g.agregaVertice(7,1,6);
            g.agregaVertice(7,6,3);
            g.agregaVertice(7,3,14);
            return g;
        }
        //from,to,cost
        public static AdjacencyList initializeDAG(int nodes){
            g = new AdjacencyList(nodes);
            g.agregaVertice(0,1,0);
            g.agregaVertice(1,2,0);
            g.agregaVertice(1,3,0);
            g.agregaVertice(2,4,0);
            g.agregaVertice(2,5,0);
            g.agregaVertice(3,6,0);
            g.agregaVertice(4,7,0);
            g.agregaVertice(5,7,0);
            g.agregaVertice(6,5,0);
            g.agregaVertice(6,7,0);
            return g;
        }

         //This graph has weights , but in BFS it is not necessary and is cyclic
        public static AdjacencyList initializeGraph(int nodes){
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
            return g;
        }
    }
}
