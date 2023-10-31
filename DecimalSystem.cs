namespace Number_System
{
    /// <summary>
    /// Class that represent Decimal Numbers System
    /// </summary>
    public class DecimalSystem : Base
    {
        /// <summary>
        /// Initializes a New Instance Of The Class To The Value Indicated by Specified String Parameter
        /// </summary>
        /// <param name="value">
        /// String That Hold The Value of The Octal System Instance
        /// </param>
        public DecimalSystem(string value)
        {
            value.Gaurd("0123456789", NumberBase.DECIMAL);
            this.Value = value;

        }
    }

}
