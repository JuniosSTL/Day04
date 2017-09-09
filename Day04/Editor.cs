using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Editor
    {
        public Shape[] drawn; 
        public void Draw()
        {
            Random r = new Random();

            int circleCount = r.Next(0, 10);
            int rectCount = r.Next(0, 10);
            int triCount = r.Next(0, 10);

            drawn = new Shape[circleCount + rectCount + triCount];

            int index = 0;
            for (int i = 0; i < circleCount; i++)
            {
                drawn[index] = new Circle();
                //drawn[index].Draw();
                index++;
            }

            for (int i = 0; i < rectCount; i++)
            {
                drawn[index] = new Rectangle();
                //drawn[index].Draw();
                index++;
            }

            for (int i = 0; i < triCount; i++)
            {
                drawn[index] = new Triangle();
                //drawn[index].Draw();
                index++;
            }
        }

        public void Save()
        {

        }

        public void Load()
        {
            for(int i =0; i < drawn.Length; ++i)
            {
                drawn[i].Draw();
            }
        }
    }
}
