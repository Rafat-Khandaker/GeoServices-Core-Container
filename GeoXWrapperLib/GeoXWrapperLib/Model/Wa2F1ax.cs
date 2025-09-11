using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1ax : WA
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

        //------------------------------------------------------------------------------------
        // --SPO(2021-10-13): Add Condo_Base_BBL field 
        //------------------------------------------------------------------------------------
        private BBL m_condo_base_bbl;
        private string m_filler8;
        private string m_coop_num;
        private Sanborn m_sanborn;
        private BusArea m_business_area;
        private DofMap m_dof_map;

        // --spo(2014-03-04):  added latitude, longitude Version 14.1 / Release 14A
        private string m_filler9;
        private string m_latitude;
        private string m_longitude;
        private string m_x_coord;
        private string m_y_coord;

        // --spo(2009-07-17):  added new field BID
        private B5sc m_bid_id;

        // --spo(2010-10-18):  added new fields for TPAD 
        private string m_TPAD_bin_status;
        private BIN m_TPAD_new_bin;
        private string m_TPAD_new_bin_status;
        private string m_TPAD_conflict_flag;

        //------------------------------------------------------------------------------------
        // ---spo(2017-09-29):    Added new DCP_Zoning_Map field for release 17D 
        // ---                    Requires that m_filler10 be reduced by 3
        //------------------------------------------------------------------------------------
        private string m_DCP_Zoning_Map;
        private string m_filler10;

        private string[] m_valid_lgcs = new string[4];

        // --spo(2011-09-23):  new fields added to regular WA21A to make WA21AX
        private string m_reason_code;
        private string m_reason_code_qualifier;
        private string m_warning_code;
        private string m_grc;
        private string m_filler11;
        private string m_num_of_addrs;

        // --arrays are zero based so there are 21 entries below
        private AddrRangeX[] m_addr_x_list = new AddrRangeX[21];

        public Wa2F1ax()
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

            // Add Condo_Base_BBL field 
            m_condo_base_bbl = new BBL();
            m_filler8 = new string(' ', 5);
            m_coop_num = new string(' ', 4);
            m_sanborn = new Sanborn();
            m_business_area = new BusArea();
            m_dof_map = new DofMap();

            // Add latitude, longitude
            m_filler9 = new string(' ', 3);
            m_latitude = new string(' ', 9);
            m_longitude = new string(' ', 11);
            m_x_coord = new string(' ', 7);
            m_y_coord = new string(' ', 7);

            // Add new field BID
            m_bid_id = new B5sc();

            // Add new fields for TPAD
            m_TPAD_bin_status = new string(' ', 1);
            m_TPAD_new_bin = new BIN();
            m_TPAD_new_bin_status = new string(' ', 1);
            m_TPAD_conflict_flag = new string(' ', 1);

            // Add new DCP_Zoning_Map field for release 17D
            m_DCP_Zoning_Map = new string(' ', 3);
            m_filler10 = new string(' ', 6);

            // Initialize valid_lgcs array
            for (int i = 0; i < 4; i++)
            {
                m_valid_lgcs[i] = new string(' ', 2);
            }

            // Add fields for regular WA21A to make WA21AX
            m_reason_code = new string(' ', 1);
            m_reason_code_qualifier = new string(' ', 1);
            m_warning_code = new string(' ', 2);
            m_grc = new string(' ', 2);
            m_filler11 = new string(' ', 108);
            m_num_of_addrs = new string(' ', 4);

            // Initialize addr_x_list array
            for (int i = 0; i < 21; i++)
            {
                m_addr_x_list[i] = new AddrRangeX();
            }
        }

        // Constructor with a string parameter
        public Wa2F1ax(string inString) => Wa2F1axFromString(inString);


        // Clear method reinitializes the object to spaces
        public override void Clear() => Wa2F1axFromString(new string(' ', 2800));


        // ToString method converts the object to a string
        public override string ToString() => Wa2F1axToString();


        // FromString method converts a string to a Wa2F1ax object
        public override void FromString(string inString) => Wa2F1axFromString(inString);


        // Helper methods Wa2F1axFromString and Wa2F1axToString can be defined here
        public void Wa2F1axFromString(string inString)
        {
            int i;
            try { m_gridkey1 = new VsamKey1(inString.Substring(0, 21)); } catch { m_gridkey1 = new VsamKey1(); }
            try { m_cont_parity_ind = inString.Substring(21, 1); } catch { m_cont_parity_ind = string.Empty; }
            try { m_lohns = inString.Substring(22, 11); } catch { m_lohns = string.Empty; }
            try { m_bbl = new BBL(inString.Substring(33, 10)); } catch { m_bbl = new BBL(); }
            
            try { m_filler1 = inString.Substring(43, 1); } catch { m_filler1 = string.Empty; }
            try { m_rpad_scc = inString.Substring(44, 1); } catch { m_rpad_scc = string.Empty; }
            try { m_filler2 = inString.Substring(45, 1); } catch { m_filler2 = string.Empty; }
            try { m_rpad_bldg_class = inString.Substring(46, 2); } catch { m_rpad_bldg_class = string.Empty; }
            try { m_corner_code = inString.Substring(48, 2); } catch { m_corner_code = string.Empty; }

            try { m_num_of_bldgs = inString.Substring(50, 4); } catch { m_num_of_bldgs = string.Empty; }

            try { m_num_of_blockfaces = inString.Substring(54, 2); } catch { m_num_of_blockfaces = string.Empty; }
            try { m_interior_flag = inString.Substring(56, 1); } catch { m_interior_flag = string.Empty; }
            try { m_vacant_flag = inString.Substring(57, 1); } catch { m_vacant_flag = string.Empty; }
            try { m_irreg_flag = inString.Substring(58, 1); } catch { m_irreg_flag = string.Empty; }
            try { m_mh_ri_flag = inString.Substring(59, 1); } catch { m_mh_ri_flag = string.Empty; }
            try { m_addr_overflow_flag = inString.Substring(60, 1); } catch { m_addr_overflow_flag = string.Empty; }
            try { m_res_internal_use = inString.Substring(80, 1); } catch { m_res_internal_use = string.Empty; }
            try { m_bin = new BIN(inString.Substring(81, 7)); } catch { m_bin = new BIN(); }
            try { m_condo_flag = inString.Substring(88, 1); } catch { m_condo_flag = string.Empty; }
            try { m_filler3 = inString.Substring(89, 1); } catch { m_filler3 = string.Empty; }

            try { m_condo_num = inString.Substring(90, 4); } catch { m_condo_num = string.Empty; }
            try { m_condo_bill_bbl = new BBL(inString.Substring(101, 10)); } catch { m_condo_bill_bbl = new BBL(); }
            try { m_filler5 = inString.Substring(111, 1); } catch { m_filler5 = string.Empty; }
            try { m_condo_bill_scc = inString.Substring(112, 1); } catch { m_condo_bill_scc = string.Empty; }
            try { m_condo_lo_bbl = new BBL(inString.Substring(113, 10)); } catch { m_condo_lo_bbl = new BBL(); }
            try { m_filler6 = inString.Substring(123, 1); } catch { m_filler6 = string.Empty; }
            try { m_condo_hi_bbl = new BBL(inString.Substring(124, 10)); } catch { m_condo_hi_bbl = new BBL(); }
            try { m_filler7 = inString.Substring(134, 1); } catch { m_filler7 = string.Empty; }
            try { m_condo_base_bbl = new BBL(inString.Substring(135, 10)); } catch { m_condo_base_bbl = new BBL(); }

            try { m_filler8 = inString.Substring(145, 5); } catch { m_filler8 = string.Empty; }
            try { m_coop_num = inString.Substring(150, 4); } catch { m_coop_num = string.Empty; }
            try { m_sanborn = new Sanborn(inString.Substring(154, 8)); } catch { m_sanborn = new Sanborn(); }
            try { m_business_area = new BusArea(inString.Substring(162, 5)); } catch { m_business_area = new BusArea(); }
            try { m_dof_map = new DofMap(inString.Substring(167, 9)); } catch { m_dof_map = new DofMap(); }
            try { m_filler9 = inString.Substring(176, 3); } catch { m_filler9 = string.Empty; }

            try { m_latitude = inString.Substring(179, 9); } catch { m_latitude = string.Empty; }
            try { m_longitude = inString.Substring(188, 11); } catch { m_longitude = string.Empty; }
            try { m_x_coord = inString.Substring(199, 7); } catch { m_x_coord = string.Empty; }
            try { m_y_coord = inString.Substring(206, 7); } catch { m_y_coord = string.Empty; }

            try { m_bid_id = new B5sc(inString.Substring(213, 6)); } catch { m_bid_id = new B5sc(); }
            try { m_TPAD_bin_status = inString.Substring(219, 1); } catch { m_TPAD_bin_status = string.Empty; }
            try { m_TPAD_new_bin = new BIN(inString.Substring(220, 7)); } catch { m_TPAD_new_bin = new BIN(); }
            try { m_TPAD_new_bin_status = inString.Substring(227, 1); } catch { m_TPAD_new_bin_status = string.Empty; }
            try { m_TPAD_conflict_flag = inString.Substring(228, 1); } catch { m_TPAD_conflict_flag = string.Empty; }

            try { m_DCP_Zoning_Map = inString.Substring(229, 3); } catch { m_DCP_Zoning_Map = string.Empty; }
            try { m_filler10 = inString.Substring(232, 6); } catch { m_filler10 = string.Empty; }

            // Parse valid_lgcs
            for (i = 0; i < 4; i++)
                try { m_valid_lgcs[i] = inString.Substring(238 + (i * 2), 2); } 
                catch { m_valid_lgcs[i] = string.Empty; }

            try { m_reason_code = inString.Substring(246, 1); } catch { m_reason_code = string.Empty; }
            try { m_reason_code_qualifier = inString.Substring(247, 1); } catch { m_reason_code_qualifier = string.Empty; }
            try { m_warning_code = inString.Substring(248, 2); } catch { m_warning_code = string.Empty; }
            try { m_grc = inString.Substring(250, 2); } catch { m_grc = string.Empty; }

            try { m_filler11 = inString.Substring(252, 108); } catch { m_filler11 = string.Empty; }
            try { m_num_of_addrs = inString.Substring(360, 4); } catch { m_num_of_addrs = string.Empty; }

            // Arrays are zero-based, so there are 21 entries below
            for (i = 0; i < 21; i++)
            {
                try
                {
                    m_addr_x_list[i] = new AddrRangeX(inString.Substring(364 + (i * 116), 116));
                }
                catch
                {
                    m_addr_x_list[i] = new AddrRangeX();
                }
            }
        }


        public string Wa2F1axToString()
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

            // Add Condo_Base_BBL field
            sb.Append(m_condo_base_bbl);
            sb.Append(m_filler8);
            sb.Append(m_coop_num);
            sb.Append(m_sanborn.SanbornToString());
            sb.Append(m_business_area.BusAreaToString());
            sb.Append(m_dof_map.DofMapToString());

            // Add latitude, longitude
            sb.Append(m_filler9);
            sb.Append(m_latitude);
            sb.Append(m_longitude);
            sb.Append(m_x_coord);
            sb.Append(m_y_coord);

            // Add new field BID
            sb.Append(m_bid_id.ToString());

            // Add new fields for TPAD
            sb.Append(m_TPAD_bin_status);
            sb.Append(m_TPAD_new_bin.BINToString());
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(m_TPAD_conflict_flag);

            // Add new DCP_Zoning_Map field for release 17D
            sb.Append(m_DCP_Zoning_Map);
            sb.Append(m_filler10);

            // Append valid_lgcs
            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
            }

            sb.Append(m_reason_code);
            sb.Append(m_reason_code_qualifier);
            sb.Append(m_warning_code);
            sb.Append(m_grc);
            sb.Append(m_filler11);
            sb.Append(m_num_of_addrs);

            // Arrays are zero-based, so there are 21 entries below
            for (int i = 0; i < 21; i++)
            {
                sb.Append(m_addr_x_list[i].AddrRangeXToString());
            }

            return sb.ToString();
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

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

            // Add Condo_Base_BBL field
            sb.Append(m_condo_base_bbl.Display());
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

            // Added latitude, longitude
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

            // Added new field BID
            sb.Append(m_bid_id.Display());
            sb.Append(c);

            // Added new fields for TPAD
            sb.Append(m_TPAD_bin_status);
            sb.Append(c);
            sb.Append(m_TPAD_new_bin.Display());
            sb.Append(c);
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(c);
            sb.Append(m_TPAD_conflict_flag);
            sb.Append(c);

            // Added new DCP_Zoning_Map field for release 17D
            sb.Append(m_DCP_Zoning_Map);
            sb.Append(c);
            sb.Append(m_filler10);
            sb.Append(c);

            // Append valid_lgcs
            for (i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_reason_code);
            sb.Append(c);
            sb.Append(m_reason_code_qualifier);
            sb.Append(c);
            sb.Append(m_warning_code);
            sb.Append(c);
            sb.Append(m_grc);
            sb.Append(c);
            sb.Append(m_filler11);
            sb.Append(c);
            sb.Append(m_num_of_addrs);
            sb.Append(c);

            // Arrays are zero-based, so there are 21 entries below
            for (i = 0; i < 21; i++)
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

            // Add Condo_Base_BBL field
            sb.AppendFormat("condo_base_bbl = {0}{1}", m_condo_base_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("filler8 = {0}{1}", m_filler8, Environment.NewLine);
            sb.AppendFormat("coop_num = {0}{1}", m_coop_num, Environment.NewLine);
            sb.AppendFormat("sanborn = {0}{1}", m_sanborn.Display(), Environment.NewLine);
            sb.AppendFormat("business_area = {0}{1}", m_business_area.Display(), Environment.NewLine);
            sb.AppendFormat("dof_map = {0}{1}", m_dof_map.Display(), Environment.NewLine);

            // Added latitude, longitude
            sb.AppendFormat("filler9 = {0}{1}", m_filler9, Environment.NewLine);
            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);
            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);

            // Added new field BID
            sb.AppendFormat("bid_id = {0}{1}", m_bid_id.Display(), Environment.NewLine);

            // Added new fields for TPAD
            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin = {0}{1}", m_TPAD_new_bin.Display(), Environment.NewLine);
            sb.AppendFormat("TPAD_new_bin_status = {0}{1}", m_TPAD_new_bin_status, Environment.NewLine);
            sb.AppendFormat("TPAD_conflict_flag = {0}{1}", m_TPAD_conflict_flag, Environment.NewLine);

            // Added new DCP_Zoning_Map field for release 17D
            sb.AppendFormat("DCP_Zoning_Map = {0}{1}", m_DCP_Zoning_Map, Environment.NewLine);
            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);

            // Append valid_lgcs
            for (i = 0; i < 4; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("reason_code = {0}{1}", m_reason_code, Environment.NewLine);
            sb.AppendFormat("reason_code_qualifier = {0}{1}", m_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("warning_code = {0}{1}", m_warning_code, Environment.NewLine);
            sb.AppendFormat("grc = {0}{1}", m_grc, Environment.NewLine);
            sb.AppendFormat("filler11 = {0}{1}", m_filler11, Environment.NewLine);
            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            // Arrays are zero-based, so there are 21 entries below
            for (i = 0; i < 21; i++)
            {
                sb.AppendFormat("addr_x_list({0}) = {1}{2}", i, m_addr_x_list[i].Display(), Environment.NewLine);
            }

            return sb.ToString();
        }

        public string GoatDisplay()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            // Uncommented and modified the header
            sb.AppendLine();
            sb.AppendLine("**************************************************************************************************************");
            sb.AppendLine("***********************************************  GOAT:  Wa2F1ax  *********************************************");
            sb.AppendLine("**************************************************************************************************************");

            sb.AppendFormat("{0}{1}{2}{3}{4}", Environment.NewLine, "****************************************  ",
                            "Property Level Information", "  ****************************************", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Tax Block:", m_bbl.block, "RPAD SCC:", m_rpad_scc, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Tax Lot:", m_bbl.lot, "RPAD Building Class:", m_rpad_bldg_class, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "BBL:", m_bbl.ToString(), "RPAD Interior Lot:", m_interior_flag, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Block Faces:", m_bbl.ToString(), "RPAD Irreg. Shaped Lot:", m_interior_flag, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Sanborn Boro/Vol/Page:", m_sanborn.Display(), "RPAD Condo Number:", m_condo_num, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "X,Y Coordinates:", m_x_coord + ", " + m_y_coord, "RPAD Co-op Number:", m_coop_num, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Latitude, Longitude:", m_latitude + ", " + m_longitude, "Condo Lot:", m_condo_flag, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Vacant Lot:", m_vacant_flag, "Tax Map/Section/Volume:", m_dof_map.Display(), Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Structures:", m_num_of_bldgs, "DCP Zoning Map:", m_DCP_Zoning_Map, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Condo Billing BBL:", m_condo_bill_bbl.Display(), "Condo Base BBL:", m_condo_base_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Low BBL of Condo:", m_condo_lo_bbl.Display(), "High BBL of Condo:", m_condo_hi_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "BIN:", m_bin.ToString(), "BIN Status:", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "TPAD BIN:", m_TPAD_new_bin.ToString(), "TPAD BIN Status:", m_TPAD_new_bin_status, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Corner Code:", m_corner_code, "TPAD Conflict Flag:", m_TPAD_conflict_flag, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Business Improvement District:", m_bid_id.ToString(), " ", " ", Environment.NewLine);

            sb.AppendLine();
            sb.AppendFormat("{0} {1} {2}", "Number of Addresses on Lot:", m_num_of_addrs, Environment.NewLine);
            sb.AppendLine();

            sb.AppendLine("Type          Low-HND         High-HND B7SC       Street-Name                      BIN     TPAD-BIN-Status");

            short numAddresses = Convert.ToInt16(m_num_of_addrs);

            // Loop through the addresses and display them
            for (i = 0; i < numAddresses; i++)
            {
                sb.AppendFormat("{0, -4} {1,-16} {2,-16} {3,-10} {4,-32} {5,-7} {6,-1} {7}",
                                m_addr_x_list[i].addr_type,
                                m_addr_x_list[i].lhnd,
                                m_addr_x_list[i].hhnd,
                                m_addr_x_list[i].b7sc.Display(),
                                m_addr_x_list[i].stname,
                                m_addr_x_list[i].bin.ToString(),
                                m_addr_x_list[i].TPAD_bin_status,
                                Environment.NewLine);
            }

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "************************************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************  Wa2F1ax  ****************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "************************************************************************************************", Environment.NewLine);

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

            // Added new DCP_Zoning_Map field for release 17D
            sb.AppendFormat("DCP_Zoning_Map = {0}{1}", m_DCP_Zoning_Map, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", "**********  Condo Information  **********", Environment.NewLine);

            sb.AppendFormat("condo_flag = {0}{1}", m_condo_flag, Environment.NewLine);
            sb.AppendFormat("condo_num = {0}{1}", m_condo_num, Environment.NewLine);
            sb.AppendFormat("condo_bill_bbl = {0}{1}", m_condo_bill_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_bill_scc = {0}{1}", m_condo_bill_scc, Environment.NewLine);
            sb.AppendFormat("condo_lo_bbl = {0}{1}", m_condo_lo_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_hi_bbl = {0}{1}", m_condo_hi_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("condo_base_bbl = {0}{1}", m_condo_base_bbl.Display(), Environment.NewLine);

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

            sb.AppendFormat("{0}{1}", "**********  Return Code Information  **********", Environment.NewLine);

            sb.AppendFormat("reason_code = {0}{1}", m_reason_code, Environment.NewLine);
            sb.AppendFormat("reason_code_qualifier = {0}{1}", m_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("warning_code = {0}{1}", m_warning_code, Environment.NewLine);
            sb.AppendFormat("grc = {0}{1}", m_grc, Environment.NewLine);

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

            // Create a Heading for the Address List
            sb.AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}", "Type ", "BIN     ", "TPAD ", "         Low HND ", "        High HND ", "B7SC       ", "Street Name     ", Environment.NewLine + Environment.NewLine);
            for (i = 0; i <= 20; i++)
            {
                sb.AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}",
                                addr_x_list[i].addr_type + "    ", addr_x_list[i].bin.ToString() + " ", addr_x_list[i].TPAD_bin_status + "    ",
                                addr_x_list[i].lhnd + " ", addr_x_list[i].hhnd + " ", addr_x_list[i].b7sc.Display() + " ", addr_x_list[i].stname,
                                Environment.NewLine);
            }

            return sb.ToString();
        }

        public string DCP_Zoning_Map
        {
            get => m_DCP_Zoning_Map;
            set
            {
                int strlen = Math.Min(value.Length, 3);
                m_DCP_Zoning_Map = value.Substring(0, strlen);
            }
        }

        public string TPAD_bin_status
        {
            get => m_TPAD_bin_status;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_TPAD_bin_status = value.Substring(0, strlen);
            }
        }

        public string TPAD_conflict_flag
        {
            get => m_TPAD_conflict_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_TPAD_conflict_flag = value.Substring(0, strlen);
            }
        }

        public BIN TPAD_new_bin
        {
            get => m_TPAD_new_bin;
            set => m_TPAD_new_bin = value;
        }

        public string TPAD_new_bin_status
        {
            get => m_TPAD_new_bin_status;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_TPAD_new_bin_status = value.Substring(0, strlen);
            }
        }

        public string addr_overflow_flag
        {
            get => m_addr_overflow_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_addr_overflow_flag = value.Substring(0, strlen);
            }
        }

        public AddrRangeX[] addr_x_list
        {
            get => m_addr_x_list;
            set => m_addr_x_list = value;
        }

        public BBL bbl
        {
            get => m_bbl;
            set => m_bbl = value;
        }

        public B5sc bid_id
        {
            get => m_bid_id;
            set => m_bid_id = value;
        }

        public BIN bin
        {
            get => m_bin;
            set => m_bin = value;
        }
        public BusArea business_area
        {
            get => m_business_area;
            set => m_business_area = value;
        }

        public BBL condo_base_bbl
        {
            get => m_condo_base_bbl;
            set => m_condo_base_bbl = value;
        }

        public BBL condo_bill_bbl
        {
            get => m_condo_bill_bbl;
            set => m_condo_bill_bbl = value;
        }

        public string condo_bill_scc
        {
            get => m_condo_bill_scc;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_condo_bill_scc = value.Substring(0, strlen);
            }
        }

        public string condo_flag
        {
            get => m_condo_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_condo_flag = value.Substring(0, strlen);
            }
        }

        public BBL condo_hi_bbl
        {
            get => m_condo_hi_bbl;
            set => m_condo_hi_bbl = value;
        }

        public BBL condo_lo_bbl
        {
            get => m_condo_lo_bbl;
            set => m_condo_lo_bbl = value;
        }

        public string condo_num
        {
            get => m_condo_num;
            set
            {
                int strlen = Math.Min(value.Length, 4);
                m_condo_num = value.Substring(0, strlen);
            }
        }

        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        public string coop_num
        {
            get => m_coop_num;
            set
            {
                int strlen = Math.Min(value.Length, 4);
                m_coop_num = value.Substring(0, strlen);
            }
        }

        public string corner_code
        {
            get => m_corner_code;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                m_corner_code = value.Substring(0, strlen);
            }
        }

        public DofMap dof_map
        {
            get => m_dof_map;
            set => m_dof_map = value;
        }


        public string filler1
        {
            get => m_filler1;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_filler1 = value.Substring(0, strlen);
            }
        }
        public string filler10
        {
            get => m_filler10;
            set
            {
                int strlen = Math.Min(value.Length, 6);  // Adjusted max length to 6
                m_filler10 = value.Substring(0, strlen);
            }
        }

        public string filler11
        {
            get => m_filler11;
            set
            {
                int strlen = Math.Min(value.Length, 108);
                m_filler11 = value.Substring(0, strlen);
            }
        }

        public string filler2
        {
            get => m_filler2;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_filler2 = value.Substring(0, strlen);
            }
        }

        public string filler3
        {
            get => m_filler3;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_filler3 = value.Substring(0, strlen);
            }
        }

        public string filler4
        {
            get => m_filler4;
            set
            {
                int strlen = Math.Min(value.Length, 7);
                m_filler4 = value.Substring(0, strlen);
            }
        }

        public string filler5
        {
            get => m_filler5;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_filler5 = value.Substring(0, strlen);
            }
        }

        public string filler6
        {
            get => m_filler6;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_filler6 = value.Substring(0, strlen);
            }
        }

        public string filler7
        {
            get => m_filler7;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_filler7 = value.Substring(0, strlen);
            }
        }

        public string filler8
        {
            get => m_filler8;
            set
            {
                int strlen = Math.Min(value.Length, 5);
                m_filler8 = value.Substring(0, strlen);
            }
        }
        public string filler9
        {
            get => m_filler9;
            set
            {
                int strlen = Math.Min(value.Length, 3);
                m_filler9 = value.Substring(0, strlen);
            }
        }

        public string grc
        {
            get => m_grc;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                m_grc = value.Substring(0, strlen);
            }
        }

        public VsamKey1 gridkey1
        {
            get => m_gridkey1;
            set => m_gridkey1 = value;
        }

        public string interior_flag
        {
            get => m_interior_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_interior_flag = value.Substring(0, strlen);
            }
        }
        public string irreg_flag
        {
            get => m_irreg_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_irreg_flag = value.Substring(0, strlen);
            }
        }


        public string latitude
        {
            get => m_latitude;
            set
            {
                int strlen = Math.Min(value.Length, 9);
                m_latitude = value.Substring(0, strlen);
            }
        }

        public string lohns
        {
            get => m_lohns;
            set
            {
                int strlen = Math.Min(value.Length, 11);
                m_lohns = value.Substring(0, strlen);
            }
        }

        public string longitude
        {
            get => m_longitude;
            set
            {
                int strlen = Math.Min(value.Length, 11);
                m_longitude = value.Substring(0, strlen);
            }
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_mh_ri_flag = value.Substring(0, strlen);
            }
        }

        public string num_of_addrs
        {
            get => m_num_of_addrs;
            set
            {
                int strlen = Math.Min(value.Length, 4);
                m_num_of_addrs = value.Substring(0, strlen);
            }
        }

        public string num_of_bldgs
        {
            get => m_num_of_bldgs;
            set
            {
                int strlen = Math.Min(value.Length, 4);
                m_num_of_bldgs = value.Substring(0, strlen);
            }
        }

        public string num_of_blockfaces
        {
            get => m_num_of_blockfaces;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                m_num_of_blockfaces = value.Substring(0, strlen);
            }
        }

        public string reason_code
        {
            get => m_reason_code;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_reason_code = value.Substring(0, strlen);
            }
        }

        public string reason_code_qualifier
        {
            get => m_reason_code_qualifier;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_reason_code_qualifier = value.Substring(0, strlen);
            }
        }

        public string res_internal_use
        {
            get => m_res_internal_use;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_res_internal_use = value.Substring(0, strlen);
            }
        }

        public string rpad_bldg_class
        {
            get => m_rpad_bldg_class;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                m_rpad_bldg_class = value.Substring(0, strlen);
            }
        }
        public string rpad_scc
        {
            get => m_rpad_scc;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_rpad_scc = value.Substring(0, strlen);
            }
        }

        public Sanborn sanborn
        {
            get => m_sanborn;
            set => m_sanborn = value;
        }

        public string stroll_key
        {
            get => m_stroll_key;
            set
            {
                int strlen = Math.Min(value.Length, 19);
                m_stroll_key = value.Substring(0, strlen);
            }
        }

        public string vacant_flag
        {
            get => m_vacant_flag;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_vacant_flag = value.Substring(0, strlen);
            }
        }

        [XmlArrayItem("lgc", typeof(string))]
        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string warning_code
        {
            get => m_warning_code;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                m_warning_code = value.Substring(0, strlen);
            }
        }

        public string x_coord
        {
            get => m_x_coord;
            set
            {
                int strlen = Math.Min(value.Length, 7);
                m_x_coord = value.Substring(0, strlen);
            }
        }

        public string y_coord
        {
            get => m_y_coord;
            set
            {
                int strlen = Math.Min(value.Length, 7);
                m_y_coord = value.Substring(0, strlen);
            }
        }

        public string valid_lgcs_item(int index) => m_valid_lgcs[index];
        public void valid_lgcs_item(int index, string value) 
        {
            int strlen = Math.Min(value.Length, 2);
            m_valid_lgcs[index] = value.Substring(0, strlen);
        }

        public AddrRangeX addr_x_list_item(int index) => m_addr_x_list[index];

        public void addr_x_list_item(int index, AddrRangeX value)  => m_addr_x_list[index] = value;
        

    }
}
