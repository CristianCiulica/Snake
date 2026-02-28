using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameState
    {
        public int Rows {  get; }
        public int Columns { get; }
        public GridValue[,] Grid { get; }
        public Direction Dir { get; private set; }
        public int Score {  get; private set; }
        public bool GameOver {  get; private set; }

        private readonly LinkedList<Position> snakePosition= new LinkedList<Position>();
        private readonly Random random = new Random();
        public GameState(int rows, int cols)
        {
            Rows=rows; 
            Columns = cols;
            Grid = new GridValue[Rows, Columns];
            Dir = Direction.Right;
        }
        private void AddSnake() {
            int r = Rows / 2;
            for (int c = 1; c <= 3; c++)
            {
                Grid[r, c] = GridValue.Snake;
                snakePosition.AddFirst(new Position(r, c));
            }
        }
    }
}
