using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AmaZon
{
    public class ItemModel : INotifyPropertyChanged
    {
        private decimal quantity;
        private decimal totalPrice;

        public decimal Stock { get; set; }
        public string Image {  get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }

        public decimal Quantity
        {
            get => quantity;
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged(nameof(Quantity)); // error handeling for "Quantity"
                    TotalPrice = Price * quantity;
                }
            }
        }

        public decimal TotalPrice
        {
            get => totalPrice;
            set
            {
                if (totalPrice != value)
                {
                    totalPrice = value;
                    OnPropertyChanged(nameof(TotalPrice)); // error handeling for "TotalPrice"
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
