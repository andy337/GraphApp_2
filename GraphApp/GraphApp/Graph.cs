using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    abstract class Graph
    {
        public int N { get; }

        public Graph(int n)
        {
            N = n;
        }

        public abstract string Print(); // Вивести граф

        public abstract void AddEdge(int f_element, int l_element); // Додати дугу

        public abstract void RemoveEdge(int f_element, int l_element); // Видалити дугу

        public abstract bool CheckEdge(int f_element, int l_element); // Перевірка існування дуги

        public string IsIsolated(int v) // Ізольвона вершина
        {
            if (InDegree(v) == "0" && OutDegree(v) == "0")
            {
                return "True";
            }
            return "False";
        }

        public abstract string OutDegree(int v); // Напівстепінь дуги(виходу)

        public abstract string InDegree(int v); // Напівстепінь дуги(входу)

        public abstract Graph Converter(); // Конвертер

        public abstract int[] BFS(int v);

        public string MatrixDistance(int v) // Матриця відстаней
        {
            int[,] matrixDistance = new int[N, N];
            string str = "";
            for (int i = 0; i < N; i++)
            {
                int[] distance = BFS(i);
                for (int j = 0; j < N; j++)
                {
                    matrixDistance[i, j] = distance[j];
                    str += matrixDistance[i, j] + ", ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
