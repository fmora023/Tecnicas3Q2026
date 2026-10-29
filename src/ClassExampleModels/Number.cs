namespace ClassExampleModels
{
    /// <summary>
    /// Class to define the number structure.
    /// </summary>
    public class Number
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Number"/> class.
        /// </summary>
        /// <param name="number">The number.</param>
        public Number(string number)
        {
            this.Code = 0;
            this.NumberData = 0;
        }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        /// <value>
        /// The region code.
        /// </value>
        public int Code { get; set; } = 0;

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int NumberData { get; set; } = 0;

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if (this.Code == 0)
            {
                return this.NumberData.ToString();
            }
            return $"+{this.Code} {this.NumberData}";
        }
    }
}
