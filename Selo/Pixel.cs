using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
    public readonly struct Pixel
    {
        private const char PixelChar = '█';

        public Pixel(int x, int y,ConsoleColor Color)
        {
            this.x = x;
            this.y = y;
            this.Color = Color;
        }
        public int x { get; }
        public int y { get; }

        public ConsoleColor Color { get; }
        
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(PixelChar);
        }
    }
}
