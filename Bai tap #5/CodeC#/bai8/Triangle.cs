using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Vẽ hình tam giác");
        }
        public override void erase()
        {
            Console.WriteLine("Xóa thành công hình tam giác");
        }
        public override void move(int x, int y)
        {
            Console.WriteLine($"Di chuyển hình tam giác đến tọa độ ({x}, {y}");
        }
    }
}
