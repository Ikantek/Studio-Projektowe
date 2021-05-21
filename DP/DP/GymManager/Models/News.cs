using System;
using System.Collections.Generic;

#nullable disable

namespace GymManager.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
    }
}
