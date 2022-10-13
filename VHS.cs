using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLabJT
{
    public class VHS : Movie
    {
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
        }

        public int CurrentScene { get; set; } = 0;

        public override void Play()
        {
            if (CurrentScene < Scenes.Count)
            {
                for (int i = 0; i < Scenes.Count; i++)
                {
                    string sceneVHS = Scenes[CurrentScene];
                    CurrentScene++;
                    Console.WriteLine(sceneVHS);
                }
            }
            else
            {
                Rewind();
            }   
        }

        public int Rewind()
        {
            CurrentScene = 0;
            return CurrentScene;
        }
    }
}
