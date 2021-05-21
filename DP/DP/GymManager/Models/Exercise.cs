using System;
using System.Collections.Generic;

#nullable disable

namespace GymManager.Models
{
    public partial class Exercise
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? ExcerciseName { get; set; }
        public int? Result { get; set; }
    }
}
