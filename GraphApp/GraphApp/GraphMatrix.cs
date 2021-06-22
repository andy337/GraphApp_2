using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    class GraphMatrix : Graph
    {
        private int[,] matrix;

        public GraphMatrix(int n) : base(n)
        {
            matrix = new int[N, N];
        }

        public override string Print()
        {
            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    str += matrix[i, j] + " ";
                }
                str += "\n";
            }
            return str;
        }



        public override void AddEdge(int f_element, int l_element)
        {
            if (matrix[l_element, f_element] != 0)
            {
                throw new Exception("Цей граф не має мiстити кратних дуг");
            }
            matrix[f_element, l_element] = 1;
        }

        public override void RemoveEdge(int f_element, int l_element)
        {
            matrix[f_element, l_element] = 0;
        }

        public override bool CheckEdge(int f_element, int l_element)
        {
            if (matrix[f_element, l_element] == 1)
            {
                return true;
            }
            return false;
        }

        public override string OutDegree(int index)
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (matrix[index, i] == 1)
                {
                    count++;
                }
            }
            return count.ToString();
        }

        public override string InDegree(int index)
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (matrix[i, index] == 1)
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

                for (int i = 0; i < N; i++)
                {
                    if (matrix[v, i] == 1 && !marked[i])
                    {
                        marked[i] = true;
                        temp = true;
                        queue.Enqueue(i);
                        distance[i] = count;
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
            GraphList graphList = new GraphList(N);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        graphList.AddEdge(i, j);
                    }
                }
            }
            return graphList;
        }
    }
}
