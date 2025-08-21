using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa1Aimz : WA
    {
        private string m_in_azfct;
        private string m_in_func_code;
        private string m_in_mp_boro;
        private string m_in_mp_hnd;
        private string m_in_mp_stname1;
        private string m_in_mp_stname2;
        private string m_in_mp_boro2;
        private string m_in_mp_compass_dir;
        private string m_in_mp_txblk;
        private string m_in_mp_txlot;
        private string m_in_mp_txlot_version;
        private BIN m_in_mp_bin;
        private string m_in_platform_ind;
        private string m_in_boro1;
        private string m_in_hnd;
        private string m_in_hns;
        private string m_in_filler01;
        private B10sc m_in_b10sc1;
        private string m_in_stname1;
        private string m_in_boro2;
        private B10sc m_in_b10sc2;
        private string m_in_stname2;
        private string m_in_compass_dir;
        private string m_in_snl;
        private string m_in_stname_normalization;
        private BBL m_in_bbl;
        private string m_in_filler02;
        private BIN m_in_bin;
        private string m_in_filler3;
        private string m_out_flood_ins_map_num;
        private string m_out_fimp_warn_msg;
        private string m_out_dcp_sect_map_num;
        private string m_out_dcp_zone_map_num;
        private string m_out_adjacent1_zone_num;
        private string m_out_adjacent2_zone_num;
        private string m_out_geo_map_num;
        private Sanborn m_out_sanborn1;
        private Sanborn m_out_sanborn2;
        private BBL m_out_bbl;
        private string m_out_filler01;
        private DofMap m_out_dof_map;
        private string m_out_x_coord;
        private string m_out_y_coord;
        private string m_out_ortho_tile_id;
        private BIN m_out_bin;
        private string m_out_filler02;
        private string m_out_reason_code;
        private string m_out_grc;
        private string m_out_error_message1;
        private string m_out_error_message2;
        private string m_out_error_message3;
        private string m_out_number_of_similar_stnames;
        private string[] m_out_similar_stname_list = new string[10];

        public Wa1Aimz()
        {
            m_in_azfct = new string(' ', 2);
            m_in_func_code = new string(' ', 2);
            m_in_mp_boro = new string(' ', 1);
            m_in_mp_hnd = new string(' ', 12);
            m_in_mp_stname1 = new string(' ', 32);
            m_in_mp_stname2 = new string(' ', 32);
            m_in_mp_boro2 = new string(' ', 1);
            m_in_mp_compass_dir = new string(' ', 1);
            m_in_mp_txblk = new string(' ', 5);
            m_in_mp_txlot = new string(' ', 4);
            m_in_mp_txlot_version = new string(' ', 1);
            m_in_mp_bin = new BIN();
            m_in_platform_ind = new string(' ', 1);
            m_in_boro1 = new string(' ', 1);
            m_in_hnd = new string(' ', 12);
            m_in_hns = new string(' ', 11);
            m_in_filler01 = new string(' ', 1);
            m_in_b10sc1 = new B10sc();
            m_in_stname1 = new string(' ', 32);
            m_in_boro2 = new string(' ', 1);
            m_in_b10sc2 = new B10sc();
            m_in_stname2 = new string(' ', 32);
            m_in_compass_dir = new string(' ', 1);
            m_in_snl = new string(' ', 2);
            m_in_stname_normalization = new string(' ', 1);
            m_in_bbl = new BBL();
            m_in_filler02 = new string(' ', 1);
            m_in_bin = new BIN();
            m_in_filler3 = new string(' ', 50);
            m_out_flood_ins_map_num = new string(' ', 5);
            m_out_fimp_warn_msg = new string(' ', 80);
            m_out_dcp_sect_map_num = new string(' ', 2);
            m_out_dcp_zone_map_num = new string(' ', 3);
            m_out_adjacent1_zone_num = new string(' ', 3);
            m_out_adjacent2_zone_num = new string(' ', 3);
            m_out_geo_map_num = new string(' ', 3);
            m_out_sanborn1 = new Sanborn();
            m_out_sanborn2 = new Sanborn();
            m_out_bbl = new BBL();
            m_out_filler01 = new string(' ', 1);
            m_out_dof_map = new DofMap();
            m_out_x_coord = new string(' ', 7);
            m_out_y_coord = new string(' ', 7);
            m_out_ortho_tile_id = new string(' ', 6);
            m_out_bin = new BIN();
            m_out_filler02 = new string(' ', 188);
            m_out_reason_code = new string(' ', 1);
            m_out_grc = new string(' ', 2);
            m_out_error_message1 = new string(' ', 80);
            m_out_error_message2 = new string(' ', 80);
            m_out_error_message3 = new string(' ', 80);
            m_out_number_of_similar_stnames = new string(' ', 2);

            for (int i = 0; i <= 9; i++)
            {
                m_out_similar_stname_list[i] = new string(' ', 32);
            }
        }

        /// <summary>
        /// Constructor for <c>Wa1Aimz</c>
        /// </summary>
        public Wa1Aimz(string inString) => Wa1AimzFromString(inString);


        public override void Clear()
        {
            this.Wa1AimzFromString(new string(' ', 1200));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa1Aimz</c> object to a string
        /// </summary>
        public override string ToString()
        {
            return this.Wa1AimzToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa1Aimz</c> object
        /// </summary>
        public override void FromString(string inString)
        {
            this.Wa1AimzFromString(inString);
        }

        /// <summary>
        /// <c>Wa1AimzToString</c> converts a <c>Wa1Aimz</c> object to a string
        /// </summary>
        public string Wa1AimzToString()
        {
            var sb = new StringBuilder();

            sb.Append(m_in_azfct);
            sb.Append(m_in_func_code);
            sb.Append(m_in_mp_boro);
            sb.Append(m_in_mp_hnd);
            sb.Append(m_in_mp_stname1);
            sb.Append(m_in_mp_stname2);
            sb.Append(m_in_mp_boro2);
            sb.Append(m_in_mp_compass_dir);
            sb.Append(m_in_mp_txblk);
            sb.Append(m_in_mp_txlot);
            sb.Append(m_in_mp_txlot_version);
            sb.Append(m_in_mp_bin.BINToString());
            sb.Append(m_in_platform_ind);
            sb.Append(m_in_boro1);
            sb.Append(m_in_hnd);
            sb.Append(m_in_hns);
            sb.Append(m_in_filler01);
            sb.Append(m_in_b10sc1.B10scToString());
            sb.Append(m_in_stname1);
            sb.Append(m_in_boro2);
            sb.Append(m_in_b10sc2.B10scToString());
            sb.Append(m_in_stname2);
            sb.Append(m_in_compass_dir);
            sb.Append(m_in_snl);
            sb.Append(m_in_stname_normalization);
            sb.Append(m_in_bbl.BBLToString());
            sb.Append(m_in_filler02);
            sb.Append(m_in_bin.BINToString());
            sb.Append(m_in_filler3);
            sb.Append(m_out_flood_ins_map_num);
            sb.Append(m_out_fimp_warn_msg);
            sb.Append(m_out_dcp_sect_map_num);
            sb.Append(m_out_dcp_zone_map_num);
            sb.Append(m_out_adjacent1_zone_num);
            sb.Append(m_out_adjacent2_zone_num);
            sb.Append(m_out_geo_map_num);
            sb.Append(m_out_sanborn1.SanbornToString());
            sb.Append(m_out_sanborn2.SanbornToString());
            sb.Append(m_out_bbl.BBLToString());
            sb.Append(m_out_filler01);
            sb.Append(m_out_dof_map.DofMapToString());
            sb.Append(m_out_x_coord);
            sb.Append(m_out_y_coord);
            sb.Append(m_out_ortho_tile_id);
            sb.Append(m_out_bin.BINToString());
            sb.Append(m_out_filler02);
            sb.Append(m_out_reason_code);
            sb.Append(m_out_grc);
            sb.Append(m_out_error_message1);
            sb.Append(m_out_error_message2);
            sb.Append(m_out_error_message3);
            sb.Append(m_out_number_of_similar_stnames);

            for (int i = 0; i < 10; i++)
            {
                sb.Append(m_out_similar_stname_list[i]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// <c>Wa1AimzFromString</c> converts a string to a <c>Wa1Aimz</c> object
        /// </summary>
        public void Wa1AimzFromString(string inString)
        {
            m_in_azfct = inString.Substring(0, 2);
            m_in_func_code = inString.Substring(2, 2);
            m_in_mp_boro = inString.Substring(4, 1);
            m_in_mp_hnd = inString.Substring(5, 12);
            m_in_mp_stname1 = inString.Substring(17, 32);
            m_in_mp_stname2 = inString.Substring(49, 32);
            m_in_mp_boro2 = inString.Substring(81, 1);
            m_in_mp_compass_dir = inString.Substring(82, 1);
            m_in_mp_txblk = inString.Substring(83, 5);
            m_in_mp_txlot = inString.Substring(88, 4);
            m_in_mp_txlot_version = inString.Substring(92, 1);
            m_in_mp_bin = new BIN(inString.Substring(93, 7));
            m_in_platform_ind = inString.Substring(100, 1);
            m_in_boro1 = inString.Substring(101, 1);
            m_in_hnd = inString.Substring(102, 12);
            m_in_hns = inString.Substring(114, 11);
            m_in_filler01 = inString.Substring(125, 1);
            m_in_b10sc1 = new B10sc(inString.Substring(126, 11));
            m_in_stname1 = inString.Substring(137, 32);
            m_in_boro2 = inString.Substring(169, 1);
            m_in_b10sc2 = new B10sc(inString.Substring(170, 11));
            m_in_stname2 = inString.Substring(181, 32);
            m_in_compass_dir = inString.Substring(213, 1);
            m_in_snl = inString.Substring(214, 2);
            m_in_stname_normalization = inString.Substring(216, 1);
            m_in_bbl = new BBL(inString.Substring(217, 10));
            m_in_filler02 = inString.Substring(227, 1);
            m_in_bin = new BIN(inString.Substring(228, 7));
            m_in_filler3 = inString.Substring(235, 50);
            m_out_flood_ins_map_num = inString.Substring(285, 5);
            m_out_fimp_warn_msg = inString.Substring(290, 80);
            m_out_dcp_sect_map_num = inString.Substring(370, 2);
            m_out_dcp_zone_map_num = inString.Substring(372, 3);
            m_out_adjacent1_zone_num = inString.Substring(375, 3);
            m_out_adjacent2_zone_num = inString.Substring(378, 3);
            m_out_geo_map_num = inString.Substring(381, 3);
            m_out_sanborn1 = new Sanborn(inString.Substring(384, 8));
            m_out_sanborn2 = new Sanborn(inString.Substring(392, 8));
            m_out_bbl = new BBL(inString.Substring(400, 10));
            m_out_filler01 = inString.Substring(410, 1);
            m_out_dof_map = new DofMap(inString.Substring(411, 9));
            m_out_x_coord = inString.Substring(420, 7);
            m_out_y_coord = inString.Substring(427, 7);
            m_out_ortho_tile_id = inString.Substring(434, 6);
            m_out_bin = new BIN(inString.Substring(440, 7));
            m_out_filler02 = inString.Substring(447, 188);
            m_out_reason_code = inString.Substring(635, 1);
            m_out_grc = inString.Substring(636, 2);
            m_out_error_message1 = inString.Substring(638, 80);
            m_out_error_message2 = inString.Substring(718, 80);
            m_out_error_message3 = inString.Substring(798, 80);
            m_out_number_of_similar_stnames = inString.Substring(878, 2);

            for (int i = 0; i < 10; i++)
            {
                try {
                    m_out_similar_stname_list[i] = inString.Substring(880 + (i * 32), 32);
                }
                catch {
                    m_out_similar_stname_list[i] = string.Empty;
                } 
            }
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.Append(m_in_azfct);
            sb.Append(c);
            sb.Append(m_in_func_code);
            sb.Append(c);
            sb.Append(m_in_mp_boro);
            sb.Append(c);
            sb.Append(m_in_mp_hnd);
            sb.Append(c);
            sb.Append(m_in_mp_stname1);
            sb.Append(c);
            sb.Append(m_in_mp_stname2);
            sb.Append(c);
            sb.Append(m_in_mp_boro2);
            sb.Append(c);
            sb.Append(m_in_mp_compass_dir);
            sb.Append(c);
            sb.Append(m_in_mp_txblk);
            sb.Append(c);
            sb.Append(m_in_mp_txlot);
            sb.Append(c);
            sb.Append(m_in_mp_txlot_version);
            sb.Append(c);
            sb.Append(m_in_mp_bin.Display());
            sb.Append(c);
            sb.Append(m_in_platform_ind);
            sb.Append(c);
            sb.Append(m_in_boro1);
            sb.Append(c);
            sb.Append(m_in_hnd);
            sb.Append(c);
            sb.Append(m_in_hns);
            sb.Append(c);
            sb.Append(m_in_filler01);
            sb.Append(c);
            sb.Append(m_in_b10sc1.Display());
            sb.Append(c);
            sb.Append(m_in_stname1);
            sb.Append(c);
            sb.Append(m_in_boro2);
            sb.Append(c);
            sb.Append(m_in_b10sc2.Display());
            sb.Append(c);
            sb.Append(m_in_stname2);
            sb.Append(c);
            sb.Append(m_in_compass_dir);
            sb.Append(c);
            sb.Append(m_in_snl);
            sb.Append(c);
            sb.Append(m_in_stname_normalization);
            sb.Append(c);
            sb.Append(m_in_bbl.Display());
            sb.Append(c);
            sb.Append(m_in_filler02);
            sb.Append(c);
            sb.Append(m_in_bin.Display());
            sb.Append(c);
            sb.Append(m_in_filler3);
            sb.Append(c);
            sb.Append(m_out_flood_ins_map_num);
            sb.Append(c);
            sb.Append(m_out_fimp_warn_msg);
            sb.Append(c);
            sb.Append(m_out_dcp_sect_map_num);
            sb.Append(c);
            sb.Append(m_out_dcp_zone_map_num);
            sb.Append(c);
            sb.Append(m_out_adjacent1_zone_num);
            sb.Append(c);
            sb.Append(m_out_adjacent2_zone_num);
            sb.Append(c);
            sb.Append(m_out_geo_map_num);
            sb.Append(c);
            sb.Append(m_out_sanborn1.Display());
            sb.Append(c);
            sb.Append(m_out_sanborn2.Display());
            sb.Append(c);
            sb.Append(m_out_bbl.Display());
            sb.Append(c);
            sb.Append(m_out_filler01);
            sb.Append(c);
            sb.Append(m_out_dof_map.Display());
            sb.Append(c);
            sb.Append(m_out_x_coord);
            sb.Append(c);
            sb.Append(m_out_y_coord);
            sb.Append(c);
            sb.Append(m_out_ortho_tile_id);
            sb.Append(c);
            sb.Append(m_out_bin.Display());
            sb.Append(c);
            sb.Append(m_out_filler02);
            sb.Append(c);
            sb.Append(m_out_reason_code);
            sb.Append(c);
            sb.Append(m_out_grc);
            sb.Append(c);
            sb.Append(m_out_error_message1);
            sb.Append(c);
            sb.Append(m_out_error_message2);
            sb.Append(c);
            sb.Append(m_out_error_message3);
            sb.Append(c);
            sb.Append(m_out_number_of_similar_stnames);
            sb.Append(c);

            for (i = 0; i < 10; i++)
            {
                sb.Append(m_out_similar_stname_list[i]);
                sb.Append(c);
            }

            return sb.ToString();
        }

        public override string Display() => Display('-');

        /// <summary>
        /// <c>Print</c>
        /// <para>Creates a string with <c>Wa1Aimz</c> field names and values</para>
        /// </summary>
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("in_azfct = {0}{1}", m_in_azfct, Environment.NewLine);
            sb.AppendFormat("in_func_code = {0}{1}", m_in_func_code, Environment.NewLine);
            sb.AppendFormat("in_mp_boro = {0}{1}", m_in_mp_boro, Environment.NewLine);
            sb.AppendFormat("in_mp_hnd = {0}{1}", m_in_mp_hnd, Environment.NewLine);
            sb.AppendFormat("in_mp_stname1 = {0}{1}", m_in_mp_stname1, Environment.NewLine);
            sb.AppendFormat("in_mp_stname2 = {0}{1}", m_in_mp_stname2, Environment.NewLine);
            sb.AppendFormat("in_mp_boro2 = {0}{1}", m_in_mp_boro2, Environment.NewLine);
            sb.AppendFormat("in_mp_compass_dir = {0}{1}", m_in_mp_compass_dir, Environment.NewLine);
            sb.AppendFormat("in_mp_txblk = {0}{1}", m_in_mp_txblk, Environment.NewLine);
            sb.AppendFormat("in_mp_txlot = {0}{1}", m_in_mp_txlot, Environment.NewLine);
            sb.AppendFormat("in_mp_txlot_version = {0}{1}", m_in_mp_txlot_version, Environment.NewLine);
            sb.AppendFormat("in_mp_bin = {0}{1}", m_in_mp_bin.Display(), Environment.NewLine);
            sb.AppendFormat("in_platform_ind = {0}{1}", m_in_platform_ind, Environment.NewLine);
            sb.AppendFormat("in_boro1 = {0}{1}", m_in_boro1, Environment.NewLine);
            sb.AppendFormat("in_hnd = {0}{1}", m_in_hnd, Environment.NewLine);
            sb.AppendFormat("in_hns = {0}{1}", m_in_hns, Environment.NewLine);
            sb.AppendFormat("in_filler01 = {0}{1}", m_in_filler01, Environment.NewLine);
            sb.AppendFormat("in_b10sc1 = {0}{1}", m_in_b10sc1.Display(), Environment.NewLine);
            sb.AppendFormat("in_stname1 = {0}{1}", m_in_stname1, Environment.NewLine);
            sb.AppendFormat("in_boro2 = {0}{1}", m_in_boro2, Environment.NewLine);
            sb.AppendFormat("in_b10sc2 = {0}{1}", m_in_b10sc2.Display(), Environment.NewLine);
            sb.AppendFormat("in_stname2 = {0}{1}", m_in_stname2, Environment.NewLine);
            sb.AppendFormat("in_compass_dir = {0}{1}", m_in_compass_dir, Environment.NewLine);
            sb.AppendFormat("in_snl = {0}{1}", m_in_snl, Environment.NewLine);
            sb.AppendFormat("in_stname_normalization = {0}{1}", m_in_stname_normalization, Environment.NewLine);
            sb.AppendFormat("in_bbl = {0}{1}", m_in_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("in_filler02 = {0}{1}", m_in_filler02, Environment.NewLine);
            sb.AppendFormat("in_bin = {0}{1}", m_in_bin.Display(), Environment.NewLine);
            sb.AppendFormat("in_filler3 = {0}{1}", m_in_filler3, Environment.NewLine);
            sb.AppendFormat("out_flood_ins_map_num = {0}{1}", m_out_flood_ins_map_num, Environment.NewLine);
            sb.AppendFormat("out_fimp_warn_msg = {0}{1}", m_out_fimp_warn_msg, Environment.NewLine);
            sb.AppendFormat("out_dcp_sect_map_num = {0}{1}", m_out_dcp_sect_map_num, Environment.NewLine);
            sb.AppendFormat("out_dcp_zone_map_num = {0}{1}", m_out_dcp_zone_map_num, Environment.NewLine);
            sb.AppendFormat("out_adjacent1_zone_num = {0}{1}", m_out_adjacent1_zone_num, Environment.NewLine);
            sb.AppendFormat("out_adjacent2_zone_num = {0}{1}", m_out_adjacent2_zone_num, Environment.NewLine);
            sb.AppendFormat("out_geo_map_num = {0}{1}", m_out_geo_map_num, Environment.NewLine);
            sb.AppendFormat("out_sanborn1 = {0}{1}", m_out_sanborn1.Display(), Environment.NewLine);
            sb.AppendFormat("out_sanborn2 = {0}{1}", m_out_sanborn2.Display(), Environment.NewLine);
            sb.AppendFormat("out_bbl = {0}{1}", m_out_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("out_filler01 = {0}{1}", m_out_filler01, Environment.NewLine);
            sb.AppendFormat("out_dof_map = {0}{1}", m_out_dof_map.Display(), Environment.NewLine);
            sb.AppendFormat("out_x_coord = {0}{1}", m_out_x_coord, Environment.NewLine);
            sb.AppendFormat("out_y_coord = {0}{1}", m_out_y_coord, Environment.NewLine);
            sb.AppendFormat("out_ortho_tile_id = {0}{1}", m_out_ortho_tile_id, Environment.NewLine);
            sb.AppendFormat("out_bin = {0}{1}", m_out_bin.Display(), Environment.NewLine);
            sb.AppendFormat("out_filler02 = {0}{1}", m_out_filler02, Environment.NewLine);
            sb.AppendFormat("out_reason_code = {0}{1}", m_out_reason_code, Environment.NewLine);
            sb.AppendFormat("out_grc = {0}{1}", m_out_grc, Environment.NewLine);
            sb.AppendFormat("out_error_message1 = {0}{1}", m_out_error_message1, Environment.NewLine);
            sb.AppendFormat("out_error_message2 = {0}{1}", m_out_error_message2, Environment.NewLine);
            sb.AppendFormat("out_error_message3 = {0}{1}", m_out_error_message3, Environment.NewLine);
            sb.AppendFormat("out_number_of_similar_stnames = {0}{1}", m_out_number_of_similar_stnames, Environment.NewLine);

            for (i = 0; i < 10; i++)
            {
                sb.AppendFormat("out_similar_stname_list({0}) = {1}{2}", i, m_out_similar_stname_list[i], Environment.NewLine);
            }

            return sb.ToString();
        }

        public string in_azfct
        {
            get => m_in_azfct;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                if (strlen > 0)
                    m_in_azfct = value.Substring(0, strlen);
            }
        }

        public string in_func_code
        {
            get => m_in_func_code;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                if (strlen > 0)
                    m_in_func_code = value.Substring(0, strlen);
            }
        }

        public string in_mp_boro
        {
            get => m_in_mp_boro;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_mp_boro = value.Substring(0, strlen);
            }
        }

        public string in_mp_hnd
        {
            get => m_in_mp_hnd;
            set
            {
                int strlen = value.Length;
                if (strlen > 12) strlen = 12;
                if (strlen > 0)
                    m_in_mp_hnd = value.Substring(0, strlen);
            }
        }

        public string in_mp_stname1
        {
            get => m_in_mp_stname1;
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                if (strlen > 0)
                    m_in_mp_stname1 = value.Substring(0, strlen);
            }
        }

        public string in_mp_stname2
        {
            get => m_in_mp_stname2;
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                if (strlen > 0)
                    m_in_mp_stname2 = value.Substring(0, strlen);
            }
        }

        public string in_mp_boro2
        {
            get => m_in_mp_boro2;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_mp_boro2 = value.Substring(0, strlen);
            }
        }

        public string in_mp_compass_dir
        {
            get => m_in_mp_compass_dir;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_mp_compass_dir = value.Substring(0, strlen);
            }
        }

        public string in_mp_txblk
        {
            get => m_in_mp_txblk;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                if (strlen > 0)
                    m_in_mp_txblk = value.Substring(0, strlen);
            }
        }

        public string in_mp_txlot
        {
            get => m_in_mp_txlot;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                if (strlen > 0)
                    m_in_mp_txlot = value.Substring(0, strlen);
            }
        }

        public string in_mp_txlot_version
        {
            get => m_in_mp_txlot_version;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_mp_txlot_version = value.Substring(0, strlen);
            }
        }

        public BIN in_mp_bin
        {
            get => m_in_mp_bin;
            set => m_in_mp_bin = value;
        }

        public string in_platform_ind
        {
            get => m_in_platform_ind;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_platform_ind = value.Substring(0, strlen);
            }
        }

        public string in_boro1
        {
            get => m_in_boro1;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_boro1 = value.Substring(0, strlen);
            }
        }

        public string in_hnd
        {
            get => m_in_hnd;
            set
            {
                int strlen = value.Length;
                if (strlen > 12) strlen = 12;
                if (strlen > 0)
                    m_in_hnd = value.Substring(0, strlen);
            }
        }

        public string in_hns
        {
            get => m_in_hns;
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                if (strlen > 0)
                    m_in_hns = value.Substring(0, strlen);
            }
        }

        public string in_filler01
        {
            get => m_in_filler01;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_filler01 = value.Substring(0, strlen);
            }
        }

        public B10sc in_b10sc1
        {
            get => m_in_b10sc1;
            set => m_in_b10sc1 = value;
        }

        public string in_stname1
        {
            get => m_in_stname1;
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                if (strlen > 0)
                    m_in_stname1 = value.Substring(0, strlen);
            }
        }

        public string in_boro2
        {
            get => m_in_boro2;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_boro2 = value.Substring(0, strlen);
            }
        }

        public B10sc in_b10sc2
        {
            get => m_in_b10sc2;
            set => m_in_b10sc2 = value;
        }

        public string in_stname2
        {
            get => m_in_stname2;
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                if (strlen > 0)
                    m_in_stname2 = value.Substring(0, strlen);
            }
        }

        public string in_compass_dir
        {
            get => m_in_compass_dir;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_compass_dir = value.Substring(0, strlen);
            }
        }

        public string in_snl
        {
            get => m_in_snl;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                if (strlen > 0)
                    m_in_snl = value.Substring(0, strlen);
            }
        }

        public string in_stname_normalization
        {
            get => m_in_stname_normalization;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_stname_normalization = value.Substring(0, strlen);
            }
        }

        public BBL in_bbl
        {
            get => m_in_bbl;
            set => m_in_bbl = value;
        }

        public string in_filler02
        {
            get => m_in_filler02;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                if (strlen > 0)
                    m_in_filler02 = value.Substring(0, strlen);
            }
        }

        public BIN in_bin
        {
            get => m_in_bin;
            set => m_in_bin = value;
        }

        public string in_filler3
        {
            get => m_in_filler3;
            set
            {
                int strlen = value.Length;
                if (strlen > 50) strlen = 50;
                if (strlen > 0)
                    m_in_filler3 = value.Substring(0, strlen);
            }
        }

        public string out_flood_ins_map_num
        {
            get => m_out_flood_ins_map_num;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                if (strlen > 0)
                    m_out_flood_ins_map_num = value.Substring(0, strlen);
            }
        }

        // Repeat the same process for other properties...
        public string out_fimp_warn_msg
        {
            get => m_out_fimp_warn_msg;
            set
            {
                int strlen = Math.Min(value.Length, 80);
                if (strlen > 0) m_out_fimp_warn_msg = value.Substring(0, strlen);
            }
        }

        public string out_dcp_sect_map_num
        {
            get => m_out_dcp_sect_map_num;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                if (strlen > 0) m_out_dcp_sect_map_num = value.Substring(0, strlen);
            }
        }

        public string out_dcp_zone_map_num
        {
            get => m_out_dcp_zone_map_num;
            set
            {
                int strlen = Math.Min(value.Length, 3);
                if (strlen > 0) m_out_dcp_zone_map_num = value.Substring(0, strlen);
            }
        }

        public string out_adjacent1_zone_num
        {
            get => m_out_adjacent1_zone_num;
            set
            {
                int strlen = Math.Min(value.Length, 3);
                if (strlen > 0) m_out_adjacent1_zone_num = value.Substring(0, strlen);
            }
        }

        public string out_adjacent2_zone_num
        {
            get => m_out_adjacent2_zone_num;
            set
            {
                int strlen = Math.Min(value.Length, 3);
                if (strlen > 0) m_out_adjacent2_zone_num = value.Substring(0, strlen);
            }
        }

        public string out_geo_map_num
        {
            get => m_out_geo_map_num;
            set
            {
                int strlen = Math.Min(value.Length, 3);
                if (strlen > 0) m_out_geo_map_num = value.Substring(0, strlen);
            }
        }

        public Sanborn out_sanborn1
        {
            get => m_out_sanborn1;
            set => m_out_sanborn1 = value;
        }

        public Sanborn out_sanborn2
        {
            get => m_out_sanborn2;
            set => m_out_sanborn2 = value;
        }

        public BBL out_bbl
        {
            get => m_out_bbl;
            set => m_out_bbl = value;
        }

        public string out_filler01
        {
            get => m_out_filler01;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                if (strlen > 0) m_out_filler01 = value.Substring(0, strlen);
            }
        }

        public DofMap out_dof_map
        {
            get => m_out_dof_map;
            set => m_out_dof_map = value;
        }

        public string out_x_coord
        {
            get => m_out_x_coord;
            set
            {
                int strlen = Math.Min(value.Length, 7);
                if (strlen > 0) m_out_x_coord = value.Substring(0, strlen);
            }
        }

        public string out_y_coord
        {
            get => m_out_y_coord;
            set
            {
                int strlen = Math.Min(value.Length, 7);
                if (strlen > 0) m_out_y_coord = value.Substring(0, strlen);
            }
        }

        public string out_ortho_tile_id
        {
            get => m_out_ortho_tile_id;
            set
            {
                int strlen = Math.Min(value.Length, 6);
                if (strlen > 0) m_out_ortho_tile_id = value.Substring(0, strlen);
            }
        }

        public BIN out_bin
        {
            get => m_out_bin;
            set => m_out_bin = value;
        }

        public string out_filler02
        {
            get => m_out_filler02;
            set
            {
                int strlen = Math.Min(value.Length, 188);
                if (strlen > 0) m_out_filler02 = value.Substring(0, strlen);
            }
        }

        public string out_reason_code
        {
            get => m_out_reason_code;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                if (strlen > 0) m_out_reason_code = value.Substring(0, strlen);
            }
        }

        public string out_grc
        {
            get => m_out_grc;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                if (strlen > 0) m_out_grc = value.Substring(0, strlen);
            }
        }

        public string out_error_message1
        {
            get => m_out_error_message1;
            set
            {
                int strlen = Math.Min(value.Length, 80);
                if (strlen > 0) m_out_error_message1 = value.Substring(0, strlen);
            }
        }

        public string out_error_message2
        {
            get => m_out_error_message2;
            set
            {
                int strlen = Math.Min(value.Length, 80);
                if (strlen > 0) m_out_error_message2 = value.Substring(0, strlen);
            }
        }

        public string out_error_message3
        {
            get => m_out_error_message3;
            set
            {
                int strlen = Math.Min(value.Length, 80);
                if (strlen > 0) m_out_error_message3 = value.Substring(0, strlen);
            }
        }

        public string out_number_of_similar_stnames
        {
            get => m_out_number_of_similar_stnames;
            set
            {
                int strlen = Math.Min(value.Length, 2);
                if (strlen > 0) m_out_number_of_similar_stnames = value.Substring(0, strlen);
            }
        }

        [XmlArrayItem(ElementName = "stname")]
        public string[] out_similar_stname_list
        {
            get => m_out_similar_stname_list;
            set => m_out_similar_stname_list = value;
        }

        public string out_similar_stname_list_item(int index) => m_out_similar_stname_list[index];

        public void out_similar_stname_list_item(int index, string value)
        {
                int strlen = Math.Min(value.Length, 32);
                if (strlen > 0) m_out_similar_stname_list[index] = value.Substring(0, strlen);
        }

    }
}
