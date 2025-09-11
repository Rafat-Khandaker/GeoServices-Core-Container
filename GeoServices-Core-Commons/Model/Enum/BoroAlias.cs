using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Model.Enum
{
    public readonly struct BoroAlias
    {
        public string Name { get; }
        public string Abbreviation { get; }
        public string Code { get; }

        public BoroAlias(string name, string abbreviation, string code)
        {
            Name = name;
            Abbreviation = abbreviation;
            Code = code;
        }

        /// <summary>
        /// Match an input borough string against its accepted name, abbreviation, or code, using insensitive case and sort rules
        /// </summary>
        /// <param name="inBoro">Input borough related string</param>
        /// <returns>True if matches against any acceptable field for the BoroAlias, false otherwise</returns>
        public bool MatchAny(string inBoro) => string.Equals(inBoro, Name, StringComparison.OrdinalIgnoreCase) || string.Equals(inBoro, Abbreviation, StringComparison.OrdinalIgnoreCase) || string.Equals(inBoro, Code, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Match an input borough name against its accepted name, using insensitive case and sort rules
        /// </summary>
        /// <param name="inName">Input borough code string</param>
        /// <returns>True if matches against the acceptable name for the BoroAlias, false otherwise</returns>
        public bool MatchName(string inName) => string.Equals(inName, Name, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Match an input borough name against its accepted name, using insensitive case and sort rules
        /// </summary>
        /// <param name="inAbbrev">Input borough code string</param>
        /// <returns>True if matches against the acceptable name for the BoroAlias, false otherwise</returns>
        public bool MatchAbbrev(string inAbbrev) => string.Equals(inAbbrev, Abbreviation, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Match a borough code against its accepted code, using insensitive case and sort rules
        /// </summary>
        /// <param name="inCode">Input borough code string</param>
        /// <returns>True if matches against the acceptable code for the BoroAlias, false otherwise</returns>
        public bool MatchCode(string inCode) => string.Equals(inCode, Code, StringComparison.OrdinalIgnoreCase);
    }
}
