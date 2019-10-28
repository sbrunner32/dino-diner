using System;
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
        /// Event Handler for property changes, notifies when an order property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The items that make up this order.
        /// </summary>
        public IOrderItem[] Items {
            get
            {
                return items.ToArray();
            }            
        }

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
                NotifyAllPropertiesChanged();        
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
            //items = new ObservableCollection<IOrderItem>();
            
            //Add(new Entrees.SteakosaurusBurger());
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Adds an item to the items list of this order
        /// </summary>
        /// <param name="item">IOrderItem to be added to the order</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Removes IOrderItem item from the list of items in the order.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }            
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Helper method to notify all properties have changed.
        /// </summary>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }
    }
}
