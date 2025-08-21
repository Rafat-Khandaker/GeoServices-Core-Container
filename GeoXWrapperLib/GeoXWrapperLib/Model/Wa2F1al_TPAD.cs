using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1al_TPAD : WA
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

        // Added latitude, longitude Version 14.1 / Release 14A
        private string m_filler9;
        private string m_latitude;
        private string m_longitude;
        private string m_x_coord;
        private string m_y_coord;

        // Added new field BID
        private B5sc m_bid_id;

        // Added new fields for TPAD 
        private string m_TPAD_bin_status;
        private BIN m_TPAD_new_bin;
        private string m_TPAD_new_bin_status;
        private string m_TPAD_conflict_flag;
        private string m_filler10;
        private string[] m_valid_lgcs = new string[4];
        private string m_num_of_addrs;


        public Wa2F1al_TPAD()
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
                m_valid_lgcs[i] = new string(' ', 2);
            }
            m_num_of_addrs = new string(' ', 4);
            for (int i = 0; i <= 2187; i++)
            {
                m_TPAD_list[i] = new TPADLongWa2Info();
            }
            m_filler11 = new string(' ', 4);
        }

        // Constructor with input string
        public Wa2F1al_TPAD(string inString) => Wa2F1al_TPADFromString(inString);
        

        // Clear method that reinitializes the object to spaces
        public override void Clear() => Wa2F1al_TPADFromString(new string(' ', 17750));
        

        // ToString method to convert the object to a string
        public override string ToString() => Wa2F1al_TPADToString();
        

        // FromString method to convert a string to the object
        public override void FromString(string inString) => Wa2F1al_TPADFromString(inString);
        

        // Helper methods for converting to and from strings (not provided in original code, assumed to be defined elsewhere)

        public string Wa2F1al_TPADToString()
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

            // Added latitude, longitude
            sb.Append(m_filler9);
            sb.Append(m_latitude);
            sb.Append(m_longitude);
            sb.Append(m_x_coord);
            sb.Append(m_y_coord);

            // Added new field BID
            sb.Append(m_bid_id.ToString());

            // Added new fields for TPAD
            sb.Append(m_TPAD_bin_status);
            sb.Append(m_TPAD_new_bin.BINToString());
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(m_TPAD_conflict_flag);
            sb.Append(m_filler10);

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs[i]);
            }

            sb.Append(m_num_of_addrs);

            for (int i = 0; i <= 2187; i++)
            {
                sb.Append(m_TPAD_list[i].TPADLongWa2InfoToString());
            }

            sb.Append(m_filler11);

            return sb.ToString();
        }

        public void Wa2F1al_TPADFromString(string inString)
        {
            int index = 0;

            m_gridkey1 = new VsamKey1(inString.Substring(index, 21));
            index += 21;

            m_cont_parity_ind = inString.Substring(index, 1);
            index += 1;

            m_lohns = inString.Substring(index, 11);
            index += 11;

            m_bbl = new BBL(inString.Substring(index, 10));
            index += 10;

            m_filler1 = inString.Substring(index, 1);
            index += 1;

            m_rpad_scc = inString.Substring(index, 1);
            index += 1;

            m_filler2 = inString.Substring(index, 1);
            index += 1;

            m_rpad_bldg_class = inString.Substring(index, 2);
            index += 2;

            m_corner_code = inString.Substring(index, 2);
            index += 2;

            m_num_of_bldgs = inString.Substring(index, 4);
            index += 4;

            m_num_of_blockfaces = inString.Substring(index, 2);
            index += 2;

            m_interior_flag = inString.Substring(index, 1);
            index += 1;

            m_vacant_flag = inString.Substring(index, 1);
            index += 1;

            m_irreg_flag = inString.Substring(index, 1);
            index += 1;

            m_mh_ri_flag = inString.Substring(index, 1);
            index += 1;

            m_addr_overflow_flag = inString.Substring(index, 1);
            index += 1;

            m_stroll_key = inString.Substring(index, 19);
            index += 19;

            m_res_internal_use = inString.Substring(index, 1);
            index += 1;

            m_bin = new BIN(inString.Substring(index, 7));
            index += 7;

            m_condo_flag = inString.Substring(index, 1);
            index += 1;

            m_filler3 = inString.Substring(index, 1);
            index += 1;

            m_condo_num = inString.Substring(index, 4);
            index += 4;

            m_filler4 = inString.Substring(index, 7);
            index += 7;

            m_condo_bill_bbl = new BBL(inString.Substring(index, 10));
            index += 10;

            m_filler5 = inString.Substring(index, 1);
            index += 1;

            m_condo_bill_scc = inString.Substring(index, 1);
            index += 1;

            m_condo_lo_bbl = new BBL(inString.Substring(index, 10));
            index += 10;

            m_filler6 = inString.Substring(index, 1);
            index += 1;

            m_condo_hi_bbl = new BBL(inString.Substring(index, 10));
            index += 10;

            m_filler7 = inString.Substring(index, 1);
            index += 1;

            m_filler8 = inString.Substring(index, 15);
            index += 15;

            m_coop_num = inString.Substring(index, 4);
            index += 4;

            m_sanborn = new Sanborn(inString.Substring(index, 8));
            index += 8;

            m_business_area = new BusArea(inString.Substring(index, 5));
            index += 5;

            m_dof_map = new DofMap(inString.Substring(index, 9));
            index += 9;

            // Added latitude, longitude
            m_filler9 = inString.Substring(index, 3);
            index += 3;

            m_latitude = inString.Substring(index, 9);
            index += 9;

            m_longitude = inString.Substring(index, 11);
            index += 11;

            m_x_coord = inString.Substring(index, 7);
            index += 7;

            m_y_coord = inString.Substring(index, 7);
            index += 7;

            // Added new field BID
            m_bid_id = new B5sc(inString.Substring(index, 6));
            index += 6;

            // Added new fields for TPAD
            m_TPAD_bin_status = inString.Substring(index, 1);
            index += 1;

            m_TPAD_new_bin = new BIN(inString.Substring(index, 7));
            index += 7;

            m_TPAD_new_bin_status = inString.Substring(index, 1);
            index += 1;

            m_TPAD_conflict_flag = inString.Substring(index, 1);
            index += 1;

            m_filler10 = inString.Substring(index, 9);
            index += 9;

            for (int i = 0; i <= 3; i++)
            {
                try { m_valid_lgcs[i] = inString.Substring(index, 2); } catch { m_valid_lgcs[i] = string.Empty; }
                index += 2;
            }

            m_num_of_addrs = inString.Substring(index, 4);
            index += 4;

            for (int i = 0; i <= 2187; i++)
            {
                try { m_TPAD_list[i] = new TPADLongWa2Info(inString.Substring(index, 8)); } catch { m_TPAD_list[i] = new TPADLongWa2Info(); }
                index += 8;
            }

            m_filler11 = inString.Substring(index, 4);
        }


        private TPADLongWa2Info[] m_TPAD_list = new TPADLongWa2Info[2188];

        private string m_filler11;



        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

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
            sb.Append(m_rpad_scc);
            sb.Append(c);
            sb.Append(m_filler2);
            sb.Append(c);
            sb.Append(m_rpad_bldg_class);
            sb.Append(c);
            sb.Append(m_corner_code);
            sb.Append(c);
            sb.Append(m_num_of_bldgs);
            sb.Append(c);
            sb.Append(m_num_of_blockfaces);
            sb.Append(c);
            sb.Append(m_interior_flag);
            sb.Append(c);
            sb.Append(m_vacant_flag);
            sb.Append(c);
            sb.Append(m_irreg_flag);
            sb.Append(c);
            sb.Append(m_mh_ri_flag);
            sb.Append(c);
            sb.Append(m_addr_overflow_flag);
            sb.Append(c);
            sb.Append(m_stroll_key);
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
            sb.Append(m_filler5);
            sb.Append(c);
            sb.Append(m_condo_bill_scc);
            sb.Append(c);
            sb.Append(m_condo_lo_bbl.Display());
            sb.Append(c);
            sb.Append(m_filler6);
            sb.Append(c);
            sb.Append(m_condo_hi_bbl.Display());
            sb.Append(c);
            sb.Append(m_filler7);
            sb.Append(c);
            sb.Append(m_filler8);
            sb.Append(c);
            sb.Append(m_coop_num);
            sb.Append(c);
            sb.Append(m_sanborn.Display());
            sb.Append(c);
            sb.Append(m_business_area.Display());
            sb.Append(c);
            sb.Append(m_dof_map.Display());
            sb.Append(c);

            // Added latitude and longitude (2014-03-04)
            sb.Append(m_filler9);
            sb.Append(c);
            sb.Append(m_latitude);
            sb.Append(c);
            sb.Append(m_longitude);
            sb.Append(c);
            sb.Append(m_x_coord);
            sb.Append(c);
            sb.Append(m_y_coord);
            sb.Append(c);

            // Added new field BID (2009-07-17)
            sb.Append(m_bid_id.Display());
            sb.Append(c);

            // Added new fields for TPAD (2010-10-18)
            sb.Append(m_TPAD_bin_status);
            sb.Append(c);
            sb.Append(m_TPAD_new_bin.Display());
            sb.Append(c);
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(c);
            sb.Append(m_TPAD_conflict_flag);
            sb.Append(c);
            sb.Append(m_filler10);
            sb.Append(c);

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_num_of_addrs);
            sb.Append(c);

            for (int i = 0; i <= 2187; i++)
            {
                sb.Append(m_TPAD_list[i].Display());
                sb.Append(c);
            }

            sb.Append(m_filler11);

            return sb.ToString();
        }

        public override string Display()
        {
            return Display('-');
        }


        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

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

            // Added latitude, longitude (2014-03-04)
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);
            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);
            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);

            // Added new field BID (2009-07-17)
            sb.AppendFormat("bid_id = {0}{1}", m_bid_id.Display(), Environment.NewLine);

            // Added new fields for TPAD (2010-10-18)
            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin = {0}{1}", m_TPAD_new_bin.Display(), Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin_status = {0}{1}", m_TPAD_new_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_conflict_flag = {0}{1}", m_TPAD_conflict_flag, Environment.NewLine);
            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);

            for (int i = 0; i <= 3; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            for (int i = 0; i <= 2187; i++)
            {
                sb.AppendFormat("TPAD_list({0}) = {1}{2}", i, m_TPAD_list[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("filler11 = {0}{1}", m_filler11, Environment.NewLine);

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F1ax  ******************************", Environment.NewLine);
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

            for (i = 0; i <= 3; i++)
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
            sb.AppendFormat("filler11 = {0}{1}", m_filler11, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Number of Addresses  **********", Environment.NewLine);
            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            // Create a Heading for the Address List (SPO(2017-05-01))
            sb.AppendFormat("{0}{1}{2}", "BIN" + "\t", "TPAD", Environment.NewLine + Environment.NewLine);

            for (i = 0; i <= 2187; i++)
            {
                sb.AppendFormat("{0}{1}{2}", TPAD_list[i].bin.ToString() + "\t", TPAD_list[i].TPAD_bin_status, Environment.NewLine);
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
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        public string lohns
        {
            get => m_lohns;
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_lohns = value.Substring(0, strlen);
            }
        }

        public BBL bbl
        {
            get => m_bbl;
            set => m_bbl = value;
        }

        public string filler1
        {
            get => m_filler1;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler1 = value.Substring(0, strlen);
            }
        }

        public string rpad_scc
        {
            get => m_rpad_scc;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_rpad_scc = value.Substring(0, strlen);
            }
        }

        public string filler2
        {
            get => m_filler2;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler2 = value.Substring(0, strlen);
            }
        }

        public string rpad_bldg_class
        {
            get => m_rpad_bldg_class;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_rpad_bldg_class = value.Substring(0, strlen);
            }
        }

        public string corner_code
        {
            get => m_corner_code;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_corner_code = value.Substring(0, strlen);
            }
        }

        public string num_of_bldgs
        {
            get => m_num_of_bldgs;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_num_of_bldgs = value.Substring(0, strlen);
            }
        }

        public string num_of_blockfaces
        {
            get => m_num_of_blockfaces;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_num_of_blockfaces = value.Substring(0, strlen);
            }
        }

        public string interior_flag
        {
            get => m_interior_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_interior_flag = value.Substring(0, strlen);
            }
        }

        public string vacant_flag
        {
            get => m_vacant_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_vacant_flag = value.Substring(0, strlen);
            }
        }

        public string irreg_flag
        {
            get => m_irreg_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_irreg_flag = value.Substring(0, strlen);
            }
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_mh_ri_flag = value.Substring(0, strlen);
            }
        }

        public string addr_overflow_flag
        {
            get => m_addr_overflow_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_addr_overflow_flag = value.Substring(0, strlen);
            }
        }

        public string stroll_key
        {
            get => m_stroll_key;
            set
            {
                int strlen = value.Length;
                if (strlen > 19) strlen = 19;
                m_stroll_key = value.Substring(0, strlen);
            }
        }

        public string res_internal_use
        {
            get => m_res_internal_use;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_res_internal_use = value.Substring(0, strlen);
            }
        }

        public BIN bin
        {
            get => m_bin;
            set => m_bin = value;
        }

        public string condo_flag
        {
            get => m_condo_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_condo_flag = value.Substring(0, strlen);
            }
        }

        public string filler3
        {
            get => m_filler3;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler3 = value.Substring(0, strlen);
            }
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

        public string valid_lgcs_item(int index) => m_valid_lgcs[index];

        public void valid_lgcs_item(int index, string value) => m_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;

        public string num_of_addrs
        {
            get => m_num_of_addrs;
            set => m_num_of_addrs = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public TPADLongWa2Info[] TPAD_list
        {
            get => m_TPAD_list;
            set => m_TPAD_list = value;
        }

        public TPADLongWa2Info TPAD_list_item(int index) => m_TPAD_list[index];
        public void TPAD_list_item(int index, TPADLongWa2Info value) => m_TPAD_list[index] = value;
        

        public string filler11
        {
            get => m_filler11;
            set => m_filler11 = value.Length > 4 ? value.Substring(0, 4) : value;
        }


    }
}
