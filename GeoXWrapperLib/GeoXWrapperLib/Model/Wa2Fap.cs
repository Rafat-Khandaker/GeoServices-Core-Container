using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2Fap : WA
    {
        private VsamKey1 m_gridkey1;
        private string m_cont_parity_ind;
        private string m_lohns;
        private BBL m_bbl;
        private string m_filler1;
        private string m_num_of_bldgs;
        private string m_filler2;
        private string m_res_internal_use;
        private BIN m_bin;
        private string m_condo_flag;
        private string m_filler3;
        private string m_condo_num;
        private string m_filler4;
        private BBL m_condo_bill_bbl;
        private string m_filler5;
        private BBL m_condo_lo_bbl;
        private string m_filler6;
        private BBL m_condo_hi_bbl;
        private string m_filler7;
        private string m_coop_num;
        private string m_filler8;
        private string m_latitude;
        private string m_longitude;
        private string m_x_coord;
        private string m_y_coord;
        private string m_filler9;
        private string m_ap_id;
        private string[] m_valid_lgcs = new string[4];
        private string m_num_of_addrs;
        private AddrRange_ap[] m_addr_list = new AddrRange_ap[21];

        /// <summary>Constructor for <c>Wa2Fap</c></summary>
        public Wa2Fap()
        {
            m_gridkey1 = new VsamKey1();
            m_cont_parity_ind = new string(' ', 1);
            m_lohns = new string(' ', 11);
            m_bbl = new BBL();
            m_filler1 = new string(' ', 7);
            m_num_of_bldgs = new string(' ', 4);
            m_filler2 = new string(' ', 26);
            m_res_internal_use = new string(' ', 1);
            m_bin = new BIN();
            m_condo_flag = new string(' ', 1);
            m_filler3 = new string(' ', 1);
            m_condo_num = new string(' ', 4);
            m_filler4 = new string(' ', 7);
            m_condo_bill_bbl = new BBL();
            m_filler5 = new string(' ', 2);
            m_condo_lo_bbl = new BBL();
            m_filler6 = new string(' ', 1);
            m_condo_hi_bbl = new BBL();
            m_filler7 = new string(' ', 16);
            m_coop_num = new string(' ', 4);
            m_filler8 = new string(' ', 25);
            m_latitude = new string(' ', 9);
            m_longitude = new string(' ', 11);
            m_x_coord = new string(' ', 7);
            m_y_coord = new string(' ', 7);
            m_filler9 = new string(' ', 16);
            m_ap_id = new string(' ', 9);
            for (int i = 0; i < 4; i++)
                m_valid_lgcs[i] = new string(' ', 2);
            m_num_of_addrs = new string(' ', 4);
            for (int i = 0; i < 21; i++)
                m_addr_list[i] = new AddrRange_ap();
        }

        /// <summary>Constructor for <c>Wa2Fap</c></summary>
        public Wa2Fap(string inString) => Wa2FapFromString(inString);

        /// <summary><c>Clear</c> reinitializes the <c>Wa2Fap</c> object to spaces</summary>
        public override void Clear() => Wa2FapFromString(new string(' ', 1363));

        /// <summary><c>ToString</c> converts a <c>Wa2Fap</c> object to a string</summary>
        public override string ToString() => Wa2FapToString();

        /// <summary><c>FromString</c> converts a string to a <c>Wa2Fap</c> object</summary>
        public override void FromString(string inString) => Wa2FapFromString(inString);

        /// <summary><c>Wa2FapToString</c> converts a <c>Wa2Fap</c> object to a string</summary>
        public string Wa2FapToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_gridkey1.VsamKey1ToString());
            sb.Append(m_cont_parity_ind);
            sb.Append(m_lohns);
            sb.Append(m_bbl.BBLToString());
            sb.Append(m_filler1);
            sb.Append(m_num_of_bldgs);
            sb.Append(m_filler2);
            sb.Append(m_res_internal_use);
            sb.Append(m_bin.BINToString());
            sb.Append(m_condo_flag);
            sb.Append(m_filler3);
            sb.Append(m_condo_num);
            sb.Append(m_filler4);
            sb.Append(m_condo_bill_bbl.BBLToString());
            sb.Append(m_filler5);
            sb.Append(m_condo_lo_bbl.BBLToString());
            sb.Append(m_filler6);
            sb.Append(m_condo_hi_bbl.BBLToString());
            sb.Append(m_filler7);
            sb.Append(m_coop_num);
            sb.Append(m_filler8);
            sb.Append(m_latitude);
            sb.Append(m_longitude);
            sb.Append(m_x_coord);
            sb.Append(m_y_coord);
            sb.Append(m_filler9);
            sb.Append(m_ap_id);
            foreach (var lgc in m_valid_lgcs)
                sb.Append(lgc);
            sb.Append(m_num_of_addrs);
            foreach (var addr in m_addr_list)
                sb.Append(addr.AddrRange_apToString());
            return sb.ToString();
        }

        /// <summary><c>Wa2FapFromString</c> converts a string to a <c>Wa2Fap</c> object</summary>
        public void Wa2FapFromString(string inString)
        {
            try { m_gridkey1 = new VsamKey1(inString.Substring(0, 21)); } catch { m_gridkey1 = new VsamKey1(); }
            try { m_cont_parity_ind = inString.Substring(21, 1); } catch { m_cont_parity_ind = string.Empty;  }
            try { m_lohns = inString.Substring(22, 11); } catch { m_lohns = string.Empty; }
            try { m_lohns = inString.Substring(22, 11); } catch { m_lohns = string.Empty; }
            try { m_bbl = new BBL(inString.Substring(33, 21)); } catch { m_bbl = new BBL(); }
            try { m_filler1 = inString.Substring(54, 7); } catch { m_filler1 = string.Empty; }
            try { m_num_of_bldgs = inString.Substring(61, 4); } catch { m_num_of_bldgs = string.Empty; }
            try { m_filler2 = inString.Substring(65, 26); } catch { m_filler2 = string.Empty; }
            try { m_res_internal_use = inString.Substring(91, 1); } catch { m_res_internal_use = string.Empty; }
            try { m_bin = new BIN(inString.Substring(92, 9)); } catch { m_bin = new BIN(); }
            try { m_condo_flag = inString.Substring(101, 1); } catch { m_condo_flag = string.Empty; }
            try { m_filler3 = inString.Substring(102, 1); } catch { m_filler3 = string.Empty; }
            try { m_condo_num = inString.Substring(103, 4); } catch { m_condo_num = string.Empty; }
            try { m_filler4 = inString.Substring(107, 7); } catch { m_filler4 = string.Empty; }
            try { m_condo_bill_bbl = new BBL(inString.Substring(114, 21)); } catch { m_condo_bill_bbl = new BBL(); }
            try { m_filler5 = inString.Substring(135, 2); } catch { m_filler5 = string.Empty; }
            try { m_condo_lo_bbl = new BBL(inString.Substring(137, 21)); } catch { m_condo_lo_bbl = new BBL();  }


            try { m_filler6 = inString.Substring(158, 1); } catch { m_filler6 = string.Empty; }
            try { m_condo_hi_bbl = new BBL(inString.Substring(159, 21)); } catch { m_condo_hi_bbl = new BBL(); }
            try { m_filler7 = inString.Substring(180, 16); } catch { m_filler7 = string.Empty; }
            try { m_coop_num = inString.Substring(196, 4); } catch { m_coop_num = string.Empty; }
            try { m_filler8 = inString.Substring(200, 25); } catch { m_filler8 = string.Empty; }
            try { m_latitude = inString.Substring(225, 9); } catch { m_latitude = string.Empty; }


            try { m_longitude = inString.Substring(234, 11); } catch { m_longitude = string.Empty; }
            try { m_x_coord = inString.Substring(245, 7); } catch { m_x_coord = string.Empty; }
            try { m_y_coord = inString.Substring(252, 7); } catch { m_y_coord = string.Empty; }
            try { m_filler9 = inString.Substring(259, 16); } catch { m_filler9 = string.Empty; }

            try { m_ap_id = inString.Substring(275, 9); } catch { m_ap_id = string.Empty; }
                
            for (int i = 0; i < 4; i++)
                try { m_valid_lgcs[i] = inString.Substring(284 + (i * 2), 2); } catch { m_valid_lgcs[i] = string.Empty; }
                
            m_num_of_addrs = inString.Substring(296, 4);
            for (int i = 0; i < 21; i++)
                try { m_addr_list[i] = new AddrRange_ap(inString.Substring(300 + (i * 20), 20)); } catch { m_addr_list[i] = new AddrRange_ap(); }

        }


        // Overloaded method with character separator
        public override string Display(char separator)
        {
            var sb = new StringBuilder();

            sb.Append(m_gridkey1.Display());
            sb.Append(separator);
            sb.Append(m_cont_parity_ind);
            sb.Append(separator);
            sb.Append(m_lohns);
            sb.Append(separator);
            sb.Append(m_bbl.Display());
            sb.Append(separator);
            sb.Append(m_filler1);
            sb.Append(separator);
            sb.Append(m_num_of_bldgs);
            sb.Append(separator);
            sb.Append(m_filler2);
            sb.Append(separator);
            sb.Append(m_res_internal_use);
            sb.Append(separator);
            sb.Append(m_bin.Display());
            sb.Append(separator);
            sb.Append(m_condo_flag);
            sb.Append(separator);
            sb.Append(m_filler3);
            sb.Append(separator);
            sb.Append(m_condo_num);
            sb.Append(separator);
            sb.Append(m_filler4);
            sb.Append(separator);
            sb.Append(m_condo_bill_bbl.Display());
            sb.Append(separator);
            sb.Append(m_filler5);
            sb.Append(separator);
            sb.Append(m_condo_lo_bbl.Display());
            sb.Append(separator);
            sb.Append(m_filler6);
            sb.Append(separator);
            sb.Append(m_condo_hi_bbl.Display());
            sb.Append(separator);
            sb.Append(m_filler7);
            sb.Append(separator);
            sb.Append(m_coop_num);
            sb.Append(separator);
            sb.Append(m_filler8);
            sb.Append(separator);
            sb.Append(m_latitude);
            sb.Append(separator);
            sb.Append(m_longitude);
            sb.Append(separator);
            sb.Append(m_x_coord);
            sb.Append(separator);
            sb.Append(m_y_coord);
            sb.Append(separator);
            sb.Append(m_filler9);
            sb.Append(separator);
            sb.Append(m_ap_id);
            sb.Append(separator);

            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(separator);
            }

            sb.Append(m_num_of_addrs);
            sb.Append(separator);

            for (int i = 0; i < 21; i++)
            {
                sb.Append(m_addr_list[i].Display());
                sb.Append(separator);
            }

            return sb.ToString();
        }

        // Overloaded method with default separator (dash)
        public override string Display()
        {
            return Display('-');
        }

        public override string Print()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lohns = {0}{1}", m_lohns, Environment.NewLine);
            sb.AppendFormat("bbl = {0}{1}", m_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler1 = {0}{1}", m_filler1, Environment.NewLine);
            sb.AppendFormat("num_of_bldgs = {0}{1}", m_num_of_bldgs, Environment.NewLine);
            sb.AppendFormat("filler2 = {0}{1}", m_filler2, Environment.NewLine);
            sb.AppendFormat("res_internal_use = {0}{1}", m_res_internal_use, Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("condo_flag = {0}{1}", m_condo_flag, Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("condo_num = {0}{1}", m_condo_num, Environment.NewLine);
            sb.AppendFormat("filler4 = {0}{1}", m_filler4, Environment.NewLine);
            sb.AppendFormat("condo_bill_bbl = {0}{1}", m_condo_bill_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler5 = {0}{1}", m_filler5, Environment.NewLine);
            sb.AppendFormat("condo_lo_bbl = {0}{1}", m_condo_lo_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler6 = {0}{1}", m_filler6, Environment.NewLine);
            sb.AppendFormat("condo_hi_bbl = {0}{1}", m_condo_hi_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler7 = {0}{1}", m_filler7, Environment.NewLine);
            sb.AppendFormat("coop_num = {0}{1}", m_coop_num, Environment.NewLine);
            sb.AppendFormat("filler8 = {0}{1}", m_filler8, Environment.NewLine);
            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);
            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Valid LGCs  **********", Environment.NewLine);

            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Fillers  **********", Environment.NewLine);
            sb.AppendFormat("filler1 = {0}{1}", m_filler1, Environment.NewLine);
            sb.AppendFormat("filler2 = {0}{1}", m_filler2, Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("filler4 = {0}{1}", m_filler4, Environment.NewLine);
            sb.AppendFormat("filler5 = {0}{1}", m_filler5, Environment.NewLine);
            sb.AppendFormat("filler6 = {0}{1}", m_filler6, Environment.NewLine);
            sb.AppendFormat("filler7 = {0}{1}", m_filler7, Environment.NewLine);
            sb.AppendFormat("filler8 = {0}{1}", m_filler8, Environment.NewLine);
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Number of Addresses  **********", Environment.NewLine);
            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            // Uncomment and modify the code below if necessary for printing address information
            // sb.AppendFormat("{0}{1}{2}{3}{4}{5}",
            //                "Type" + "\t", "BIN" + "\t", "   Low HND" + "\t", "   High HND" + "\t", "B7SC" + "\t" + "\t",
            //                Environment.NewLine + Environment.NewLine);
            // for (int i = 0; i < 21; i++)
            // {
            //     sb.AppendFormat("{0}{1}{2}{3}{4}{5}",
            //                     addr_ap_list[i].addr_type + "\t", addr_ap_list[i].bin.ToString() + "\t",
            //                     addr_ap_list[i].lhnd + "\t", addr_ap_list[i].hhnd + "\t", addr_ap_list[i].b7sc.Display + "\t",
            //                     Environment.NewLine);
            // }

            sb.AppendFormat("{0}{1}{2}{3}{4}{5}",
                             "Type ", "BIN     ", "         Low HND ", "        High HND ", "B7SC       ", Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < 21; i++)
            {
                sb.AppendFormat("{0}{1}{2}{3}{4}{5}", 
                                 addr_ap_list[i].addr_type + "    ", addr_ap_list[i].bin.ToString() + " ",
                                 addr_ap_list[i].lhnd + " ", addr_ap_list[i].hhnd + " ", addr_ap_list[i].b7sc.Display(),
                                 Environment.NewLine);
                // sb.AppendFormat("addr_x_list({0}) = {1}{2}", i, m_addr_x_list[i].Display, Environment.NewLine);
            }

            return sb.ToString();

        }

        public VsamKey1 gridkey1
        {
            get => m_gridkey1;
            set => m_gridkey1 = value;
        }

        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set => m_cont_parity_ind = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string lohns
        {
            get => m_lohns;
            set => m_lohns = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        public BBL bbl
        {
            get => m_bbl;
            set => m_bbl = value;
        }

        public string filler1
        {
            get => m_filler1;
            set => m_filler1 = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string num_of_bldgs
        {
            get => m_num_of_bldgs;
            set => m_num_of_bldgs = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string filler2
        {
            get => m_filler2;
            set => m_filler2 = value.Length > 26 ? value.Substring(0, 26) : value;
        }

        public string res_internal_use
        {
            get => m_res_internal_use;
            set => m_res_internal_use = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public BIN bin
        {
            get => m_bin;
            set => m_bin = value;
        }

        public string condo_flag
        {
            get => m_condo_flag;
            set => m_condo_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string filler3
        {
            get => m_filler3;
            set => m_filler3 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string condo_num
        {
            get => m_condo_num;
            set => m_condo_num = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string filler4
        {
            get => m_filler4;
            set => m_filler4 = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public BBL condo_bill_bbl
        {
            get => m_condo_bill_bbl;
            set => m_condo_bill_bbl = value;
        }

        public string filler5
        {
            get => m_filler5;
            set => m_filler5 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public BBL condo_lo_bbl
        {
            get => m_condo_lo_bbl;
            set => m_condo_lo_bbl = value;
        }

        public string filler6
        {
            get => m_filler6;
            set => m_filler6 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public BBL condo_hi_bbl
        {
            get => m_condo_hi_bbl;
            set => m_condo_hi_bbl = value;
        }

        public string filler7
        {
            get => m_filler7;
            set => m_filler7 = value.Length > 16 ? value.Substring(0, 16) : value;
        }

        public string coop_num
        {
            get => m_coop_num;
            set => m_coop_num = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string filler8
        {
            get => m_filler8;
            set => m_filler8 = value.Length > 25 ? value.Substring(0, 25) : value;
        }

        public string latitude
        {
            get => m_latitude;
            set => m_latitude = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        public string longitude
        {
            get => m_longitude;
            set => m_longitude = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        public string x_coord
        {
            get => m_x_coord;
            set => m_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string y_coord
        {
            get => m_y_coord;
            set => m_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string filler9
        {
            get => m_filler9;
            set => m_filler9 = value.Length > 16 ? value.Substring(0, 16) : value;
        }

        [XmlArrayItem("lgc")]
        public string valid_lgcs
        {
            get => m_ap_id;
            set => m_ap_id = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        public string[] valid_lgcs_item
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string ValidLgcsItem(int index) => m_valid_lgcs[index];
        public void ValidLgcsItem(int index, string value) => m_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        
        public string num_of_addrs
        {
            get => m_num_of_addrs;
            set => m_num_of_addrs = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public AddrRange_ap[] addr_ap_list
        {
            get => m_addr_list;
            set => m_addr_list = value;
        }

        public AddrRange_ap addr_ap_list_item(int index) => m_addr_list[index];
        public void addr_ap_list_item(int index, AddrRange_ap value) => m_addr_list[index] = value;
    }
}
