using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public class Rectangle : Quad
    {
        public override void draw()
        {
            Console.WriteLine("Vẽ hình chữ nhật (Rectangle)");
        }
        public override void erase()
        {
            Console.WriteLine("Xóa hình chữ nhật");
        }
        public override void move(int x, int y)
        {
            Console.WriteLine($"Di chuyển hình chữ nhật đến tọa độ ({x}, {y})");
        }
    }
}
