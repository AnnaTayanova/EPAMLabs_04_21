using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;

namespace GeometricFigures1
{
    class TestTriangle
    {
        [Test]
        public void TestArea([Range(0, 20)] double x, [Range(0, 20)] double y, [Range(0, 20)] double z)
        {
            var area = GeometricFigures.Triangle.GetArea(x, y, z);
            var area_formula = Math.Sqrt((x + y + z) / 2 * ((x + y + z) / 2 - x) * ((x + y + z) / 2 - y) * ((x + y + z) / 2 - z));
            Assert.AreEqual(area_formula, area, $"Мы ожидаем {area_formula}, а пришло {area}");
        }

        //Не выполнены: 3152

        [Test]
        public void TestLength([Range(0, 20)] double x, [Range(0, 20)] double y, [Range(0, 20)] double z)
        {
            var length = GeometricFigures.Triangle.GetLength(x, y, z);
            var length_formula = x + y + z;
            Assert.AreEqual(length_formula, length, $"Ожидается {length_formula}, пришло {length}");
        }

        //Не выполнены: 861
    }
}
