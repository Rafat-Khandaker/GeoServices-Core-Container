using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1a : WA
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
        private BBL m_condo_base_bbl;
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
        private string m_DCP_Zoning_Map;
        private string m_filler10;
        private string[] m_valid_lgcs;
        private string m_num_of_addrs;
        private AddrRange[] m_addr_list;

        public Wa2F1a()
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

            // SPO(2021-10-13): Add Condo_Base_BBL field
            m_condo_base_bbl = new BBL();
            m_filler8 = new string(' ', 5);

            m_coop_num = new string(' ', 4);
            m_sanborn = new Sanborn();
            m_business_area = new BusArea();
            m_dof_map = new DofMap();

            // SPO(2017-04-14): Below 3-byte filler is reserved for UPAD Deleted Flags (Address, BBL, BIN)
            m_filler9 = new string(' ', 3);

            // SPO(2014-03-04): Added latitude, longitude
            m_latitude = new string(' ', 9);
            m_longitude = new string(' ', 11);
            m_x_coord = new string(' ', 7);
            m_y_coord = new string(' ', 7);

            // SPO(2009-07-17): Added new field BID
            m_bid_id = new B5sc();

            // SPO(2010-10-18): Added new fields for TPAD
            m_TPAD_bin_status = new string(' ', 1);
            m_TPAD_new_bin = new BIN();
            m_TPAD_new_bin_status = new string(' ', 1);
            m_TPAD_conflict_flag = new string(' ', 1);

            // SPO(2017-09-29): Added new DCP_Zoning_Map field for release 17D
            m_DCP_Zoning_Map = new string(' ', 3);

            // SPO(2017-04-14): Need to modify m_filler10 to free up 3 bytes of storage for Has Units Flags (Address, BBL, BIN)
            m_filler10 = new string(' ', 6);

            m_valid_lgcs = new string[4];
            for (int i = 0; i < 4; i++)
            {
                m_valid_lgcs[i] = new string(' ', 2);
            }

            m_num_of_addrs = new string(' ', 4);

            m_addr_list = new AddrRange[21];
            for (int i = 0; i < 21; i++)
            {
                m_addr_list[i] = new AddrRange();
            }
        }
        public Wa2F1a(string inString)
        {
            this.Wa2F1aFromString(inString);
        }

        public override void Clear()
        {
            this.Wa2F1aFromString(new string(' ', 1363));
        }

        public override string ToString()
        {
            return this.Wa2F1aToString();
        }

        public override void FromString(string inString)
        {
            this.Wa2F1aFromString(inString);
        }

        public string Wa2F1aToString()
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

            // SPO(2021-10-13): Add Condo_Base_BBL field
            sb.Append(m_condo_base_bbl);
            sb.Append(m_filler8);
            sb.Append(m_coop_num);
            sb.Append(m_sanborn.SanbornToString());
            sb.Append(m_business_area.BusAreaToString());
            sb.Append(m_dof_map.DofMapToString());

            // SPO(2014-03-04): added latitude, longitude
            sb.Append(m_filler9);
            sb.Append(m_latitude);
            sb.Append(m_longitude);
            sb.Append(m_x_coord);
            sb.Append(m_y_coord);

            // SPO(2009-07-17): added new field BID
            sb.Append(m_bid_id.ToString());

            // SPO(2010-10-18): added new fields for TPAD
            sb.Append(m_TPAD_bin_status);
            sb.Append(m_TPAD_new_bin.BINToString());
            sb.Append(m_TPAD_new_bin_status);
            sb.Append(m_TPAD_conflict_flag);

            // SPO(2017-09-29): Added new DCP_Zoning_Map field for release 17D
            sb.Append(m_DCP_Zoning_Map);
            sb.Append(m_filler10);

            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
            }

            sb.Append(m_num_of_addrs);

            for (int i = 0; i < 21; i++)
            {
                sb.Append(m_addr_list[i].AddrRangeToString());
            }

            return sb.ToString();
        }

        public void Wa2F1aFromString(string inString)
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

            // Added new DCP_Zoning_Map field for release 17D
            m_condo_base_bbl = new BBL(inString.Substring(135, 10));
            m_filler8 = inString.Substring(145, 5);
            m_coop_num = inString.Substring(150, 4);
            m_sanborn = new Sanborn(inString.Substring(154, 8));
            m_business_area = new BusArea(inString.Substring(162, 5));
            m_dof_map = new DofMap(inString.Substring(167, 9));

            // Added latitude and longitude
            m_filler9 = inString.Substring(176, 3);
            m_latitude = inString.Substring(179, 9);
            m_longitude = inString.Substring(188, 11);
            m_x_coord = inString.Substring(199, 7);
            m_y_coord = inString.Substring(206, 7);

            // Added new field BID
            m_bid_id = new B5sc(inString.Substring(213, 6));

            // Added new fields for TPAD
            m_TPAD_bin_status = inString.Substring(219, 1);
            m_TPAD_new_bin = new BIN(inString.Substring(220, 7));
            m_TPAD_new_bin_status = inString.Substring(227, 1);
            m_TPAD_conflict_flag = inString.Substring(228, 1);

            // Added new DCP_Zoning_Map field for release 17D
            m_DCP_Zoning_Map = inString.Substring(229, 3);

            m_filler10 = inString.Substring(232, 6);

            // Process the valid LGCs
            for (i = 0; i < 4; i++)
            {
                try {
                    m_valid_lgcs[i] = inString.Substring(238 + (i * 2), 2);
                }
                catch {
                    m_valid_lgcs[i] = string.Empty;
                }
            }

            m_num_of_addrs = inString.Substring(246, 4);

            // Process the address list
            for (i = 0; i < 20; i++)
            {
                try
                {
                    m_addr_list[i] = new AddrRange(inString.Substring(250 + (i * 53), 53));
                }
                catch
                {
                    m_addr_list[i] = new AddrRange();
                }
                
            }
        }

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

            // Added new DCP_Zoning_Map field
            sb.Append(m_DCP_Zoning_Map);
            sb.Append(c);

            sb.Append(m_filler10);
            sb.Append(c);

            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_num_of_addrs);
            sb.Append(c);

            for (int i = 0; i < 20; i++)
            {
                sb.Append(m_addr_list[i].Display());
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

            // Added new DCP_Zoning_Map field
            sb.AppendFormat("DCP_Zoning_Map = {0}{1}", m_DCP_Zoning_Map, Environment.NewLine);

            sb.AppendFormat("filler10 = {0}{1}", m_filler10, Environment.NewLine);

            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("num_of_addrs = {0}{1}", m_num_of_addrs, Environment.NewLine);

            for (int i = 0; i < 20; i++)
            {
                sb.AppendFormat("addr_list({0}) = {1}{2}", i, m_addr_list[i].Display(), Environment.NewLine);
            }

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "**************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F1a  ******************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "**************************************************************************", Environment.NewLine);

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

            // Add Condo_Base_BBL field
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

            for (int i = 0; i < 4; i++)
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

            // Heading for the Address List
            sb.AppendFormat("{0}{1}{2}{3}{4}{5}", "Type ", "BIN     ", "         Low HND ", "        High HND ", "B7SC       ", Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < 20; i++)
            {
                sb.AppendFormat("{0}{1}{2}{3}{4}{5}",
                                 addr_list[i].addr_type + "    ", addr_list[i].bin.ToString() + " ",
                                 addr_list[i].lhnd + " ", addr_list[i].hhnd + " ", addr_list[i].b7sc.Display(),
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
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_condo_num = value.Substring(0, strlen);
            }
        }

        public string filler4
        {
            get => m_filler4;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_filler4 = value.Substring(0, strlen);
            }
        }

        public BBL condo_bill_bbl
        {
            get => m_condo_bill_bbl;
            set => m_condo_bill_bbl = value;
        }

        public string filler5
        {
            get => m_filler5;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler5 = value.Substring(0, strlen);
            }
        }

        public string condo_bill_scc
        {
            get => m_condo_bill_scc;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_condo_bill_scc = value.Substring(0, strlen);
            }
        }

        public BBL condo_lo_bbl
        {
            get => m_condo_lo_bbl;
            set => m_condo_lo_bbl = value;
        }

        public string filler6
        {
            get => m_filler6;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler6 = value.Substring(0, strlen);
            }
        }

        public BBL condo_hi_bbl
        {
            get => m_condo_hi_bbl;
            set => m_condo_hi_bbl = value;
        }

        public string filler7
        {
            get => m_filler7;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler7 = value.Substring(0, strlen);
            }
        }

        public BBL condo_base_bbl
        {
            get => m_condo_base_bbl;
            set => m_condo_base_bbl = value;
        }

        public string filler8
        {
            get => m_filler8;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_filler8 = value.Substring(0, strlen);
            }
        }

        public string coop_num
        {
            get => m_coop_num;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_coop_num = value.Substring(0, strlen);
            }
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
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_filler9 = value.Substring(0, strlen);
            }
        }

        public string latitude
        {
            get => m_latitude;
            set
            {
                int strlen = value.Length;
                if (strlen > 9) strlen = 9;
                m_latitude = value.Substring(0, strlen);
            }
        }

        public string longitude
        {
            get => m_longitude;
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_longitude = value.Substring(0, strlen);
            }
        }

        public string x_coord
        {
            get => m_x_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_x_coord = value.Substring(0, strlen);
            }
        }

        public string y_coord
        {
            get => m_y_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_y_coord = value.Substring(0, strlen);
            }
        }

        public B5sc bid_id
        {
            get => m_bid_id;
            set => m_bid_id = value;
        }

        public string TPAD_bin_status
        {
            get => m_TPAD_bin_status;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_TPAD_bin_status = value.Substring(0, strlen);
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
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_TPAD_new_bin_status = value.Substring(0, strlen);
            }
        }

        public string TPAD_conflict_flag
        {
            get => m_TPAD_conflict_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_TPAD_conflict_flag = value.Substring(0, strlen);
            }
        }

        public string DCP_Zoning_Map
        {
            get => m_DCP_Zoning_Map;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_DCP_Zoning_Map = value.Substring(0, strlen);
            }
        }

        public string filler10
        {
            get => m_filler10;
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_filler10 = value.Substring(0, strlen);
            }
        }

        [XmlArrayItem("lgc", typeof(string))]
        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string valid_lgcs_item(int index) => m_valid_lgcs[index];

        public void valid_lgcs_item(int index, string value)
        {
            int strlen = value.Length;
            if (strlen > 2) strlen = 2;
            m_valid_lgcs[index] = value.Substring(0, strlen);
        }

        public string num_of_addrs
        {
            get => m_num_of_addrs;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_num_of_addrs = value.Substring(0, strlen);
            }
        }

        public AddrRange[] addr_list
        {
            get => m_addr_list;
            set => m_addr_list = value;
        }

        public AddrRange addr_list_item(int index) => m_addr_list[index];
        public void addr_list_item(int index, AddrRange value) => m_addr_list[index] = value;
        


    }
}
