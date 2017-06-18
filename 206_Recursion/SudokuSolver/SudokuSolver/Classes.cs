using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Sudoku
    {
        int[,] t;
        Position[] fixPos, emptyPos;

        public Sudoku(int[,] t)
        {
            this.t = t;
            FieldSelection();
        }

        void FieldSelection()
        {
            // How many zero imtes we have
            int db = 0;
            for (int i = 0; i < t.GetLength(0); i++)
                for (int j = 0; j < t.GetLength(1); j++)
                    if (t[i, j] != 0)
                        db++;

            // Creating the blocks
            fixPos = new Position[db];
            emptyPos = new Position[(t.GetLength(0) * t.GetLength(1)) - db];

            // Rechecking the matrix
            int idxf = 0, idxu = 0;
            for (int i = 0; i < t.GetLength(0); i++)
                for (int j = 0; j < t.GetLength(1); j++)
                    if (t[i, j] != 0)
                        fixPos[idxf++] = new Position(i, j);
                    else
                        emptyPos[idxu++] = new Position(i, j);
        }

        void FieldConcatenation(int[] e)
        {
            for (int i = 0; i < e.Length; i++)
                t[emptyPos[i].Row, emptyPos[i].Column] = e[i];
        }

        public bool Solution()
        {
            bool exists = false;
            int[] e = new int[emptyPos.Length];
            BackTrack(0, ref exists, e);
            if (exists)
                FieldConcatenation(e);
            return exists;
        }

        bool ft(int level, int number)
        {
            int i = 0;
            while (i < fixPos.Length && !(number == t[fixPos[i].Row, fixPos[i].Column] && Position.Block(emptyPos[level], fixPos[i])))
                i++;
            return i == fixPos.Length;
        }
        
        bool fk(int level, int number, int k, int knumber)
        {
            return !(number == knumber && Position.Block(emptyPos[level], emptyPos[k]));
        }

        void BackTrack(int level, ref bool exists, int[] e)
        {
            int i = 0;
            do
            {
                i++;
                if(ft(level, i))
                {
                    int k = 0;
                    while (k < level && fk(level, i, k, e[k]))
                        k++;
                    if(k == level)
                    {
                        e[level] = i;
                        if (level == emptyPos.Length - 1)
                            exists = true;
                        else
                            BackTrack(level + 1, ref exists, e);
                    }
                }
            }
            while (!exists && i < 9);
        }
    }

    class Position
    {
        int column, row;
        public int Column { get { return column; } }
        public int Row { get { return row; } }

        public Position(int column, int row)
        {
            this.column = column;
            this.row = row;
        }

        public static bool Block(Position p1, Position p2)
        {
            return ((p1.Row == p2.Row) || (p1.Column == p2.Column) || ((p1.Row / 3 == p2.Row / 3) && (p1.Column / 3 == p2.Column / 3)));
        }
    }
}
