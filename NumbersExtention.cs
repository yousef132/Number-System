using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_System
{
    
    public static class NumbersExtention
    {

        /// <summary>
        /// Check If The Given Value Match With The Given Number Base  
        /// </summary>
        /// <param name="value"></param>
        /// <param name="ValidChars"></param>
        /// <param name="NB">
        /// Instance of Enum
        /// </param>
        /// <exception cref="InvalidOperationException"></exception>

        public static void Gaurd(this string value , string ValidChars , NumberBase NB)
        {
            foreach(var ch in value)
            {
                if (!ValidChars.Contains(ch))
                {
                    throw new InvalidOperationException($"{value} is invalid {NB} Format");
                }
            }

        }
        /// <summary>
        /// Method That Convert Between The Current Number System and The Given Number System
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="NB"></param>
        /// <returns></returns>
        public static string To<T>(this T value  , NumberBase NB) where T:Base
        {
            NumberBase FromBase;
            switch (value)
            {
                case BinarySystem:FromBase=NumberBase.BINARY; break;
                case DecimalSystem:FromBase=NumberBase.DECIMAL; break;
                case HexaDecimalSystem:FromBase=NumberBase.HEXADECIMAL; break;
                case OctalSystem:FromBase=NumberBase.OCTAL; break;
                default:FromBase = NumberBase.DECIMAL; break;
            }
            return Convert.ToString(Convert.ToInt32(value.Value, (int)FromBase), (int)NB);
        }
    }
}
