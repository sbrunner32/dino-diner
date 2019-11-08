/* IOrderItem Interface
 * Author: Sam Brunner
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for an item that is ordered.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {


        /// <summary>
        /// The price of the order item in dollars.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Contains a text description of the order item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Array containing any special requests/instructions for the order item
        /// </summary>
        string[] Special { get; }

    }
}
