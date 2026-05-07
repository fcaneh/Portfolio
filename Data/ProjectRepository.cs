using Portfolio.Models;

namespace Portfolio.Data;

public static class ProjectRepository
{
    public static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                IconType = IconType.VideoGame,
                Name = "Morpion – Godot C#",
                Period = "Avril 2026",
                Description = "Jeu du morpion développé en C# avec Godot, avec deux niveaux d’IA dont un algorithme Minimax.",
                Technologies = new()
                {
                    "C#",
                    "Godot",
                    "IA",
                    "Minimax"
                },
                Features = new()
                {
                    "IA heuristique",
                    "IA Minimax imbattable",
                    "Menu de sélection",
                    "Export Windows"
                },
                GithubLink = "https://github.com/fcaneh-jeux/morpion",
                DownloadLink = "https://github.com/fcaneh-jeux/morpion/releases/download/v1.0.0/morpion_v1.zip"
            },

            new Project
            {
                IconType = IconType.Developer,
                Name = "Portfolio personnel",
                Period = "Avril 2026",
                Description = "Portfolio développé avec Blazor pour présenter mon parcours, mes expériences et mes projets.",
                Technologies = new()
                {
                    "C#",
                    ".NET",
                    "Blazor",
                    "CSS"
                },
                Features = new()
                {
                    "Pages dynamiques",
                    "Composants Razor",
                    "Modèles C#",
                    "Design responsive"
                },
                GithubLink = "https://github.com/fcaneh/Portfolio",
                DownloadLink = ""
            }
        };
    }
}