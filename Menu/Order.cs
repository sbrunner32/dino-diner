using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An order of various food and drink items
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The items that make up this order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Subtotal of the order's cost before Tax
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double temp = 0;
                foreach(IOrderItem item in Items)
                {
                    temp += item.Price;
                }
                if (temp > 0)
                    return temp;
                else
                    return 0;
            }
        }
        /// <summary>
        /// Gets the Sales tax rate of the order
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return 0;
            }
            protected set
            {
                
            }
        }
        /// <summary>
        /// Gets the cost of sales tax for this order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Gets the total cost of this order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
