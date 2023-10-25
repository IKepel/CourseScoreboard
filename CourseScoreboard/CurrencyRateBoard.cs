using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseScoreboard
{
    /// <summary>
    /// Represents a currency rate board that keeps track of buy and sell rates for a specific currency.
    /// </summary>
    /// <typeparam name="T">The type representing the currency (e.g., string for currency code).</typeparam>
    public class CurrencyRateBoard<T>
    {
        private readonly List<RateChangeHistory> _rateChangeHistories = new();

        /// <summary>
        /// Gets or sets the currency for which the rates are being tracked.
        /// </summary>
        public T Currency { get; set; }

        /// <summary>
        /// Gets or sets the current buy rate for the currency.
        /// </summary>
        public double BuyRate { get; set; }

        /// <summary>
        /// Gets or sets the current sell rate for the currency.
        /// </summary>
        public double SellRate { get; set; }

        /// <summary>
        /// Initializes a new instance of the CurrencyRateBoard class with the specified currency, buy rate, and sell rate.
        /// </summary>
        /// <param name="currency">The currency for which rates are being tracked.</param>
        /// <param name="buyRate">The initial buy rate for the currency.</param>
        /// <param name="sellRate">The initial sell rate for the currency.</param>
        public CurrencyRateBoard(T currency, double buyRate, double sellRate) 
        {
            Currency = currency;
            BuyRate = buyRate;
            SellRate = sellRate;
            _rateChangeHistories.Add(new RateChangeHistory(buyRate, sellRate));
        }

        /// <summary>
        /// Changes the buy and sell rates for the currency and records the rate change in the history.
        /// </summary>
        /// <param name="newBuyRate">The new buy rate for the currency.</param>
        /// <param name="newSellRate">The new sell rate for the currency.</param>
        public void ChangeRate(double newBuyRate, double newSellRate)
        {
            BuyRate = newBuyRate;
            SellRate = newSellRate;
            _rateChangeHistories.Add(new RateChangeHistory(newBuyRate, newSellRate));
            Console.WriteLine($"New rate {Currency}: Buy rate - {BuyRate}, Sell rate - {SellRate}");
        }

        /// <summary>
        /// Prints the rate change history for the currency.
        /// </summary>
        public void PrintHistory()
        {
            Console.WriteLine($"History of the price {Currency}:");
            foreach (var historyItem in _rateChangeHistories)
            {
                Console.WriteLine($"Buy rate - {historyItem.BuyRate}, Sell rate - {historyItem.SellRate}");
            }
        }

        /// <summary>
        /// Overrides the default ToString method to provide a custom string representation of the object.
        /// </summary>
        /// <returns>A string representation of the RateChangeHistory object.</returns>
        public override string ToString()
        {
            return $"Currency: {Currency}, Buy rate: {BuyRate}, Sell rate: {SellRate}";
        }
    }
}