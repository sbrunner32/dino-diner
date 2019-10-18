﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for an item that is ordered.
    /// </summary>
    public interface IOrderItem
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
