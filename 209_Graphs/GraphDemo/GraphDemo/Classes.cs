using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDemo
{
    class GraphNeighbourList : Graph
    {
        List<int>[] L;

        public GraphNeighbourList(int N)
            :base (N)
        {
            L = new List<int>[N];
            for (int i = 0; i < N; i++)
                L[i] = new List<int>();
        }

        public override List<int> Peaks()
        {
            List<int> l = new List<int>();
            for (int i = 0; i < N; i++)
                l.Add(i);
            return l;
        }

        public override void AddEdge(int from, int to)
        {
            L[from].Add(to);
            L[to].Add(from);
        }

        public override bool LeadEdge(int from, int to)
        {
            return L[from].Contains(to);
        }
    }

    class GraphPeakMatrix : Graph
    {
        int[,] CS;
        
        public GraphPeakMatrix(int N)
            :base (N)
        {
            CS = new int[N, N];
        }

        public override List<int> Peaks()
        {
            List<int> l = new List<int>();
            for (int i = 0; i < N; i++)
                l.Add(i);
            return l;
        }

        public override void AddEdge(int from, int to)
        {
            CS[from, to] = 1;
            CS[to, from] = 1;
        }

        public override bool LeadEdge(int from, int to)
        {
            return CS[from, to] == 1;
        }
    }

    abstract class Graph
    {
        protected int N;

        public Graph(int N)
        {
            this.N = N;
        }

        public abstract List<int> Peaks();
        public abstract void AddEdge(int from, int to);
        public abstract bool LeadEdge(int from, int to);

        public List<int> Neighbours(int peak)
        {
            List<int> l = new List<int>();
            foreach (int i in Peaks())
                if (LeadEdge(peak, i))
                    l.Add(i);
            return l;
        }

        public List<int> LattitudeRun()
        {
            List<int> F = new List<int>();
            Queue<int> S = new Queue<int>();
            F.Add(0);
            S.Enqueue(0);
            while(S.Count != 0)
            {
                int k = S.Dequeue();
                foreach (int x in Neighbours(k))
                {
                    if(!F.Contains(x))
                    {
                        S.Enqueue(x);
                        F.Add(x);
                    }
                }
            }
            return F;
        }

        public List<int> DepthRun()
        {
            List<int> F = new List<int>();
            DepthRunRec(0, F);
            return F;
        }

        void DepthRunRec(int k, List<int> F)
        {
            F.Add(k);
            foreach (int x in Neighbours(k))
                if (!F.Contains(x))
                    DepthRunRec(x, F);
        }
    }
}
