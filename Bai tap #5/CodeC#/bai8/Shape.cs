using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public abstract class Shape
    {
        public abstract void draw();
        public abstract void erase();
        public abstract void move(int x, int y);
    }
}
