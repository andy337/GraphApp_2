using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    class GraphList : Graph
    {
        private List<List<int>> graphList;

        public GraphList(int n) : base(n)
        {
            graphList = new List<List<int>>(n);
            for (int i = 0; i < n; i++)
            {
                graphList.Add(new List<int>());
            }
        }

        public override string Print()
        {
            string str = "";
            for (int i = 0; i < N; i++)
            {
                str += i + " -> ";
                for (int j = 0; j < graphList[i].Count; j++)
                {
                    str += graphList[i][j] + ", ";
                }
                str += "\n";
            }
            return str;
        }

        public override void AddEdge(int f_element, int l_element)
        {
            graphList[f_element].Add(l_element);
        }

        public override void RemoveEdge(int f_element, int l_element)
        {
            graphList[f_element].Remove(l_element);
        }

        public override bool CheckEdge(int f_element, int l_element)
        {
            if (graphList[f_element].Contains(l_element))
                return true;
            return false;
        }

        public override string OutDegree(int f_element)
        {
            return (graphList[f_element].Count).ToString();
        }

        public override string InDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (graphList[i].Contains(v))
                {
                    count++;
                }
            }
            return count.ToString();
        }

        public override int[] BFS(int vertex)
        {
            Queue<int> queue = new Queue<int>();
            bool[] marked = new bool[N];
            int[] distance = new int[N];
            int count = 1;


            queue.Enqueue(vertex);
            marked[vertex] = true;
            while (queue.Count > 0)
            {
                bool temp = false;
                var v = queue.Dequeue();

                for (int i = 0; i < graphList[v].Count; i++)
                {
                    if (!marked[graphList[v][i]])
                    {
                        marked[graphList[v][i]] = true;
                        temp = true;
                        queue.Enqueue(graphList[v][i]);
                        distance[graphList[v][i]] = count;
                    }
                }
                if (temp)
                {
                    count++;
                }
            }
            return distance;
        }

        public override Graph Converter()
        {
            GraphMatrix graphMatrix = new GraphMatrix(N);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < graphList[i].Count; j++)
                {
                    graphMatrix.AddEdge(i, graphList[i][j]);
                }
            }
            return graphMatrix;
        }
    }
}
