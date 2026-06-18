using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант_13
{
    class GameState
    {
        public const int Size = 4;

        private readonly Random random;

        private int[,] field;
        private int[,] previousField;

        private int score;
        private int previousScore;

        private bool canUndo;

        public int[,] Field
        {
            get { return field; }
        }

        public int Score
        {
            get { return score; }
        }

        public bool CanUndo
        {
            get { return canUndo; }
        }


        public GameState()
        {
            random = new Random();
            field = new int[Size, Size];
            previousField = new int[Size, Size];

            NewGame();
        }

        public void NewGame()
        {
            field = new int[Size, Size];
            score = 0;
            AddRandomTile();
            AddRandomTile();
        }

        private void AddRandomTile()
        {
            int x;
            int y;
            do
            {
                x = random.Next(Size);
                y = random.Next(Size);

            } while (field[x, y] != 0);


            if (random.Next(10) == 0)
                field[x, y] = 4;
            else
                field[x, y] = 2;
        }
        public void Move(Direction direction)
        {
            SaveState();
            bool changed = false;
            if (direction == Direction.Left)
                changed = MoveLeft();

            if (direction == Direction.Right)
            {
                ReverseRows();
                changed = MoveLeft();
                ReverseRows();
            }

            if (direction == Direction.Up)
            {
                Transpose();
                changed = MoveLeft();
                Transpose();
            }

            if (direction == Direction.Down)
            {
                Transpose();
                ReverseRows();
                changed = MoveLeft();
                ReverseRows();
                Transpose();
            }


            if (changed)
            {
                AddRandomTile();
                canUndo = true;
            }
            else
            {
                RestoreState();
            }
        }
        private bool MoveLeft()
        {
            bool changed = false;
            for (int i = 0; i < Size; i++)
            {
                int[] line = new int[Size];


                int index = 0;

                for (int j = 0; j < Size; j++)
                {
                    if (field[i, j] != 0)
                    {
                        line[index] = field[i, j];
                        index++;
                    }
                }

                for (int j = 0; j < Size - 1; j++)
                {
                    if (line[j] != 0 &&
                        line[j] == line[j + 1])
                    {
                        line[j] *= 2;

                        score += line[j];

                        line[j + 1] = 0;
                    }
                }
                int[] result = new int[Size];
                index = 0;

                for (int j = 0; j < Size; j++)
                {
                    if (line[j] != 0)
                    {
                        result[index] = line[j];
                        index++;
                    }
                }
                for (int j = 0; j < Size; j++)
                {
                    if (field[i, j] != result[j])
                        changed = true;

                    field[i, j] = result[j];
                }
            }
            return changed;
        }
        private void ReverseRows()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size / 2; j++)
                {
                    int temp = field[i, j];

                    field[i, j] = field[i, Size - j - 1];

                    field[i, Size - j - 1] = temp;
                }
            }
        }

        private void Transpose()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    int temp = field[i, j];

                    field[i, j] = field[j, i];

                    field[j, i] = temp;
                }
            }
        }
        private void SaveState()
        {
            previousField = (int[,])field.Clone();
            previousScore = score;
        }
        private void RestoreState()
        {
            field = previousField;
            score = previousScore;
        }
    public void Undo()
        {
            if (canUndo)
            {
                field = previousField;
                score = previousScore;
                canUndo = false;
            }
        }
        public bool CanMove()
{
    for (int i = 0; i < Size; i++)
    {
        for (int j = 0; j < Size; j++)
        {
            if (field[i, j] == 0)
                return true;
            if (i < Size - 1 && field[i, j] == field[i + 1, j])
                return true;
            if (j < Size - 1 && field[i, j] == field[i, j + 1])
                return true;
        }
    }

    return false;
}
    }
}

