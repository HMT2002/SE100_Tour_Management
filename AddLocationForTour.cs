﻿using System;
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
    public partial class AddLocationForTour : Form
    {
        string ID;

        ImageList listView_ImageList1 = new ImageList();
        ImageList listView_ImageList2 = new ImageList();
        TOUR tour = new TOUR();
        List<DIADIEM> ListDiaDiem = new List<DIADIEM>();
        List<DIADIEM> ListTatCaDiaDiem = new List<DIADIEM>();

        public AddLocationForTour(string id)
        {
            InitializeComponent();
            ID = id;
            Init();
        }

        private void Init()
        {

            //if (listView1 != null)
            //{ 
            //    listView1.Items.Clear();
            //}
            //if (listView_ImageList != null)
            //{
            //    listView_ImageList.Images.Clear(); 
            //}
            var result2 = (from dd in DataProvider.Ins.DB.DIADIEMs
                          join tb_belong in DataProvider.Ins.DB.tb_DIADIEM_DULICH on dd.ID equals tb_belong.IDDIADIEM
                          where tb_belong.IDTOUR == ID && tb_belong.IsDeleted==false
                          select dd)
                                     .ToList();
            var result = (from dd in DataProvider.Ins.DB.DIADIEMs
                          where dd.IsDeleted==false
                           select dd)
                         .ToList();
            int i = 0;
            foreach (DIADIEM diadiem in result2)
            {
                ListDiaDiem.Add(diadiem);
                var listViewItem = listView2.Items.Add(diadiem.TEN);
                listView_ImageList2.Images.Add(i.ToString(), Converter.Instance.ByteArrayToImage(diadiem.PICBI));
                listViewItem.ImageKey = i.ToString();
                i++;
            }

            foreach (DIADIEM diadiem in result)
            {
                ListTatCaDiaDiem.Add(diadiem);

                var listViewItem = listView1.Items.Add(diadiem.TEN);
                listView_ImageList1.Images.Add(i.ToString(), Converter.Instance.ByteArrayToImage(diadiem.PICBI));
                listViewItem.ImageKey = i.ToString();
                i++;
            }
            listView_ImageList1.ImageSize = new Size(100, 100);
            listView_ImageList2.ImageSize = new Size(100, 100);

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
                DIADIEM dd = ListTatCaDiaDiem[listView1.SelectedItems[0].Index];
                if (ListDiaDiem.Contains(dd))
                {
                    return;
                }

                ListDiaDiem.Add(dd);
                string randomkey = Converter.Instance.RandomString(5);
                var listViewItem = listView2.Items.Add(dd.TEN);
                listView_ImageList2.Images.Add(randomkey, Converter.Instance.ByteArrayToImage(dd.PICBI));
                listViewItem.ImageKey = randomkey;
            }
            catch (Exception ex)
            {

            }
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                ListDiaDiem.Remove(ListDiaDiem[listView2.SelectedItems[0].Index]);
                listView_ImageList2.Images.RemoveAt(listView2.SelectedItems[0].Index);
                listView2.Items.RemoveAt(listView2.SelectedItems[0].Index);
            }
            catch (Exception ex)
            {

            }
        }

        private void btngunaUpdate_Click(object sender, EventArgs e)
        {
            foreach (var tb_diadiem in DataProvider.Ins.DB.tb_DIADIEM_DULICH.Where(x => x.IDTOUR == ID && x.IsDeleted == false))
            {
                tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == ID && x.IsDeleted == false).FirstOrDefault();
                tour.GIA = tour.GIA - DataProvider.Ins.DB.DIADIEMs.Where(x => x.ID == tb_diadiem.IDDIADIEM).FirstOrDefault().GIA;

                DataProvider.Ins.DB.tb_DIADIEM_DULICH.Remove(tb_diadiem);
            }
            DataProvider.Ins.DB.SaveChanges();

            foreach (DIADIEM diadiem in ListDiaDiem)
            {
                string random1 = Converter.Instance.RandomString2(5);
                while (DataProvider.Ins.DB.tb_DIADIEM_DULICH.Where(x => x.ID == random1&& x.IsDeleted==false).FirstOrDefault() != null)
                {
                    random1 = Converter.Instance.RandomString2(5);
                }

                DataProvider.Ins.DB.tb_DIADIEM_DULICH.Add(new tb_DIADIEM_DULICH() { ID = random1, IDDIADIEM = diadiem.ID, IDTOUR = ID,IsDeleted=false });
                tour = DataProvider.Ins.DB.TOURs.Where(x => x.ID == ID && x.IsDeleted == false).FirstOrDefault();
                tour.GIA = tour.GIA + DataProvider.Ins.DB.DIADIEMs.Where(x => x.ID == diadiem.ID).FirstOrDefault().GIA;
                DataProvider.Ins.DB.SaveChanges();

            }

            this.Close();
        }

        private void btngunaExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
