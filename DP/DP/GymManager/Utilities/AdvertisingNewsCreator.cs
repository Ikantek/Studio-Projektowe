using GymManager.Models;

namespace GymManager.Utilities
{
    public class AdvertisingNewsCreator : NewsCreator
    {
        private int _Id;
        private int _Type;
        private string _Header;
        private string _Description;

        public AdvertisingNewsCreator(int Id, int Type, string Header, string Description)
        {
            _Id = Id;
            _Type = Type;
            _Header = Header;
            _Description = Description;
        }

        public override NewsInterface GetNews()
        {
            return new AdvertisingNews(_Id, _Type, _Header, _Description);
        }
    }
}

