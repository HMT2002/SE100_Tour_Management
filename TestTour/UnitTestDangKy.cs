using NUnit.Framework;
using System;
using System.Drawing;
using System.IO;
using Tour;
using Tour.Model;
using Tour.Proxy;
using Tour.Utils;

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
            this.FDangKy = new Tour.DangKy();
            this.FPhuongTien = new Tour.PhuongTien();
            this.FLocation = new Tour.Location();
            this.FDoanDuLich = new Tour.DoanDuLich();


        }


        [Test]
        public void TestAddHotel0()
        {            
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins=DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result= new Proxy(new Hotel()).testCheckHotelInput("123", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.True(result);
        }

        [Test]
        public void TestAddHotel1()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.False(result);
        }

        [Test]
        public void TestAddHotel2()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("123", null, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.False(result);
        }

        [Test]
        public void TestAddLocation0()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Location()).testCheckLocationInput("123", img_data, "1");
            Assert.True(result);
        }
        [Test]
        public void TestAddLocation1()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("123", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.True(result);
        }
        [Test]
        public void TestAddLocation2()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("123", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.True(result);
        }

        [Test]
        public void TestAddPhuongTien0()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("123", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.True(result);
        }
        [Test]
        public void TestAddPhuongTien1()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("123", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.True(result);
        }
        [Test]
        public void TestAddPhuongTien2()
        {
            string solution_dir = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            string TestDirectory = TestContext.CurrentContext.TestDirectory;
            var ins = DataProvider.Ins;
            string app_domain = AppDomain.CurrentDomain.BaseDirectory;
            string image_path = Path.Combine(app_domain, @"..\..\..\testimg.png");
            Image image = Image.FromFile(image_path);
            byte[] img_data = Converter.Instance.ImageToByte(image);
            bool result = new Proxy(new Hotel()).testCheckHotelInput("123", img_data, "1", "Ha Giang", "Hà Giang là một tỉnh thuộc vùng Đông Bắc Bộ, Việt Nam", "50000");
            Assert.True(result);
        }

    }
}