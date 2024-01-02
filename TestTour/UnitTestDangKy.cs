using NUnit.Framework;

namespace TestTour
{
    public class TestsDangKy
    {
        Tour.Tour fTour;

        Tour.DangKy FDangKy;
        Tour.Hotel FHotel;
        Tour.PhuongTien FPhuongTien;
        Tour.Location FLocation;
        Tour.DoanDuLich FDoanDuLich;


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

            Assert.True(fTour.CheckData());
        }



    }
}