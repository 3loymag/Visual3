namespace CityEvents.Models
{
    public class EventCategory
    {
        private bool[] _categories = new bool[9];

        public bool Kid
        {
            get => _categories[0];
            set => _categories[0] = value;
        }

        public bool Sport
        {
            get => _categories[1];
            set => _categories[1] = value;
        }

        public bool Culture
        {
            get => _categories[2];
            set => _categories[2] = value;
        }

        public bool Excursions
        {
            get => _categories[3];
            set => _categories[3] = value;
        }

        public bool Lifestyle
        {
            get => _categories[4];
            set => _categories[4] = value;
        }

        public bool Party
        {
            get => _categories[5];
            set => _categories[5] = value;
        }

        public bool Education
        {
            get => _categories[6];
            set => _categories[6] = value;
        }

        public bool Online
        {
            get => _categories[7];
            set => _categories[7] = value;
        }

        public bool Show
        {
            get => _categories[8];
            set => _categories[8] = value;
        }

        public bool[] Categories
        {
            get => _categories;
            set => _categories = value;
        }
    }
}
