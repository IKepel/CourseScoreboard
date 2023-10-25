using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseScoreboard
{
    /// <summary>
    /// Represents the history of buy and sell rate changes for a currency.
    /// </summary>
    public class RateChangeHistory
    {
        /// <summary>
        /// Gets or sets the buy rate at the time of the rate change.
        /// </summary>
        public double BuyRate { get; set; }

        /// <summary>
        /// Gets or sets the sell rate at the time of the rate change.
        /// </summary>
        public double SellRate { get; set; }

        /// <summary>
        /// Initializes a new instance of the RateChangeHistory class with the specified buy rate and sell rate.
        /// </summary>
        /// <param name="buyRate">The buy rate at the time of the rate change.</param>
        /// <param name="sellRate">The sell rate at the time of the rate change.</param>
        public RateChangeHistory(double buyRate, double sellRate)
        {
            BuyRate = buyRate;
            SellRate = sellRate;
        }
    }
}