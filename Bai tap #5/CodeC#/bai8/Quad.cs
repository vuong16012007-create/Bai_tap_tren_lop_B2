using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public class Quad : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Vẽ hình tứ giác (Quad)");
        }
        public override void erase()
        {
            Console.WriteLine("Xóa hình tú giác");
        }
        public override void move(int x, int y)
        {
            Console.WriteLine($"Di chuyển tứ giác đến tọa đọ({x}, {y}");
        }
    }
}
