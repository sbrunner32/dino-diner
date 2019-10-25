﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An order of various food and drink items
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Event Handler for property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The items that make up this order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; }

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
        /// Private backing variable to store SalesTaxRate, defaulted to 0.
        /// </summary>
        private double salesTaxRate = 0;
        /// <summary>
        /// Gets the Sales tax rate of the order
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            protected set
            {
                if (value > 0)
                    salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
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

        /// <summary>
        /// Public constructor for creating the order.
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
            Items.Add(new Entrees.SteakosaurusBurger());
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
