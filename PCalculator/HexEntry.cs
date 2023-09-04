using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCalculator
{
    public class GraphicsDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.DrawLine(dirtyRect.X, dirtyRect.Y, dirtyRect.X, dirtyRect.Y+20);
            //canvas.DrawText("test", dirtyRect.X, dirtyRect.Y, dirtyRect.Width,dirtyRect.Height);
        }
    }

    class HexEntry 
    {
    }
}
