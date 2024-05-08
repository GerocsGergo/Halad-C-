using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillamosTest
{
    class Functions
    {
        public struct Profile
        {

            public int ID;
            public string Name;
            public int HighScore;

            public Profile(string line)
            {
                var oneLine = line.Split().ToArray();

                ID = int.Parse(oneLine[0]);
                Name = oneLine[1];
                HighScore = int.Parse(oneLine[2]);

            }

            public int GetID()
            {
                return this.ID;

            }

            public string GetName()
            {
                return Name;

            }


            public int GetHighScore()
            {
                return this.HighScore;

            }

        }

        public struct Settings
        {
            public string name;
            public string value;
            public Settings(string lines)
            {
                var oneLine = lines.Split().ToArray();
                name = oneLine[0];
                value = oneLine[1];
            }
            public string getName()
            {
                return this.name;
            }
            public void setName(string name)
            {
                this.name = name;
            }

            public string getValue()
            {
                return this.value;
            }

            public void setValue(string value)
            {
                this.value = value;
            }
        }


        //ScoreBoard menü függvényei

        //GameOver menü függvényei



        //MainMenu menü függvényei

        public static void CloseAllForms()
        {

            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }

        }

        //Settings menü függvényei

        public TextBox[] BadBoxes(TextBox Up, TextBox Down, TextBox Left, TextBox Right) {
            List<TextBox> textBoxes = new List<TextBox>();
            bool BadUp = BadBox(Up);
            bool BadDown = BadBox(Down); 
            bool BadLeft = BadBox(Left); 
            bool BadRight = BadBox(Right);
            if (BadUp == true)
            {
                textBoxes.Add(Up);
            }
            if (BadDown == true)
            {
                textBoxes.Add(Down);
            }
            if (BadLeft == true)
            {
                textBoxes.Add(Left);
            }
            if (BadRight == true)
            {
                textBoxes.Add(Right);
            }


            return textBoxes.ToArray();
        }

        public bool BadBox(TextBox Key) { 
            bool bad = true; //true ha nem jo és false ha jó
            string[] good = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                 "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z","Up","Down","Left","Right"};
            foreach (var letter in good)
            {
                if (Key.Text == letter)
                {
                    bad = false;
                }
            }

            return bad;
        }

        public void TableProfil(string FileName, DataGridView Profils)
        {
            var lines = File.ReadAllLines(FileName).Select(x => new Profile(x)).OrderByDescending(x => x.HighScore).ToArray();


            for (int i = 0; i < lines.Length; i++)
            {
                Profils.Rows.Add(lines[i].GetID(), lines[i].GetName(), lines[i].GetHighScore());
            }

        }


        public string TrackBarDifficulty(int value)
        {
            string text = "Impossible";


            if (value == 0)
            {
                text = "Easy";
            }
            else if (value == 1)
            {
                text = "Normal";
            }
            return text;
        }

        public int SetTrackBarDifficulty(string difficulty)
        {
            int value = 1;

            switch (difficulty)
            {
                case "Impossible":
                    value = 2;
                    break;
                case "Normal":
                    value = 1;
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }


    }
}
