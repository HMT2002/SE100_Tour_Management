using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.CollectionLists
{
    public class DALTourModel
    {
        public DALTourModel() { }
        string tentour;
        public string TENTOUR { get => tentour; set => tentour = value; }
        string idtour;
        public string IDTOUR { get => idtour; set => idtour = value; }
        string id;
        public string ID { get => id; set => id = value; }
        double gia;
        public double GIA { get => gia; set => gia = value; }

        byte[] banner;
        public byte[] BANNER { get => banner; set => banner = value; }
        string tourtype;
        public string TOURTYPE { get => tourtype; set => tourtype = value; }

        string dacdiem;
        public string DACDIEM { get => dacdiem; set => dacdiem = value; }
    }

    public class DALTourCollection
    {
        public DALTourCollection() { }

        public List<DALTourModel> AvailableTourList()
        {
            return (from tour in DataProvider.Ins.DB.TOURs
                    join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                    where tour.IsDeleted == false && doan.IsDeleted == false
                    select new DALTourModel
                    {
                        TENTOUR = tour.TEN,
                        IDTOUR = tour.ID,
                        GIA = (double)tour.GIA,
                    }
                ).ToList();
        }

        public List<DALTourModel> AllTourList()
        {
            return (from tour in DataProvider.Ins.DB.TOURs
                    join giamgia in DataProvider.Ins.DB.GIAMGIAs on tour.ID equals giamgia.IDTOUR
                    where tour.IsDeleted == false && giamgia.IsDeleted == false
                    group tour by new { tour, giamgia } into g
                    select new DALTourModel
                    {
                        ID = g.Key.tour.ID,
                        TENTOUR = g.Key.tour.TEN,
                        GIA = (double)g.Key.tour.GIA,
                        BANNER = g.Key.giamgia.PICBI,
                        TOURTYPE = g.Key.tour.LOAI,
                        DACDIEM = g.Key.tour.DACDIEM,
                    }).Distinct().ToList();
        }
    }
}
