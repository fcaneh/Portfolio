using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Models
{
    public class Experience
    {
        public string Icon { get; set; } = "💼";
        public string Company { get; set; } = "";
        public string Role { get; set; } = "";
        public string Period { get; set; } = "";

        public List<string> Technologies { get; set; } = new();
        public List<string> Missions { get; set; } = new();
    }
}
