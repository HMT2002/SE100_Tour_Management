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
    public partial class AddHotelForGroup : Form
    {
        string ID;

        ImageList listView_ImageList1 = new ImageList();
        ImageList listView_ImageList2 = new ImageList();

        List<KHACHSAN> ListKhachSan = new List<KHACHSAN>();
        List<KHACHSAN> ListTatCaKhachSan = new List<KHACHSAN>();

        public decimal tong_GIA=0;

        public AddHotelForGroup(string id)
        {
            InitializeComponent();
            ID = id;
            Init();
        }

        private void Init()
        {
            var result2 = (from ks in DataProvider.Ins.DB.KHACHSANs
                           join tb_belong in DataProvider.Ins.DB.tb_KHACHSAN on ks.ID equals tb_belong.IDKHACHSAN
                           where tb_belong.IDDOAN == ID && tb_belong.IsDeleted==false
                           select ks)
                                     .ToList();
            var result = (from ks in DataProvider.Ins.DB.KHACHSANs
                          where ks.IsDeleted==false
                          select ks)
                         .ToList();
            int i = 0;
            foreach (KHACHSAN khachsan in result2)
            {
                ListKhachSan.Add(khachsan);
                var listViewItem = listView2.Items.Add(khachsan.TEN);
                listView_ImageList2.Images.Add(i.ToString(), Converter.Instance.ByteArrayToImage(khachsan.PICBI));
                listViewItem.ImageKey = i.ToString();
                i++;
            }
            i = 0;
            foreach (KHACHSAN khachsan in result)
            {
                ListTatCaKhachSan.Add(khachsan);

                var listViewItem = listView1.Items.Add(khachsan.TEN);
                listView_ImageList1.Images.Add(i.ToString(), Converter.Instance.ByteArrayToImage(khachsan.PICBI));
                listViewItem.ImageKey = i.ToString();
                i++;
            }
            listView_ImageList1.ImageSize = new Size(60, 60);
            listView_ImageList2.ImageSize = new Size(60, 60);

            listView1.LargeImageList = listView_ImageList1;
            listView2.LargeImageList = listView_ImageList2;

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                KHACHSAN ks = ListTatCaKhachSan[listView1.SelectedItems[0].Index];
                if (ListKhachSan.Contains(ks))
                {
                    return;
                }

                ListKhachSan.Add(ks);
                string randomkey = Converter.Instance.RandomString(5);
                var listViewItem = listView2.Items.Add(ks.TEN);
                listView_ImageList2.Images.Add(randomkey, Converter.Instance.ByteArrayToImage(ks.PICBI));
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
                ListKhachSan.Remove(ListKhachSan[listView2.SelectedItems[0].Index]);
                listView_ImageList2.Images.RemoveAt(listView2.SelectedItems[0].Index);
                listView2.Items.RemoveAt(listView2.SelectedItems[0].Index);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach(var tb_ks in DataProvider.Ins.DB.tb_KHACHSAN.Where(x => x.IDDOAN == ID))
            {
                DataProvider.Ins.DB.tb_KHACHSAN.Remove(tb_ks);
            }
            DataProvider.Ins.DB.SaveChanges();


            foreach (KHACHSAN khachsan in ListKhachSan)
            {
                string random1 = Converter.Instance.RandomString2(5);
                while (DataProvider.Ins.DB.tb_KHACHSAN.Where(x => x.ID == random1).FirstOrDefault() != null)
                {
                    random1 = Converter.Instance.RandomString2(5);
                }
                tong_GIA +=(decimal) khachsan.GIA;

                DataProvider.Ins.DB.tb_KHACHSAN.Add(new tb_KHACHSAN() { ID = random1, IDKHACHSAN = khachsan.ID, IDDOAN = ID,IsDeleted=false });


            }

            DataProvider.Ins.DB.SaveChanges();

            this.Close();
        }

        private void btngunaExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
