using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public class Polygon : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Vẽ thành công hình đa giác");
        }
        public override void erase()
        {
            Console.WriteLine("Xóa thành công hình đa giác");
        }
        public override void move(int x, int y)
        {
            Console.WriteLine($"Di chuyển hình đa giác đến tọa độ({x}, {y})");
        }
    }
}
