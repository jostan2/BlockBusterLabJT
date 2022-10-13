using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLabJT
{
    public class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
        }

        public int index { get; set; }

        public override void Play()
        {
            PrintScenes(Scenes);
            Console.Write($"What scenes do you want to watch? Search by 1 to {Scenes.Count}: ");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Console.WriteLine(Scenes[index-1]);
        }
    }
}
