using System;
using System.Collections.Generic;
using System.Text;
using Portfolio.Models;

namespace Portfolio.Data
{
    public static class ExperienceRepository
    {
        public static List<Experience> GetExperiences()
        {
            return new List<Experience>
        {
            new Experience
            {
                IconType = IconType.Work,
                Company = "LundiMatin",
                Role = "Développeur ASP / PHP / API",
                Period = "Octobre 2024 – Juillet 2025",
                Technologies = new()
                {
                    "ASP",
                    "PHP",
                    "NestJS",
                    "SQL Server",
                    "API REST"
                },
                Missions = new()
                {
                    "Maintenance de l’ERP Oxatis",
                    "Correction de bugs applicatifs",
                    "Participation à une migration vers une nouvelle architecture",
                    "Création d’API PHP / NestJS",
                    "Intégration avec une application legacy"
                }
            },

            new Experience
            {
                IconType = IconType.Work,
                Company = "MonChasseurImmo",
                Role = "Développeur .NET",
                Period = "Août 2023 – Décembre 2023",
                Technologies = new()
                {
                    "C#",
                    ".NET",
                    "SQL"
                },
                Missions = new()
                {
                    "Développement d’applications .NET",
                    "Participation aux évolutions fonctionnelles",
                    "Maintenance et amélioration du code existant"
                }
            },

            new Experience
            {
                IconType = IconType.Work,
                Company = "Smag",
                Role = "Développeur .NET",
                Period = "Novembre 2022 – Avril 2023",
                Technologies = new()
                {
                    "C#",
                    ".NET",
                    "SQL"
                },
                Missions = new()
                {
                    "Développement backend .NET",
                    "Maintenance applicative",
                    "Correction de bugs"
                }
            },

            new Experience
            {
                IconType = IconType.Work,
                Company = "Acelys",
                Role = "Développeur .NET",
                Period = "Juillet 2021 – Novembre 2022",
                Technologies = new()
                {
                    "C#",
                    ".NET",
                    "SQL",
                    "Agile"
                },
                Missions = new()
                {
                    "Développement logiciel",
                    "Participation à des projets en équipe Agile",
                    "Maintenance et évolution des applications"
                }
            },

            new Experience
            {
                IconType = IconType.Developer,
                Company = "Projets personnels",
                Role = "Autoformation",
                Period = "2023 – 2024",
                Technologies = new()
                {
                    "C#",
                    ".NET",
                    "Angular",
                    "Java"
                },
                Missions = new()
                {
                    "Développement de projets personnels en C# .NET",
                    "Apprentissage Angular",
                    "Initiation au langage Java",
                    "Approfondissement des concepts de programmation"
                }
            }
        };
        }
    }
}
