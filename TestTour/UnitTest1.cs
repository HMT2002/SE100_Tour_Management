using NUnit.Framework;

namespace TestTour
{
    public class Tests
    {
        Tour.Tour fTour;

        [SetUp]
        public void Setup()
        {
            fTour = new Tour.Tour();
        }



        [Test]
        public void TestTour1()
        {
            fTour.nametour = "nametour";
            fTour.typetour = "Plane";
            fTour.price = "150000k";

            Assert.False(fTour.CheckData());
        }

        [Test]
        public void TestTour2()
        {
            fTour.nametour = "nametour";
            fTour.typetour = "Plane";
            fTour.price = "150000";

            Assert.False(fTour.CheckData());
        }



    }
}