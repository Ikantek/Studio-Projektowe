using GymManager.Models;

namespace GymManager.Utilities
{
    public class AdvertisingNews : NewsInterface
    {
        private int _Id;
        private int _Type;
        private string _Header;
        private string _Description;

        public AdvertisingNews(int Id, int Type, string Header, string Description)
        {
            _Id = Id;
            _Type = Type;
            _Header = Header;
            _Description = Description;
        }
        override public int Id
        {
            get { return _Id; }
        }
        override public string Header
        {
            get { return _Header; }
        }
        override public int Type
        {
            get { return _Type; }
        }
        override public string Description
        {
            get { return _Description; }
        }
    }

}
