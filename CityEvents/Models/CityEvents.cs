using System;
using DynamicData.Binding;

namespace CityEvents.Models
{
    public class CityEvent : AbstractNotifyPropertyChanged
    {
        private string _header = string.Empty;
        private string _description = string.Empty;
        private string _image = string.Empty;
        private string _date = string.Empty;
        private EventCategory _category = null!;
        private decimal _price = Decimal.Zero;
        private ushort _maxPrintLength = 135;

        public string Header
        {
            get => _header;
            set => SetAndRaise(ref _header, value);
        }

        public string Description
        {
            get
            {
                if (_description.Length > _maxPrintLength)
                    return _description.Substring(0, _maxPrintLength) + "...";

                return _description;
            }
            set => SetAndRaise(ref _description, value);
        }

        public string Image
        {
            get => _image;
            set => SetAndRaise(ref _image, value);
        }

        public string Date
        {
            get => _date;
            set => SetAndRaise(ref _date, value);
        }

        public EventCategory Category
        {
            get => _category;
            set => SetAndRaise(ref _category, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetAndRaise(ref _price, value);
        }
    }
}
