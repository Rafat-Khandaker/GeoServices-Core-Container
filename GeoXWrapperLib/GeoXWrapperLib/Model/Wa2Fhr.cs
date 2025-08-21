using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2Fhr : WA
    {
        private FileInfo m_geo_file_info;
        private FileInfo[] m_file_info_array = new FileInfo[8];
        private string m_thin_rec_type1;
        private string m_thin_file_tag;
        private string m_thin_date;
        private string m_thin_filler01;
        private string m_thin_rec_type2;
        private string m_thin_release;
        private string m_thin_filler02;
        private string m_thin_rectype3;
        private string m_thin_rec_cnt;
        private string m_thin_filler03;

        private FileInfo m_grid1r_file_info;
        private FileInfo m_auxseg_file_info;
        private FileInfo m_tpad_file_info;
        private FileInfo m_apequiv_file_info;

        private FileInfo m_ap_file_info;
        private FileInfo m_upad_file_info;
        private FileInfo m_stat_file_info;

        private FileInfo m_stt1_file_info;
        private FileInfo m_st1a_file_info;
        private FileInfo m_stt2_file_info;
        private FileInfo m_stt3_file_info;
        private FileInfo m_st3s_file_info;
        private FileInfo m_stap_file_info;
        private FileInfo m_stbl_file_info;
        private FileInfo m_stbn_file_info;
        private FileInfo m_sttd_file_info;

        private FileInfo m_sneq_file_info;

        private string[] m_dsnames = new string[36];

        private string m_filler01;

        /// <summary>
        /// Constructor for <c>Wa2Fhr</c>
        /// </summary>
        public Wa2Fhr()
        {
            m_geo_file_info = new FileInfo();

            // Initialize file info array
            for (int i = 0; i < 8; i++)
            {
                m_file_info_array[i] = new FileInfo();
            }

            m_thin_rec_type1 = new string(' ', 4);
            m_thin_file_tag = new string(' ', 4);
            m_thin_date = new string(' ', 6);
            m_thin_filler01 = new string(' ', 12);
            m_thin_rec_type2 = new string(' ', 4);
            m_thin_release = new string(' ', 4);
            m_thin_filler02 = new string(' ', 18);
            m_thin_rectype3 = new string(' ', 4);
            m_thin_rec_cnt = new string(' ', 8);
            m_thin_filler03 = new string(' ', 14);

            m_grid1r_file_info = new FileInfo();
            m_auxseg_file_info = new FileInfo();
            m_tpad_file_info = new FileInfo();
            m_apequiv_file_info = new FileInfo();

            m_ap_file_info = new FileInfo();
            m_upad_file_info = new FileInfo();
            m_stat_file_info = new FileInfo();

            m_stt1_file_info = new FileInfo();
            m_st1a_file_info = new FileInfo();
            m_stt2_file_info = new FileInfo();
            m_stt3_file_info = new FileInfo();
            m_st3s_file_info = new FileInfo();
            m_stap_file_info = new FileInfo();
            m_stbl_file_info = new FileInfo();
            m_stbn_file_info = new FileInfo();
            m_sttd_file_info = new FileInfo();

            m_sneq_file_info = new FileInfo();

            // Initialize dsnames array with 35 elements, each being a string of 60 spaces
            for (int i = 0; i < 35; i++)
            {
                m_dsnames[i] = new string(' ', 60);
            }

            // Initialize filler01 with 2146 spaces
            m_filler01 = new string(' ', 2146);
        }

        // Constructor that accepts a string and processes it using Wa2FhrFromString
        public Wa2Fhr(string inString)
        {
            Wa2FhrFromString(inString);
        }

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>Wa2Fhr</c> object to spaces.
        /// </summary>
        public override void Clear()
        {
            Wa2FhrFromString(new string(' ', 5000));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa2Fhr</c> object to a string.
        /// </summary>
        public override string ToString()
        {
            return Wa2FhrToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa2Fhr</c> object.
        /// </summary>
        public override void FromString(string inString)
        {
            Wa2FhrFromString(inString);
        }

        /// <summary>
        /// <c>Wa2FhrToString</c> converts a <c>Wa2Fhr</c> object to a string.
        /// </summary>
        public string Wa2FhrToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_geo_file_info.FileInfoToString());

            // Appending m_file_info_array elements to the StringBuilder
            for (int i = 0; i < 8; i++)
            {
                sb.Append(m_file_info_array[i].FileInfoToString());
            }

            sb.Append(m_thin_rec_type1);
            sb.Append(m_thin_file_tag);
            sb.Append(m_thin_date);
            sb.Append(m_thin_filler01);
            sb.Append(m_thin_rec_type2);
            sb.Append(m_thin_release);
            sb.Append(m_thin_filler02);
            sb.Append(m_thin_rectype3);
            sb.Append(m_thin_rec_cnt);
            sb.Append(m_thin_filler03);

            sb.Append(m_grid1r_file_info.FileInfoToString());
            sb.Append(m_auxseg_file_info.FileInfoToString());
            sb.Append(m_tpad_file_info.FileInfoToString());
            sb.Append(m_apequiv_file_info.FileInfoToString());

            sb.Append(m_ap_file_info.FileInfoToString());
            sb.Append(m_upad_file_info.FileInfoToString());
            sb.Append(m_stat_file_info.FileInfoToString());

            sb.Append(m_stt1_file_info.FileInfoToString());
            sb.Append(m_st1a_file_info.FileInfoToString());
            sb.Append(m_stt2_file_info.FileInfoToString());
            sb.Append(m_stt3_file_info.FileInfoToString());
            sb.Append(m_st3s_file_info.FileInfoToString());
            sb.Append(m_stap_file_info.FileInfoToString());
            sb.Append(m_stbl_file_info.FileInfoToString());
            sb.Append(m_stbn_file_info.FileInfoToString());
            sb.Append(m_sttd_file_info.FileInfoToString());

            // Adding new entry for SNEQ
            sb.Append(m_sneq_file_info.FileInfoToString());

            // Appending the dsnames array elements to the StringBuilder
            for (int i = 0; i < 35; i++)
            {
                sb.Append(m_dsnames[i]);
            }

            sb.Append(m_filler01);

            return sb.ToString();
        }

        // Example placeholder for the "Wa2FhrFromString" method, assuming it's defined elsewhere
        public void Wa2FhrFromString(string inString)
        {
            int i;

            // Initialize m_geo_file_info from the input string
            m_geo_file_info = new FileInfo(inString.Substring(0, 26));

            // Initialize m_file_info_array with 26-character chunks from the input string
            for (i = 0; i < 8; i++)
            {
                m_file_info_array[i] = new FileInfo(inString.Substring(26 + (i * 26), 26));
            }

            m_thin_rec_type1 = inString.Substring(234, 4);
            m_thin_file_tag = inString.Substring(238, 4);
            m_thin_date = inString.Substring(242, 6);
            m_thin_filler01 = inString.Substring(248, 12);
            m_thin_rec_type2 = inString.Substring(260, 4);
            m_thin_release = inString.Substring(264, 4);
            m_thin_filler02 = inString.Substring(268, 18);
            m_thin_rectype3 = inString.Substring(286, 4);
            m_thin_rec_cnt = inString.Substring(290, 8);
            m_thin_filler03 = inString.Substring(298, 14);

            // Initialize other FileInfo objects from the input string
            m_grid1r_file_info = new FileInfo(inString.Substring(312, 26));
            m_auxseg_file_info = new FileInfo(inString.Substring(338, 26));
            m_tpad_file_info = new FileInfo(inString.Substring(364, 26));
            m_apequiv_file_info = new FileInfo(inString.Substring(390, 26));

            m_ap_file_info = new FileInfo(inString.Substring(416, 26));
            m_upad_file_info = new FileInfo(inString.Substring(442, 26));
            m_stat_file_info = new FileInfo(inString.Substring(468, 26));

            m_stt1_file_info = new FileInfo(inString.Substring(494, 26));
            m_st1a_file_info = new FileInfo(inString.Substring(520, 26));
            m_stt2_file_info = new FileInfo(inString.Substring(546, 26));
            m_stt3_file_info = new FileInfo(inString.Substring(572, 26));
            m_st3s_file_info = new FileInfo(inString.Substring(598, 26));

            m_stap_file_info = new FileInfo(inString.Substring(624, 26));
            m_stbl_file_info = new FileInfo(inString.Substring(650, 26));
            m_stbn_file_info = new FileInfo(inString.Substring(676, 26));
            m_sttd_file_info = new FileInfo(inString.Substring(702, 26));

            // Added new entry for SNEQ, Sanitation Equiv
            m_sneq_file_info = new FileInfo(inString.Substring(728, 26));

            // Initialize m_dsnames array (35 entries of 60 characters each)
            for (i = 0; i < 35; i++)
            {
                m_dsnames[i] = inString.Substring(754 + (i * 60), 60);
            }

            // Initialize m_filler01
            m_filler01 = inString.Substring(2854, 2146);
        }

        /// <summary>
        /// Creates a string of <c>Wa2Fhr</c> field values separated by a character.
        /// </summary>
        public override string Display(char separator)
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.Append(m_geo_file_info.Display());
            sb.Append(separator);

            // Append m_file_info_array items
            for (i = 0; i < 8; i++)
            {
                sb.Append(m_file_info_array[i].Display());
                sb.Append(separator);
            }

            sb.Append(m_thin_rec_type1);
            sb.Append(separator);
            sb.Append(m_thin_file_tag);
            sb.Append(separator);
            sb.Append(m_thin_date);
            sb.Append(separator);
            sb.Append(m_thin_filler01);
            sb.Append(separator);
            sb.Append(m_thin_rec_type2);
            sb.Append(separator);
            sb.Append(m_thin_release);
            sb.Append(separator);
            sb.Append(m_thin_filler02);
            sb.Append(separator);
            sb.Append(m_thin_rectype3);
            sb.Append(separator);
            sb.Append(m_thin_rec_cnt);
            sb.Append(separator);
            sb.Append(m_thin_filler03);
            sb.Append(separator);

            // Append other FileInfo objects' display values
            sb.Append(m_grid1r_file_info.Display());
            sb.Append(separator);
            sb.Append(m_auxseg_file_info.Display());
            sb.Append(separator);
            sb.Append(m_tpad_file_info.Display());
            sb.Append(separator);
            sb.Append(m_apequiv_file_info.Display());
            sb.Append(separator);

            sb.Append(m_ap_file_info.Display());
            sb.Append(separator);
            sb.Append(m_upad_file_info.Display());
            sb.Append(separator);
            sb.Append(m_stat_file_info.Display());
            sb.Append(separator);

            sb.Append(m_stt1_file_info.Display());
            sb.Append(separator);
            sb.Append(m_st1a_file_info.Display());
            sb.Append(separator);
            sb.Append(m_stt2_file_info.Display());
            sb.Append(separator);
            sb.Append(m_stt3_file_info.Display());
            sb.Append(separator);
            sb.Append(m_st3s_file_info.Display());
            sb.Append(separator);
            sb.Append(m_stap_file_info.Display());
            sb.Append(separator);
            sb.Append(m_stbl_file_info.Display());
            sb.Append(separator);
            sb.Append(m_stbn_file_info.Display());
            sb.Append(separator);
            sb.Append(m_sttd_file_info.Display());
            sb.Append(separator);

            // Added new entry for SNEQ, Sanitation Equiv
            sb.Append(m_sneq_file_info.Display());
            sb.Append(separator);

            // Append m_dsnames array items
            for (i = 0; i < 35; i++)
            {
                sb.Append(m_dsnames[i]);
                sb.Append(separator);
            }

            sb.Append(m_filler01);

            return sb.ToString();
        }

        public override string Display()
        {
            return Display('-');
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("geo_file_info = {0}{1}", m_geo_file_info.Display(), Environment.NewLine);

            // For loop to handle m_file_info_array
            for (int i = 0; i < 8; i++)
            {
                sb.AppendFormat("file_info_array({0}) = {1}{2}", i, m_file_info_array[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("thin_rec_type1 = {0}{1}", m_thin_rec_type1, Environment.NewLine);
            sb.AppendFormat("thin_file_tag = {0}{1}", m_thin_file_tag, Environment.NewLine);
            sb.AppendFormat("thin_date = {0}{1}", m_thin_date, Environment.NewLine);
            sb.AppendFormat("thin_filler01 = {0}{1}", m_thin_filler01, Environment.NewLine);
            sb.AppendFormat("thin_rec_type2 = {0}{1}", m_thin_rec_type2, Environment.NewLine);
            sb.AppendFormat("thin_release = {0}{1}", m_thin_release, Environment.NewLine);
            sb.AppendFormat("thin_filler02 = {0}{1}", m_thin_filler02, Environment.NewLine);
            sb.AppendFormat("thin_rectype3 = {0}{1}", m_thin_rectype3, Environment.NewLine);
            sb.AppendFormat("thin_rec_cnt = {0}{1}", m_thin_rec_cnt, Environment.NewLine);
            sb.AppendFormat("thin_filler03 = {0}{1}", m_thin_filler03, Environment.NewLine);

            sb.AppendFormat("grid1r_file_info = {0}{1}", m_grid1r_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("auxseg_file_info = {0}{1}", m_auxseg_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("tpad_file_info = {0}{1}", m_tpad_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("apequiv_file_info = {0}{1}", m_apequiv_file_info.Display(), Environment.NewLine);

            sb.AppendFormat("ap_file_info = {0}{1}", m_ap_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("upad_file_info = {0}{1}", m_upad_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("stat_file_info = {0}{1}", m_stat_file_info.Display(), Environment.NewLine);

            sb.AppendFormat("stt1_file_info = {0}{1}", m_stt1_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("st1a_file_info = {0}{1}", m_st1a_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("stt2_file_info = {0}{1}", m_stt2_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("stt3_file_info = {0}{1}", m_stt3_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("st3s_file_info = {0}{1}", m_st3s_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("stap_file_info = {0}{1}", m_stap_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("stbl_file_info = {0}{1}", m_stbl_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("stbn_file_info = {0}{1}", m_stbn_file_info.Display(), Environment.NewLine);
            sb.AppendFormat("sttd_file_info = {0}{1}", m_sttd_file_info.Display(), Environment.NewLine);

            sb.AppendFormat("sneq_file_info = {0}{1}", m_sneq_file_info.Display(), Environment.NewLine);

            for (int i = 0; i < 35; i++)
            {
                sb.AppendFormat("dsnames({0}) = {1}{2}", i, m_dsnames[i], Environment.NewLine);
            }

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);

            return sb.ToString();
        }

        public string Report() =>
                $"{Environment.NewLine}****************************************************************************{Environment.NewLine}" +
                $"******************************  Wa2Fhr  ***********************************{Environment.NewLine}" +
                $"****************************************************************************{Environment.NewLine}";


        // Property for geo_file_info
        public FileInfo geo_file_info
        {
            get => m_geo_file_info;
            set => m_geo_file_info = value;
        }

        // Property for file_info_array
        public FileInfo[] file_info_array
        {
            get => m_file_info_array;
            set => m_file_info_array = value;
        }

        // Property for file_info_array item
        public FileInfo file_info_array_item(int index) => m_file_info_array[index];

        public void file_info_array_item(int index, FileInfo value) => m_file_info_array[index] = value;
        

        // Property for thin_rec_type1
        public string thin_rec_type1
        {
            get => m_thin_rec_type1;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_thin_rec_type1 = value.Substring(0, strlen);
            }
        }

        // Property for thin_file_tag
        public string thin_file_tag
        {
            get => m_thin_file_tag;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_thin_file_tag = value.Substring(0, strlen);
            }
        }

        // Property for thin_date
        public string thin_date
        {
            get => m_thin_date;
            set
            {
                int strlen = value.Length > 6 ? 6 : value.Length;
                m_thin_date = value.Substring(0, strlen);
            }
        }

        // Property for thin_filler01
        public string thin_filler01
        {
            get => m_thin_filler01;
            set
            {
                int strlen = value.Length > 12 ? 12 : value.Length;
                m_thin_filler01 = value.Substring(0, strlen);
            }
        }

        // Property for thin_rec_type2
        public string thin_rec_type2
        {
            get => m_thin_rec_type2;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_thin_rec_type2 = value.Substring(0, strlen);
            }
        }

        // Property for thin_release
        public string thin_release
        {
            get => m_thin_release;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_thin_release = value.Substring(0, strlen);
            }
        }

        // Property for thin_filler02
        public string thin_filler02
        {
            get => m_thin_filler02;
            set
            {
                int strlen = value.Length > 18 ? 18 : value.Length;
                m_thin_filler02 = value.Substring(0, strlen);
            }
        }

        // Property for thin_rectype3
        public string thin_rectype3
        {
            get => m_thin_rectype3;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_thin_rectype3 = value.Substring(0, strlen);
            }
        }

        // Property for thin_rec_cnt
        public string thin_rec_cnt
        {
            get => m_thin_rec_cnt;
            set
            {
                int strlen = value.Length > 8 ? 8 : value.Length;
                m_thin_rec_cnt = value.Substring(0, strlen);
            }
        }

        // Property for thin_filler03
        public string thin_filler03
        {
            get => m_thin_filler03;
            set
            {
                int strlen = value.Length > 14 ? 14 : value.Length;
                m_thin_filler03 = value.Substring(0, strlen);
            }
        }

        // Property for grid1r_file_info
        public FileInfo grid1r_file_info
        {
            get => m_grid1r_file_info;
            set => m_grid1r_file_info = value;
        }

        // Property for auxseg_file_info
        public FileInfo auxseg_file_info
        {
            get => m_auxseg_file_info;
            set => m_auxseg_file_info = value;
        }

        // Property for tpad_file_info
        public FileInfo tpad_file_info
        {
            get => m_tpad_file_info;
            set => m_tpad_file_info = value;
        }

        // Property for apequiv_file_info
        public FileInfo apequiv_file_info
        {
            get => m_apequiv_file_info;
            set => m_apequiv_file_info = value;
        }

        // Property for ap_file_info
        public FileInfo ap_file_info
        {
            get => m_ap_file_info;
            set => m_ap_file_info = value;
        }

        // Property for upad_file_info
        public FileInfo upad_file_info
        {
            get => m_upad_file_info;
            set => m_upad_file_info = value;
        }

        // Property for stat_file_info
        public FileInfo stat_file_info
        {
            get => m_stat_file_info;
            set => m_stat_file_info = value;
        }

        public FileInfo stt1_file_info
        {
            get => m_stt1_file_info;
            set => m_stt1_file_info = value;
        }

        public FileInfo st1a_file_info
        {
            get => m_st1a_file_info;
            set => m_st1a_file_info = value;
        }

        public FileInfo stt2_file_info
        {
            get => m_stt2_file_info;
            set => m_stt2_file_info = value;
        }

        public FileInfo stt3_file_info
        {
            get => m_stt3_file_info;
            set => m_stt3_file_info = value;
        }

        public FileInfo st3s_file_info
        {
            get => m_st3s_file_info;
            set => m_st3s_file_info = value;
        }

        public FileInfo stap_file_info
        {
            get => m_stap_file_info;
            set => m_stap_file_info = value;
        }

        public FileInfo stbl_file_info
        {
            get => m_stbl_file_info;
            set => m_stbl_file_info = value;
        }

        public FileInfo stbn_file_info
        {
            get => m_stbn_file_info;
            set => m_stbn_file_info = value;
        }

        public FileInfo sttd_file_info
        {
            get => m_sttd_file_info;
            set => m_sttd_file_info = value;
        }

        public FileInfo sneq_file_info
        {
            get => m_sneq_file_info;
            set => m_sneq_file_info = value;
        }

        [XmlArrayItem("dsname", typeof(string))]
        public string[] dsnames
        {
            get => m_dsnames;
            set => m_dsnames = value;
        }

        public string dsnames_item(int index) => m_dsnames[index];

        public void dsnames_item(int index, string value)
        {
            var strlen = value.Length;
            if (strlen > 60) strlen = 60;
            m_dsnames[index] = value.Substring(0, strlen);
        }

        public string filler01
        {
            get => m_filler01;
            set
            {
                var strlen = value.Length;
                if (strlen > 2146) strlen = 2146;
                m_filler01 = value.Substring(0, strlen);
            }
        }


    }

}
