using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1al : WA
    {
        private VsamKey1 m_gridkey1;
        private string m_cont_parity_ind;
        private string m_lohns;
        private BBL m_bbl;
        private string m_filler1;
        private string m_rpad_scc;
        private string m_filler2;
        private string m_rpad_bldg_class;
        private string m_corner_code;
        private string m_num_of_bldgs;
        private string m_num_of_blockfaces;
        private string m_interior_flag;
        private string m_vacant_flag;
        private string m_irreg_flag;
        private string m_mh_ri_flag;
        private string m_addr_overflow_flag;
        private string m_stroll_key;
        private string m_res_internal_use;
        private BIN m_bin;
        private string m_condo_flag;
        private string m_filler3;
        private string m_condo_num;
        private string m_filler4;
        private BBL m_condo_bill_bbl;
        private string m_filler5;
        private string m_condo_bill_scc;
        private BBL m_condo_lo_bbl;
        private string m_filler6;
        private BBL m_condo_hi_bbl;
        private string m_filler7;
        private string m_filler8;
        private string m_coop_num;
        private Sanborn m_sanborn;
        private BusArea m_business_area;
        private DofMap m_dof_map;
        private string m_filler9;
        private string m_latitude;
        private string m_longitude;
        private string m_x_coord;
        private string m_y_coord;
        private B5sc m_bid_id;
        private string m_TPAD_bin_status;
        private BIN m_TPAD_new_bin;
        private string m_TPAD_new_bin_status;
        private string m_TPAD_conflict_flag;
        private string m_filler10;
        private string[] m_valid_lgcs = new string[3];
        private string m_num_of_addrs;
        private BIN[] m_bin_list = new BIN[2500];

        public Wa2F1al()
        {
            m_gridkey1 = new VsamKey1();
            m_cont_parity_ind = new string(' ', 1);
            m_lohns = new string(' ', 11);
            m_bbl = new BBL();
            m_filler1 = new string(' ', 1);
            m_rpad_scc = new string(' ', 1);
            m_filler2 = new string(' ', 1);
            m_rpad_bldg_class = new string(' ', 2);
            m_corner_code = new string(' ', 2);
            m_num_of_bldgs = new string(' ', 4);
            m_num_of_blockfaces = new string(' ', 2);
            m_interior_flag = new string(' ', 1);
            m_vacant_flag = new string(' ', 1);
            m_irreg_flag = new string(' ', 1);
            m_mh_ri_flag = new string(' ', 1);
            m_addr_overflow_flag = new string(' ', 1);
            m_stroll_key = new string(' ', 19);
            m_res_internal_use = new string(' ', 1);
            m_bin = new BIN();
            m_condo_flag = new string(' ', 1);
            m_filler3 = new string(' ', 1);
            m_condo_num = new string(' ', 4);
            m_filler4 = new string(' ', 7);
            m_condo_bill_bbl = new BBL();
            m_filler5 = new string(' ', 1);
            m_condo_bill_scc = new string(' ', 1);
            m_condo_lo_bbl = new BBL();
            m_filler6 = new string(' ', 1);
            m_condo_hi_bbl = new BBL();
            m_filler7 = new string(' ', 1);
            m_filler8 = new string(' ', 15);
            m_coop_num = new string(' ', 4);
            m_sanborn = new Sanborn();
            m_business_area = new BusArea();
            m_dof_map = new DofMap();
            m_filler9 = new string(' ', 3);
            m_latitude = new string(' ', 9);
            m_longitude = new string(' ', 11);
            m_x_coord = new string(' ', 7);
            m_y_coord = new string(' ', 7);
            m_bid_id = new B5sc();
            m_TPAD_bin_status = new string(' ', 1);
            m_TPAD_new_bin = new BIN();
            m_TPAD_new_bin_status = new string(' ', 1);
            m_TPAD_conflict_flag = new string(' ', 1);
            m_filler10 = new string(' ', 9);

            for (int i = 0; i <= 3; i++)
            {
                try { m_valid_lgcs[i] = new string(' ', 2); } catch { m_valid_lgcs[i] = string.Empty; }
            }

            m_num_of_addrs = new string(' ', 4);

            for (int i = 0; i <= 2499 && i < m_bin_list.Length; i++)
            {
                m_bin_list[i] = new BIN();
            }
        }

        public Wa2F1al(string inString)
        {
            Wa2F1alFromString(inString);
        }

        public override void Clear()
        {
            Wa2F1alFromString(new string(' ', 17750));
        }

        public override string ToString()
        {
            return Wa2F1alToString();
        }

        public override void FromString(string inString)
        {
            Wa2F1alFromString(inString);
        }

        public override string Display(char separator)
        {
            StringBuilder sb = new StringBuilder();
            int i;

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
            sb.Append(m_rpad_scc);
            sb.Append(separator);
            sb.Append(m_filler2);
            sb.Append(separator);
            sb.Append(m_rpad_bldg_class);
            sb.Append(separator);
            sb.Append(m_corner_code);
            sb.Append(separator);
            sb.Append(m_num_of_bldgs);
            sb.Append(separator);
            sb.Append(m_num_of_blockfaces);
            sb.Append(separator);
            sb.Append(m_interior_flag);
            sb.Append(separator);
            sb.Append(m_vacant_flag);
            sb.Append(separator);
            sb.Append(m_irreg_flag);
            sb.Append(separator);
            sb.Append(m_mh_ri_flag);
            sb.Append(separator);
            sb.Append(m_addr_overflow_flag);
            sb.Append(separator);
            sb.Append(m_stroll_key);
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
            sb.Append(m_condo_bill_scc);
            sb.Append(separator);
            sb.Append(m_condo_lo_bbl.Display());
            sb.Append(separator);
            sb.Append(m_filler6);
            sb.Append(separator);
            sb.Append(m_condo_hi_bbl.Display());
            sb.Append(separator);
            sb.Append(m_filler7);
            sb.Append(separator);
            sb.Append(m_filler8);
            sb.Append(separator);
            sb.Append(m_coop_num);
            sb.Append(separator);
            sb.Append(m_sanborn.Display());
            sb.Append(separator);
            sb.Append(m_business_area.Display());
            sb.Append(separator);
            sb.Append(m_dof_map.Display());
            sb.Append(separator);
            sb.Append(m_filler9);
            sb.Append(separator);
            sb.Append(m_latitude);
            sb.Append(separator);
            sb.Append(m_longitude);
            sb.Append(separator);
            sb.Append(m_x_coord);
            sb.Append(separator);
            sb.Append(m_y_coord);
            sb.Append(separator);
            sb.Append(m_bid_id.Display());
            sb.Append(separator);
            sb.Append(m_TPAD_bin_status);
            sb.Append(separator);
            sb.Append(m_TPAD_new_bin.Display());
            sb.Append(separator);
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(separator);
            sb.Append(m_TPAD_conflict_flag);
            sb.Append(separator);
            sb.Append(m_filler10);
            sb.Append(separator);

            for (i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(separator);
            }

            sb.Append(m_num_of_addrs);
            sb.Append(separator);

            for (i = 0; i < 2500; i++)
            {
                sb.Append(m_bin_list[i].Display());
                sb.Append(separator);
            }

            return sb.ToString();
        }

        public override string Display()
        {
            return this.Display('-');
        }


        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lohns = {0}{1}", m_lohns, Environment.NewLine);
            sb.AppendFormat("bbl = {0}{1}", m_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler1 = {0}{1}", m_filler1, Environment.NewLine);
            sb.AppendFormat("rpad_scc = {0}{1}", m_rpad_scc, Environment.NewLine);
            sb.AppendFormat("filler2 = {0}{1}", m_filler2, Environment.NewLine);
            sb.AppendFormat("rpad_bldg_class = {0}{1}", m_rpad_bldg_class, Environment.NewLine);
            sb.AppendFormat("corner_code = {0}{1}", m_corner_code, Environment.NewLine);
            sb.AppendFormat("num_of_bldgs = {0}{1}", m_num_of_bldgs, Environment.NewLine);
            sb.AppendFormat("num_of_blockfaces = {0}{1}", m_num_of_blockfaces, Environment.NewLine);
            sb.AppendFormat("interior_flag = {0}{1}", m_interior_flag, Environment.NewLine);
            sb.AppendFormat("vacant_flag = {0}{1}", m_vacant_flag, Environment.NewLine);
            sb.AppendFormat("irreg_flag = {0}{1}", m_irreg_flag, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("addr_overflow_flag = {0}{1}", m_addr_overflow_flag, Environment.NewLine);
            sb.AppendFormat("stroll_key = {0}{1}", m_stroll_key, Environment.NewLine);
            sb.AppendFormat("res_internal_use = {0}{1}", m_res_internal_use, Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("condo_flag = {0}{1}", m_condo_flag, Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("condo_num = {0}{1}", m_condo_num, Environment.NewLine);
            sb.AppendFormat("filler4 = {0}{1}", m_filler4, Environment.NewLine);
            sb.AppendFormat("condo_bill_bbl = {0}{1}", m_condo_bill_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler5 = {0}{1}", m_filler5, Environment.NewLine);
            sb.AppendFormat("condo_bill_scc = {0}{1}", m_condo_bill_scc, Environment.NewLine);
            sb.AppendFormat("condo_lo_bbl = {0}{1}", m_condo_lo_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler6 = {0}{1}", m_filler6, Environment.NewLine);
            sb.AppendFormat("condo_hi_bbl = {0}{1}", m_condo_hi_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler7 = {0}{1}", m_filler7, Environment.NewLine);
            sb.AppendFormat("filler8 = {0}{1}", m_filler8, Environment.NewLine);
            sb.AppendFormat("coop_num = {0}{1}", m_coop_num, Environment.NewLine);
            sb.AppendFormat("sanborn = {0}{1}", m_sanborn.Display(), Environment.NewLine);
            sb.AppendFormat("business_area = {0}{1}", m_business_area.Display(), Environment.NewLine);
            sb.AppendFormat("dof_map = {0}{1}", m_dof_map.Display(), Environment.NewLine);

            //spo(2014-03-04):  added latitude, longitude
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);
            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);

            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);

            //spo(2009-07-17):  added new field BID
            sb.AppendFormat("bid_id = {0}{1}", m_bid_id.Display(), Environment.NewLine);

            //spo(2010-10-18):  added new fields for TPAD
            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin = {0}{1}", m_TPAD_new_bin.Display(), Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin_status = {0}{1}", m_TPAD_new_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_conflict_flag = {0}{1}", m_TPAD_conflict_flag, Environment.NewLine);
            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);

            for (i = 0; i < 4; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            for (i = 0; i < 2500; i++)
            {
                sb.AppendFormat("bin_list({0}) = {1}{2}", i, m_bin_list[i].Display(), Environment.NewLine);
            }

            return sb.ToString();
        }


        public string Wa2F1alToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_gridkey1.VsamKey1ToString());
            sb.Append(m_cont_parity_ind);
            sb.Append(m_lohns);
            sb.Append(m_bbl.BBLToString());
            sb.Append(m_filler1);
            sb.Append(m_rpad_scc);
            sb.Append(m_filler2);
            sb.Append(m_rpad_bldg_class);
            sb.Append(m_corner_code);
            sb.Append(m_num_of_bldgs);
            sb.Append(m_num_of_blockfaces);
            sb.Append(m_interior_flag);
            sb.Append(m_vacant_flag);
            sb.Append(m_irreg_flag);
            sb.Append(m_mh_ri_flag);
            sb.Append(m_addr_overflow_flag);
            sb.Append(m_stroll_key);
            sb.Append(m_res_internal_use);
            sb.Append(m_bin.BINToString());
            sb.Append(m_condo_flag);
            sb.Append(m_filler3);
            sb.Append(m_condo_num);
            sb.Append(m_filler4);
            sb.Append(m_condo_bill_bbl.BBLToString());
            sb.Append(m_filler5);
            sb.Append(m_condo_bill_scc);
            sb.Append(m_condo_lo_bbl.BBLToString());
            sb.Append(m_filler6);
            sb.Append(m_condo_hi_bbl.BBLToString());
            sb.Append(m_filler7);
            sb.Append(m_filler8);
            sb.Append(m_coop_num);
            sb.Append(m_sanborn.SanbornToString());
            sb.Append(m_business_area.BusAreaToString());
            sb.Append(m_dof_map.DofMapToString());
            sb.Append(m_filler9);
            sb.Append(m_latitude);
            sb.Append(m_longitude);
            sb.Append(m_x_coord);
            sb.Append(m_y_coord);
            sb.Append(m_bid_id.ToString());
            sb.Append(m_TPAD_bin_status);
            sb.Append(m_TPAD_new_bin.BINToString());
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(m_TPAD_conflict_flag);
            sb.Append(m_filler10);

            for (int i = 0; i <= 3; i++)
                sb.Append(m_valid_lgcs[i]);
            

            sb.Append(m_num_of_addrs);

            for (int i = 0; i <= 2499; i++)
                sb.Append(m_bin_list[i].BINToString());

            return sb.ToString();
        }


        public void Wa2F1alFromString(string inString)
        {
            int i;

            m_gridkey1 = new VsamKey1(inString.Substring(0, 21));
            m_cont_parity_ind = inString.Substring(21, 1);
            m_lohns = inString.Substring(22, 11);
            m_bbl = new BBL(inString.Substring(33, 10));
            m_filler1 = inString.Substring(43, 1);
            m_rpad_scc = inString.Substring(44, 1);
            m_filler2 = inString.Substring(45, 1);
            m_rpad_bldg_class = inString.Substring(46, 2);
            m_corner_code = inString.Substring(48, 2);
            m_num_of_bldgs = inString.Substring(50, 4);
            m_num_of_blockfaces = inString.Substring(54, 2);
            m_interior_flag = inString.Substring(56, 1);
            m_vacant_flag = inString.Substring(57, 1);
            m_irreg_flag = inString.Substring(58, 1);
            m_mh_ri_flag = inString.Substring(59, 1);
            m_addr_overflow_flag = inString.Substring(60, 1);
            m_stroll_key = inString.Substring(61, 19);
            m_res_internal_use = inString.Substring(80, 1);
            m_bin = new BIN(inString.Substring(81, 7));
            m_condo_flag = inString.Substring(88, 1);
            m_filler3 = inString.Substring(89, 1);
            m_condo_num = inString.Substring(90, 4);
            m_filler4 = inString.Substring(94, 7);
            m_condo_bill_bbl = new BBL(inString.Substring(101, 10));
            m_filler5 = inString.Substring(111, 1);
            m_condo_bill_scc = inString.Substring(112, 1);
            m_condo_lo_bbl = new BBL(inString.Substring(113, 10));
            m_filler6 = inString.Substring(123, 1);
            m_condo_hi_bbl = new BBL(inString.Substring(124, 10));
            m_filler7 = inString.Substring(134, 1);
            m_filler8 = inString.Substring(135, 15);
            m_coop_num = inString.Substring(150, 4);
            m_sanborn = new Sanborn(inString.Substring(154, 8));
            m_business_area = new BusArea(inString.Substring(162, 5));
            m_dof_map = new DofMap(inString.Substring(167, 9));

            // Added latitude, longitude
            m_filler9 = inString.Substring(176, 3);
            m_latitude = inString.Substring(179, 9);
            m_longitude = inString.Substring(188, 11);

            // Coordinates
            m_x_coord = inString.Substring(199, 7);
            m_y_coord = inString.Substring(206, 7);

            // Added new field BID
            m_bid_id = new B5sc(inString.Substring(213, 6));

            // Added new fields for TPAD
            m_TPAD_bin_status = inString.Substring(219, 1);
            m_TPAD_new_bin = new BIN(inString.Substring(220, 7));
            m_TPAD_new_bin_status = inString.Substring(227, 1);
            m_TPAD_conflict_flag = inString.Substring(228, 1);
            m_filler10 = inString.Substring(229, 9);

            for (i = 0; i < 4; i++)
                try { m_valid_lgcs[i] = inString.Substring(238 + (i * 2), 2); } catch { m_valid_lgcs[i] = string.Empty; }
            

            try { m_num_of_addrs = inString.Substring(246, 4); }catch{ m_num_of_addrs = string.Empty; }

            for (i = 0; i < 2500; i++)
                try { m_bin_list[i] = new BIN(inString.Substring(250 + (i * 7), 7)); } catch { m_bin_list[i] = new BIN(); }
                
            
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F1a Long ******************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lohns = {0}{1}", m_lohns, Environment.NewLine);
            sb.AppendFormat("filler1 = {0}{1}", m_filler1, Environment.NewLine);
            sb.AppendFormat("rpad_scc = {0}{1}", m_rpad_scc, Environment.NewLine);
            sb.AppendFormat("filler2 = {0}{1}", m_filler2, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("bbl = {0}{1}", m_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Lot Level Information  **********", Environment.NewLine);

            sb.AppendFormat("rpad_bldg_class = {0}{1}", m_rpad_bldg_class, Environment.NewLine);
            sb.AppendFormat("corner_code = {0}{1}", m_corner_code, Environment.NewLine);
            sb.AppendFormat("num_of_bldgs = {0}{1}", m_num_of_bldgs, Environment.NewLine);
            sb.AppendFormat("num_of_blockfaces = {0}{1}", m_num_of_blockfaces, Environment.NewLine);
            sb.AppendFormat("interior_flag = {0}{1}", m_interior_flag, Environment.NewLine);
            sb.AppendFormat("vacant_flag = {0}{1}", m_vacant_flag, Environment.NewLine);
            sb.AppendFormat("irreg_flag = {0}{1}", m_irreg_flag, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("addr_overflow_flag = {0}{1}", m_addr_overflow_flag, Environment.NewLine);
            sb.AppendFormat("stroll_key = {0}{1}", m_stroll_key, Environment.NewLine);
            sb.AppendFormat("res_internal_use = {0}{1}", m_res_internal_use, Environment.NewLine);

            sb.AppendFormat("coop_num = {0}{1}", m_coop_num, Environment.NewLine);
            sb.AppendFormat("sanborn = {0}{1}", m_sanborn.Display(), Environment.NewLine);
            sb.AppendFormat("business_area = {0}{1}", m_business_area.Display(), Environment.NewLine);
            sb.AppendFormat("dof_map = {0}{1}", m_dof_map.Display(), Environment.NewLine);
            sb.AppendFormat("bid_id = {0}{1}", m_bid_id.Display(), Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Condo Information  **********", Environment.NewLine);

            sb.AppendFormat("condo_flag = {0}{1}", m_condo_flag, Environment.NewLine);
            sb.AppendFormat("condo_num = {0}{1}", m_condo_num, Environment.NewLine);
            sb.AppendFormat("condo_bill_bbl = {0}{1}", m_condo_bill_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_bill_scc = {0}{1}", m_condo_bill_scc, Environment.NewLine);
            sb.AppendFormat("condo_lo_bbl = {0}{1}", m_condo_lo_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_hi_bbl = {0}{1}", m_condo_hi_bbl.Display(), Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  XYs and Lat/Longs  **********", Environment.NewLine);

            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);
            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  TPAD Information  **********", Environment.NewLine);

            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin = {0}{1}", m_TPAD_new_bin.Display(), Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin_status = {0}{1}", m_TPAD_new_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_conflict_flag = {0}{1}", m_TPAD_conflict_flag, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Valid LGCs  **********", Environment.NewLine);

            for (i = 0; i < 4; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Fillers  **********", Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("filler4 = {0}{1}", m_filler4, Environment.NewLine);
            sb.AppendFormat("filler8 = {0}{1}", m_filler8, Environment.NewLine);
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);
            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Number of Addresses  **********", Environment.NewLine);
            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "BIN", Environment.NewLine + Environment.NewLine);
            for (i = 0; i < 2500; i++)
            {
                sb.AppendFormat("{0}{1}", m_bin_list[i].ToString(), Environment.NewLine);
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
            set => m_filler1 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string rpad_scc
        {
            get => m_rpad_scc;
            set => m_rpad_scc = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string filler2
        {
            get => m_filler2;
            set => m_filler2 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string rpad_bldg_class
        {
            get => m_rpad_bldg_class;
            set => m_rpad_bldg_class = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string corner_code
        {
            get => m_corner_code;
            set => m_corner_code = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string num_of_bldgs
        {
            get => m_num_of_bldgs;
            set => m_num_of_bldgs = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string num_of_blockfaces
        {
            get => m_num_of_blockfaces;
            set => m_num_of_blockfaces = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string interior_flag
        {
            get => m_interior_flag;
            set => m_interior_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string vacant_flag
        {
            get => m_vacant_flag;
            set => m_vacant_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string irreg_flag
        {
            get => m_irreg_flag;
            set => m_irreg_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set => m_mh_ri_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string addr_overflow_flag
        {
            get => m_addr_overflow_flag;
            set => m_addr_overflow_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string stroll_key
        {
            get => m_stroll_key;
            set => m_stroll_key = value;
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
            set => m_filler5 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string condo_bill_scc
        {
            get => m_condo_bill_scc;
            set => m_condo_bill_scc = value.Length > 1 ? value.Substring(0, 1) : value;
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
            set => m_filler7 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string filler8
        {
            get => m_filler8;
            set => m_filler8 = value.Length > 15 ? value.Substring(0, 15) : value;
        }

        public string coop_num
        {
            get => m_coop_num;
            set => m_coop_num = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public Sanborn sanborn
        {
            get => m_sanborn;
            set => m_sanborn = value;
        }

        public BusArea business_area
        {
            get => m_business_area;
            set => m_business_area = value;
        }

        public DofMap dof_map
        {
            get => m_dof_map;
            set => m_dof_map = value;
        }

        public string filler9
        {
            get => m_filler9;
            set => m_filler9 = value.Length > 3 ? value.Substring(0, 3) : value;
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

        public B5sc bid_id
        {
            get => m_bid_id;
            set => m_bid_id = value;
        }

        public string TPAD_bin_status
        {
            get => m_TPAD_bin_status;
            set => m_TPAD_bin_status = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public BIN TPAD_new_bin
        {
            get => m_TPAD_new_bin;
            set => m_TPAD_new_bin = value;
        }

        public string TPAD_new_bin_status
        {
            get => m_TPAD_new_bin_status;
            set => m_TPAD_new_bin_status = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string TPAD_conflict_flag
        {
            get => m_TPAD_conflict_flag;
            set => m_TPAD_conflict_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string filler10
        {
            get => m_filler10;
            set => m_filler10 = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string valid_lgcs_item(int Index) => m_valid_lgcs[Index];

        public void valid_lgcs_item(int Index, string value) => m_valid_lgcs[Index] = value.Length > 2 ? value.Substring(0, 2) : value;
        
        public string num_of_addrs
        {
            get => m_num_of_addrs;
            set => m_num_of_addrs = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public BIN[] bin_list
        {
            get => m_bin_list;
            set => m_bin_list = value;
        }

        public BIN bin_list_item(int Index) => m_bin_list[Index];
        public void bin_list_item(int Index, BIN value)  => m_bin_list[Index] = value;

    }
}
