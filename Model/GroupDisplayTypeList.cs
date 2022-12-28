using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Model
{
    public class GroupDisplayTypeList
    {
        private static GroupDisplayTypeList instance;

        public static GroupDisplayTypeList Instance
        {
            get { if (instance == null) instance = new GroupDisplayTypeList(); return GroupDisplayTypeList.instance; }
            private set { GroupDisplayTypeList.instance = value; }
        }
        private GroupDisplayTypeList()
        {

        }

        public List<GroupDisplayType> AllType(string search_ID = "", string search_Name="")
        {
            string value = "";
            if(string.Empty.CompareTo(search_ID.Trim()) != 0)
            {
                value=search_ID.Trim();

                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.ID.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = (
                                        doan.NGAYKHOIHANH > DateTime.Today ? "Planning" :
                                        doan.NGAYKHOIHANH <= DateTime.Today && doan.NGAYKETTHUC > DateTime.Today ? "Ongoing" :
                                        doan.NGAYKETTHUC < DateTime.Today ? "Ended" : ""

                                        ),

                        }).ToList();
            }
            else if(string.Empty.CompareTo(search_Name.Trim()) != 0)
            {
                value = search_Name.Trim();

                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.TEN.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = (
                                        doan.NGAYKHOIHANH > DateTime.Today ? "Planning" :
                                        doan.NGAYKHOIHANH <= DateTime.Today && doan.NGAYKETTHUC > DateTime.Today ? "Ongoing" :
                                        doan.NGAYKETTHUC < DateTime.Today  ? "Ended" : ""

                                        ),

                        }).ToList();
            }
            else
            {
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = (
                                        doan.NGAYKHOIHANH > DateTime.Today ? "Planning" :
                                        doan.NGAYKHOIHANH <= DateTime.Today && doan.NGAYKETTHUC > DateTime.Today ? "Ongoing" :
                                        doan.NGAYKETTHUC < DateTime.Today ? "Ended" : ""

                                        ),

                        }).ToList();
            }

        }


        public List<GroupDisplayType> PlanningType(string search_ID = "", string search_Name = "")
        {
            string value = "";
            if (string.Empty.CompareTo(search_ID.Trim()) != 0)
            {
                value = search_ID.Trim();
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKHOIHANH > DateTime.Today && doan.ID.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = "Planning"

                        }).ToList();
            }
            else if (string.Empty.CompareTo(search_Name.Trim()) != 0)
            {
                value = search_Name.Trim();
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKHOIHANH > DateTime.Today && doan.TEN.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = "Planning"

                        }).ToList();
            }
            else
            {
                return (from doan in DataProvider.Ins.DB.DOANs
                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                    where doan.IsDeleted == false && tour.IsDeleted == false &&doan.NGAYKHOIHANH > DateTime.Today
                    select new GroupDisplayType
                    {
                        ID = doan.ID,
                        TEN = doan.TEN,
                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                        NGAYKETTHUC = doan.NGAYKETTHUC,
                        CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                        GIA_TOUR = tour.GIA,
                        TEN_TOUR = tour.TEN,
                        ID_TOUR = tour.ID,
                        STATUS = "Planning"

                    }).ToList();
            }
              

        }
        public List<GroupDisplayType> OngoingType(string search_ID = "", string search_Name = "")
        {

            string value = "";
            if (string.Empty.CompareTo(search_ID.Trim()) != 0)
            {
                value = search_ID.Trim();
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKHOIHANH <= DateTime.Today && doan.NGAYKETTHUC >= DateTime.Today && doan.ID.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = "Ongoing"

                        }).ToList();
            }
            else if (string.Empty.CompareTo(search_Name.Trim()) != 0)
            {
                value = search_Name.Trim();
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKHOIHANH <= DateTime.Today && doan.NGAYKETTHUC >= DateTime.Today && doan.TEN.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = "Ongoing"

                        }).ToList();
            }
            else
            {
            return (from doan in DataProvider.Ins.DB.DOANs
                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                    where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKHOIHANH <= DateTime.Today && doan.NGAYKETTHUC >= DateTime.Today

                    select new GroupDisplayType
                    {
                        ID = doan.ID,
                        TEN = doan.TEN,
                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                        NGAYKETTHUC = doan.NGAYKETTHUC,
                        CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                        GIA_TOUR = tour.GIA,
                        TEN_TOUR = tour.TEN,
                        ID_TOUR = tour.ID,
                        STATUS = "Ongoing"

                    }).ToList();
            }


        }

        public List<GroupDisplayType> EndedType(string search_ID = "", string search_Name = "")
        {
            string value = "";
            if (string.Empty.CompareTo(search_ID.Trim()) != 0)
            {
                value = search_ID.Trim();
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKETTHUC < DateTime.Today && doan.ID.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = "Ended"

                        }).ToList();
            }
            else if (string.Empty.CompareTo(search_Name.Trim()) != 0)
            {
                value = search_Name.Trim();
                return (from doan in DataProvider.Ins.DB.DOANs
                        join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                        where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKETTHUC < DateTime.Today&&doan.TEN.Contains(value)

                        select new GroupDisplayType
                        {
                            ID = doan.ID,
                            TEN = doan.TEN,
                            NGAYKHOIHANH = doan.NGAYKHOIHANH,
                            NGAYKETTHUC = doan.NGAYKETTHUC,
                            CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                            GIA_TOUR = tour.GIA,
                            TEN_TOUR = tour.TEN,
                            ID_TOUR = tour.ID,
                            STATUS = "Ended"

                        }).ToList();
            }
            else
            {
            return (from doan in DataProvider.Ins.DB.DOANs
                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                    where doan.IsDeleted == false && tour.IsDeleted == false && doan.NGAYKETTHUC < DateTime.Today

                    select new GroupDisplayType
                    {
                        ID = doan.ID,
                        TEN = doan.TEN,
                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                        NGAYKETTHUC = doan.NGAYKETTHUC,
                        CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                        GIA_TOUR = tour.GIA,
                        TEN_TOUR = tour.TEN,
                        ID_TOUR = tour.ID,
                        STATUS = "Ended"

                    }).ToList();
            }

        }
    }
}
