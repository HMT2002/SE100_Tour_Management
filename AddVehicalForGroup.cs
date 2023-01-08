using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;


namespace Tour
{
    public partial class AddVehicalForGroup : Form
    {

        string ID;

        ImageList listView_ImageList1 = new ImageList();
        ImageList listView_ImageList2 = new ImageList();
        DOAN group = new DOAN();
        List<PHUONGTIEN> ListPhuongTien = new List<PHUONGTIEN>();
        List<PHUONGTIEN> ListTatCaPhuongTien = new List<PHUONGTIEN>();
        public decimal tong_GIA = 0;

        public AddVehicalForGroup(string id)
        {
            InitializeComponent();

            ID = id;
            Init();
        }

        private void Init()
        {
            var result2 = (from pt in DataProvider.Ins.DB.PHUONGTIENs
                           join tb_belong in DataProvider.Ins.DB.tb_PHUONGTIEN on pt.ID equals tb_belong.IDPHUONGTIEN
                           where tb_belong.IDDOAN == ID && tb_belong.IsDeleted == false
                           select pt)
                                     .ToList();
            var result = (from pt in DataProvider.Ins.DB.PHUONGTIENs
                          where pt.IsDeleted==false
                          select pt)
                         .ToList();
            int i = 0;
            foreach (PHUONGTIEN phuongtien in result2)
            {
                ListPhuongTien.Add(phuongtien);
                var listViewItem = listView2.Items.Add(phuongtien.TEN);
                listView_ImageList2.Images.Add(i.ToString(), Converter.Instance.ByteArrayToImage(phuongtien.PICBI));
                listViewItem.ImageKey = i.ToString();
                i++;
            }
            i = 0;
            foreach (PHUONGTIEN phuongtien in result)
            {
                ListTatCaPhuongTien.Add(phuongtien);

                var listViewItem = listView1.Items.Add(phuongtien.TEN);
                listView_ImageList1.Images.Add(i.ToString(), Converter.Instance.ByteArrayToImage(phuongtien.PICBI));
                listViewItem.ImageKey = i.ToString();
                i++;
            }
            listView_ImageList1.ImageSize = new Size(60, 60);
            listView_ImageList2.ImageSize = new Size(60, 60);

            listView1.LargeImageList = listView_ImageList1;
            listView2.LargeImageList = listView_ImageList2;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var tb_pt in DataProvider.Ins.DB.tb_PHUONGTIEN.Where(x => x.IDDOAN == ID))
            {
                group = DataProvider.Ins.DB.DOANs.Where(x => x.ID == ID).FirstOrDefault();
                group.GIA = group.GIA - tb_pt.PHUONGTIEN.GIA;
                DataProvider.Ins.DB.tb_PHUONGTIEN.Remove(tb_pt);
            }
            DataProvider.Ins.DB.SaveChanges();

            string random1 = Converter.Instance.RandomString2(5);
            foreach (PHUONGTIEN phuongtien in ListPhuongTien)
            {
                random1 = Converter.Instance.RandomString2(5);
                while (DataProvider.Ins.DB.tb_PHUONGTIEN.Where(x => x.ID == random1).FirstOrDefault() != null)
                {
                    random1 = Converter.Instance.RandomString2(5);
                }
                tong_GIA += (decimal)phuongtien.GIA;
                DataProvider.Ins.DB.tb_PHUONGTIEN.Add(new tb_PHUONGTIEN() { ID = random1, IDPHUONGTIEN = phuongtien.ID, IDDOAN = ID,IsDeleted=false });
                group = DataProvider.Ins.DB.DOANs.Where(x => x.ID == ID).FirstOrDefault();
                group.GIA = group.GIA + phuongtien.GIA;
               
            }
            DataProvider.Ins.DB.SaveChanges();

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddVehicalForGroup_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PHUONGTIEN pt = ListTatCaPhuongTien[listView1.SelectedItems[0].Index];
                if (ListPhuongTien.Contains(pt))
                {
                    return;
                }

                ListPhuongTien.Add(pt);
                string randomkey = Converter.Instance.RandomString(5);
                var listViewItem = listView2.Items.Add(pt.TEN);
                listView_ImageList2.Images.Add(randomkey, Converter.Instance.ByteArrayToImage(pt.PICBI));
                listViewItem.ImageKey = randomkey;
            }
            catch (Exception ex)
            {

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListPhuongTien.Remove(ListPhuongTien[listView2.SelectedItems[0].Index]);
                listView_ImageList2.Images.RemoveAt(listView2.SelectedItems[0].Index);
                listView2.Items.RemoveAt(listView2.SelectedItems[0].Index);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
