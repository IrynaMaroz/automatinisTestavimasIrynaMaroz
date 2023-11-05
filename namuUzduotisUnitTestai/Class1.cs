using NUnit.Framework;
using System;

namespace namuUzduotisUnitTestai
{
    public class ar995DalinasiIs3BeLiekanos
    {
        [Test]
        public void arDalinasiIs3BeLiekanos()
        {
            int skaicius = 995;
            bool rezultatas = ArDalinasiIs3BeLiekanos(skaicius);
        }
        public bool ArDalinasiIs3BeLiekanos(int skaicius)
        {
            return skaicius % 3 == 0;
        }
    }
    public class DienosTestas
    {
        [Test]
        public void ArSisDienosTrečiadienis_Zalias()
        {
            DateTime siandien = DateTime.Now;

            bool arTreciadienis = ArTreciadienis(siandien);

            Assert.IsTrue(arTreciadienis, "Šiandien turėtų būti trečiadienis.");
        }

        public bool ArTreciadienis(DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Wednesday;
        }
    }
    public class ValandosTestas
    {
        [Test]
        public void ArDabartinisLaikasYra13Val_Zalias()
        {
            DateTime dabartinisLaikas = DateTime.Now;

            bool ar13Val = Ar13Valandu(dabartinisLaikas);

            Assert.IsTrue(ar13Val, "Dabartinis laikas turėtų būti 13 valanda.");
        }

        public bool Ar13Valandu(DateTime laikas)
        {
            return laikas.Hour == 13;
        }
    }
    public class LyginiaiSkaiciaiTestas
    {
        [Test]
        public void ArKeturiosLyginiaiSkaiciaiNuo1Iki10_Zalias()
        {
            int skaiciuKiekis = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    skaiciuKiekis++;
                }
            }
            Assert.AreEqual(4, skaiciuKiekis, "Nuo 1 iki 10 yra 4 lyginiai skaičiai.");
        }
    }
}
