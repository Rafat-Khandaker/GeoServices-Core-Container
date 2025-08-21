using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1v : WA
    {
        private Wa2F1e m_wa2f1e;

        private string[] m_valid_lgcs = new string[4];
        private string m_boe_lgc_pointer;
        private string m_segment_azm;
        private string m_segment_orient;
        private string m_lo_x_coord;
        private string m_lo_y_coord;
        private string m_lo_z_coord;
        private string m_hi_x_coord;
        private string m_hi_y_coord;
        private string m_hi_z_coord;
        private string m_curve_center_x_coord;
        private string m_curve_center_y_coord;
        private string m_curve_center_z_coord;
        private string m_circle_radius;
        private string m_secant_location;
        private string m_beta_angle;
        private string m_alpha_angle;
        private string m_from_node;
        private string m_to_node;
        private LionKey m_vanity_lion_key;
        private string m_vanity_sos;
        private string m_split_lo_hns;
        private string m_traffic_dir;
        private string m_turn_restrictions;
        private string m_gbicurv_fraction;
        private string m_roadway_type;
        private string m_physical_id;
        private string m_generic_id;
        private string m_nypd_id;
        private string m_fdny_id;
        private string m_filler03;
        private string m_street_status;
        private string m_street_width;
        private string m_street_width_irregular;
        private string m_bike_lane;
        private string m_federal_classification_code;
        private string m_right_of_way_type;
        private string[] m_additional_valid_lgcs = new string[5];

        /// <summary>Constructor for <c>Wa2F1v</c></summary>
        public Wa2F1v()
        {
            m_wa2f1e = new Wa2F1e();

            for (int i = 0; i < 4; i++)
                 m_valid_lgcs[i] = new string(' ', 2); 
            
            m_boe_lgc_pointer = new string(' ', 1);
            m_segment_azm = new string(' ', 3);
            m_segment_orient = new string(' ', 1);
            m_lo_x_coord = new string(' ', 7);
            m_lo_y_coord = new string(' ', 7);
            m_lo_z_coord = new string(' ', 7);
            m_hi_x_coord = new string(' ', 7);
            m_hi_y_coord = new string(' ', 7);
            m_hi_z_coord = new string(' ', 7);
            m_curve_center_x_coord = new string(' ', 7);
            m_curve_center_y_coord = new string(' ', 7);
            m_curve_center_z_coord = new string(' ', 7);
            m_circle_radius = new string(' ', 7);
            m_secant_location = new string(' ', 1);
            m_beta_angle = new string(' ', 5);
            m_alpha_angle = new string(' ', 5);
            m_from_node = new string(' ', 7);
            m_to_node = new string(' ', 7);
            m_vanity_lion_key = new LionKey();
            m_vanity_sos = new string(' ', 1);
            m_split_lo_hns = new string(' ', 11);
            m_traffic_dir = new string(' ', 1);
            m_turn_restrictions = new string(' ', 10);
            m_gbicurv_fraction = new string(' ', 3);
            m_roadway_type = new string(' ', 2);
            m_physical_id = new string(' ', 7);
            m_generic_id = new string(' ', 7);
            m_nypd_id = new string(' ', 7);
            m_fdny_id = new string(' ', 7);
            m_filler03 = new string(' ', 7);
            m_street_status = new string(' ', 1);
            m_street_width = new string(' ', 3);
            m_street_width_irregular = new string(' ', 1);
            m_bike_lane = new string(' ', 2);
            m_federal_classification_code = new string(' ', 2);
            m_right_of_way_type = new string(' ', 1);

            for (int i = 0; i < 5; i++)
                m_additional_valid_lgcs[i] = new string(' ', 2);
        }

        public Wa2F1v(string inString) => Wa2F1vFromString(inString);

        /// <summary>Clear reinitializes the Wa2F1v object to spaces</summary>
        public override void Clear() => Wa2F1vFromString(new string(' ', 500));

        /// <summary>ToString converts a Wa2F1v object to a string</summary>
        public override string ToString() => Wa2F1vToString();

        /// <summary>FromString converts a string to a Wa2F1v object</summary>
        public override void FromString(string inString) => Wa2F1vFromString(inString);

        /// <summary>Wa2F1vToString converts a Wa2F1v object to a string</summary>
        public string Wa2F1vToString()
        {
            var sb = new StringBuilder();

            sb.Append(m_wa2f1e.ToString());

            for (int i = 0; i < 4; i++)
                sb.Append(m_valid_lgcs[i]);

            sb.Append(m_boe_lgc_pointer);
            sb.Append(m_segment_azm);
            sb.Append(m_segment_orient);
            sb.Append(m_lo_x_coord);
            sb.Append(m_lo_y_coord);
            sb.Append(m_lo_z_coord);
            sb.Append(m_hi_x_coord);
            sb.Append(m_hi_y_coord);
            sb.Append(m_hi_z_coord);
            sb.Append(m_curve_center_x_coord);
            sb.Append(m_curve_center_y_coord);
            sb.Append(m_curve_center_z_coord);
            sb.Append(m_circle_radius);
            sb.Append(m_secant_location);
            sb.Append(m_beta_angle);
            sb.Append(m_alpha_angle);
            sb.Append(m_from_node);
            sb.Append(m_to_node);
            sb.Append(m_vanity_lion_key.LionKeyToString());
            sb.Append(m_vanity_sos);
            sb.Append(m_split_lo_hns);
            sb.Append(m_traffic_dir);
            sb.Append(m_turn_restrictions);
            sb.Append(m_gbicurv_fraction);
            sb.Append(m_roadway_type);
            sb.Append(m_physical_id);
            sb.Append(m_generic_id);
            sb.Append(m_nypd_id);
            sb.Append(m_fdny_id);
            sb.Append(m_filler03);
            sb.Append(m_street_status);
            sb.Append(m_street_width);
            sb.Append(m_street_width_irregular);
            sb.Append(m_bike_lane);
            sb.Append(m_federal_classification_code);
            sb.Append(m_right_of_way_type);

            // Append m_additional_valid_lgcs array (which is zero-based)
            for (int i = 0; i < 5; i++)
                sb.Append(m_additional_valid_lgcs[i]);

            return sb.ToString();
        }
        /// <summary>Converts a string to a Wa2F1v object</summary>
        public void Wa2F1vFromString(string inString)
        {
            int i;

            // Parse m_wa2f1e object from the first 300 characters
            m_wa2f1e.FromString(inString.Substring(0, 300));

            // Parse valid_lgcs array (0 to 3)
            for (i = 0; i < 4; i++)
            {
                try { m_valid_lgcs[i] = inString.Substring(300 + (i * 2), 2); } catch { m_valid_lgcs[i] = string.Empty; }
            }

            // Parse other fields based on their respective positions
            m_boe_lgc_pointer = inString.Substring(308, 1);
            m_segment_azm = inString.Substring(309, 3);
            m_segment_orient = inString.Substring(312, 1);
            m_lo_x_coord = inString.Substring(313, 7);
            m_lo_y_coord = inString.Substring(320, 7);
            m_lo_z_coord = inString.Substring(327, 7);
            m_hi_x_coord = inString.Substring(334, 7);
            m_hi_y_coord = inString.Substring(341, 7);
            m_hi_z_coord = inString.Substring(348, 7);
            m_curve_center_x_coord = inString.Substring(355, 7);
            m_curve_center_y_coord = inString.Substring(362, 7);
            m_curve_center_z_coord = inString.Substring(369, 7);
            m_circle_radius = inString.Substring(376, 7);
            m_secant_location = inString.Substring(383, 1);
            m_beta_angle = inString.Substring(384, 5);
            m_alpha_angle = inString.Substring(389, 5);
            m_from_node = inString.Substring(394, 7);
            m_to_node = inString.Substring(401, 7);
            m_vanity_lion_key = new LionKey(inString.Substring(408, 10));
            m_vanity_sos = inString.Substring(418, 1);
            m_split_lo_hns = inString.Substring(419, 11);
            m_traffic_dir = inString.Substring(430, 1);
            m_turn_restrictions = inString.Substring(431, 10);
            m_gbicurv_fraction = inString.Substring(441, 3);
            m_roadway_type = inString.Substring(444, 2);
            m_physical_id = inString.Substring(446, 7);
            m_generic_id = inString.Substring(453, 7);
            m_nypd_id = inString.Substring(460, 7);
            m_fdny_id = inString.Substring(467, 7);
            m_filler03 = inString.Substring(474, 7);
            m_street_status = inString.Substring(481, 1);
            m_street_width = inString.Substring(482, 3);
            m_street_width_irregular = inString.Substring(485, 1);
            m_bike_lane = inString.Substring(486, 1);
            m_federal_classification_code = inString.Substring(487, 2);
            m_right_of_way_type = inString.Substring(489, 1);

            // Parse m_additional_valid_lgcs array (0 to 4)
            for (i = 0; i < 5; i++)
            {
                try { m_additional_valid_lgcs[i] = inString.Substring(490 + (i * 2), 2); }
                catch { m_additional_valid_lgcs[i] = string.Empty; }
            }
        }

        /// <summary>Displays all fields as a string separated by a specified character</summary>
        public override string Display(char c)
        {
            var sb = new StringBuilder();

            sb.Append(m_wa2f1e.Display());
            sb.Append(c);

            // Append valid_lgcs (0 to 3)
            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_boe_lgc_pointer);
            sb.Append(c);
            sb.Append(m_segment_azm);
            sb.Append(c);
            sb.Append(m_segment_orient);
            sb.Append(c);
            sb.Append(m_lo_x_coord);
            sb.Append(c);
            sb.Append(m_lo_y_coord);
            sb.Append(c);
            sb.Append(m_lo_z_coord);
            sb.Append(c);
            sb.Append(m_hi_x_coord);
            sb.Append(c);
            sb.Append(m_hi_y_coord);
            sb.Append(c);
            sb.Append(m_hi_z_coord);
            sb.Append(c);
            sb.Append(m_curve_center_x_coord);
            sb.Append(c);
            sb.Append(m_curve_center_y_coord);
            sb.Append(c);
            sb.Append(m_curve_center_z_coord);
            sb.Append(c);
            sb.Append(m_circle_radius);
            sb.Append(c);
            sb.Append(m_secant_location);
            sb.Append(c);
            sb.Append(m_beta_angle);
            sb.Append(c);
            sb.Append(m_alpha_angle);
            sb.Append(c);
            sb.Append(m_from_node);
            sb.Append(c);
            sb.Append(m_to_node);
            sb.Append(c);
            sb.Append(m_vanity_lion_key.Display());
            sb.Append(c);
            sb.Append(m_vanity_sos);
            sb.Append(c);
            sb.Append(m_split_lo_hns);
            sb.Append(c);
            sb.Append(m_traffic_dir);
            sb.Append(c);
            sb.Append(m_turn_restrictions);
            sb.Append(c);
            sb.Append(m_gbicurv_fraction);
            sb.Append(c);
            sb.Append(m_roadway_type);
            sb.Append(c);
            sb.Append(m_physical_id);
            sb.Append(c);
            sb.Append(m_generic_id);
            sb.Append(c);
            sb.Append(m_nypd_id);
            sb.Append(c);
            sb.Append(m_fdny_id);
            sb.Append(c);
            sb.Append(m_filler03);
            sb.Append(c);
            sb.Append(m_street_status);
            sb.Append(c);
            sb.Append(m_street_width);
            sb.Append(c);
            sb.Append(m_street_width_irregular);
            sb.Append(c);
            sb.Append(m_bike_lane);
            sb.Append(c);
            sb.Append(m_federal_classification_code);
            sb.Append(c);
            sb.Append(m_right_of_way_type);
            sb.Append(c);

            // Append m_additional_valid_lgcs (0 to 4)
            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_additional_valid_lgcs[i]);
                sb.Append(c);
            }

            return sb.ToString();
        }


        /// <summary>
        /// Display method that uses a default character "-" for separation
        /// </summary>
        public override string Display() => Display('-');

        /// <summary>
        /// Print method that returns a formatted string of field names and their corresponding values.
        /// </summary>
        public override string Print()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{m_wa2f1e.Print}");

            // Print valid_lgcs (0 to 3)
            for (int i = 0; i < 4; i++)
                sb.AppendLine($"valid_lgcs({i}) = {m_valid_lgcs[i]}");

            sb.AppendLine($"boe_lgc_pointer = {m_boe_lgc_pointer}");
            sb.AppendLine($"segment_azm = {m_segment_azm}");
            sb.AppendLine($"segment_orient = {m_segment_orient}");
            sb.AppendLine($"lo_x_coord = {m_lo_x_coord}");
            sb.AppendLine($"lo_y_coord = {m_lo_y_coord}");
            sb.AppendLine($"lo_z_coord = {m_lo_z_coord}");
            sb.AppendLine($"hi_x_coord = {m_hi_x_coord}");
            sb.AppendLine($"hi_y_coord = {m_hi_y_coord}");
            sb.AppendLine($"hi_z_coord = {m_hi_z_coord}");
            sb.AppendLine($"curve_center_x_coord = {m_curve_center_x_coord}");
            sb.AppendLine($"curve_center_y_coord = {m_curve_center_y_coord}");
            sb.AppendLine($"curve_center_z_coord = {m_curve_center_z_coord}");
            sb.AppendLine($"circle_radius = {m_circle_radius}");
            sb.AppendLine($"secant_location = {m_secant_location}");
            sb.AppendLine($"beta_angle = {m_beta_angle}");
            sb.AppendLine($"alpha_angle = {m_alpha_angle}");
            sb.AppendLine($"from_node = {m_from_node}");
            sb.AppendLine($"to_node = {m_to_node}");
            sb.AppendLine($"vanity_lion_key = {m_vanity_lion_key.Display()}");
            sb.AppendLine($"vanity_sos = {m_vanity_sos}");
            sb.AppendLine($"split_lo_hns = {m_split_lo_hns}");
            sb.AppendLine($"traffic_dir = {m_traffic_dir}");
            sb.AppendLine($"turn_restrictions = {m_turn_restrictions}");
            sb.AppendLine($"gbicurv_fraction = {m_gbicurv_fraction}");
            sb.AppendLine($"roadway_type = {m_roadway_type}");
            sb.AppendLine($"physical_id = {m_physical_id}");
            sb.AppendLine($"generic_id = {m_generic_id}");
            sb.AppendLine($"nypd_id = {m_nypd_id}");
            sb.AppendLine($"fdny_id = {m_fdny_id}");
            sb.AppendLine($"filler03 = {m_filler03}");
            sb.AppendLine($"street_status = {m_street_status}");
            sb.AppendLine($"street_width = {m_street_width}");
            sb.AppendLine($"street_width_irregular = {m_street_width_irregular}");
            sb.AppendLine($"bike_lane = {m_bike_lane}");
            sb.AppendLine($"federal_classification_code = {m_federal_classification_code}");
            sb.AppendLine($"right_of_way_type = {m_right_of_way_type}");

            // Print additional_valid_lgcs (0 to 4)
            for (int i = 0; i < 5; i++)
                sb.AppendLine($"additional_valid_lgcs({i}) = {m_additional_valid_lgcs[i]}");

            return sb.ToString();
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F1v  ***********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            return sb.ToString();
        }

        public Wa2F1e wa2f1e
        {
            get => m_wa2f1e;
            set => m_wa2f1e = value;
        }

        [XmlArrayItem(typeof(string), ElementName = "lgc")]
        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string valid_lgcs_item(int index) => m_valid_lgcs[index];
        public void valid_lgcs_item(int index, string value)
        {
            var strlen = Math.Min(value.Length, 2);
            m_valid_lgcs[index] = value.Substring(0, strlen);
        }
        

        public string boe_lgc_pointer
        {
            get => m_boe_lgc_pointer;
            set
            {
                var strlen = Math.Min(value.Length, 1);
                m_boe_lgc_pointer = value.Substring(0, strlen);
            }
        }

        public string segment_azm
        {
            get => m_segment_azm;
            set
            {
                var strlen = Math.Min(value.Length, 3);
                m_segment_azm = value.Substring(0, strlen);
            }
        }

        public string segment_orient
        {
            get => m_segment_orient;
            set
            {
                var strlen = Math.Min(value.Length, 1);
                m_segment_orient = value.Substring(0, strlen);
            }
        }

        public string lo_x_coord
        {
            get => m_lo_x_coord;
            set
            {
                var strlen = Math.Min(value.Length, 7);
                m_lo_x_coord = value.Substring(0, strlen);
            }
        }

        public string lo_y_coord
        {
            get => m_lo_y_coord;
            set
            {
                var strlen = Math.Min(value.Length, 7);
                m_lo_y_coord = value.Substring(0, strlen);
            }
        }

        public string lo_z_coord
        {
            get => m_lo_z_coord;
            set
            {
                var strlen = Math.Min(value.Length, 7);
                m_lo_z_coord = value.Substring(0, strlen);
            }
        }

        public string hi_x_coord
        {
            get => m_hi_x_coord;
            set => m_hi_x_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string hi_y_coord
        {
            get => m_hi_y_coord;
            set => m_hi_y_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string hi_z_coord
        {
            get => m_hi_z_coord;
            set => m_hi_z_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string curve_center_x_coord
        {
            get => m_curve_center_x_coord;
            set => m_curve_center_x_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string curve_center_y_coord
        {
            get => m_curve_center_y_coord;
            set => m_curve_center_y_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string curve_center_z_coord
        {
            get => m_curve_center_z_coord;
            set => m_curve_center_z_coord = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string circle_radius
        {
            get => m_circle_radius;
            set => m_circle_radius = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string secant_location
        {
            get => m_secant_location;
            set => m_secant_location = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string beta_angle
        {
            get => m_beta_angle;
            set => m_beta_angle = value.Substring(0, Math.Min(value.Length, 5));
        }

        public string alpha_angle
        {
            get => m_alpha_angle;
            set => m_alpha_angle = value.Substring(0, Math.Min(value.Length, 5));
        }

        public string from_node
        {
            get => m_from_node;
            set => m_from_node = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string to_node
        {
            get => m_to_node;
            set => m_to_node = value.Substring(0, Math.Min(value.Length, 7));
        }

        public LionKey vanity_lion_key
        {
            get => m_vanity_lion_key;
            set => m_vanity_lion_key = value;
        }

        public string vanity_sos
        {
            get => m_vanity_sos;
            set => m_vanity_sos = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string split_lo_hns
        {
            get => m_split_lo_hns;
            set => m_split_lo_hns = value.Substring(0, Math.Min(value.Length, 11));
        }

        public string traffic_dir
        {
            get => m_traffic_dir;
            set => m_traffic_dir = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string turn_restrictions
        {
            get => m_turn_restrictions;
            set => m_turn_restrictions = value.Substring(0, Math.Min(value.Length, 10));
        }

        public string gbicurv_fraction
        {
            get => m_gbicurv_fraction;
            set => m_gbicurv_fraction = value.Substring(0, Math.Min(value.Length, 3));
        }

        public string roadway_type
        {
            get => m_roadway_type;
            set => m_roadway_type = value.Substring(0, Math.Min(value.Length, 2));
        }

        public string physical_id
        {
            get => m_physical_id;
            set => m_physical_id = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string generic_id
        {
            get => m_generic_id;
            set => m_generic_id = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string nypd_id
        {
            get => m_nypd_id;
            set => m_nypd_id = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string fdny_id
        {
            get => m_fdny_id;
            set => m_fdny_id = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string filler03
        {
            get => m_filler03;
            set => m_filler03 = value.Substring(0, Math.Min(value.Length, 7));
        }

        public string street_status
        {
            get => m_street_status;
            set => m_street_status = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string street_width
        {
            get => m_street_width;
            set => m_street_width = value.Substring(0, Math.Min(value.Length, 3));
        }

        public string street_width_irregular
        {
            get => m_street_width_irregular;
            set => m_street_width_irregular = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string bike_lane
        {
            get => m_bike_lane;
            set => m_bike_lane = value.Substring(0, Math.Min(value.Length, 2));
        }

        public string federal_classification_code
        {
            get => m_federal_classification_code;
            set => m_federal_classification_code = value.Substring(0, Math.Min(value.Length, 2));
        }

        public string right_of_way_type
        {
            get => m_right_of_way_type;
            set => m_right_of_way_type = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string[] additional_valid_lgcs
        {
            get => m_additional_valid_lgcs;
            set => m_additional_valid_lgcs = value;
        }

        public string additional_valid_lgcs_item(int index) => m_additional_valid_lgcs[index];

        public void additional_valid_lgcs_item(int index, string value) {
            var strlen = Math.Min(value.Length, 2);
            m_additional_valid_lgcs[index] = value.Substring(0, strlen);          
        }

    }

}
