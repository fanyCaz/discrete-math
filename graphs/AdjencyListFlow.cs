using System;
using System.Collections.Generic;

namespace graphs
{
    public class AdjacencyListFlow
    {
        LinkedList<Tuple<int, int,int>>[] adjList;
        public AdjacencyListFlow(int vertices)
        {
            adjList = new LinkedList<Tuple<int, int,int>>[vertices];

            for (int i = 0; i < adjList.Length; ++i)
            {
                adjList[i] = new LinkedList<Tuple<int, int,int>>();
            }
        }

        public void agregaVertice(int startVertex, int endVertex, int weight,int flow)
        {
            adjList[startVertex].AddLast(new Tuple<int, int,int>(endVertex, weight,flow));
        }

        public LinkedList<Tuple<int, int,int>> this[int index]
        {
            get
            {
                LinkedList<Tuple<int, int,int>> edgeList
                               = new LinkedList<Tuple<int, int,int>>(adjList[index]);
 
                return edgeList;
            }
        }

        public void mostrarListaAdyacencia()
        {
            int i = 0;
            foreach (LinkedList<Tuple<int, int,int>> list in adjList)
            {
                Console.Write("adjacencyList[" + i + "] -> ");
 
                foreach (Tuple<int, int,int> vertice in list)
                {
                    Console.Write(vertice.Item1 + "(" + vertice.Item2 + ", " + vertice.Item3 +")");
                }
                ++i;
                Console.WriteLine();
            }
        }
    }
}