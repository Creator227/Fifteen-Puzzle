using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пятнашки
{
    public class GameController
    {
        public int[] Puzzle { get; private set; }
        private int EmptyPos { get; set; }
        public int Steps { get; private set; }
        private int Size { get; set; } 
        public GameController(int size)
        {
            Size = size;
            Puzzle = new int[Size * Size];
            for (int i = 0; i < (Size * Size) - 1; i++)
                Puzzle[i] = i + 1;

            EmptyPos = Size * Size - 1;
            Random rn = new Random();

            //Делаю 100 случайных сдвигов блоков 
            while (IsFinished())
            {
                for (int i = 0; i < 100; i++)
                {
                 
                    int side = rn.Next() % 4;
                    if (side == 0)
                        if (EmptyPos % Size != 0)
                        {
                            MoveBlock(EmptyPos - 1);
                            continue;
                        }
                        else side++;
                    if (side == 1)
                    {
                        if (EmptyPos % Size != Size - 1)
                        {
                            MoveBlock(EmptyPos + 1);
                            continue;
                        }
                        else side--;
                    }
                    if (side == 2)
                    {
                        if (EmptyPos - Size >= 0)
                        {
                            MoveBlock(EmptyPos - Size);
                            continue;
                        }
                        else side++;
                    }
                    if (side == 3)
                    {
                        if (EmptyPos + Size <= Size * Size - 1)
                        {
                            MoveBlock(EmptyPos + Size);
                            continue;
                        }
                        else side--;
                    }
                }
            }
            Steps = 0;
        }
        public bool MoveBlock(int pos)
        {
            if ((pos == EmptyPos - 1 && EmptyPos % Size != 0) 
                || (pos == EmptyPos + 1 && EmptyPos % Size != Size - 1)
                || (pos == EmptyPos + Size ) || (pos == EmptyPos - Size))
            {
                Puzzle[EmptyPos] = Puzzle[pos];
                Puzzle[pos] = 0;
                EmptyPos = pos;
                ++Steps;
                return true;
            }
            return false;
        }

        public bool IsFinished()
        {
            for (int i = 0; i < Size * Size - 1; i++)
                if (Puzzle[i] != i + 1)
                    return false;

            return true;
        }

    }
}
