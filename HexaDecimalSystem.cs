namespace Number_System
{
    /// <summary>
    /// Class that represent  HexaDecimal Numbers System
    /// </summary>
    public class HexaDecimalSystem : Base
    {
        /// <summary>
        /// Initializes a New Instance Of The Class To The Value Indicated by Specified String Parameter
        /// </summary>
        /// <param name="value">
        /// String That Hold The Value of The Octal System Instance
        /// </param>
        public HexaDecimalSystem(string value)
        {
            value.Gaurd("0123456789abcdefABCDEF", NumberBase.HEXADECIMAL);
            this.Value = value;
        }
    }

}
