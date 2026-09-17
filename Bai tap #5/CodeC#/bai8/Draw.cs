using System;
using System.Collections.Generic;
using System.Text;

namespace bai8
{
    public class Drawing
    {
        public void drawShape(Shape theShpae)
        {
            theShpae.draw();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Drawing banVe = new Drawing();

            Shape hinhTron = new Circle();
            Shape hinhTamGiac = new Triangle();
            Shape hinhChuNhat = new Rectangle();

            Console.WriteLine("--- TEST GỌI HÀM DRAW TỪ LỚP DRAWING ---");

            banVe.drawShape(hinhTron);
            banVe.drawShape(hinhTamGiac);
            banVe.drawShape(hinhChuNhat);

            Console.WriteLine("\n--- TEST CÁC HÀM KHÁC (MOVE, ERASE) ---");
            hinhChuNhat.move(10, 20);
            hinhTron.erase();

            Console.ReadLine();
        }
    }
}
