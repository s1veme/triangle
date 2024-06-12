using TriangleLibrary;

namespace TriangleLibraryTests
{
    [TestClass]
    public class TriangleValidatorTests
    {
        [TestMethod]
        public void IsValidTriangle_ValidTriangles()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(5, 5, 5);
            var triangle3 = new Triangle(2, 2, 3);
            var validator1 = new TriangleValidator(triangle1);
            var validator2 = new TriangleValidator(triangle2);
            var validator3 = new TriangleValidator(triangle3);

            Assert.IsTrue(validator1.IsValidTriangle());
            Assert.IsTrue(validator2.IsValidTriangle());
            Assert.IsTrue(validator3.IsValidTriangle());
        }

        [TestMethod]
        public void IsValidTriangle_InvalidTriangles()
        {
            var triangle1 = new Triangle(1, 2, 3);
            var triangle2 = new Triangle(5, 1, 1);
            var triangle3 = new Triangle(10, 1, 1);
            var validator1 = new TriangleValidator(triangle1);
            var validator2 = new TriangleValidator(triangle2);
            var validator3 = new TriangleValidator(triangle3);

            Assert.IsFalse(validator1.IsValidTriangle());
            Assert.IsFalse(validator2.IsValidTriangle());
            Assert.IsFalse(validator3.IsValidTriangle());
        }

        [TestMethod]
        public void DetermineSideType_CorrectSideType()
        {
            var equilateral = new Triangle(3, 3, 3);
            var isosceles = new Triangle(3, 3, 2);
            var scalene = new Triangle(3, 4, 5);
            var validatorEquilateral = new TriangleValidator(equilateral);
            var validatorIsosceles = new TriangleValidator(isosceles);
            var validatorScalene = new TriangleValidator(scalene);

            Assert.AreEqual("Равносторонний", validatorEquilateral.DetermineSideType());
            Assert.AreEqual("Равнобедренный", validatorIsosceles.DetermineSideType());
            Assert.AreEqual("Разносторонний", validatorScalene.DetermineSideType());
        }

        [TestMethod]
        public void DetermineAngleType_CorrectAngleType()
        {
            var rightAngled = new Triangle(3, 4, 5);
            var acuteAngled = new Triangle(2, 2, 3);
            var obtuseAngled = new Triangle(3, 4, 6);
            var validatorRightAngled = new TriangleValidator(rightAngled);
            var validatorAcuteAngled = new TriangleValidator(acuteAngled);
            var validatorObtuseAngled = new TriangleValidator(obtuseAngled);

            Assert.AreEqual("Прямоугольный", validatorRightAngled.DetermineAngleType());
            Assert.AreEqual("Остроугольный", validatorAcuteAngled.DetermineAngleType());
            Assert.AreEqual("Тупоугольный", validatorObtuseAngled.DetermineAngleType());
        }

        [TestMethod]
        public void ToString_CorrectTriangleDescription()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(5, 5, 5);
            var triangle3 = new Triangle(2, 2, 2);
            var invalidTriangle = new Triangle(1, 1, 2);
            var validator1 = new TriangleValidator(triangle1);
            var validator2 = new TriangleValidator(triangle2);
            var validator3 = new TriangleValidator(triangle3);
            var invalidValidator = new TriangleValidator(invalidTriangle);

            Assert.AreEqual("Разносторонний\r\nПрямоугольный", validator1.ToString());
            Assert.AreEqual("Равносторонний\r\nОстроугольный", validator2.ToString());
            Assert.AreEqual("Равносторонний\r\nОстроугольный", validator3.ToString());
            Assert.AreEqual("Треугольник не существует", invalidValidator.ToString());
        }
    }
}