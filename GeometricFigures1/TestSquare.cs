using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;

namespace GeometricFigures1
{
    class TestSquare
    {
        [Test]
        public void TestArea([Range(0, 20)] int x)
        {
            var area = GeometricFigures.Square.GetArea(x);
            var area_formula = x * x;
            Assert.AreEqual(area_formula, area, $"Ожидается {area_formula}, пришло {area}");
        }

        //Не выполнены: 2

        [Test]
        public void TestLength([Range(0, 20)] int x)
        {
            var length = GeometricFigures.Square.GetLength(x);
            var length_formula = x * 4;
            Assert.AreEqual(length_formula, length, $"Ожидается {length_formula}, пришло {length}");
        }

        //Не выполнены: 2
    }
}
