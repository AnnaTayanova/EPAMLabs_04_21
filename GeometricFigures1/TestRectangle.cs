using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;

namespace GeometricFigures1
{
    public class TestRectangle
    {

        [Test]
        public void TestArea([Range(0, 20)] int x, [Range(0, 20)] int y)
        {
            var area = GeometricFigures.Rectangle.GetArea(x, y);
            var area_formula = x * y;
            Assert.AreEqual(area_formula, area, $"Ожидается {area_formula}, пришло {area}");
        }

        //Не выполнены: 39
    
        [Test]
        public void TestLength([Range(0, 20)] int x, [Range(0, 20)] int y)
        {
            var length = GeometricFigures.Rectangle.GetLength(x, y);
            var length_formula = (x + y) * 2;
            Assert.AreEqual(length_formula, length, $"Ожидается {length_formula}, пришло {length}");
        }

        //Не выполнены: 41
    }
}
