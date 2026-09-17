using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public  class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Vẽ hình tròn (Circle)");
        }
        public override void erase()
        {
            Console.WriteLine("Xóa hình tròn");
        }
        public override void move(int x, int y)
        {
            Console.WriteLine($"Di chuyển hình tròn đến tọa độ ({x}, {y})");
        }
    }
}
