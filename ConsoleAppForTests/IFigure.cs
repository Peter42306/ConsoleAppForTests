using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    public interface IFigure
    {
        int x { get; set; }  // Координата X
        int y { get; set; }  // Координата Y

        void Draw();         // Метод для отрисовки
    }
}
