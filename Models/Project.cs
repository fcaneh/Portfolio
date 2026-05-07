using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Models
{
    public class Project
    {
        public IconType IconType { get; set; } = IconType.VideoGame;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Period { get; set; } = "";
        public List<string> Technologies { get; set; } = new();
        public List<string> Features { get; set; } = new();
        public string GithubLink { get; set; } = "";
        public string DownloadLink { get; set; } = "";
    }
}
