using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Models
{
    public enum IconType
    {
        Work,
        Developer,
        VideoGame,
        BoardGame
    }


    public static class IconTypeExtensions
    {
        public static string ToEmoji(this IconType iconType)
        {
            return iconType switch
            {
                IconType.Work => "💼",
                IconType.Developer => "🧑‍💻",
                IconType.VideoGame => "🎮",
                IconType.BoardGame => "🎲",
                _ => "📁"
            };
        }
    }

}
