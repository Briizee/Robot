using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Robot
{
    class Robot
    {
        public char direction;
        private Point position = new Point();

        public void initializePoint()
        {
            this.direction = 'N';
            this.position.X = 100;
            this.position.Y = 100;
        }

        public Point movePosition( int distance)
        {
            char direction = this.direction;
            int newY = this.position.Y;
            int newX = this.position.X;
            switch (direction)
            {
                case 'N':
                    newY -= distance;
                    break;
                case 'S':
                    newY += distance;
                    break;
                case 'W':
                    newX -= distance;
                    break;
                case 'E':
                    newX += distance;
                    break;
            }
            if(newY < 0 || newY > 200 || newX < 0 || newX >200)
            {
               
                throw new ArgumentOutOfRangeException();
            } else
            {
                this.position.Y = newY;
                this.position.X = newX;
                this.changeDirection(direction);
                return this.position;
            }


        }

        public void changeDirection(char newDirection)
        {
            this.direction = newDirection;
        }
    }
}
