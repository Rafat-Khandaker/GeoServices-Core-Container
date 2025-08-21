using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class FHRDisplay
    {
        private readonly Wa1 _wa1;
        private readonly Wa2Fhr _wa2fhr;

        public FHRDisplay(Wa1 wa1, Wa2Fhr wa2fhr)
        {
            _wa1 = wa1;
            _wa2fhr = wa2fhr;
        }

        public Dictionary<string, string> fileInfo
        {
            get
            {
                Dictionary<string, string> fileInfoDict = new Dictionary<string, string>();
                foreach (GeoXWrapperLib.Model.FileInfo file in _wa2fhr.file_info_array)
                {
                    string tag = file.file_tag.Trim();

                    fileInfoDict.Add($"{tag}_file_tag", tag);
                    fileInfoDict.Add($"{tag}_file_release", file.release.Trim());
                    fileInfoDict.Add($"{tag}_file_date", file.file_date.Trim());
                }

                return fileInfoDict;
            }
        }

        public string in_func_code => _wa1.in_func_code;
        public string out_error_message => _wa1.out_error_message;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_grc => _wa1.out_grc;
        public string out_geosupport_version => _wa2fhr.geo_file_info.release.Insert(2, ".").TrimStart('0');

        public string out_thin_tag => _wa2fhr.thin_file_tag.Trim();
        public string out_thin_release => _wa2fhr.thin_release.Trim();
        public string out_thin_date => _wa2fhr.thin_date.Trim();

        public string out_grid1r_tag => _wa2fhr.grid1r_file_info.file_tag.Trim();
        public string out_grid1r_release => _wa2fhr.grid1r_file_info.release.Trim();
        public string out_grid1r_date => _wa2fhr.grid1r_file_info.file_date.Trim();

        public string out_auxseg_tag => _wa2fhr.auxseg_file_info.file_tag.Trim();
        public string out_auxseg_release => _wa2fhr.auxseg_file_info.release.Trim();
        public string out_auxseg_date => _wa2fhr.auxseg_file_info.file_date.Trim();

        public string out_apequiv_tag => _wa2fhr.apequiv_file_info.file_tag.Trim();
        public string out_apequiv_release => _wa2fhr.apequiv_file_info.release.Trim();
        public string out_apequiv_date => _wa2fhr.apequiv_file_info.file_date.Trim();

        public string out_tpad_tag => _wa2fhr.tpad_file_info.file_tag.Trim();
        public string out_tpad_release => _wa2fhr.tpad_file_info.release.Trim();
        public string out_tpad_date => _wa2fhr.tpad_file_info.file_date.Trim();

        public string out_upad_tag => _wa2fhr.upad_file_info.file_tag.Trim();
        public string out_upad_release => _wa2fhr.upad_file_info.release.Trim();
        public string out_upad_date => _wa2fhr.upad_file_info.file_date.Trim();

        public string out_geo_tag => _wa2fhr.geo_file_info.file_tag.Trim();
        public string out_geo_release => _wa2fhr.geo_file_info.release.Trim();
        public string out_geo_date => _wa2fhr.geo_file_info.file_date.Trim();

        public string out_sneq_file_tag => _wa2fhr.sneq_file_info.file_tag.Trim();
        public string out_sneq_file_release => _wa2fhr.sneq_file_info.release.Trim();
        public string out_sneq_file_date => _wa2fhr.sneq_file_info.file_date.Trim();

        public string out_ap_file_tag => _wa2fhr.ap_file_info.file_tag.Trim();
        public string out_ap_file_release => _wa2fhr.ap_file_info.release.Trim();
        public string out_ap_file_date => _wa2fhr.ap_file_info.file_date.Trim();

        #region file_info_array Specifc Fields
        public string out_EDEQ_file_release => ReadInfo("EDEQ")?.release.Trim();
        public string out_EDEQ_file_date => ReadInfo("EDEQ")?.file_date.Trim();

        public string out_GRD1_file_release => ReadInfo("GRD1")?.release.Trim();
        public string out_GRD1_file_date => ReadInfo("GRD1")?.file_date.Trim();

        public string out_GRD2_file_release => ReadInfo("GRD2")?.release.Trim();
        public string out_GRD2_file_date => ReadInfo("GRD2")?.file_date.Trim();

        public string out_GRD3_file_release => ReadInfo("GRD3")?.release.Trim();
        public string out_GRD3_file_date => ReadInfo("GRD3")?.file_date.Trim();

        public string out_PAD_file_release => ReadInfo("PAD")?.release.Trim();
        public string out_PAD_file_date => ReadInfo("PAD")?.file_date.Trim();

        public string out_SAN_file_release => ReadInfo("SAN")?.release.Trim();
        public string out_SAN_file_date => ReadInfo("SAN")?.file_date.Trim();

        public string out_SND_file_release => ReadInfo("SND")?.release.Trim();
        public string out_SND_file_date => ReadInfo("SND")?.file_date.Trim();

        /// <summary>
        /// Search for a specific record in wa2's file_info_array
        /// </summary>
        /// <param name="tag">File tag to query, as string</param>
        /// <returns>FileInfo object with the tag inputted, defaults to null if not found</returns>
        private GeoXWrapperLib.Model.FileInfo ReadInfo(string tag) => string.IsNullOrWhiteSpace(tag)
            ? null
            : Array.Find(_wa2fhr.file_info_array, info => info.file_tag.Contains(tag));
        #endregion
    }
}