using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F2w : WA
    {
        private Wa2F2 m_wa2f2;
        private string m_filler_for_grid_gen;
        private string[] m_valid_lgcs_st1 = new string[4];
        private string[] m_valid_lgcs_st2 = new string[4];
        private string[] m_turn_restrictions = new string[10];
        private string[] m_preferred_lgcs = new string[5];
        private string m_true_replication_counter;
        private string[] m_node_list = new string[20];
        private B7sc[,,] m_node_b7scs = new B7sc[20, 5, 4];
        private string m_reason_code;
        private string m_reason_code_qualifier;
        private string m_warning_code;
        private string m_grc;
        private string m_latitude;
        private string m_longitude;
        private string m_census_tract_2020;
        private string m_census_block_2020;
        private string m_census_block_suffix_2020;
        private string m_nta_2020;
        private string m_cdta_2020;
        private string m_filler_01;

        public Wa2F2w()
        {
            m_wa2f2 = new Wa2F2();
            m_filler_for_grid_gen = new string(' ', 22);
            for (int i = 0; i < 4; i++)
                m_valid_lgcs_st1[i] = new string(' ', 2);
            for (int i = 0; i < 4; i++)
                m_valid_lgcs_st2[i] = new string(' ', 2);
            for (int i = 0; i < 10; i++)
                m_turn_restrictions[i] = new string(' ', 1);
            for (int i = 0; i < 5; i++)
                m_preferred_lgcs[i] = new string(' ', 2);
            m_true_replication_counter = new string(' ', 2);
            for (int i = 0; i < 20; i++)
                m_node_list[i] = new string(' ', 7);

            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 5; j++)
                    for (int k = 0; k < 4; k++)
                        m_node_b7scs[i, j, k] = new B7sc();

            m_reason_code = new string(' ', 1);
            m_reason_code_qualifier = new string(' ', 1);
            m_warning_code = new string(' ', 2);
            m_grc = new string(' ', 2);

            // Added for Geosupport Version 15.3/Release 15C
            m_latitude = new string(' ', 9);
            m_longitude = new string(' ', 11);

            // Census 2020 fields
            m_census_tract_2020 = new string(' ', 6);
            m_census_block_2020 = new string(' ', 4);
            m_census_block_suffix_2020 = new string(' ', 1);
            m_nta_2020 = new string(' ', 6);
            m_cdta_2020 = new string(' ', 4);

            m_filler_01 = new string(' ', 353);
        }

        public Wa2F2w(string inString) => Wa2F2wFromString(inString);

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>Wa2F2w</c> object to spaces
        /// </summary>
        public override void Clear() => Wa2F2wFromString(new string(' ', 4000));

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa2F2w</c> object to a string
        /// </summary>
        public override string ToString() => Wa2F2wToString();

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa2F2w</c> object
        /// </summary>
        public override void FromString(string inString) => Wa2F2wFromString(inString);

        /// <summary>
        /// Converts a <c>Wa2F2w</c> object to a string
        /// </summary>
        public string Wa2F2wToString()
        {
            var sb = new StringBuilder();

            sb.Append(m_wa2f2.ToString());
            sb.Append(m_filler_for_grid_gen);

            for (int i = 0; i <= 3; i++) sb.Append(m_valid_lgcs_st1[i]);
            for (int i = 0; i <= 3; i++) sb.Append(m_valid_lgcs_st2[i]);
            for (int i = 0; i <= 9; i++) sb.Append(m_turn_restrictions[i]);
            for (int i = 0; i <= 4; i++) sb.Append(m_preferred_lgcs[i]);
            sb.Append(m_true_replication_counter);

            for (int i = 0; i <= 19; i++) sb.Append(m_node_list[i]);

            // Need to expand this into an array
            for (int i = 0; i <= 19; i++)
                for (int j = 0; j <= 4; j++)
                    for (int k = 0; k <= 3; k++)
                        sb.Append(m_node_b7scs[i, j, k].B7scToString());

            sb.Append(m_reason_code);
            sb.Append(m_reason_code_qualifier);
            sb.Append(m_warning_code);
            sb.Append(m_grc);

            // Added for Geosupport Version 15.3/Release 15C - Start
            sb.Append(m_latitude);
            sb.Append(m_longitude);

            // Add 21 bytes for new census 2020 fields
            sb.Append(m_census_tract_2020);
            sb.Append(m_census_block_2020);
            sb.Append(m_census_block_suffix_2020);
            sb.Append(m_nta_2020);
            sb.Append(m_cdta_2020);

            // End of added for Geosupport Version 15.3/Release 15C
            sb.Append(m_filler_01);
            sb.Append(m_true_replication_counter);

            // Uncomment if needed
            // for (int i = 0; i <= 4; i++) sb.Append(m_x_sts[i].B5scToString());

            return sb.ToString();
        }

        public void Wa2F2wFromString(string inString)
        {
            int i, j, k;

            m_wa2f2.FromString(inString.Substring(0, 200));

            m_filler_for_grid_gen = inString.Substring(200, 22);

            for (i = 0; i <= 3; i++)
            {
                try{ m_valid_lgcs_st1[i] = inString.Substring(222 + (i * 2), 2); } catch { m_valid_lgcs_st1[i] = string.Empty;  }
            }

            for (i = 0; i <= 3; i++)
            {
                try { m_valid_lgcs_st2[i] = inString.Substring(230 + (i * 2), 2); } catch { m_valid_lgcs_st2[i] = string.Empty; }
            }

            //---------------------------------------------------------------------- 
            //--SPO(2022-02-07): Correcting the location for turn_restrictions 
            //----------------------------------------------------------------------
            for (i = 0; i <= 9; i++)
            {
                try { m_turn_restrictions[i] = inString.Substring(238 + (i * 1), 1); } catch { m_turn_restrictions[i] = string.Empty; }
            }

            for (i = 0; i <= 4; i++)
            {
                try { m_preferred_lgcs[i] = inString.Substring(248 + (i * 2), 2); } catch { m_preferred_lgcs[i] = string.Empty; }
            }

            m_true_replication_counter = inString.Substring(258, 2);

            for (i = 0; i <= 19; i++)
            {
                try { m_node_list[i] = inString.Substring(260 + (i * 7), 7); } catch { m_node_list[i] = string.Empty; }
            }

            // Need to expand this into an array 
            // m_filler_node_b7scs = inString.Substring(400, 3200);
            for (i = 0; i <= 19; i++)
                for (j = 0; j <= 4; j++)
                    for (k = 0; k <= 3; k++)
                        try { 
                            m_node_b7scs[i, j, k] = new B7sc(inString.Substring(400 + (k * 8) + (j * 32) + (i * 160), 8)); 
                        } catch { 
                            m_node_b7scs[i, j, k] = new B7sc(); 
                        }

            m_reason_code = inString.Substring(3600, 1);
            m_reason_code_qualifier = inString.Substring(3601, 1);
            m_warning_code = inString.Substring(3602, 2);
            m_grc = inString.Substring(3604, 2);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - Start
            m_latitude = inString.Substring(3606, 9);
            m_longitude = inString.Substring(3615, 11);

            //------------------------------------------------------------------
            //--spo(2021-03-10): Add 21 bytes for new census 2020 fields 
            //------------------------------------------------------------------
            m_census_tract_2020 = inString.Substring(3626, 6);
            m_census_block_2020 = inString.Substring(3632, 4);
            m_census_block_suffix_2020 = inString.Substring(3636, 1);
            m_nta_2020 = inString.Substring(3637, 6);
            m_cdta_2020 = inString.Substring(3643, 4);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - End

            // m_filler_01 = inString.Substring(3626, 374);
            m_filler_01 = inString.Substring(3647, 353);
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i, j, k;

            sb.Append(m_wa2f2.Display());
            sb.Append(c);

            sb.Append(m_filler_for_grid_gen);
            sb.Append(c);
            for (i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs_st1[i]);
                sb.Append(c);
            }

            for (i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs_st2[i]);
                sb.Append(c);
            }

            for (i = 0; i <= 9; i++)
            {
                sb.Append(m_turn_restrictions[i]);
                sb.Append(c);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_preferred_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_true_replication_counter);
            sb.Append(c);
            for (i = 0; i <= 19; i++)
            {
                sb.Append(m_node_list[i]);
                sb.Append(c);
            }

            // Need to expand this into an array 
            // sb.Append(m_filler_node_b7scs);
            sb.Append(c);
            for (i = 0; i <= 19; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    for (k = 0; k <= 3; k++)
                    {
                        sb.Append(m_node_b7scs[i, j, k].Display());
                        sb.Append(c);
                    }
                }
            }

            sb.Append(m_reason_code);
            sb.Append(c);
            sb.Append(m_reason_code_qualifier);
            sb.Append(c);
            sb.Append(m_warning_code);
            sb.Append(c);
            sb.Append(m_grc);
            sb.Append(c);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - Start
            sb.Append(m_latitude);
            sb.Append(c);
            sb.Append(m_longitude);
            sb.Append(c);

            //------------------------------------------------------------------
            //--spo(2021-03-10): Add 21 bytes for new census 2020 fields 
            //------------------------------------------------------------------
            sb.Append(m_census_tract_2020);
            sb.Append(c);
            sb.Append(m_census_block_2020);
            sb.Append(c);
            sb.Append(m_census_block_suffix_2020);
            sb.Append(c);
            sb.Append(m_nta_2020);
            sb.Append(c);
            sb.Append(m_cdta_2020);
            sb.Append(c);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - End

            sb.Append(m_filler_01);
            sb.Append(c);
            sb.Append(m_true_replication_counter);
            sb.Append(c);

            // For i = 0 to 4
            //     sb.Append(m_x_sts[i].B5scToString());
            // End For

            return sb.ToString();
        }

        public override string Display() => Display('-');

        public override string Print()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}{1}", m_wa2f2.Print, Environment.NewLine);
            sb.AppendFormat("filler_for_grid_gen = {0}{1}", m_filler_for_grid_gen, Environment.NewLine);

            for (int i = 0; i <= 3; i++)
                sb.AppendFormat("valid_lgcs_st1({0}) = {1}{2}", i, m_valid_lgcs_st1[i], Environment.NewLine);

            for (int i = 0; i <= 3; i++)
                sb.AppendFormat("valid_lgcs_st2({0}) = {1}{2}", i, m_valid_lgcs_st2[i], Environment.NewLine);

            for (int i = 0; i <= 9; i++)
                sb.AppendFormat("turn_restrictions({0}) = {1}{2}", i, m_turn_restrictions[i], Environment.NewLine);

            for (int i = 0; i <= 4; i++)
                sb.AppendFormat("preferred_lgcs({0}) = {1}{2}", i, m_preferred_lgcs[i], Environment.NewLine);

            sb.AppendFormat("true_replication_counter = {0}{1}", m_true_replication_counter, Environment.NewLine);

            for (int i = 0; i <= 19; i++)
                sb.AppendFormat("node_list({0}) = {1}{2}", i, m_node_list[i], Environment.NewLine);

            for (int i = 0; i <= 19; i++)
                for (int j = 0; j <= 4; j++)
                    for (int k = 0; k <= 3; k++)
                        sb.AppendFormat("node_b7scs({0}, {1}, {2}) = {3}{4}", i, j, k, m_node_b7scs[i, j, k].Display(), Environment.NewLine);

            sb.AppendFormat("reason_code = {0}{1}", m_reason_code, Environment.NewLine);
            sb.AppendFormat("reason_code_qualifier = {0}{1}", m_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("warning_code = {0}{1}", m_warning_code, Environment.NewLine);
            sb.AppendFormat("grc = {0}{1}", m_grc, Environment.NewLine);

            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);

            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("nta_2020 {0}{1}", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("cdta_2020 = {0}{1}", m_cdta_2020, Environment.NewLine);

            sb.AppendFormat("filler_01 = {0}{1}", m_filler_01, Environment.NewLine);

            return sb.ToString();
        }


        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F2w  **********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("{0}{1}", m_wa2f2.Report(), Environment.NewLine);

            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "********************  Information beyond Wa2F2  ********************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Latitude Longitude Information  **********", Environment.NewLine + Environment.NewLine);
            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);

            // Add 21 bytes for new census 2020 fields
            sb.AppendFormat("{0}{1}", m_wa2f2.Report(), Environment.NewLine);
            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Census 2020 Geography  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("nta_2020 {0}{1}", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("cdta_2020 = {0}{1}", m_cdta_2020, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Valid and Preferred LGCs for Input Streets  **********", Environment.NewLine + Environment.NewLine);

            for (int i = 0; i <= 3; i++)
                sb.AppendFormat("valid_lgcs_st1({0}) = {1}{2}", i, m_valid_lgcs_st1[i], Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            for (int i = 0; i <= 3; i++)
                sb.AppendFormat("valid_lgcs_st2({0}) = {1}{2}", i, m_valid_lgcs_st2[i], Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            for (int i = 0; i <= 4; i++)
                sb.AppendFormat("preferred_lgcs({0}) = {1}{2}", i, m_preferred_lgcs[i], Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            for (int i = 0; i <= 9; i++)
                sb.AppendFormat("turn_restrictions({0}) = {1}{2}", i, m_turn_restrictions[i], Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Node List for Duplicate Intersecting Streets  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("true_replication_counter = {0}{1}", m_true_replication_counter, Environment.NewLine);
            for (int i = 0; i <= 19; i++)
                sb.AppendFormat("node_list({0}) = {1}{2}", i, m_node_list[i], Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Intersecting B7SCs for Nodes  **********", Environment.NewLine + Environment.NewLine);

            // Expand this into an array 
            for (int i = 0; i <= 19; i++)
                for (int j = 0; j <= 4; j++)
                    for (int k = 0; k <= 3; k++)
                        sb.AppendFormat("node_b7scs({0}, {1}, {2}) = {3}{4}", i, j, k, m_node_b7scs[i, j, k].Display(), Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  GRC Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("reason_code = {0}{1}", m_reason_code, Environment.NewLine);
            sb.AppendFormat("reason_code_qualifier = {0}{1}", m_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("warning_code = {0}{1}", m_warning_code, Environment.NewLine);
            sb.AppendFormat("grc = {0}{1}", m_grc, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Latitude/Longitude  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Miscellaneous Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("filler_for_grid_gen = {0}{1}", m_filler_for_grid_gen, Environment.NewLine);
            sb.AppendFormat("filler_01 = {0}{1}", m_filler_01, Environment.NewLine);

            return sb.ToString();
        }

        public Wa2F2 wa2f2
        {
            get { return m_wa2f2; }
            set { m_wa2f2 = value; }
        }


        public string filler_for_grid_gen
        {
            get { return m_filler_for_grid_gen; }
            set
            {
                int strlen = value.Length;
                if (strlen > 22) strlen = 22;
                m_filler_for_grid_gen = value.Substring(0, strlen);
            }
        }


        public string[] valid_lgcs_st1
        {
            get { return m_valid_lgcs_st1; }
            set { m_valid_lgcs_st1 = value; }
        }

        public string valid_lgcs_st1_item(int index) => m_valid_lgcs_st1[index];

        public void valid_lgcs_st1_item(int index, string value){
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_valid_lgcs_st1[index] = value.Substring(0, strlen);
        }


        public string[] valid_lgcs_st2
        {
            get { return m_valid_lgcs_st2; }
            set { m_valid_lgcs_st2 = value; }
        }

        public string valid_lgcs_st2_item(int index) => m_valid_lgcs_st2[index];
        public void valid_lgcs_st2_item(int index, string value){
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_valid_lgcs_st2[index] = value.Substring(0, strlen);
        }
        

        public string[] turn_restrictions
        {
            get { return m_turn_restrictions; }
            set { m_turn_restrictions = value; }
        }

        public string turn_restrictions_item(int index) => m_turn_restrictions[index];

        public void turn_restrictions_item(int index, string value){
            int strlen = value.Length;
            if (strlen > 1) strlen = 1;
            m_turn_restrictions[index] = value.Substring(0, strlen);
        }

        public string[] preferred_lgcs
        {
            get { return m_preferred_lgcs; }
            set { m_preferred_lgcs = value; }
        }

        public string preferred_lgcs_item(int index) => m_preferred_lgcs[index];
        public void preferred_lgcs_item(int index, string value){
            int strlen = value.Length;
            if (strlen > 2) strlen = 2;
            m_preferred_lgcs[index] = value.Substring(0, strlen);
        }


        public string true_replication_counter
        {
            get { return m_true_replication_counter; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_true_replication_counter = value.Substring(0, strlen);
            }
        }


        public string[] node_list
        {
            get { return m_node_list; }
            set { m_node_list = value; }
        }

        public string node_list_item(int index) => m_node_list[index];
        public void node_list_item(int index, string value){
            int strlen = value.Length;
            if (strlen > 7) strlen = 7;
            m_node_list[index] = value.Substring(0, strlen);
        }

        public B7sc[,,] node_b7scs
        {
            get { return m_node_b7scs; }
            set { m_node_b7scs = value; }
        }
        // Property for node_b7scs_item
        public B7sc node_b7scs_item(int Node_Idx, int Street_Idx, int Lgc_Idx) => m_node_b7scs[Node_Idx, Street_Idx, Lgc_Idx];
        public void node_b7scs_item(int Node_Idx, int Street_Idx, int Lgc_Idx, B7sc value) =>  m_node_b7scs[Node_Idx, Street_Idx, Lgc_Idx] = value;
        

        // Property for reason_code
        public string reason_code
        {
            get => m_reason_code;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_reason_code = value.Substring(0, strlen);
            }
        }

        // Property for reason_code_qualifier
        public string reason_code_qualifier
        {
            get => m_reason_code_qualifier;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_reason_code_qualifier = value.Substring(0, strlen);
            }
        }

        // Property for warning_code
        public string warning_code
        {
            get => m_warning_code;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 2 ? 2 : strlen;
                m_warning_code = value.Substring(0, strlen);
            }
        }

        // Property for grc
        public string grc
        {
            get => m_grc;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 2 ? 2 : strlen;
                m_grc = value.Substring(0, strlen);
            }
        }

        // Property for m_latitude
        public string latitude
        {
            get => m_latitude;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 9 ? 9 : strlen;
                m_latitude = value.Substring(0, strlen);
            }
        }

        // Property for m_longitude
        public string longitude
        {
            get => m_longitude;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 11 ? 11 : strlen;
                m_longitude = value.Substring(0, strlen);
            }
        }

        // Property for census_tract_2020
        public string census_tract_2020
        {
            get => m_census_tract_2020;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 6 ? 6 : strlen;
                m_census_tract_2020 = value.Substring(0, strlen);
            }
        }

        // Property for census_block_2020
        public string census_block_2020
        {
            get => m_census_block_2020;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 4 ? 4 : strlen;
                m_census_block_2020 = value.Substring(0, strlen);
            }
        }

        // Property for census_block_suffix_2020
        public string census_block_suffix_2020
        {
            get => m_census_block_suffix_2020;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_census_block_suffix_2020 = value.Substring(0, strlen);
            }
        }

        // Property for nta_2020
        public string nta_2020
        {
            get => m_nta_2020;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 6 ? 6 : strlen;
                m_nta_2020 = value.Substring(0, strlen);
            }
        }

        // Property for cdta_2020
        public string cdta_2020
        {
            get => m_cdta_2020;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 4 ? 4 : strlen;
                m_cdta_2020 = value.Substring(0, strlen);
            }
        }

        // Property for filler_01
        public string filler_01
        {
            get => m_filler_01;
            set
            {
                int strlen = value.Length;
                // If strlen > 394 Then strlen = 374
                strlen = strlen > 353 ? 353 : strlen;
                m_filler_01 = value.Substring(0, strlen);
            }
        }


    }

}
