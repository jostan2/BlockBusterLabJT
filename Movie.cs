using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLabJT
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }

    public abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        public Genre Category { get; set; } 


        public Movie(string Title, Genre Category, int RunTime, List<String> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes.ToList();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine($"Run Time: {RunTime} minutes");
            Console.WriteLine("Category: " + Category);
        }

        public void PrintScenes(List<string> Scenes)
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i+1}: {Scenes[i]}");
            }

        }

        public abstract void Play();
    }
}
