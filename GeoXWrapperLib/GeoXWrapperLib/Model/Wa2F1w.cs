using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1w : WA
    {
        private Wa2F1 m_wa2f1;
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

        // Default Constructor
        public Wa2F1w()
        {
            m_wa2f1 = new Wa2F1();

            for (int i = 0; i <= 3; i++)
            {
                m_valid_lgcs[i] = new string(' ', 2);
            }
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

            for (int i = 0; i <= 4; i++)
            {
                m_additional_valid_lgcs[i] = new string(' ', 2);
            }
        }

        // Constructor with a string parameter
        public Wa2F1w(string inString)
        {
            Wa2F1wFromString(inString);
        }

        // Clear method
        public override void Clear()
        {
            Wa2F1wFromString(new string(' ', 500));
        }

        // ToString method
        public override string ToString()
        {
            return Wa2F1wToString();
        }

        // FromString method
        public override void FromString(string inString)
        {
            Wa2F1wFromString(inString);
        }

        // Placeholder methods to avoid compilation errors (assuming these methods are defined elsewhere)
        public string Wa2F1wToString()
        {
            var sb = new StringBuilder();

            sb.Append(m_wa2f1.ToString());

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs[i]);
            }

            sb.Append(m_boe_lgc_pointer)
              .Append(m_segment_azm)
              .Append(m_segment_orient)
              .Append(m_lo_x_coord)
              .Append(m_lo_y_coord)
              .Append(m_lo_z_coord)
              .Append(m_hi_x_coord)
              .Append(m_hi_y_coord)
              .Append(m_hi_z_coord)
              .Append(m_curve_center_x_coord)
              .Append(m_curve_center_y_coord)
              .Append(m_curve_center_z_coord)
              .Append(m_circle_radius)
              .Append(m_secant_location)
              .Append(m_beta_angle)
              .Append(m_alpha_angle)
              .Append(m_from_node)
              .Append(m_to_node)
              .Append(m_vanity_lion_key.LionKeyToString())
              .Append(m_vanity_sos)
              .Append(m_split_lo_hns)
              .Append(m_traffic_dir)
              .Append(m_turn_restrictions)
              .Append(m_gbicurv_fraction)
              .Append(m_roadway_type)
              .Append(m_physical_id)
              .Append(m_generic_id)
              .Append(m_nypd_id)
              .Append(m_fdny_id)
              .Append(m_filler03)
              .Append(m_street_status)
              .Append(m_street_width)
              .Append(m_street_width_irregular)
              .Append(m_bike_lane)
              .Append(m_federal_classification_code)
              .Append(m_right_of_way_type);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_additional_valid_lgcs[i]);
            }

            return sb.ToString();
        }

        public void Wa2F1wFromString(string inString)
        {
            int index = 0;

            m_wa2f1.FromString(inString.Substring(index, 300));
            index += 300;

            for (int i = 0; i <= 3; i++)
            {
                m_valid_lgcs[i] = inString.Substring(index, 2);
                index += 2;
            }

            m_boe_lgc_pointer = inString.Substring(index, 1);
            index += 1;

            m_segment_azm = inString.Substring(index, 3);
            index += 3;

            m_segment_orient = inString.Substring(index, 1);
            index += 1;

            m_lo_x_coord = inString.Substring(index, 7);
            index += 7;

            m_lo_y_coord = inString.Substring(index, 7);
            index += 7;

            m_lo_z_coord = inString.Substring(index, 7);
            index += 7;

            m_hi_x_coord = inString.Substring(index, 7);
            index += 7;

            m_hi_y_coord = inString.Substring(index, 7);
            index += 7;

            m_hi_z_coord = inString.Substring(index, 7);
            index += 7;

            m_curve_center_x_coord = inString.Substring(index, 7);
            index += 7;

            m_curve_center_y_coord = inString.Substring(index, 7);
            index += 7;

            m_curve_center_z_coord = inString.Substring(index, 7);
            index += 7;

            m_circle_radius = inString.Substring(index, 7);
            index += 7;

            m_secant_location = inString.Substring(index, 1);
            index += 1;

            m_beta_angle = inString.Substring(index, 5);
            index += 5;

            m_alpha_angle = inString.Substring(index, 5);
            index += 5;

            m_from_node = inString.Substring(index, 7);
            index += 7;

            m_to_node = inString.Substring(index, 7);
            index += 7;

            m_vanity_lion_key = new LionKey(inString.Substring(index, 10));
            index += 10;

            m_vanity_sos = inString.Substring(index, 1);
            index += 1;

            m_split_lo_hns = inString.Substring(index, 11);
            index += 11;

            m_traffic_dir = inString.Substring(index, 1);
            index += 1;

            m_turn_restrictions = inString.Substring(index, 10);
            index += 10;

            m_gbicurv_fraction = inString.Substring(index, 3);
            index += 3;

            m_roadway_type = inString.Substring(index, 2);
            index += 2;

            m_physical_id = inString.Substring(index, 7);
            index += 7;

            m_generic_id = inString.Substring(index, 7);
            index += 7;

            m_nypd_id = inString.Substring(index, 7);
            index += 7;

            m_fdny_id = inString.Substring(index, 7);
            index += 7;

            m_filler03 = inString.Substring(index, 7);
            index += 7;

            m_street_status = inString.Substring(index, 1);
            index += 1;

            m_street_width = inString.Substring(index, 3);
            index += 3;

            m_street_width_irregular = inString.Substring(index, 1);
            index += 1;

            m_bike_lane = inString.Substring(index, 1);
            index += 1;

            m_federal_classification_code = inString.Substring(index, 2);
            index += 2;

            m_right_of_way_type = inString.Substring(index, 1);
            index += 1;

            for (int i = 0; i <= 4; i++)
            {
                try { m_additional_valid_lgcs[i] = inString.Substring(490 + (i * 2), 2); } catch { m_additional_valid_lgcs[i] = string.Empty; }
                index += 2;
            }
        }

        public override string Display(char c)
        {
            var sb = new StringBuilder();

            sb.Append(m_wa2f1.Display());

            sb.Append(c);
            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_boe_lgc_pointer)
              .Append(c)
              .Append(m_segment_azm)
              .Append(c)
              .Append(m_segment_orient)
              .Append(c)
              .Append(m_lo_x_coord)
              .Append(c)
              .Append(m_lo_y_coord)
              .Append(c)
              .Append(m_lo_z_coord)
              .Append(c)
              .Append(m_hi_x_coord)
              .Append(c)
              .Append(m_hi_y_coord)
              .Append(c)
              .Append(m_hi_z_coord)
              .Append(c)
              .Append(m_curve_center_x_coord)
              .Append(c)
              .Append(m_curve_center_y_coord)
              .Append(c)
              .Append(m_curve_center_z_coord)
              .Append(c)
              .Append(m_circle_radius)
              .Append(c)
              .Append(m_secant_location)
              .Append(c)
              .Append(m_beta_angle)
              .Append(c)
              .Append(m_alpha_angle)
              .Append(c)
              .Append(m_from_node)
              .Append(c)
              .Append(m_to_node)
              .Append(c)
              .Append(m_vanity_lion_key.Display())
              .Append(c)
              .Append(m_vanity_sos)
              .Append(c)
              .Append(m_split_lo_hns)
              .Append(c)
              .Append(m_traffic_dir)
              .Append(c)
              .Append(m_turn_restrictions)
              .Append(c)
              .Append(m_gbicurv_fraction)
              .Append(c)
              .Append(m_roadway_type)
              .Append(c)
              .Append(m_physical_id)
              .Append(c)
              .Append(m_generic_id)
              .Append(c)
              .Append(m_nypd_id)
              .Append(c)
              .Append(m_fdny_id)
              .Append(c)
              .Append(m_filler03)
              .Append(c)
              .Append(m_street_status)
              .Append(c)
              .Append(m_street_width)
              .Append(c)
              .Append(m_street_width_irregular)
              .Append(c)
              .Append(m_bike_lane)
              .Append(c)
              .Append(m_federal_classification_code)
              .Append(c)
              .Append(m_right_of_way_type)
              .Append(c);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_additional_valid_lgcs[i]);
                sb.Append(c);
            }

            return sb.ToString();
        }

        public override string Display() => Display('-');
        public override string Print()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}{1}", m_wa2f1.Print(), Environment.NewLine);

            for (int i = 0; i <= 3; i++)
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);

            sb.AppendFormat("boe_lgc_pointer = {0}{1}", m_boe_lgc_pointer, Environment.NewLine)
              .AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine)
              .AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine)
              .AppendFormat("lo_x_coord = {0}{1}", m_lo_x_coord, Environment.NewLine)
              .AppendFormat("lo_y_coord = {0}{1}", m_lo_y_coord, Environment.NewLine)
              .AppendFormat("lo_z_coord = {0}{1}", m_lo_z_coord, Environment.NewLine)
              .AppendFormat("hi_x_coord = {0}{1}", m_hi_x_coord, Environment.NewLine)
              .AppendFormat("hi_y_coord = {0}{1}", m_hi_y_coord, Environment.NewLine)
              .AppendFormat("hi_z_coord = {0}{1}", m_hi_z_coord, Environment.NewLine)
              .AppendFormat("curve_center_x_coord = {0}{1}", m_curve_center_x_coord, Environment.NewLine)
              .AppendFormat("curve_center_y_coord = {0}{1}", m_curve_center_y_coord, Environment.NewLine)
              .AppendFormat("curve_center_z_coord = {0}{1}", m_curve_center_z_coord, Environment.NewLine)
              .AppendFormat("circle_radius = {0}{1}", m_circle_radius, Environment.NewLine)
              .AppendFormat("secant_location = {0}{1}", m_secant_location, Environment.NewLine)
              .AppendFormat("beta_angle = {0}{1}", m_beta_angle, Environment.NewLine)
              .AppendFormat("alpha_angle = {0}{1}", m_alpha_angle, Environment.NewLine)
              .AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine)
              .AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine)
              .AppendFormat("vanity_lion_key = {0}{1}", m_vanity_lion_key.Display(), Environment.NewLine)
              .AppendFormat("vanity_sos = {0}{1}", m_vanity_sos, Environment.NewLine)
              .AppendFormat("split_lo_hns = {0}{1}", m_split_lo_hns, Environment.NewLine)
              .AppendFormat("traffic_dir = {0}{1}", m_traffic_dir, Environment.NewLine)
              .AppendFormat("turn_restrictions = {0}{1}", m_turn_restrictions, Environment.NewLine)
              .AppendFormat("gbicurv_fraction = {0}{1}", m_gbicurv_fraction, Environment.NewLine)
              .AppendFormat("roadway_type = {0}{1}", m_roadway_type, Environment.NewLine)
              .AppendFormat("physical_id = {0}{1}", m_physical_id, Environment.NewLine)
              .AppendFormat("generic_id = {0}{1}", m_generic_id, Environment.NewLine)
              .AppendFormat("nypd_id = {0}{1}", m_nypd_id, Environment.NewLine)
              .AppendFormat("fdny_id = {0}{1}", m_fdny_id, Environment.NewLine)
              .AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine)
              .AppendFormat("street_status = {0}{1}", m_street_status, Environment.NewLine)
              .AppendFormat("street_width = {0}{1}", m_street_width, Environment.NewLine)
              .AppendFormat("street_width_irregular = {0}{1}", m_street_width_irregular, Environment.NewLine)
              .AppendFormat("bike_lane = {0}{1}", m_bike_lane, Environment.NewLine)
              .AppendFormat("federal_classification_code = {0}{1}", m_federal_classification_code, Environment.NewLine)
              .AppendFormat("right_of_way_type = {0}{1}", m_right_of_way_type, Environment.NewLine);

            for (int i = 0; i <= 4; i++)
                sb.AppendFormat("additional_valid_lgcs({0}) = {1}{2}", i, m_additional_valid_lgcs[i], Environment.NewLine);

            return sb.ToString();
        }
        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine(); // Equivalent to vbCrLf
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F1w  ***********************************");
            sb.AppendLine("****************************************************************************");

            return sb.ToString();
        }

        // Property for wa2f1
        public Wa2F1 Wa2f1
        {
            get => m_wa2f1;
            set => m_wa2f1 = value;
        }

        // Property for valid_lgcs array
        [XmlArrayItem(ElementName = "lgc")]
        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        // Property for valid_lgcs item
        public string valid_lgcs_item(int index) => m_valid_lgcs[index];

        public void valid_lgcs_item(int index, string value){
            int strlen = value.Length;
            if (strlen > 2) strlen = 2;
            m_valid_lgcs[index] = value.Substring(0, strlen);
        }

        // Property for boe_lgc_pointer
        public string boe_lgc_pointer
        {
            get => m_boe_lgc_pointer;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_boe_lgc_pointer = value.Substring(0, strlen);
            }
        }

        // Property for segment_azm
        public string segment_azm
        {
            get => m_segment_azm;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_segment_azm = value.Substring(0, strlen);
            }
        }

        // Property for segment_orient
        public string segment_orient
        {
            get => m_segment_orient;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_segment_orient = value.Substring(0, strlen);
            }
        }

        // Property for lo_x_coord
        public string lo_x_coord
        {
            get => m_lo_x_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_lo_x_coord = value.Substring(0, strlen);
            }
        }

        // Property for lo_y_coord
        public string lo_y_coord
        {
            get => m_lo_y_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_lo_y_coord = value.Substring(0, strlen);
            }
        }

        // Property for lo_z_coord
        public string lo_z_coord
        {
            get => m_lo_z_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_lo_z_coord = value.Substring(0, strlen);
            }
        }
        // Property for hi_x_coord
        public string hi_x_coord
        {
            get => m_hi_x_coord;
            set => m_hi_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for hi_y_coord
        public string hi_y_coord
        {
            get => m_hi_y_coord;
            set => m_hi_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for hi_z_coord
        public string hi_z_coord
        {
            get => m_hi_z_coord;
            set => m_hi_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for curve_center_x_coord
        public string curve_center_x_coord
        {
            get => m_curve_center_x_coord;
            set => m_curve_center_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for curve_center_y_coord
        public string curve_center_y_coord
        {
            get => m_curve_center_y_coord;
            set => m_curve_center_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for curve_center_z_coord
        public string curve_center_z_coord
        {
            get => m_curve_center_z_coord;
            set => m_curve_center_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for circle_radius
        public string circle_radius
        {
            get => m_circle_radius;
            set => m_circle_radius = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for secant_location
        public string secant_location
        {
            get => m_secant_location;
            set => m_secant_location = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for beta_angle
        public string beta_angle
        {
            get => m_beta_angle;
            set => m_beta_angle = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        // Property for alpha_angle
        public string alpha_angle
        {
            get => m_alpha_angle;
            set => m_alpha_angle = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        // Property for from_node
        public string from_node
        {
            get => m_from_node;
            set => m_from_node = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for to_node
        public string to_node
        {
            get => m_to_node;
            set => m_to_node = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for vanity_lion_key
        public LionKey vanity_lion_key
        {
            get => m_vanity_lion_key;
            set => m_vanity_lion_key = value;
        }

        // Property for vanity_sos
        public string vanity_sos
        {
            get => m_vanity_sos;
            set => m_vanity_sos = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for split_lo_hns
        public string split_lo_hns
        {
            get => m_split_lo_hns;
            set => m_split_lo_hns = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        // Property for traffic_dir
        public string traffic_dir
        {
            get => m_traffic_dir;
            set => m_traffic_dir = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for turn_restrictions
        public string turn_restrictions
        {
            get => m_turn_restrictions;
            set => m_turn_restrictions = value.Length > 10 ? value.Substring(0, 10) : value;
        }

        // Property for gbicurv_fraction
        public string gbicurv_fraction
        {
            get => m_gbicurv_fraction;
            set => m_gbicurv_fraction = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // Property for roadway_type
        public string roadway_type
        {
            get => m_roadway_type;
            set => m_roadway_type = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for physical_id
        public string physical_id
        {
            get => m_physical_id;
            set => m_physical_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for generic_id
        public string generic_id
        {
            get => m_generic_id;
            set => m_generic_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for nypd_id
        public string nypd_id
        {
            get => m_nypd_id;
            set => m_nypd_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for fdny_id
        public string fdny_id
        {
            get => m_fdny_id;
            set => m_fdny_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for filler03 (blockface_id)
        public string filler03
        {
            get => m_filler03;
            set => m_filler03 = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for street_status
        public string street_status
        {
            get => m_street_status;
            set => m_street_status = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for street_width
        public string street_width
        {
            get => m_street_width;
            set => m_street_width = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // Property for street_width_irregular
        public string street_width_irregular
        {
            get => m_street_width_irregular;
            set => m_street_width_irregular = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for bike_lane
        public string bike_lane
        {
            get => m_bike_lane;
            set => m_bike_lane = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for federal_classification_code
        public string federal_classification_code
        {
            get => m_federal_classification_code;
            set => m_federal_classification_code = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for right_of_way_type
        public string right_of_way_type
        {
            get => m_right_of_way_type;
            set => m_right_of_way_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for additional_valid_lgcs (array)
        public string[] additional_valid_lgcs
        {
            get => m_additional_valid_lgcs;
            set => m_additional_valid_lgcs = value;
        }

        // Property for additional_valid_lgcs_item
        public string additional_valid_lgcs_item(int index) => m_additional_valid_lgcs[index];

        public void additional_valid_lgcs_item(int index, string value) => m_additional_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        


    }


}
