using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2Fapx : WA
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
        private string m_filler10;
        private string m_num_of_addrs;
        private AddrRange_apx[] m_addr_x_list = new AddrRange_apx[21];

        // Default constructor
        public Wa2Fapx()
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
            m_filler10 = new string(' ', 114);
            m_num_of_addrs = new string(' ', 4);
            for (int i = 0; i < 21; i++)
                m_addr_x_list[i] = new AddrRange_apx();
        }

        // Constructor with a string input
        public Wa2Fapx(string inString)
        {
            Wa2FapxFromString(inString);
        }

        // Clear method
        public override void Clear()
        {
            Wa2FapxFromString(new string(' ', 2800));
        }

        // ToString method
        public override string ToString()
        {
            return Wa2FapxToString();
        }

        // FromString method
        public override void FromString(string inString)
        {
            Wa2FapxFromString(inString);
        }

        // Convert the object to a string
        public string Wa2FapxToString()
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
            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
            }
            sb.Append(m_filler10);
            sb.Append(m_num_of_addrs);
            for (int i = 0; i < 21; i++)
            {
                sb.Append(m_addr_x_list[i].AddrRange_apxToString());
            }

            return sb.ToString();
        }

        // Convert a string to an object
        public void Wa2FapxFromString(string inString)
        {
            int i;
            m_gridkey1 = new VsamKey1(inString.Substring(0, 21));
            m_cont_parity_ind = inString.Substring(21, 1);
            m_lohns = inString.Substring(22, 11);
            m_bbl = new BBL(inString.Substring(33, 10));
            m_filler1 = inString.Substring(43, 7);
            m_num_of_bldgs = inString.Substring(50, 4);
            m_filler2 = inString.Substring(54, 26);
            m_res_internal_use = inString.Substring(80, 1);
            m_bin = new BIN(inString.Substring(81, 7));
            m_condo_flag = inString.Substring(88, 1);
            m_filler3 = inString.Substring(89, 1);
            m_condo_num = inString.Substring(90, 4);
            m_filler4 = inString.Substring(94, 7);
            m_condo_bill_bbl = new BBL(inString.Substring(101, 10));
            m_filler5 = inString.Substring(111, 2);
            m_condo_lo_bbl = new BBL(inString.Substring(113, 10));
            m_filler6 = inString.Substring(123, 1);
            m_condo_hi_bbl = new BBL(inString.Substring(124, 10));
            m_filler7 = inString.Substring(134, 16);
            m_coop_num = inString.Substring(150, 4);
            m_filler8 = inString.Substring(154, 25);
            m_latitude = inString.Substring(179, 9);
            m_longitude = inString.Substring(188, 11);
            m_x_coord = inString.Substring(199, 7);
            m_y_coord = inString.Substring(206, 7);
            m_filler9 = inString.Substring(213, 16);
            m_ap_id = inString.Substring(229, 9);

            for (i = 0; i < 4; i++)
            {
                m_valid_lgcs[i] = inString.Substring(238 + (i * 2), 2);
            }

            m_filler10 = inString.Substring(246, 114);
            m_num_of_addrs = inString.Substring(360, 4);

            for (i = 0; i < 21; i++)
            {
                m_addr_x_list[i] = new AddrRange_apx(inString.Substring(364 + (i * 116), 116));
            }
        }

        // Display method
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_gridkey1.Display());
            sb.Append(c);
            sb.Append(m_cont_parity_ind);
            sb.Append(c);
            sb.Append(m_lohns);
            sb.Append(c);
            sb.Append(m_bbl.Display());
            sb.Append(c);
            sb.Append(m_filler1);
            sb.Append(c);
            sb.Append(m_num_of_bldgs);
            sb.Append(c);
            sb.Append(m_filler2);
            sb.Append(c);
            sb.Append(m_res_internal_use);
            sb.Append(c);
            sb.Append(m_bin.Display());
            sb.Append(c);
            sb.Append(m_condo_flag);
            sb.Append(c);
            sb.Append(m_filler3);
            sb.Append(c);
            sb.Append(m_condo_num);
            sb.Append(c);
            sb.Append(m_filler4);
            sb.Append(c);
            sb.Append(m_condo_bill_bbl.Display());
            sb.Append(c);
            sb.Append(c);
            sb.Append(m_filler7);
            sb.Append(c);
            sb.Append(m_coop_num);
            sb.Append(c);
            sb.Append(m_filler8);
            sb.Append(c);
            sb.Append(m_latitude);
            sb.Append(c);
            sb.Append(m_longitude);
            sb.Append(c);
            sb.Append(m_x_coord);
            sb.Append(c);
            sb.Append(m_y_coord);
            sb.Append(c);
            sb.Append(m_filler9);
            sb.Append(c);
            sb.Append(m_ap_id);
            sb.Append(c);

            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(c);
            sb.Append(m_filler10);
            sb.Append(c);
            sb.Append(m_num_of_addrs);
            sb.Append(c);

            // Arrays are zero-based, so there are 21 entries below
            for (int i = 0; i < 21; i++)
            {
                sb.Append(m_addr_x_list[i].Display());
                sb.Append(c);
            }

            return sb.ToString();

        }

        public override string Display()
        {
            return this.Display('-');
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
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);
            sb.AppendFormat("ap_id = {0}{1}", m_ap_id, Environment.NewLine);

            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);
            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            for (int i = 0; i < 21; i++)
            {
                sb.AppendFormat("addr_x_list({0}) = {1}{2}", i, m_addr_x_list[i].Display(), Environment.NewLine);
            }

            return sb.ToString();
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "*****************************  Wa2Fapx  *********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Keys  **********", Environment.NewLine);

            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lohns = {0}{1}", m_lohns, Environment.NewLine);
            sb.AppendFormat("filler1 = {0}{1}", m_filler1, Environment.NewLine);
            sb.AppendFormat("filler2 = {0}{1}", m_filler2, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("bbl = {0}{1}", m_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("res_internal_use = {0}{1}", m_res_internal_use, Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("ap_id = {0}{1}", m_ap_id, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Lot Level Information  **********", Environment.NewLine);

            sb.AppendFormat("num_of_bldgs = {0}{1}", m_num_of_bldgs, Environment.NewLine);
            sb.AppendFormat("coop_num = {0}{1}", m_coop_num, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Condo Information  **********", Environment.NewLine);

            sb.AppendFormat("condo_flag = {0}{1}", m_condo_flag, Environment.NewLine);
            sb.AppendFormat("condo_num = {0}{1}", m_condo_num, Environment.NewLine);
            sb.AppendFormat("condo_bill_bbl = {0}{1}", m_condo_bill_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_lo_bbl = {0}{1}", m_condo_lo_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_hi_bbl = {0}{1}", m_condo_hi_bbl.Display(), Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  XYs and Lat/Longs  **********", Environment.NewLine);

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
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("filler4 = {0}{1}", m_filler4, Environment.NewLine);
            sb.AppendFormat("filler5 = {0}{1}", m_filler5, Environment.NewLine);
            sb.AppendFormat("filler6 = {0}{1}", m_filler6, Environment.NewLine);
            sb.AppendFormat("filler7 = {0}{1}", m_filler7, Environment.NewLine);
            sb.AppendFormat("filler8 = {0}{1}", m_filler8, Environment.NewLine);
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);
            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Number of Addresses  **********", Environment.NewLine);
            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}{2}{3}{4}{5}{6}",
                            "Type ", "BIN     ", "         Low HND ", "        High HND ", "B7SC       ", "Street Name     ", Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < 21; i++)
            {
                sb.AppendFormat("{0}{1}{2}{3}{4}{5}{6}",
                                addr_x_list[i].addr_type + "    ",
                                addr_x_list[i].bin.ToString() + " ",
                                addr_x_list[i].lhnd + " ",
                                addr_x_list[i].hhnd + " ",
                                addr_x_list[i].b7sc.Display() + " ",
                                addr_x_list[i].stname,
                                Environment.NewLine);
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
            set => m_cont_parity_ind = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string lohns
        {
            get => m_lohns;
            set => m_lohns = value.Substring(0, Math.Min(value.Length, 11));
        }

        public BBL bbl
        {
            get => m_bbl;
            set => m_bbl = value;
        }

        public string filler1
        {
            get => m_filler1;
            set => m_filler1 = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string num_of_bldgs
        {
            get => m_num_of_bldgs;
            set => m_num_of_bldgs = value.Substring(0, Math.Min(value.Length, 4));
        }

        public string filler2
        {
            get => m_filler2;
            set => m_filler2 = value.Substring(0, Math.Min(value.Length, 26));
        }

        public string res_internal_use
        {
            get => m_res_internal_use;
            set => m_res_internal_use = value.Substring(0, Math.Min(value.Length, 1));
        }

        public BIN bin
        {
            get => m_bin;
            set => m_bin = value;
        }

        public string condo_flag
        {
            get => m_condo_flag;
            set => m_condo_flag = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string filler3
        {
            get => m_filler3;
            set => m_filler3 = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string condo_num
        {
            get => m_condo_num;
            set => m_condo_num = value.Substring(0, Math.Min(value.Length, 4));
        }

        public string filler4
        {
            get => m_filler4;
            set => m_filler4 = value.Substring(0, Math.Min(value.Length, 7));
        }

        public BBL condo_bill_bbl
        {
            get => m_condo_bill_bbl;
            set => m_condo_bill_bbl = value;
        }

        public string filler5
        {
            get => m_filler5;
            set => m_filler5 = value.Substring(0, Math.Min(value.Length, 2));
        }

        public BBL condo_lo_bbl
        {
            get => m_condo_lo_bbl;
            set => m_condo_lo_bbl = value;
        }

        public string filler6
        {
            get => m_filler6;
            set => m_filler6 = value.Substring(0, Math.Min(value.Length, 1));
        }

        public BBL condo_hi_bbl
        {
            get => m_condo_hi_bbl;
            set => m_condo_hi_bbl = value;
        }

        public string filler7
        {
            get => m_filler7;
            set => m_filler7 = value.Substring(0, Math.Min(value.Length, 16));
        }

        public string coop_num
        {
            get => m_coop_num;
            set => m_coop_num = value.Substring(0, Math.Min(value.Length, 4));
        }

        public string filler8
        {
            get => m_filler8;
            set => m_filler8 = value.Substring(0, Math.Min(value.Length, 25));
        }

        public string latitude
        {
            get => m_latitude;
            set => m_latitude = value.Substring(0, Math.Min(value.Length, 9));
        }

        public string longitude
        {
            get => m_longitude;
            set => m_longitude = value.Substring(0, Math.Min(value.Length, 11));
        }

        public string x_coord
        {
            get => m_x_coord;
            set => m_x_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string y_coord
        {
            get => m_y_coord;
            set => m_y_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string filler9
        {
            get => m_filler9;
            set => m_filler9 = value.Substring(0, Math.Min(value.Length, 16));
        }

        public string ap_id
        {
            get => m_ap_id;
            set => m_ap_id = value.Substring(0, Math.Min(value.Length, 9));
        }

        [XmlArrayItem("lgc", typeof(string))]
        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string valid_lgcs_item(int index) => m_valid_lgcs[index];

        public void valid_lgcs_item(int index, string value) => m_valid_lgcs[index] = value.Substring(0, Math.Min(value.Length, 2));
        
        public string filler10
        {
            get => m_filler10;
            set => m_filler10 = value.Substring(0, Math.Min(value.Length, 114));
        }

        public string num_of_addrs
        {
            get => m_num_of_addrs;
            set => m_num_of_addrs = value.Substring(0, Math.Min(value.Length, 4));
        }

        public AddrRange_apx[] addr_x_list
        {
            get => m_addr_x_list;
            set => m_addr_x_list = value;
        }

        public AddrRange_apx addr_x_list_item(int index) => m_addr_x_list[index];
        public void addr_x_list_item(int index, AddrRange_apx value) => m_addr_x_list[index] = value;
        

    }
}
