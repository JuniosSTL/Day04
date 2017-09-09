using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Editor
    {
        public List<Shape> drawn;
        public Dictionary<string, int> a;


        public void Draw()
        {
            drawn = new List<Shape>();
            Random r = new Random();

            int circleCount = r.Next(0, 10);
            int rectCount = r.Next(0, 10);
            int triCount = r.Next(0, 10);

            for (int i = 0; i < circleCount; i++)
            {
                drawn.Add(new Circle());
            }

            for (int i = 0; i < rectCount; i++)
            {
                drawn.Add(new Rectangle());
            }

            for (int i = 0; i < triCount; i++)
            {
                drawn.Add(new Triangle());
            }
        }

        public void Save()
        {

        }

        public void Load()
        {
            for(int i =0; i < drawn.Count; ++i)
            {
                drawn[i].Draw();
            }
        }
    }
}
