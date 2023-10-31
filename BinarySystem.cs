namespace Number_System
{
    /// <summary>
    /// Class that represent Binary Numbers System
    /// </summary>
    public class BinarySystem : Base
    {
        /// <summary>
        /// Initializes a New Instance Of The Class To The Value Indicated by Specified String Parameter
        /// </summary>
        /// <param name="value">
        /// String That Hold The Value of The Octal System Instance
        /// </param>
        public BinarySystem(string value)
        {
            value.Gaurd("01", NumberBase.BINARY);
            this.Value = value;
            
        }
    }

}
