using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillamosTest
{
    class VillamosFunctions
    {

        public struct Villamos
        {
            private int x;
            private int y;

            public Villamos(int x, int y)
            {

                this.x = x + 5;
                this.y = y - 5;

            }
            public int GetX()
            {
                return this.x;
            }

            public void SetX(int x)
            {
                this.x = x;
            }

            public int GetY()
            {
                return this.y;
            }

            public void SetY(int y)
            {
                this.y = y;
            }
        }

        public Villamos OneVillamos = new Villamos(10, 530);
        public List<Villamos> Villamosparts = new List<Villamos>();
        Random rnd = new Random();

        public int SetSpeed(string difficulty)
        {
         
            int speed = 1;
            switch (difficulty)
            {
                case "Normal":
                    speed = 2;
                    break;
                case "Impossible":
                    speed = 3;
                    break;
                case "Easy":
                    speed = 1;
                    break;
                default:
                    speed = 1;
                    break;
            }
            return speed;
        }


        public void SetXY(Villamos OneVillamos, PictureBox pictureBox_Head)
        {
            pictureBox_Head.Location = new Point(OneVillamos.GetX(), OneVillamos.GetY());
        }


        public void VillamosMovement(PictureBox pictureBox_Head, string lastMovementDirection, int speed,Dictionary<string, string> settingDic)
        {
            int moveSize = 20 * speed;

            if (lastMovementDirection.Equals(settingDic["right"]))//D
            {
                pictureBox_Head.Left += moveSize;
            }
            else if (lastMovementDirection == settingDic["left"])//A
            {
                pictureBox_Head.Left -= moveSize;
            }
            else if (lastMovementDirection == settingDic["up"]) //W
            {
                pictureBox_Head.Top -= moveSize;
            }
            else if (lastMovementDirection == settingDic["down"]) //S
            {
                pictureBox_Head.Top += moveSize;
            }

            //if (lastMovementDirection == "d")
            //{
            //    pictureBox_Head.Left += moveSize;
            //}
            //else if (lastMovementDirection == "a")
            //{
            //    pictureBox_Head.Left -= moveSize;
            //}
            //else if (lastMovementDirection == "w") 
            //{
            //    pictureBox_Head.Top -= moveSize;
            //}
            //else if (lastMovementDirection == "s")
            //{
            //    pictureBox_Head.Top += moveSize;
            //}

        }

        public int VillamosKeys(PictureBox pictureBox_Boulder, PictureBox pictureBox_Fuel, PictureBox pictureBox_Farmer, PictureBox pictureBox_Head, PictureBox pictureBox_TopWall, PictureBox pictureBox_DownWall, PictureBox pictureBox_LeftWall, PictureBox pictureBox_RightWall, PictureBox pictureBox_People)
        {
            bool crashedTop;
            bool crashedDown;
            bool crashedRight;
            bool crashedLeft;
            bool pickedUpPeople;
            bool pickedUpFuel;
            bool crashedIntoFarmer;
            bool crashedIntoBoulder;
            int happened = 0;
            //0 ha nem történt semmi, 1 ha ütközött, 2 ha felvett utast, 3 ha farmerrel ütközött, 4 ha felvett benzint

            crashedTop = VillamosCrash(pictureBox_Head, pictureBox_TopWall);
            crashedDown = VillamosCrash(pictureBox_Head, pictureBox_DownWall);
            crashedRight = VillamosCrash(pictureBox_Head, pictureBox_RightWall);
            crashedLeft = VillamosCrash(pictureBox_Head, pictureBox_LeftWall);
            pickedUpPeople = VillamosCrash(pictureBox_Head, pictureBox_People);
            crashedIntoFarmer = VillamosCrash(pictureBox_Head, pictureBox_Farmer);
            pickedUpFuel = VillamosCrash(pictureBox_Head, pictureBox_Fuel);
            crashedIntoBoulder = VillamosCrash(pictureBox_Head, pictureBox_Boulder);

            if (crashedTop || crashedDown || crashedLeft || crashedRight || crashedIntoBoulder)
            {
                happened = 1;
            }
            else if (pickedUpPeople)
            {
                happened = 2;
            }
            else if (crashedIntoFarmer)
            {
                happened = 3;
            }
            else if (pickedUpFuel)
            {
                happened = 4;
            }

            return happened;
        }


        public void VillamosRotate(bool rotateRight, bool rotateLeft, bool rotateUp, bool rotateDown, PictureBox pictureBox_Head, PaintEventArgs e)
        {

            if (rotateRight)
            {
                e.Graphics.TranslateTransform(pictureBox_Head.Width / 2, pictureBox_Head.Height / 2);
                e.Graphics.RotateTransform(90);
                e.Graphics.TranslateTransform(-pictureBox_Head.Width / 2, -pictureBox_Head.Height / 2);
                e.Graphics.DrawImage(pictureBox_Head.Image, new Point(0, 0));
            }
            else if (rotateLeft)
            {
                e.Graphics.TranslateTransform(pictureBox_Head.Width / 2, pictureBox_Head.Height / 2);
                e.Graphics.RotateTransform(-90);
                e.Graphics.TranslateTransform(-pictureBox_Head.Width / 2, -pictureBox_Head.Height / 2);
                e.Graphics.DrawImage(pictureBox_Head.Image, new Point(0, 0));
            }
            else if (rotateUp)
            {
                e.Graphics.TranslateTransform(pictureBox_Head.Width / 2, pictureBox_Head.Height / 2);
                e.Graphics.RotateTransform(0);
                e.Graphics.TranslateTransform(-pictureBox_Head.Width / 2, -pictureBox_Head.Height / 2);
                e.Graphics.DrawImage(pictureBox_Head.Image, new Point(0, 0));
            }
            else if (rotateDown)
            {
                e.Graphics.TranslateTransform(pictureBox_Head.Width / 2, pictureBox_Head.Height / 2);
                e.Graphics.RotateTransform(180);
                e.Graphics.TranslateTransform(-pictureBox_Head.Width / 2, -pictureBox_Head.Height / 2);
                e.Graphics.DrawImage(pictureBox_Head.Image, new Point(0, 0));
            }


        }

        public bool VillamosCrash(PictureBox villamos, PictureBox border)
        {
            bool crashedboi = false;
            try
            {
                if (villamos.Right >= border.Left
                && villamos.Left <= border.Right
                && villamos.Bottom >= border.Top
                && villamos.Top <= border.Bottom)
                {
                    crashedboi = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("asd" + e.Message);

            }
            return crashedboi;
        }


        public PictureBox ScoreGenerator(Panel panel_map, PictureBox pictureBox_Head)
        {
            int fromBorder = 40;
            PictureBox pictureBox_Score = new PictureBox();
            Rectangle score;

            if (rnd.Next(0, 100) < 75)
            {
                pictureBox_Score.Image = Image.FromFile("Wheat.png");
                pictureBox_Score.Tag = "Wheat";
            }
            else
            {
                pictureBox_Score.Image = Image.FromFile("Corn.png");
                pictureBox_Score.Tag = "Corn";
            }
            pictureBox_Score.Size = new Size(60, 60);
            pictureBox_Score.Location = new Point(rnd.Next(fromBorder, panel_map.Width - pictureBox_Score.Width - fromBorder),
                                                   rnd.Next(fromBorder, panel_map.Height - pictureBox_Score.Height - fromBorder));
            //ne kerüljön oda ahol a player van 
            score = Overlaps(panel_map, pictureBox_Score, pictureBox_Head);
            pictureBox_Score.Location = score.Location;

            return pictureBox_Score;
        }

        public PictureBox ScoreGeneratorFirst(Panel panel_map)
        {

            int fromBorder = 40;
            PictureBox pictureBox_Score = new PictureBox();

            if (rnd.Next(0, 100) < 75)
            {
                pictureBox_Score.Image = Image.FromFile("Wheat.png");
                pictureBox_Score.Tag = "Wheat";
            }
            else
            {
                pictureBox_Score.Image = Image.FromFile("Corn.png");
                pictureBox_Score.Tag = "Corn";
            }
            pictureBox_Score.Size = new Size(60, 60);
            pictureBox_Score.Location = new Point(rnd.Next(fromBorder, panel_map.Width - pictureBox_Score.Width - fromBorder),
                                                   rnd.Next(fromBorder, panel_map.Height - pictureBox_Score.Height - fromBorder));

            return pictureBox_Score;
        }

        public PictureBox FarmerGenerator(Panel panel_map, PictureBox pictureBox_Score, PictureBox pictureBox_Head)
        {
            int fromBorder = 40;
            PictureBox pictureBox_Farmer = new PictureBox();
            Rectangle farmer;

            pictureBox_Farmer.Image = Image.FromFile("Farmer.png");
            pictureBox_Farmer.Tag = "Farmer";

            pictureBox_Farmer.Size = new Size(60, 60);
            pictureBox_Farmer.Location = new Point(rnd.Next(fromBorder, panel_map.Width - pictureBox_Farmer.Width - fromBorder),
                                        rnd.Next(fromBorder, panel_map.Height - pictureBox_Farmer.Height - fromBorder));

            // farmer ne kerüljön oda ahol score van


            farmer = Overlaps(panel_map, pictureBox_Farmer, pictureBox_Score);
            pictureBox_Farmer.Location = farmer.Location;

            // farmer ne kerüljön oda ahol player van

            farmer = Overlaps(panel_map, pictureBox_Farmer, pictureBox_Head);
            pictureBox_Farmer.Location = farmer.Location;


            return pictureBox_Farmer;
        }

        public Rectangle Overlaps(Panel panel_map, PictureBox what, PictureBox withWhat)
        {
            bool overlap = false;
            int fromBorder = 40;
            Rectangle mit = new Rectangle(what.Location, what.Size);
            Rectangle ezzel = new Rectangle(withWhat.Location, withWhat.Size);

            if (mit.IntersectsWith(ezzel))
            {
                overlap = true;
            }
            while (overlap)
            {
                mit.Location = new Point(rnd.Next(fromBorder, panel_map.Width - what.Width - fromBorder),
                                               rnd.Next(fromBorder, panel_map.Height - what.Height - fromBorder));
                if (!mit.IntersectsWith(ezzel))
                {
                    overlap = false;
                }
            }
            return mit;
        }

        public PictureBox FuelGenerator(Panel panel_map, PictureBox pictureBox_Score, PictureBox pictureBox_Head, PictureBox pictureBox_Farmer)
        {
            int fromBorder = 40;
            PictureBox pictureBox_Fuel = new PictureBox();
            Rectangle fuel;

            pictureBox_Fuel.Image = Image.FromFile("Fuel.png");
            pictureBox_Fuel.Tag = "Fuel";

            pictureBox_Fuel.Size = new Size(60, 60);
            pictureBox_Fuel.Location = new Point(rnd.Next(fromBorder, panel_map.Width - pictureBox_Fuel.Width - fromBorder),
                                        rnd.Next(fromBorder, panel_map.Height - pictureBox_Fuel.Height - fromBorder));

            // fuel ne kerüljön oda ahol score van


            fuel = Overlaps(panel_map, pictureBox_Fuel, pictureBox_Score);
            pictureBox_Fuel.Location = fuel.Location;

            // fuel ne kerüljön oda ahol player van

            fuel = Overlaps(panel_map, pictureBox_Fuel, pictureBox_Head);
            pictureBox_Fuel.Location = fuel.Location;

            // fuel ne kerüljön oda ahol farmer van

            fuel = Overlaps(panel_map, pictureBox_Fuel, pictureBox_Farmer);
            pictureBox_Fuel.Location = fuel.Location;


            return pictureBox_Fuel;
        }


        public PictureBox BoulderGenerator(Panel panel_map, PictureBox pictureBox_Score, PictureBox pictureBox_Head, PictureBox pictureBox_Farmer, PictureBox pictureBox_Fuel)
        {
            int fromBorder = 40;
            PictureBox pictureBox_Boulder = new PictureBox();
            Rectangle boulder;

            if (rnd.Next(0, 100) < 55)
            {
                pictureBox_Boulder.Image = Image.FromFile("Boulder.png");
                pictureBox_Boulder.Tag = "Boulder";
            }
            else
            {
                pictureBox_Boulder.Image = Image.FromFile("barn.png");
                pictureBox_Boulder.Tag = "Barn";
            }

            pictureBox_Boulder.Size = new Size(60, 60);
            pictureBox_Boulder.Location = new Point(rnd.Next(fromBorder, panel_map.Width - pictureBox_Boulder.Width - fromBorder),
                                        rnd.Next(fromBorder, panel_map.Height - pictureBox_Boulder.Height - fromBorder));

            // boulder ne kerüljön oda ahol score van


            boulder = Overlaps(panel_map, pictureBox_Boulder, pictureBox_Score);
            pictureBox_Boulder.Location = boulder.Location;

            // boulder ne kerüljön oda ahol player van

            boulder = Overlaps(panel_map, pictureBox_Boulder, pictureBox_Head);
            pictureBox_Boulder.Location = boulder.Location;

            // boulder ne kerüljön oda ahol farmer van

            boulder = Overlaps(panel_map, pictureBox_Boulder, pictureBox_Farmer);
            pictureBox_Boulder.Location = boulder.Location;

            // boulder ne kerüljön oda ahol fuel van

            boulder = Overlaps(panel_map, pictureBox_Boulder, pictureBox_Fuel);
            pictureBox_Boulder.Location = boulder.Location;

            return pictureBox_Boulder;
        }
    }

}
