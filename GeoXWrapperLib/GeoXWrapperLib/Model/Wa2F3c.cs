using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3c : WA
    {
        private string m_gridkey3;
        private string m_cont_parity_ind;
        private string m_loc_status;
        private string m_county_boundary;
        private string m_dcp_pref_lgc1;
        private string m_dcp_pref_lgc2;
        private string m_dcp_pref_lgc3;
        private string m_lo_x_sts_cnt;
        private B5sc[] m_lo_x_sts = new B5sc[5];
        private string m_hi_x_sts_cnt;
        private B5sc[] m_hi_x_sts = new B5sc[5];
        private string m_x_street_reversal_flag;
        private LionKey m_lionkey;
        private string m_generated_record_flag;
        private string m_segment_len;
        private string m_segment_azm;
        private string m_segment_orient;
        private string m_mh_ri_flag;
        private string m_from_node;
        private string m_to_node;
        private string m_dsny_snow_priority;
        private string m_filler01;
        private string m_segment_id;
        private string m_dot_street_light_contract_area;
        private string m_sos_ind;
        private string m_curve_flag;
        private string m_feature_type;
        private string m_segment_type;
        private string m_coincident_seg_cnt;
        private string m_pgb_flag;
        private string m_filler02;
        private SegSide m_seg_side;

        public Wa2F3c()
        {
            m_gridkey3 = new string(' ', 21);
            m_cont_parity_ind = new string(' ', 1);
            m_loc_status = new string(' ', 1);
            m_county_boundary = new string(' ', 1);
            m_dcp_pref_lgc1 = new string(' ', 2);
            m_dcp_pref_lgc2 = new string(' ', 2);
            m_dcp_pref_lgc3 = new string(' ', 2);
            m_lo_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i < 5; i++)
            {
                m_lo_x_sts[i] = new B5sc();
            }
            m_hi_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i < 5; i++)
            {
                m_hi_x_sts[i] = new B5sc();
            }
            m_x_street_reversal_flag = new string(' ', 1);
            m_lionkey = new LionKey();
            m_generated_record_flag = new string(' ', 1);
            m_segment_len = new string(' ', 5);
            m_segment_azm = new string(' ', 3);
            m_segment_orient = new string(' ', 1);
            m_mh_ri_flag = new string(' ', 1);
            m_from_node = new string(' ', 7);
            m_to_node = new string(' ', 7);
            m_dsny_snow_priority = new string(' ', 1);
            m_filler01 = new string(' ', 4);
            m_segment_id = new string(' ', 7);
            m_dot_street_light_contract_area = new string(' ', 1);
            m_sos_ind = new string(' ', 1);
            m_curve_flag = new string(' ', 1);
            m_feature_type = new string(' ', 1);
            m_segment_type = new string(' ', 1);
            m_coincident_seg_cnt = new string(' ', 1);
            m_pgb_flag = new string(' ', 3);
            m_filler02 = new string(' ', 1);
            m_seg_side = new SegSide();
        }
        /// <summary>
        /// <c>Clear</c> reinitializes the <c>Wa2F3c</c> object to spaces
        /// </summary>
        public override void Clear()
        {
            Wa2F3cFromString(new string(' ', 300));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa2F3c</c> object to a string
        /// </summary>
        public override string ToString()
        {
            return Wa2F3cToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa2F3c</c> object
        /// </summary>
        public override void FromString(string inString)
        {
            Wa2F3cFromString(inString);
        }

        /// <summary>
        /// <c>Wa2F3cToString</c> converts a <c>Wa2F3c</c> object to a string
        /// </summary>
        public string Wa2F3cToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_gridkey3);
            sb.Append(m_cont_parity_ind);
            sb.Append(m_loc_status);
            sb.Append(m_county_boundary);
            sb.Append(m_dcp_pref_lgc1);
            sb.Append(m_dcp_pref_lgc2);
            sb.Append(m_dcp_pref_lgc3);
            sb.Append(m_lo_x_sts_cnt);

            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_lo_x_sts[i].B5scToString());
            }

            sb.Append(m_hi_x_sts_cnt);

            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_hi_x_sts[i].B5scToString());
            }

            sb.Append(m_x_street_reversal_flag);
            sb.Append(m_lionkey.LionKeyToString());
            sb.Append(m_generated_record_flag);
            sb.Append(m_segment_len);
            sb.Append(m_segment_azm);
            sb.Append(m_segment_orient);
            sb.Append(m_mh_ri_flag);

            // spo (2007-07-17) added m_from_node & m_to_node
            sb.Append(m_from_node);
            sb.Append(m_to_node);

            // --spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_dsny_snow_priority);
            sb.Append(m_filler01);
            sb.Append(m_segment_id);
            sb.Append(m_dot_street_light_contract_area);

            // -----------------------------------------------------------------------
            // ---spo(2016-05-03):    Correcting original error 
            // ---                    In wa2f3 m_curve_flag is in the below location
            // ---                    but in wa2f3c it is one position farther down 
            // ---                    In wa2f3 there is a dog_leg field 
            // ---                    but in wa2f3c there is a sos_ind field 
            // -----------------------------------------------------------------------
            // sb.Append(m_curve_flag);
            // sb.Append(m_dog_leg);

            sb.Append(m_sos_ind);
            sb.Append(m_curve_flag);
            sb.Append(m_feature_type);
            sb.Append(m_segment_type);

            // spo (2007-07-18) added m_coincident_seg_cnt 
            sb.Append(m_coincident_seg_cnt);

            // --SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler04 by 3 bytes
            sb.Append(m_pgb_flag);

            sb.Append(m_filler02);
            sb.Append(m_seg_side.SegSideToString());

            return sb.ToString();
        }


        public void Wa2F3cFromString(string inString)
        {
            int i;

            m_gridkey3 = inString.Substring(0, 21);
            m_cont_parity_ind = inString.Substring(21, 1);
            m_loc_status = inString.Substring(22, 1);
            m_county_boundary = inString.Substring(23, 1);
            m_dcp_pref_lgc1 = inString.Substring(24, 2);
            m_dcp_pref_lgc2 = inString.Substring(26, 2);
            m_dcp_pref_lgc3 = inString.Substring(28, 2);
            m_lo_x_sts_cnt = inString.Substring(30, 1);

            for (i = 0; i <= 4; i++)
                try { m_lo_x_sts[i] = new B5sc(inString.Substring(31 + (i * 6), 6)); }catch { m_lo_x_sts[i] = new B5sc(); }
            

            m_hi_x_sts_cnt = inString.Substring(61, 1);

            for (i = 0; i <= 4; i++)
                try { m_hi_x_sts[i] = new B5sc(inString.Substring(62 + (i * 6), 6)); } catch { m_hi_x_sts[i] = new B5sc(); }


            m_x_street_reversal_flag = inString.Substring(92, 1);
            m_lionkey = new LionKey(inString.Substring(93, 10));
            m_generated_record_flag = inString.Substring(103, 1);
            m_segment_len = inString.Substring(104, 5);
            m_segment_azm = inString.Substring(109, 3);
            m_segment_orient = inString.Substring(112, 1);
            m_mh_ri_flag = inString.Substring(113, 1);

            // spo (2007-07-17) added m_from_node & m_to_node
            m_from_node = inString.Substring(114, 7);
            m_to_node = inString.Substring(121, 7);

            // --spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            m_dsny_snow_priority = inString.Substring(128, 1);
            m_filler01 = inString.Substring(129, 4);
            m_segment_id = inString.Substring(133, 7);
            m_dot_street_light_contract_area = inString.Substring(140, 1);

            // ---spo(2016-05-03): Correcting original error
            // --- In wa2f3 m_curve_flag is in the below location but in wa2f3c it is one position farther down
            // --- In wa2f3 there is a dog_leg field but in wa2f3c there is a sos_ind field
            m_sos_ind = inString.Substring(141, 1);
            m_curve_flag = inString.Substring(142, 1);
            m_feature_type = inString.Substring(143, 1);
            m_segment_type = inString.Substring(144, 1);

            // spo (2007-07-17) added m_coincident_seg_cnt 
            m_coincident_seg_cnt = inString.Substring(145, 1);

            // --SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler04 by 3 bytes
            m_pgb_flag = inString.Substring(146, 3);

            m_filler02 = inString.Substring(149, 1);

            // m_filler02 = inString.Substring(146, 4);

            m_seg_side = new SegSide(inString.Substring(150, 150));
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.Append(m_gridkey3);
            sb.Append(c);
            sb.Append(m_cont_parity_ind);
            sb.Append(c);
            sb.Append(m_loc_status);
            sb.Append(c);
            sb.Append(m_county_boundary);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc1);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc2);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc3);
            sb.Append(c);
            sb.Append(m_lo_x_sts_cnt);
            sb.Append(c);

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_sts[i].Display());
                sb.Append(c);
            }

            sb.Append(m_hi_x_sts_cnt);
            sb.Append(c);

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_hi_x_sts[i].Display());
                sb.Append(c);
            }

            sb.Append(m_x_street_reversal_flag);
            sb.Append(c);
            sb.Append(m_lionkey.Display());
            sb.Append(c);
            sb.Append(m_generated_record_flag);
            sb.Append(c);
            sb.Append(m_segment_len);
            sb.Append(c);
            sb.Append(m_segment_azm);
            sb.Append(c);
            sb.Append(m_segment_orient);
            sb.Append(c);
            sb.Append(m_mh_ri_flag);
            sb.Append(c);

            // spo (2007-07-17) added m_from_node & m_to_node
            sb.Append(m_from_node);
            sb.Append(c);
            sb.Append(m_to_node);
            sb.Append(c);

            // --spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);
            sb.Append(m_filler01);
            sb.Append(c);
            sb.Append(m_segment_id);
            sb.Append(c);
            sb.Append(m_dot_street_light_contract_area);
            sb.Append(c);

            // ---spo(2016-05-03): Correcting original error
            // --- In wa2f3 m_curve_flag is in the below location but in wa2f3c it is one position farther down
            // --- In wa2f3 there is a dog_leg field but in wa2f3c there is a sos_ind field
            sb.Append(m_sos_ind);
            sb.Append(c);
            sb.Append(m_curve_flag);
            sb.Append(c);
            sb.Append(m_feature_type);
            sb.Append(c);
            sb.Append(m_segment_type);
            sb.Append(c);

            // spo (2007-07-17) added m_coincident_seg_cnt 
            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);

            // --SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler04 by 3 bytes
            sb.Append(m_pgb_flag);
            sb.Append(c);

            sb.Append(m_filler02);
            sb.Append(c);
            sb.Append(m_seg_side.Display());
            sb.Append(c);

            return sb.ToString();
        }

        // Overloaded version without the parameter, using default '-'
        public override string Display()
        {
            return this.Display('-');
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("gridkey3 = {0}{1}", m_gridkey3, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);
            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);
            sb.AppendFormat("lionkey = {0}{1}", m_lionkey.Display(), Environment.NewLine);
            sb.AppendFormat("generated_record_flag = {0}{1}", m_generated_record_flag, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);

            // spo (2007-07-17) added m_from_node & m_to_node
            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            // --spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A 
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            // ---spo(2016-05-03): Correcting original error
            // --- In wa2f3 m_curve_flag is in the below location but in wa2f3c it is one position farther down
            // --- In wa2f3 there is a dog_leg field but in wa2f3c there is a sos_ind field
            sb.AppendFormat("sos_ind = {0}{1}", m_sos_ind, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);

            // spo (2007-07-17) added m_coincident_seg_cnt 
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);

            // --SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler04 by 3 bytes
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            // ---spo(2016-05-10): Enhanced the presentation of Segside data
            // --- Added Print version for easier reading 
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("seg_side (display) = {0}{1}", m_seg_side.Display(), Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("seg_side (print) = {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_seg_side.Print);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F3c  ***********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Key Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("gridkey3 = {0}{1}", m_gridkey3, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);

            // --SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler04 by 3 bytes
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Geographic Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("lionkey = {0}{1}", m_lionkey.Display(), Environment.NewLine);
            sb.AppendFormat("generated_record_flag = {0}{1}", m_generated_record_flag, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            //sb.AppendFormat("dog_leg = {0}{1}", m_dog_leg, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);

            //sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Election District Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Other District Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            //sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Sanitation Information  **********", Environment.NewLine + Environment.NewLine);

            //sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Police and Fire Information  **********", Environment.NewLine + Environment.NewLine);

            //sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Census Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Cross Streets Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Miscellaneous Filler Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            //-----------------------------------------------------------------------
            //--spo(2016-05-10): Enhanced the presentation of Segside data 
            //--                Added Print version for easier reading 
            //-----------------------------------------------------------------------
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("SEGMENT SIDE {0}", Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_seg_side.Print());
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            return sb.ToString();
        }

        public string gridkey3
        {
            get => m_gridkey3;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 21);
                m_gridkey3 = value.Substring(0, strlen);
            }
        }

        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        public string loc_status
        {
            get => m_loc_status;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_loc_status = value.Substring(0, strlen);
            }
        }

        public string county_boundary
        {
            get => m_county_boundary;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_county_boundary = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc1
        {
            get => m_dcp_pref_lgc1;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 2);
                m_dcp_pref_lgc1 = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc2
        {
            get => m_dcp_pref_lgc2;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 2);
                m_dcp_pref_lgc2 = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc3
        {
            get => m_dcp_pref_lgc3;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 2);
                m_dcp_pref_lgc3 = value.Substring(0, strlen);
            }
        }

        public string lo_x_sts_cnt
        {
            get => m_lo_x_sts_cnt;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_lo_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B5sc[] lo_x_sts
        {
            get => m_lo_x_sts;
            set => m_lo_x_sts = value;
        }

        public B5sc lo_x_sts_item(int index) => m_lo_x_sts[index];
        public void lo_x_sts_item(int index, B5sc value) => m_lo_x_sts[index] = value;
      
        public string hi_x_sts_cnt
        {
            get => m_hi_x_sts_cnt;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_hi_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B5sc[] hi_x_sts
        {
            get => m_hi_x_sts;
            set => m_hi_x_sts = value;
        }

        public B5sc hi_x_sts_item(int index) => m_hi_x_sts[index];
        public void hi_x_sts_item(int index, B5sc value) => m_hi_x_sts[index] = value;

        public string x_street_reversal_flag
        {
            get => m_x_street_reversal_flag;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_x_street_reversal_flag = value.Substring(0, strlen);
            }
        }

        public LionKey lionkey
        {
            get => m_lionkey;
            set => m_lionkey = value;
        }

        public string generated_record_flag
        {
            get => m_generated_record_flag;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_generated_record_flag = value.Substring(0, strlen);
            }
        }

        public string segment_len
        {
            get => m_segment_len;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 5);
                m_segment_len = value.Substring(0, strlen);
            }
        }

        public string segment_azm
        {
            get => m_segment_azm;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 3);
                m_segment_azm = value.Substring(0, strlen);
            }
        }

        public string segment_orient
        {
            get => m_segment_orient;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_segment_orient = value.Substring(0, strlen);
            }
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_mh_ri_flag = value.Substring(0, strlen);
            }
        }

        public string from_node
        {
            get => m_from_node;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 7);
                m_from_node = value.Substring(0, strlen);
            }
        }

        public string to_node
        {
            get => m_to_node;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 7);
                m_to_node = value.Substring(0, strlen);
            }
        }

        public string dsny_snow_priority
        {
            get => m_dsny_snow_priority;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 1);
                m_dsny_snow_priority = value.Substring(0, strlen);
            }
        }

        public string filler01
        {
            get => m_filler01;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 4);
                m_filler01 = value.Substring(0, strlen);
            }
        }

        // Property for segment_id
        public string segment_id
        {
            get => m_segment_id;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_segment_id = value.Substring(0, strlen);
            }
        }

        // Property for dot_street_light_contract_area
        public string dot_street_light_contract_area
        {
            get => m_dot_street_light_contract_area;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_dot_street_light_contract_area = value.Substring(0, strlen);
            }
        }

        // Property for sos_ind
        public string sos_ind
        {
            get => m_sos_ind;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_sos_ind = value.Substring(0, strlen);
            }
        }

        // Property for curve_flag
        public string curve_flag
        {
            get => m_curve_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_curve_flag = value.Substring(0, strlen);
            }
        }

        // Property for feature_type
        public string feature_type
        {
            get => m_feature_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_feature_type = value.Substring(0, strlen);
            }
        }

        // Property for segment_type
        public string segment_type
        {
            get => m_segment_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_segment_type = value.Substring(0, strlen);
            }
        }

        // Property for coincident_seg_cnt
        public string coincident_seg_cnt
        {
            get => m_coincident_seg_cnt;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_coincident_seg_cnt = value.Substring(0, strlen);
            }
        }

        // Property for pgb_flag
        public string pgb_flag
        {
            get => m_pgb_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_pgb_flag = value.Substring(0, strlen);
            }
        }

        // Property for filler02
        public string filler02
        {
            get => m_filler02;
            set
            {
                int strlen = value.Length;
                // If you want to limit it to 1 character as in the original code
                if (strlen > 1) strlen = 1;
                m_filler02 = value.Substring(0, strlen);
            }
        }

        // Property for seg_side
        public SegSide seg_side
        {
            get => m_seg_side;
            set => m_seg_side = value;
        }

    }

}
