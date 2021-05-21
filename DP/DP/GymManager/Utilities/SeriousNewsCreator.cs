using GymManager.Models;

namespace GymManager.Utilities
{
    public class SeriousNewsCreator : NewsCreator
    {

        private int _Id;
        private int _Type;
        private string _Header;
        private string _Description;

        public SeriousNewsCreator(int Id, int Type, string Header, string Description)
        {
            _Id = Id;
            _Type = Type;
            _Header = Header.ToUpper();
            _Description = Description;
        }

        public override NewsInterface GetNews()
        {
            return new SeriousNews(_Id, _Type, _Header, _Description);
        }
    }
}
