using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa1 : WA
    {
        string m_in_func_code { get; set; } = new string(' ', 2);
        string m_in_hnd { get; set; } = new string(' ', 16);
        string m_in_hns { get; set; } = new string(' ', 11);
        string m_in_low_hnd { get; set; } = new string(' ', 16);
        string m_in_low_hns { get; set; } = new string(' ', 11);
        B10sc m_in_b10sc1 { get; set; } = new B10sc();
        string m_in_stname1 { get; set; } = new string(' ', 32);
        B10sc m_in_b10sc2 { get;  set; } = new B10sc();
        string m_in_stname2 { get; set; } = new string(' ', 32);
        B10sc m_in_b10sc3 { get; set; } = new B10sc();
        string m_in_stname3 { get; set; } = new string(' ', 32);
        BBL m_in_bbl { get; set; } = new BBL();
        string m_in_filler01 { get; set; } = new string(' ', 1);
        BIN m_in_bin { get; set; } = new BIN();
        string m_in_compass_dir { get; set; } = new string(' ', 1);
        string m_in_compass_dir2 { get; set; } = new string(' ', 1);
        string m_in_node { get; set; } = new string(' ', 7);
        string m_in_platform_ind { get; set; } = new string(' ', 1);
        string m_in_zip_code { get; set; } = new string(' ', 5);

        string m_in_unit { get; set; } = new string(' ', 14);
        string m_in_filler03 { get; set; } = new string(' ', 82);

        string m_in_long_wa2_flag { get; set; } = new string(' ', 1);
        string m_in_hn_justification { get; set; } = new string(' ', 1);

        string m_in_hnl { get; set; } = new string(' ', 2);
        string m_in_hn_norm_override { get; set; } = new string(' ', 1);
        string m_in_snl { get; set; } = new string(' ', 2);
        string m_in_stname_normalization { get; set; } = new string(' ', 1);
        string m_in_xstreet_names_flag { get; set; } = new string(' ', 1);
        string m_in_roadbed_request_switch { get; set; } = new string(' ', 1);
        string m_in_legacy_grc_flag { get; set; } = new string(' ', 1);
        string m_in_auxseg_switch { get; set; } = new string(' ', 1);
        string m_in_browse_flag { get; set; } = new string(' ', 1);
        string m_in_real_street_only { get; set; } = new string(' ', 1);

        string m_in_tpad_switch { get; set; } = new string(' ', 1);
        string m_in_mode_switch { get; set; } = new string(' ', 1);

        string m_in_filler04 { get; set; } = new string(' ', 30);

        string m_out_boro_name1 { get; set; } = new string(' ', 9);

        string m_out_hnd { get; set; } = new string(' ', 16);
        string m_out_hns { get; set; } = new string(' ', 11);
        B10sc m_out_b10sc1 { get; set; } = new B10sc();
        string m_out_stname1 { get; set; } = new string(' ', 32);
        B10sc m_out_b10sc2 { get; set; } = new B10sc();

        string m_out_stname2 { get; set; } = new string(' ', 32);
        B10sc m_out_b10sc3 { get; set; } = new B10sc();
        string m_out_stname3 { get; set; } = new string(' ', 32);
        BBL m_out_bbl { get; set; } = new BBL();
        string m_out_filler02 { get; set; } = new string(' ', 1);

        string m_out_low_hnd { get; set; } = new string(' ', 16);
        string m_out_low_hns { get; set; } = new string(' ', 11);
        BIN m_out_bin { get; set; } = new BIN();

        string[] m_out_attr_bytes { get; set;} = new string[3];
        string m_out_reason_code2 { get; set; } = new string(' ', 1);
        string m_out_reason_code_qualifier2 { get; set; } = new string(' ', 1);
        string m_out_warning_code2 { get; set; } = new string(' ', 1);
        string m_out_grc2 { get; set; } = new string(' ', 2);
        string m_out_error_message2 { get; set; } = new string(' ', 80);
        string m_out_node { get; set; } = new string(' ', 7);

        UNIT m_out_units { get; set; } = new UNIT();
        string m_out_unit { get; set; } = new string(' ', 14);
        string m_out_filler03 { get; set; } = new string(' ', 17);
        string m_out_st_attr { get; set; } = new string(' ', 1);
        string m_out_reason_code { get; set; } = new string(' ', 1);
        string m_out_reason_code_qualifier { get; set; } = new string(' ', 1);
        string m_out_warning_code { get; set; } = new string(' ', 2);
        string m_out_grc { get; set; } = new string(' ', 2);
        string m_out_error_message { get; set; } = new string(' ', 80);
        string m_out_number_of_stcodes { get; set; } = new string(' ', 2);
        B7sc[] m_out_b7sc_list { get; set; } = new B7sc[10];
        string[] m_out_stname_list { get; set; } = new string[10];


        public string in_func_code
        {
            get => m_in_func_code;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 2)
                    strlen = 2;
                m_in_func_code = new string(' ', 2);
                if (strlen > 0)
                {
                    m_in_func_code = value.Substring(0, strlen).PadRight(2);
                }
            }
        }
        public string in_hnd
        {
            get => m_in_hnd;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 16)
                    strlen = 16;
                m_in_hnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_in_hnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        public string in_hns
        {
            get => m_in_hns;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 11)
                    strlen = 11;
                m_in_hns = new string(' ', 11);
                if (strlen > 0)
                {
                    m_in_hns = value.Substring(0, strlen).PadRight(11);
                }
            }
        }
        public string in_low_hnd
        {
            get => m_in_low_hnd; 
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_in_low_hnd = new string(' ', 16);
                if (strlen > 0)
                    m_in_low_hnd = value.Substring(0, strlen).PadRight(16);
            }
        }

        public string in_low_hns
        {
            get => m_in_low_hns; 
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_in_low_hns = new string(' ', 11);
                if (strlen > 0)
                    m_in_low_hns = value.Substring(0, strlen).PadRight(11);
            }
        }

        public B10sc in_b10sc1
        {
            get => m_in_b10sc1; 
            set { m_in_b10sc1 = value; }
        }

        [XmlIgnore]
        public string in_boro1
        {
            get => m_in_b10sc1?.boro; 
            set { m_in_b10sc1.boro = value; }
        }

        [XmlIgnore]
        public string in_boro2
        {
            get => m_in_b10sc2?.boro; 
            set { m_in_b10sc2.boro = value; }
        }

        [XmlIgnore]
        public string in_boro3
        {
            get => m_in_b10sc3?.boro; 
            set { m_in_b10sc3.boro = value; }
        }

        public string in_stname1
        {
            get => m_in_stname1; 
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_in_stname1 = new string(' ', 32);
                if (strlen > 0)
                    m_in_stname1 = value.Substring(0, strlen).PadRight(32);
            }
        }

        public B10sc in_b10sc2
        {
            get => m_in_b10sc2; 
            set { m_in_b10sc2 = value; }
        }

        public string in_stname2
        {
            get => m_in_stname2; 
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_in_stname2 = new string(' ', 32);
                if (strlen > 0)
                    m_in_stname2 = value.Substring(0, strlen).PadRight(32);
            }
        }

        public B10sc in_b10sc3
        {
            get => m_in_b10sc3; 
            set { m_in_b10sc3 = value; }
        }

        public string in_stname3
        {
            get => m_in_stname3; 
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_in_stname3 = new string(' ', 32);
                if (strlen > 0)
                    m_in_stname3 = value.Substring(0, strlen).PadRight(32);
            }
        }

        public BBL in_bbl
        {
            get => m_in_bbl; 
            set { m_in_bbl = value; }
        }

        public string in_filler01
        {
            get => m_in_filler01; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_filler01 = new string(' ', 1);
                if (strlen > 0)
                    m_in_filler01 = value.Substring(0, strlen).PadRight(1);
            }
        }

        public BIN in_bin
        {
            get => m_in_bin; 
            set { m_in_bin = value; }
        }

        [XmlIgnore]
        public string in_bin_string
        {
            get => m_in_bin?.ToString(); 
            set { m_in_bin = new BIN(value); }
        }

        public string in_compass_dir
        {
            get => m_in_compass_dir; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_compass_dir = new string(' ', 1);
                if (strlen > 0)
                    m_in_compass_dir = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string in_compass_dir2
        {
            get => m_in_compass_dir2; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_compass_dir2 = new string(' ', 1);
                if (strlen > 0)
                    m_in_compass_dir2 = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string in_node
        {
            get => m_in_node; 
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_in_node = new string(' ', 7);
                if (strlen > 0)
                    m_in_node = value.Substring(0, strlen).PadRight(7);
            }
        }

        public string in_platform_ind
        {
            get => m_in_platform_ind; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_platform_ind = new string(' ', 1);
                if (strlen > 0)
                    m_in_platform_ind = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string in_zip_code
        {
            get => m_in_zip_code; 
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_in_zip_code = new string(' ', 5);
                if (strlen > 0)
                    m_in_zip_code = value.Substring(0, strlen).PadRight(5);
            }
        }

        public string in_unit
        {
            get => m_in_unit; 
            set
            {
                int strlen = value.Length;
                if (strlen > 14) strlen = 14;
                m_in_unit = new string(' ', 14);
                if (strlen > 0)
                    m_in_unit = value.Substring(0, strlen).PadRight(14);
            }
        }

        public string in_filler03
        {
            get => m_in_filler03; 
            set
            {
                int strlen = value.Length;
                if (strlen > 82) strlen = 82;
                m_in_filler03 = new string(' ', 82);
                if (strlen > 0)
                    m_in_filler03 = value.Substring(0, strlen).PadRight(82);
            }
        }

        public string in_long_wa2_flag
        { 
            get => m_in_long_wa2_flag; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_long_wa2_flag = new string(' ', 1);
                if (strlen > 0)
                    m_in_long_wa2_flag = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string in_hn_justification
        {
            get => m_in_hn_justification; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_hn_justification = new string(' ', 1);
                if (strlen > 0)
                    m_in_hn_justification = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string in_hnl
        {
            get => m_in_hnl; 
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_in_hnl = new string(' ', 2);
                if (strlen > 0)
                    m_in_hnl = value.Substring(0, strlen).PadRight(2);
            }
        }

        public string in_hn_norm_override
        {
            get => m_in_hn_norm_override; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_hn_norm_override = new string(' ', 1);
                if (strlen > 0)
                    m_in_hn_norm_override = value.Substring(0, strlen).PadRight(1);
            }
        }

        // Property for in_snl
        public string in_snl
        {
            get => m_in_snl;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_in_snl = new string(' ', 2);
                if (strlen > 0)
                {
                    m_in_snl = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        // Property for in_stname_normalization
        public string in_stname_normalization
        {
            get => m_in_stname_normalization;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_stname_normalization = new string(' ', 1);
                if (strlen > 0)
                {
                    try { m_in_stname_normalization = value.Substring(0, strlen).PadRight(1); } catch { m_in_stname_normalization = string.Empty; }
                }
            }
        }

        // Property for in_xstreet_names_flag
        public string in_xstreet_names_flag
        {
            get => m_in_xstreet_names_flag;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_xstreet_names_flag = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_xstreet_names_flag = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_roadbed_request_switch
        public string in_roadbed_request_switch
        {
            get => m_in_roadbed_request_switch;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_roadbed_request_switch = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_roadbed_request_switch = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_legacy_grc_flag
        public string in_legacy_grc_flag
        {
            get => m_in_legacy_grc_flag;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_legacy_grc_flag = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_legacy_grc_flag = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_auxseg_switch
        public string in_auxseg_switch
        {
            get => m_in_auxseg_switch;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_auxseg_switch = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_auxseg_switch = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_browse_flag
        public string in_browse_flag
        {
            get => m_in_browse_flag;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_browse_flag = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_browse_flag = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_real_street_only
        public string in_real_street_only
        {
            get => m_in_real_street_only;
          
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_real_street_only = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_real_street_only = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_tpad_switch
        public string in_tpad_switch
        {
            get => m_in_tpad_switch;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_tpad_switch = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_tpad_switch = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_mode_switch
        public string in_mode_switch
        {
            get => m_in_mode_switch;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_in_mode_switch = new string(' ', 1);
                if (strlen > 0)
                {
                    m_in_mode_switch = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for in_filler4
        public string in_filler4
        {
            get =>  m_in_filler04;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 30) strlen = 30;
                m_in_filler04 = new string(' ', 30);
                if (strlen > 0)
                {
                    m_in_filler04 = value.Substring(0, strlen).PadRight(30);
                }
            }
        }

        // Property for out_boro_name1
        public string out_boro_name1
        {
            get => m_out_boro_name1;
           
            set
            {
                int strlen = value.Length;
                if (strlen > 9) strlen = 9;
                m_out_boro_name1 = new string(' ', 9);
                if (strlen > 0)
                {
                    m_out_boro_name1 = value.Substring(0, strlen).PadRight(9);
                }
            }
        }

        // Property for out_hnd
        public string out_hnd
        {
            get => m_out_hnd;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_out_hnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_out_hnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        // Property for out_hns
        public string out_hns
        {
            get => m_out_hns;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_out_hns = new string(' ', 11);
                if (strlen > 0)
                {
                    m_out_hns = value.Substring(0, strlen).PadRight(11);
                }
            }
        }

        // Property for out_b10sc1
        public B10sc out_b10sc1
        {
            get => m_out_b10sc1;
            
            set
            {
                m_out_b10sc1 = value;
            }
        }

        // Property for out_stname1
        public string out_stname1
        {
            get => m_out_stname1;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_out_stname1 = new string(' ', 32);
                if (strlen > 0)
                {
                    m_out_stname1 = value.Substring(0, strlen).PadRight(32);
                }
            }
        }

        // Property for out_b10sc2
        public B10sc out_b10sc2
        {
            get => m_out_b10sc2;
            set => m_out_b10sc2 = value;
        }
        // Property for out_stname2
        public string out_stname2
        {
            get
            {
                return m_out_stname2;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_out_stname2 = new string(' ', 32);
                if (strlen > 0)
                {
                    m_out_stname2 = value.Substring(0, strlen).PadRight(32);
                }
            }
        }

        // Property for out_b10sc3
        public B10sc out_b10sc3
        {
            get
            {
                return m_out_b10sc3;
            }
            set
            {
                m_out_b10sc3 = value;
            }
        }

        // Property for out_stname3
        public string out_stname3
        {
            get
            {
                return m_out_stname3;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_out_stname3 = new string(' ', 32);
                if (strlen > 0)
                {
                    m_out_stname3 = value.Substring(0, strlen).PadRight(32);
                }
            }
        }

        // Property for out_bbl
        public BBL out_bbl
        {
            get
            {
                return m_out_bbl;
            }
            set
            {
                m_out_bbl = value;
            }
        }

        // Property for out_filler02
        public string out_filler02
        {
            get
            {
                return m_out_filler02;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_out_filler02 = new string(' ', 1);
                if (strlen > 0)
                {
                    m_out_filler02 = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for out_low_hnd
        public string out_low_hnd
        {
            get => m_out_low_hnd;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_out_low_hnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_out_low_hnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        // Property for out_low_hns
        public string out_low_hns
        {
            get => m_out_low_hns;
            
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_out_low_hns = new string(' ', 11);
                if (strlen > 0)
                {
                    m_out_low_hns = value.Substring(0, strlen).PadRight(11);
                }
            }
        }

        // Property for out_bin
        public BIN out_bin
        {
            get => m_out_bin;
            set => m_out_bin = value;
        }

        // Property for out_attr_bytes array
        [XmlArrayItem(typeof(string), ElementName = "attr_byte")]
        public string[] out_attr_bytes
        {
            get => m_out_attr_bytes;
            set => m_out_attr_bytes = value;
        }


        public string out_attr_bytes_item(int index) => m_out_attr_bytes[index];

        public void out_attr_bytes_item(int index, string value) {

            int strlen = value.Length;
            if (strlen > 1) strlen = 1;
            m_out_attr_bytes[index] = new string(' ', 1);
            if (strlen > 0)
            {
                m_out_attr_bytes[index] = value.Substring(0, strlen).PadRight(1);
            }

        }
     
        // Property for out_reason_code2
        public string out_reason_code2
        {
            get => m_out_reason_code2;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_out_reason_code2 = new string(' ', 1);
                if (strlen > 0)
                {
                    m_out_reason_code2 = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for out_reason_code_qualifier2
        public string out_reason_code_qualifier2
        {
            get => m_out_reason_code_qualifier2;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_out_reason_code_qualifier2 = new string(' ', 1);
                if (strlen > 0)
                {
                    m_out_reason_code_qualifier2 = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        // Property for out_warning_code2
        public string out_warning_code2
        {
            get => m_out_warning_code2;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_out_warning_code2 = new string(' ', 2);
                if (strlen > 0)
                {
                    m_out_warning_code2 = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        // Property for out_grc2
        public string out_grc2
        {
            get => m_out_grc2;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_out_grc2 = new string(' ', 2);
                if (strlen > 0)
                {
                    m_out_grc2 = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        // Property for out_error_message2
        public string out_error_message2
        {
            get => m_out_error_message2;
            set
            {
                int strlen = value.Length;
                if (strlen > 80) strlen = 80;
                m_out_error_message2 = new string(' ', 80);
                if (strlen > 0)
                {
                    m_out_error_message2 = value.Substring(0, strlen).PadRight(80);
                }
            }
        }

        public string out_node
        {
            get => m_out_node;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_out_node = new string(' ', 7);
                if (strlen > 0)
                {
                    m_out_node = value.Substring(0, strlen).PadRight(7);
                }
            }
        }

        public UNIT out_units
        {
            get => m_out_units;
            set => m_out_units = value;
        }

        public string out_unit
        {
            get => m_out_unit;
            set
            {
                int strlen = value.Length;
                if (strlen > 14) strlen = 14;
                m_out_unit = new string(' ', 14);
                if (strlen > 0)
                {
                    m_out_unit = value.Substring(0, strlen).PadRight(14);
                }
            }
        }

        public string out_filler03
        {
            get => m_out_filler03;
            set
            {
                int strlen = value.Length;
                if (strlen > 17) strlen = 17;
                m_out_filler03 = new string(' ', 17);
                if (strlen > 0)
                {
                    m_out_filler03 = value.Substring(0, strlen).PadRight(17);
                }
            }
        }

        public string out_st_attr
        {
            get => m_out_st_attr;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_out_st_attr = new string(' ', 1);
                if (strlen > 0)
                {
                    m_out_st_attr = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string out_reason_code
        {
            get => m_out_reason_code;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_out_reason_code = new string(' ', 1);
                if (strlen > 0)
                {
                    m_out_reason_code = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string out_reason_code_qualifier
        {
            get => m_out_reason_code_qualifier;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_out_reason_code_qualifier = new string(' ', 1);
                if (strlen > 0)
                {
                    m_out_reason_code_qualifier = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string out_warning_code
        {
            get => m_out_warning_code;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_out_warning_code = new string(' ', 2);
                if (strlen > 0)
                {
                    m_out_warning_code = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string out_grc
        {
            get => m_out_grc;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_out_grc = new string(' ', 2);
                if (strlen > 0)
                {
                    m_out_grc = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string out_error_message
        {
            get => m_out_error_message;
            set
            {
                int strlen = value.Length;
                if (strlen > 80) strlen = 80;
                m_out_error_message = new string(' ', 80);
                if (strlen > 0)
                {
                    m_out_error_message = value.Substring(0, strlen).PadRight(80);
                }
            }
        }

        public string out_number_of_stcodes
        {
            get => m_out_number_of_stcodes;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_out_number_of_stcodes = new string(' ', 2);
                if (strlen > 0)
                {
                    m_out_number_of_stcodes = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public B7sc[] out_b7sc_list
        {
            get => m_out_b7sc_list;
            set => m_out_b7sc_list = value;
        }

        public B7sc out_b7sc_list_item(int index) => m_out_b7sc_list[index];

        public void out_b7sc_list_item(int index, B7sc value) {
            m_out_b7sc_list[index] = value;
        }

        public string[] out_stname_list
        {
            get => m_out_stname_list;
            set => m_out_stname_list = value;
        }

        public string out_stname_list_item(int index) => m_out_stname_list[index];

        public void out_stname_list_item(int index, string value) {
            int strlen = value.Length;
            if (strlen > 32) strlen = 32;
            m_out_stname_list[index] = new string(' ', 32);
            if (strlen > 0)
            {
                m_out_stname_list[index] = value.Substring(0, strlen).PadRight(32);
            }
        }


        public Wa1() {
            int i;

            m_in_func_code = new string(' ', 2);
            m_in_hnd = new string(' ', 16);
            m_in_hns = new string(' ', 11);
            m_in_low_hnd = new string(' ', 16);
            m_in_low_hns = new string(' ', 11);
            m_in_b10sc1 = new B10sc();
            m_in_stname1 = new string(' ', 32);
            m_in_b10sc2 = new B10sc();
            m_in_stname2 = new string(' ', 32);
            m_in_b10sc3 = new B10sc();
            m_in_stname3 = new string(' ', 32);
            m_in_bbl = new BBL();
            m_in_filler01 = new string(' ', 1);
            m_in_bin = new BIN();
            m_in_compass_dir = new string(' ', 1);
            m_in_compass_dir2 = new string(' ', 1);
            m_in_node = new string(' ', 7);
            m_in_platform_ind = new string(' ', 1);
            m_in_zip_code = new string(' ', 5);
            m_in_unit = new string(' ', 14);
            m_in_filler03 = new string(' ', 82);
            m_in_long_wa2_flag = new string(' ', 1);
            m_in_hn_justification = new string(' ', 1);
            m_in_hnl = new string(' ', 2);
            m_in_hn_norm_override = new string(' ', 1);
            m_in_snl = new string(' ', 2);
            m_in_stname_normalization = new string(' ', 1);
            m_in_xstreet_names_flag = new string(' ', 1);
            m_in_roadbed_request_switch = new string(' ', 1);
            m_in_legacy_grc_flag = new string(' ', 1);
            m_in_auxseg_switch = new string(' ', 1);
            m_in_browse_flag = new string(' ', 1);
            m_in_real_street_only = new string(' ', 1);
            m_in_tpad_switch = new string(' ', 1);
            m_in_mode_switch = new string(' ', 1);
            m_in_filler04 = new string(' ', 30);

            m_out_boro_name1 = new string(' ', 9);
            m_out_hnd = new string(' ', 16);
            m_out_hns = new string(' ', 11);
            m_out_b10sc1 = new B10sc();
            m_out_stname1 = new string(' ', 32);
            m_out_b10sc2 = new B10sc();
            m_out_stname2 = new string(' ', 32);
            m_out_b10sc3 = new B10sc();
            m_out_stname3 = new string(' ', 32);
            m_out_bbl = new BBL();
            m_out_filler02 = new string(' ', 1);
            m_out_low_hnd = new string(' ', 16);
            m_out_low_hns = new string(' ', 11);
            m_out_bin = new BIN();
            m_out_attr_bytes = new string[3];
            for (i = 0; i <= 2; i++)
            {
                m_out_attr_bytes[i] = new string(' ', 1);
            }
            m_out_reason_code2 = new string(' ', 1);
            m_out_reason_code_qualifier2 = new string(' ', 1);
            m_out_warning_code2 = new string(' ', 2);
            m_out_grc2 = new string(' ', 2);
            m_out_error_message2 = new string(' ', 80);
            m_out_node = new string(' ', 7);
            m_out_units = new UNIT();
            m_out_unit = new string(' ', 14);
            m_out_filler03 = new string(' ', 17);
            m_out_st_attr = new string(' ', 1);
            m_out_reason_code = new string(' ', 1);
            m_out_reason_code_qualifier = new string(' ', 1);
            m_out_warning_code = new string(' ', 2);
            m_out_grc = new string(' ', 2);
            m_out_error_message = new string(' ', 80);
            m_out_number_of_stcodes = new string(' ', 2);
            m_out_b7sc_list = new B7sc[10];
            for (i = 0; i <= 9; i++)
            {
                m_out_b7sc_list[i] = new B7sc();
            }
            m_out_stname_list = new string[10];
            for (i = 0; i <= 9; i++)
            {
                m_out_stname_list[i] = new string(' ', 32);
            }
        }

        public Wa1(string inString) => this.Wa1FromString(inString);
        public override void Clear() => this.Wa1FromString(new string(' ', 1200));
        public override string Display() => this.Display('-');


        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.Append(m_in_func_code);
            sb.Append(c);
            sb.Append(m_in_hnd);
            sb.Append(c);
            sb.Append(m_in_hns);
            sb.Append(c);
            sb.Append(m_in_low_hnd);
            sb.Append(c);
            sb.Append(m_in_low_hns);
            sb.Append(c);
            sb.Append(m_in_b10sc1.Display());
            sb.Append(c);
            sb.Append(m_in_stname1);
            sb.Append(c);
            sb.Append(m_in_b10sc2.Display());
            sb.Append(c);
            sb.Append(m_in_stname2);
            sb.Append(c);
            sb.Append(m_in_b10sc3.Display());
            sb.Append(c);
            sb.Append(m_in_stname3);
            sb.Append(c);
            sb.Append(m_in_bbl.Display());
            sb.Append(c);
            sb.Append(m_in_filler01);
            sb.Append(c);
            sb.Append(m_in_bin.Display());
            sb.Append(c);
            sb.Append(m_in_compass_dir);
            sb.Append(c);
            sb.Append(m_in_compass_dir2);
            sb.Append(c);
            sb.Append(m_in_node);
            sb.Append(c);
            sb.Append(m_in_platform_ind);
            sb.Append(c);
            sb.Append(m_in_zip_code);
            sb.Append(c);
            sb.Append(m_in_unit);
            sb.Append(c);

            sb.Append(m_in_filler03);
            sb.Append(c);
            sb.Append(m_in_long_wa2_flag);
            sb.Append(c);
            sb.Append(m_in_hn_justification);
            sb.Append(c);
            sb.Append(m_in_hnl);
            sb.Append(c);
            sb.Append(m_in_hn_norm_override);
            sb.Append(c);
            sb.Append(m_in_snl);
            sb.Append(c);
            sb.Append(m_in_stname_normalization);
            sb.Append(c);
            sb.Append(m_in_xstreet_names_flag);
            sb.Append(c);
            sb.Append(m_in_roadbed_request_switch);
            sb.Append(c);
            sb.Append(m_in_legacy_grc_flag);
            sb.Append(c);
            sb.Append(m_in_auxseg_switch);
            sb.Append(c);
            sb.Append(m_in_browse_flag);
            sb.Append(c);
            sb.Append(m_in_real_street_only);
            sb.Append(c);
            sb.Append(m_in_tpad_switch);
            sb.Append(c);
            sb.Append(m_in_mode_switch);
            sb.Append(c);
            sb.Append(m_in_filler04);
            sb.Append(c);
            sb.Append(m_out_boro_name1);
            sb.Append(c);
            sb.Append(m_out_hnd);
            sb.Append(c);
            sb.Append(m_out_hns);
            sb.Append(c);
            sb.Append(m_out_b10sc1.Display());
            sb.Append(c);
            sb.Append(m_out_stname1);
            sb.Append(c);
            sb.Append(m_out_b10sc2.Display());
            sb.Append(c);
            sb.Append(m_out_stname2);
            sb.Append(c);
            sb.Append(m_out_b10sc3.Display());
            sb.Append(c);
            sb.Append(m_out_stname3);
            sb.Append(c);
            sb.Append(m_out_bbl.Display());
            sb.Append(c);
            sb.Append(m_out_filler02);
            sb.Append(c);
            sb.Append(m_out_low_hnd);
            sb.Append(c);
            sb.Append(m_out_low_hns);
            sb.Append(c);
            sb.Append(m_out_bin.Display());
            sb.Append(c);

            for (i = 0; i <= 2; i++)
            {
                sb.Append(m_out_attr_bytes[i]);
                sb.Append(c);
            }

            sb.Append(m_out_reason_code2);
            sb.Append(c);
            sb.Append(m_out_reason_code_qualifier2);
            sb.Append(c);
            sb.Append(m_out_warning_code2);
            sb.Append(c);
            sb.Append(m_out_grc2);
            sb.Append(c);
            sb.Append(m_out_error_message2);
            sb.Append(c);
            sb.Append(m_out_node);
            sb.Append(c);
            sb.Append(m_out_units.Display());
            sb.Append(c);
            sb.Append(m_out_unit);
            sb.Append(c);

            sb.Append(m_out_filler03);
            sb.Append(c);
            sb.Append(m_out_st_attr);
            sb.Append(c);
            sb.Append(m_out_reason_code);
            sb.Append(c);
            sb.Append(m_out_reason_code_qualifier);
            sb.Append(c);
            sb.Append(m_out_warning_code);
            sb.Append(c);
            sb.Append(m_out_grc);
            sb.Append(c);
            sb.Append(m_out_error_message);
            sb.Append(c);
            sb.Append(m_out_number_of_stcodes);
            sb.Append(c);

            for (i = 0; i <= 9; i++)
            {
                sb.Append(m_out_b7sc_list[i].Display());
                sb.Append(c);
            }

            for (i = 0; i <= 9; i++)
            {
                sb.Append(m_out_stname_list[i]);
                sb.Append(c);
            }

            return sb.ToString();
        }


     

        public override void FromString(string inString) =>  Wa1FromString(inString);
        

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("in_func_code = {0}{1}", m_in_func_code, Environment.NewLine);
            sb.AppendFormat("in_hnd = {0}{1}", m_in_hnd, Environment.NewLine);
            sb.AppendFormat("in_hns = {0}{1}", m_in_hns, Environment.NewLine);
            sb.AppendFormat("in_low_hnd = {0}{1}", m_in_low_hnd, Environment.NewLine);
            sb.AppendFormat("in_low_hns = {0}{1}", m_in_low_hns, Environment.NewLine);
            sb.AppendFormat("in_b10sc1 = {0}{1}", m_in_b10sc1.Display(), Environment.NewLine);
            sb.AppendFormat("in_stname1 = {0}{1}", m_in_stname1, Environment.NewLine);
            sb.AppendFormat("in_b10sc2 = {0}{1}", m_in_b10sc2.Display(), Environment.NewLine);
            sb.AppendFormat("in_stname2 = {0}{1}", m_in_stname2, Environment.NewLine);
            sb.AppendFormat("in_b10sc3 = {0}{1}", m_in_b10sc3.Display(), Environment.NewLine);
            sb.AppendFormat("in_stname3 = {0}{1}", m_in_stname3, Environment.NewLine);
            sb.AppendFormat("in_bbl = {0}{1}", m_in_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("in_filler01 = {0}{1}", m_in_filler01, Environment.NewLine);
            sb.AppendFormat("in_bin = {0}{1}", m_in_bin.Display(), Environment.NewLine);
            sb.AppendFormat("in_compass_dir = {0}{1}", m_in_compass_dir, Environment.NewLine);
            sb.AppendFormat("in_compass_dir2 = {0}{1}", m_in_compass_dir2, Environment.NewLine);
            sb.AppendFormat("in_node = {0}{1}", m_in_node, Environment.NewLine);
            sb.AppendFormat("in_platform_ind = {0}{1}", m_in_platform_ind, Environment.NewLine);
            sb.AppendFormat("in_zip_code = {0}{1}", m_in_zip_code, Environment.NewLine);
            // njp vesion 17.1 - Added input unit # field.
            sb.AppendFormat("in_unit = {0}{1}", m_in_unit, Environment.NewLine);

            sb.AppendFormat("in_filler03 = {0}{1}", m_in_filler03, Environment.NewLine);
            sb.AppendFormat("in_long_wa2_flag = {0}{1}", m_in_long_wa2_flag, Environment.NewLine);
            sb.AppendFormat("in_hn_justification = {0}{1}", m_in_hn_justification, Environment.NewLine);
            sb.AppendFormat("in_hnl = {0}{1}", m_in_hnl, Environment.NewLine);
            sb.AppendFormat("in_hn_norm_override = {0}{1}", m_in_hn_norm_override, Environment.NewLine);
            sb.AppendFormat("in_snl = {0}{1}", m_in_snl, Environment.NewLine);
            sb.AppendFormat("in_stname_normalization = {0}{1}", m_in_stname_normalization, Environment.NewLine);
            sb.AppendFormat("in_xstreet_names_flag = {0}{1}", m_in_xstreet_names_flag, Environment.NewLine);
            sb.AppendFormat("in_roadbed_request_switch = {0}{1}", m_in_roadbed_request_switch, Environment.NewLine);
            sb.AppendFormat("in_legacy_grc_flag = {0}{1}", m_in_legacy_grc_flag, Environment.NewLine);
            sb.AppendFormat("in_auxseg_swtich = {0}{1}", m_in_auxseg_switch, Environment.NewLine);
            // spo (2008-04-08) added browse_flag 
            sb.AppendFormat("in_browse_flag = {0}{1}", m_in_browse_flag, Environment.NewLine);
            // spo (2008-08-04) added read_street_only flag for 3S 
            sb.AppendFormat("in_real_street_only = {0}{1}", m_in_real_street_only, Environment.NewLine);
            // spo (2010-10-18) added tpad_switch for 1A, BL, BN  
            sb.AppendFormat("in_tpad_switch = {0}{1}", m_in_tpad_switch, Environment.NewLine);
            //--spo(2011-09-24):  Geosupport 11.0 added mode switch for Extended functions
            sb.AppendFormat("in_mode_switch = {0}{1}", m_in_mode_switch, Environment.NewLine);
            sb.AppendFormat("in_filler04 = {0}{1}", m_in_filler04, Environment.NewLine);

            sb.AppendFormat("out_boro_name1 = {0}{1}", m_out_boro_name1, Environment.NewLine);
            sb.AppendFormat("out_hnd = {0}{1}", m_out_hnd, Environment.NewLine);
            sb.AppendFormat("out_hns = {0}{1}", m_out_hns, Environment.NewLine);
            sb.AppendFormat("out_b10sc1 = {0}{1}", m_out_b10sc1.Display(), Environment.NewLine);
            sb.AppendFormat("out_stname1 = {0}{1}", m_out_stname1, Environment.NewLine);
            sb.AppendFormat("out_b10sc2 = {0}{1}", m_out_b10sc2.Display(), Environment.NewLine);
            sb.AppendFormat("out_stname2 = {0}{1}", m_out_stname2, Environment.NewLine);
            sb.AppendFormat("out_b10sc3 = {0}{1}", m_out_b10sc3.Display(), Environment.NewLine);
            sb.AppendFormat("out_stname3 = {0}{1}", m_out_stname3, Environment.NewLine);
            sb.AppendFormat("out_bbl = {0}{1}", m_out_bbl.Display(), Environment.NewLine);
            sb.AppendFormat("out_filler02 = {0}{1}", m_out_filler02, Environment.NewLine);
            sb.AppendFormat("out_low_hnd = {0}{1}", m_out_low_hnd, Environment.NewLine);
            sb.AppendFormat("out_low_hns = {0}{1}", m_out_low_hns, Environment.NewLine);
            sb.AppendFormat("out_bin = {0}{1}", m_out_bin.Display(), Environment.NewLine);
            for (int i = 0; i <= 2; i++)
            {
                sb.AppendFormat("out_attr_bytes({0}) = {1}{2}", i, m_out_attr_bytes[i], Environment.NewLine);
            }
            // spo(2011-10-27):  Geosupport 11.0 added second set of codes for Function 1B calls 
            sb.AppendFormat("out_reason_code2 = {0}{1}", m_out_reason_code2, Environment.NewLine);
            sb.AppendFormat("out_reason_code_qualifier2 = {0}{1}", m_out_reason_code_qualifier2, Environment.NewLine);
            sb.AppendFormat("out_warning_code2 = {0}{1}", m_out_warning_code2, Environment.NewLine);
            sb.AppendFormat("out_grc2 = {0}{1}", m_out_grc2, Environment.NewLine);
            sb.AppendFormat("out_error_message2 = {0}{1}", m_out_error_message2, Environment.NewLine);
            sb.AppendFormat("out_node = {0}{1}", m_out_node, Environment.NewLine);
            // njp vesion 17.1 - Added input unit # field.
            sb.AppendFormat("out_units = {0}{1}", m_out_units.Display(), Environment.NewLine);
            sb.AppendFormat("out_unit = {0}{1}", m_out_unit, Environment.NewLine);

            sb.AppendFormat("out_filler03 = {0}{1}", m_out_filler03, Environment.NewLine);
            sb.AppendFormat("out_st_attr = {0}{1}", m_out_st_attr, Environment.NewLine);
            sb.AppendFormat("out_reason_code = {0}{1}", m_out_reason_code, Environment.NewLine);
            sb.AppendFormat("out_reason_code_qualifier = {0}{1}", m_out_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("out_warning_code = {0}{1}", m_out_warning_code, Environment.NewLine);
            sb.AppendFormat("out_grc = {0}{1}", m_out_grc, Environment.NewLine);
            sb.AppendFormat("out_error_message = {0}{1}", m_out_error_message, Environment.NewLine);
            sb.AppendFormat("out_number_of_stcodes = {0}{1}", m_out_number_of_stcodes, Environment.NewLine);
            for (int i = 0; i <= 9; i++)
            {
                sb.AppendFormat("out_b7sc_list({0}) = {1}{2}", i, m_out_b7sc_list[i].Display(), Environment.NewLine);
            }
            for (int i = 0; i <= 9; i++)
            {
                sb.AppendFormat("out_stname_list({0}) = {1}{2}", i, m_out_stname_list[i], Environment.NewLine);
            }

            return sb.ToString();
        }


        public override string ToString() => this.Wa1ToString();

        public void Wa1FromString(string inString)
        {
            int i;

            m_in_func_code = inString.Substring(0, 2);
            m_in_hnd = inString.Substring(2, 16);
            m_in_hns = inString.Substring(18, 11);
            m_in_low_hnd = inString.Substring(29, 16);
            m_in_low_hns = inString.Substring(45, 11);
            m_in_b10sc1 = new B10sc(inString.Substring(56, 11));
            m_in_stname1 = inString.Substring(67, 32);
            m_in_b10sc2 = new B10sc(inString.Substring(99, 11));
            m_in_stname2 = inString.Substring(110, 32);
            m_in_b10sc3 = new B10sc(inString.Substring(142, 11));
            m_in_stname3 = inString.Substring(153, 32);
            m_in_bbl = new BBL(inString.Substring(185, 10));
            m_in_filler01 = inString.Substring(195, 1);
            m_in_bin = new BIN(inString.Substring(196, 7));
            m_in_compass_dir = inString.Substring(203, 1);
            m_in_compass_dir2 = inString.Substring(204, 1);
            m_in_node = inString.Substring(205, 7);
            m_in_platform_ind = inString.Substring(212, 1);
            m_in_zip_code = inString.Substring(213, 5);
            m_in_unit = inString.Substring(218, 14);
            m_in_filler03 = inString.Substring(232, 82);

            m_in_long_wa2_flag = inString.Substring(314, 1);
            m_in_hn_justification = inString.Substring(315, 1);
            m_in_hnl = inString.Substring(316, 2);
            m_in_hn_norm_override = inString.Substring(318, 1);
            m_in_snl = inString.Substring(319, 2);
            m_in_stname_normalization = inString.Substring(321, 1);
            m_in_xstreet_names_flag = inString.Substring(322, 1);
            m_in_roadbed_request_switch = inString.Substring(323, 1);
            m_in_legacy_grc_flag = inString.Substring(324, 1);
            m_in_auxseg_switch = inString.Substring(325, 1);
            m_in_browse_flag = inString.Substring(326, 1);
            m_in_real_street_only = inString.Substring(327, 1);
            m_in_tpad_switch = inString.Substring(328, 1);
            m_in_mode_switch = inString.Substring(329, 1);
            m_in_filler04 = inString.Substring(330, 30);

            m_out_boro_name1 = inString.Substring(360, 9);
            m_out_hnd = inString.Substring(369, 16);
            m_out_hns = inString.Substring(385, 11);
            m_out_b10sc1 = new B10sc(inString.Substring(396, 11));
            m_out_stname1 = inString.Substring(407, 32);
            m_out_b10sc2 = new B10sc(inString.Substring(439, 11));
            m_out_stname2 = inString.Substring(450, 32);
            m_out_b10sc3 = new B10sc(inString.Substring(482, 11));
            m_out_stname3 = inString.Substring(493, 32);
            m_out_bbl = new BBL(inString.Substring(525, 10));
            m_out_filler02 = inString.Substring(535, 1);
            m_out_low_hnd = inString.Substring(536, 16);
            m_out_low_hns = inString.Substring(552, 11);
            m_out_bin = new BIN(inString.Substring(563, 7));

            for (i = 0; i <= 2; i++)
            {
                m_out_attr_bytes[i] = inString.Substring(570 + (i * 1), 1);
            }

            m_out_reason_code2 = inString.Substring(573, 1);
            m_out_reason_code_qualifier2 = inString.Substring(574, 1);
            m_out_warning_code2 = inString.Substring(575, 2);
            m_out_grc2 = inString.Substring(577, 2);
            m_out_error_message2 = inString.Substring(579, 80);

            m_out_node = inString.Substring(659, 7);
            m_out_units = new UNIT(inString.Substring(666, 14));
            m_out_unit = inString.Substring(680, 14);
            m_out_filler03 = inString.Substring(694, 17);

            m_out_st_attr = inString.Substring(711, 1);
            m_out_reason_code = inString.Substring(712, 1);
            m_out_reason_code_qualifier = inString.Substring(713, 1);
            m_out_warning_code = inString.Substring(714, 2);
            m_out_grc = inString.Substring(716, 2);
            m_out_error_message = inString.Substring(718, 80);
            m_out_number_of_stcodes = inString.Substring(798, 2);

            for (i = 0; i <= 9; i++)
            {
                try { m_out_b7sc_list[i] = new B7sc(inString.Substring(800 + (i * 8), 8)); }
                catch { m_out_b7sc_list[i] = new B7sc(); }
            }

            for (i = 0; i <= 9; i++)
            {
                try
                {
                    m_out_stname_list[i] = inString.Substring(880 + (i * 32), 32);
                }
                catch (Exception ex)
                {
                    m_out_stname_list[i] = string.Empty;
                    continue;
                }

            }
        }

        public string Wa1ToString() {
            int i;
            StringBuilder sb = new StringBuilder();

            sb.Append(m_in_func_code);
            sb.Append(m_in_hnd);
            sb.Append(m_in_hns);
            sb.Append(m_in_low_hnd);
            sb.Append(m_in_low_hns);
            sb.Append(m_in_b10sc1.B10scToString());
            sb.Append(m_in_stname1);
            sb.Append(m_in_b10sc2.B10scToString());
            sb.Append(m_in_stname2);
            sb.Append(m_in_b10sc3.B10scToString());
            sb.Append(m_in_stname3);
            sb.Append(m_in_bbl.BBLToString());
            sb.Append(m_in_filler01);
            sb.Append(m_in_bin.BINToString());
            sb.Append(m_in_compass_dir);
            sb.Append(m_in_compass_dir2);
            sb.Append(m_in_node);
            sb.Append(m_in_platform_ind);
            sb.Append(m_in_zip_code);
            // njp version 17.1 - Added input unit # field.
            sb.Append(m_in_unit);

            sb.Append(m_in_filler03);
            sb.Append(m_in_long_wa2_flag);
            sb.Append(m_in_hn_justification);
            sb.Append(m_in_hnl);
            sb.Append(m_in_hn_norm_override);
            sb.Append(m_in_snl);
            sb.Append(m_in_stname_normalization);
            sb.Append(m_in_xstreet_names_flag);
            sb.Append(m_in_roadbed_request_switch);
            sb.Append(m_in_legacy_grc_flag);
            sb.Append(m_in_auxseg_switch);
            // spo (2008-04-08) added browse_flag 
            sb.Append(m_in_browse_flag);
            // spo (2008-08-04) added read_street_only flag for 3S 
            sb.Append(m_in_real_street_only);
            // spo (2010-10-18) added tpad_switch for 1A, BL, BN  
            sb.Append(m_in_tpad_switch);
            // --spo(2011-09-24):  Geosupport 11.0 added mode switch for Extended functions
            sb.Append(m_in_mode_switch);
            sb.Append(m_in_filler04);
            sb.Append(m_out_boro_name1);
            sb.Append(m_out_hnd);
            sb.Append(m_out_hns);
            sb.Append(m_out_b10sc1.B10scToString());
            sb.Append(m_out_stname1);
            sb.Append(m_out_b10sc2.B10scToString());
            sb.Append(m_out_stname2);
            sb.Append(m_out_b10sc3.B10scToString());
            sb.Append(m_out_stname3);
            sb.Append(m_out_bbl.BBLToString());
            sb.Append(m_out_filler02);
            sb.Append(m_out_low_hnd);
            sb.Append(m_out_low_hns);
            sb.Append(m_out_bin.BINToString());

            for (i = 0; i <= 2; i++)
            {
                sb.Append(m_out_attr_bytes[i]);
            }

            // spo(2011-10-27):  Geosupport 11.0 added second set of codes for Function 1B calls 
            sb.Append(m_out_reason_code2);
            sb.Append(m_out_reason_code_qualifier2);
            sb.Append(m_out_warning_code2);
            sb.Append(m_out_grc2);
            sb.Append(m_out_error_message2);
            sb.Append(m_out_node);
            // njp version 17.1 - Added input unit # field.
            sb.Append(m_out_units.UnitToString());
            sb.Append(m_out_unit);

            sb.Append(m_out_filler03);
            sb.Append(m_out_st_attr);
            sb.Append(m_out_reason_code);
            sb.Append(m_out_reason_code_qualifier);
            sb.Append(m_out_warning_code);
            sb.Append(m_out_grc);
            sb.Append(m_out_error_message);
            sb.Append(m_out_number_of_stcodes);

            for (i = 0; i <= 9; i++)
            {
                if (m_out_b7sc_list[i] == null) continue;

                sb.Append(m_out_b7sc_list[i].B7scToString());
            }

            for (i = 0; i <= 9; i++)
            {
                sb.Append(m_out_stname_list[i]);
            }

            return sb.ToString();
        }

    }
}
