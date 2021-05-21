using GymManager.Models;

namespace GymManager.Utilities
{
    public abstract class NewsInterface
    {
        public virtual int Id { get; set; }
        public virtual int Type { get; set; }
        public virtual string Header { get; set; }
        public virtual string Description { get; set; }

    }
}
