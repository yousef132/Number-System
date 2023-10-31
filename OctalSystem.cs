namespace Number_System
{
    /// <summary>
    /// Class that represent Octal Numbers System
    /// </summary>
    public class OctalSystem : Base
    {
        /// <summary>
        /// Initializes a New Instance Of The Class To The Value Indicated by Specified String Parameter
        /// </summary>
        /// <param name="value">
        /// String That Hold The Value of The Octal System Instance
        /// </param>
        public OctalSystem(string value)
        {
            value.Gaurd("01234567", NumberBase.OCTAL);
            this.Value = value;
        }
    }

}
