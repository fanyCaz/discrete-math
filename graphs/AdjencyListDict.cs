using System;
using System.Collections.Generic;

//usa dictionary
namespace graphs
{
    public class AdjacencyListDict
    {
        LinkedList<Dictionary<int, int>>[] adjList;
        public AdjacencyListDict(int vertices)
        {
            adjList = new LinkedList<Dictionary<int, int>>[vertices];

            for (int i = 0; i < adjList.Length; ++i)
            {
                adjList[i] = new LinkedList<Dictionary<int, int>>();
            }
        }

        public void agregaVertice(int startVertex, int endVertex, int weight)
        {
            var x = new Dictionary<int, int>();
            x.Add(endVertex, weight);
            adjList[startVertex].AddLast(x);
        }

        public LinkedList<Dictionary<int, int>> this[int index]
        {
            get
            {
                LinkedList<Dictionary<int, int>> edgeList
                               = new LinkedList<Dictionary<int, int>>(adjList[index]);
 
                return edgeList;
            }
        }

        public void mostrarListaAdyacencia()
        {
            int i = 0;
            foreach (LinkedList<Dictionary<int, int>> list in adjList)
            {
                Console.Write("adjacencyListDict[" + i + "] -> ");
 
                foreach (Dictionary<int, int> vertice in list)
                {
                    Console.Write(vertice.Keys + "(" + vertice.Values + ")");
                }
                ++i;
                Console.WriteLine();
            }
        }
    }
}