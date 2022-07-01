using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoE
{
    internal class Slovo
    {
        private Point o;
        private int a;
        private Color boja;

        public Point O
        {
            get { return o; }
        }
        public int A
        {
            get { return a; }
            set
            {
                if (value < 0) throw new Exception("a<0");
                else a = value;
            }

        }
        public Slovo(Point o, int a, Color boja)
        {
            this.o = o;
            A = a;
            this.boja = boja;
        }
        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(boja, 4);
            g.DrawLine(olovka, o.X, o.Y - a, o.X, o.Y + a);
            g.DrawLine(olovka, o.X, o.Y - a, o.X + a, o.Y - a);
            g.DrawLine(olovka, o.X, o.Y, o.X + a, o.Y);
            g.DrawLine(olovka, o.X, o.Y + a, o.X + a, o.Y + a);
        }

    }
}
