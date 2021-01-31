using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork7
{
    class TestTank : Tank
    {

        public override double GetTopCaliber()
        {
            return 125;
        }

        static void Main()
        {

            TestTank characterstic = new TestTank();

            characterstic.StartWeight(54);
            characterstic.AddDiesel(500);
            characterstic.Armor(90, 150, 135);
            double penetration = characterstic.GetTopPenetration(140);
            Console.WriteLine("My top penetration is {138}", penetration);
        }

        private void Armor(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        private void AddDiesel(int v)
        {
            throw new NotImplementedException();
        }

        private void StartWeight(int v)
        {
            throw new NotImplementedException();
        }

        private double GetTopPenetration(int v)
        {
            throw new NotImplementedException();
        }
    }
}
