using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Sort__Design_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void MainStart_Click(object sender, EventArgs e)
        {


            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (a == 1)
            {
                bookA.BackColor = Color.Red;
                volumeA.BackColor = Color.Red;
            }
            if (b == 1)
            {
                bookB.BackColor = Color.Red;
                volumeB.BackColor = Color.Red;
            }
            if (c == 1)
            {
                bookC.BackColor = Color.Red;
                volumeC.BackColor = Color.Red;
            }
            if (d == 1)
            {
                bookD.BackColor = Color.Red;
                volumeD.BackColor = Color.Red;
            }
            if (f == 1)
            {
                bookE.BackColor = Color.Red;
                volumeE.BackColor = Color.Red;
            }

            if (a == 2)
            {
                bookA.BackColor = Color.MediumSlateBlue;
                volumeA.BackColor = Color.MediumSlateBlue;
            }
            if (b == 2)
            {
                bookB.BackColor = Color.MediumSlateBlue;
                volumeB.BackColor = Color.MediumSlateBlue;
            }
            if (c == 2)
            {
                bookC.BackColor = Color.MediumSlateBlue;
                volumeC.BackColor = Color.MediumSlateBlue;
            }
            if (d == 2)
            {
                bookD.BackColor = Color.MediumSlateBlue;
                volumeD.BackColor = Color.MediumSlateBlue;
            }
            if (f == 2)
            {
                bookE.BackColor = Color.MediumSlateBlue;
                volumeE.BackColor = Color.MediumSlateBlue;
            }

            if (a == 3)
            {
                bookA.BackColor = Color.Lime;
                volumeA.BackColor = Color.Lime;
            }
            if (b == 3)
            {
                bookB.BackColor = Color.Lime;
                volumeB.BackColor = Color.Lime;
            }
            if (c == 3)
            {
                bookC.BackColor = Color.Lime;
                volumeC.BackColor = Color.Lime;
            }
            if (d == 3)
            {
                bookD.BackColor = Color.Lime;
                volumeD.BackColor = Color.Lime;
            }
            if (f == 3)
            {
                bookE.BackColor = Color.Lime;
                volumeE.BackColor = Color.Lime;
            }


            if (a == 4)
            {
                bookA.BackColor = Color.Gold;
                volumeA.BackColor = Color.Gold;
            }
            if (b == 4)
            {
                bookB.BackColor = Color.Gold;
                volumeB.BackColor = Color.Gold;
            }
            if (c == 4)
            {
                bookC.BackColor = Color.Gold;
                volumeC.BackColor = Color.Gold;
            }
            if (d == 4)
            {
                bookD.BackColor = Color.Gold;
                volumeD.BackColor = Color.Gold;
            }
            if (f == 4)
            {
                bookE.BackColor = Color.Gold;
                volumeE.BackColor = Color.Gold;
            }


            if (a == 5)
            {
                bookA.BackColor = Color.DodgerBlue;
                volumeA.BackColor = Color.DodgerBlue;
            }
            if (b == 5)
            {
                bookB.BackColor = Color.DodgerBlue;
                volumeB.BackColor = Color.DodgerBlue;
            }
            if (c == 5)
            {
                bookC.BackColor = Color.DodgerBlue;
                volumeC.BackColor = Color.DodgerBlue;
            }
            if (d == 5)
            {
                bookD.BackColor = Color.DodgerBlue;
                volumeD.BackColor = Color.DodgerBlue;
            }
            if (f == 5)
            {
                bookE.BackColor = Color.DodgerBlue;
                volumeE.BackColor = Color.DodgerBlue;

                
            }

            if (f >= d && d >= c && c >= b && b >= a)
            {
                MessageBox.Show("SORTED!");
                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                next1.Visible = false;

            }
            else
            {
                spotlightA.Visible = true;
                spotlightB.Visible = true;
            }

            MainStart.Visible = false;
            next1.Visible = true;
            refreshbtn.Visible = true;
           


        }

        private void next1_Click(object sender, EventArgs e)
        {
            next1.Visible = false;
            next2.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (f >= a && d >= a && c >= a && f >= b && d >= b && c >= b && f >= c && d >= c && f >= d && a > b)
            {

                h = volumeB.Text;
                volumeB.Text = volumeA.Text;
                volumeA.Text = h;

                m = volumeB.BackColor;
                volumeB.BackColor = volumeA.BackColor;
                volumeA.BackColor = m;

                n = bookB.BackColor;
                bookB.BackColor = bookA.BackColor;
                bookA.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightA.Visible = false;
                spotlightB.Visible = false;
                

                MessageBox.Show("SORTED!");
                next2.Visible = false;

            }
            else
            {
                if (a > b)
                {
                    h = volumeB.Text;
                    volumeB.Text = volumeA.Text;
                    volumeA.Text = h;


                    m = volumeB.BackColor;
                    volumeB.BackColor = volumeA.BackColor;
                    volumeA.BackColor = m;

                    n = bookB.BackColor;
                    bookB.BackColor = bookA.BackColor;
                    bookA.BackColor = n;

                }
                else
                {
                    noneedA.Visible = true;
                    noneedB.Visible = true;
                    spotlightA.Visible = false;
                    spotlightB.Visible = false;
                }
            }
        }

        private void next2_Click(object sender, EventArgs e)
        {
            spotlightB.Visible = true;
            spotlightC.Visible = true;
            spotlightA.Visible = false;
            noneedA.Visible = false;
            noneedB.Visible = false;

            next2.Visible = false;
            next3.Visible = true;
        }

        private void next3_Click(object sender, EventArgs e)
        {
            next3.Visible = false;
            next4.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (f >= a && d >= a && c >= a && b >= a && f >= b && d >= b && f >= c && d >= c && f >= d && b >= c)
            {

                h = volumeC.Text;
                volumeC.Text = volumeB.Text;
                volumeB.Text = h;

                m = volumeC.BackColor;
                volumeC.BackColor = volumeB.BackColor;
                volumeB.BackColor = m;

                n = bookC.BackColor;
                bookC.BackColor = bookB.BackColor;
                bookB.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightB.Visible = false;
                spotlightC.Visible = false;
               

                MessageBox.Show("SORTED!");
                next4.Visible = false;

            }
            else
            {
                if (b > c)
                {
                    h = volumeC.Text;
                    volumeC.Text = volumeB.Text;
                    volumeB.Text = h;


                    m = volumeC.BackColor;
                    volumeC.BackColor = volumeB.BackColor;
                    volumeB.BackColor = m;

                    n = bookC.BackColor;
                    bookC.BackColor = bookB.BackColor;
                    bookB.BackColor = n;

                }
                else
                {
                    noneedB.Visible = true;
                    noneedC.Visible = true;
                    spotlightB.Visible = false;
                    spotlightC.Visible = false;
                }
            }
        }

        private void next4_Click(object sender, EventArgs e)
        {
            spotlightC.Visible = true;
            spotlightD.Visible = true;
            spotlightB.Visible = false;
            noneedB.Visible = false;
            noneedC.Visible = false;

            next4.Visible = false;
            next5.Visible = true;
        }


        private void spotlightC_Click(object sender, EventArgs e)
        {

        }

        private void next5_Click(object sender, EventArgs e)
        {
            next5.Visible = false;
            next6.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (f >= a && d >= a && c >= a && b >= a && f >= b && d >= b && c >= b && f >= c && f >= d && c > d)
            {

                h = volumeD.Text;
                volumeD.Text = volumeC.Text;
                volumeC.Text = h;

                m = volumeD.BackColor;
                volumeD.BackColor = volumeC.BackColor;
                volumeC.BackColor = m;

                n = bookD.BackColor;
                bookD.BackColor = bookC.BackColor;
                bookC.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightC.Visible = false;
                spotlightD.Visible = false;
                

                MessageBox.Show("SORTED!");
                next6.Visible = false;

            }
            else
            {
                if (c > d)
                {
                    h = volumeD.Text;
                    volumeD.Text = volumeC.Text;
                    volumeC.Text = h;


                    m = volumeD.BackColor;
                    volumeD.BackColor = volumeC.BackColor;
                    volumeC.BackColor = m;

                    n = bookD.BackColor;
                    bookD.BackColor = bookC.BackColor;
                    bookC.BackColor = n;

                }
                else
                {
                    noneedC.Visible = true;
                    noneedD.Visible = true;
                    spotlightC.Visible = false;
                    spotlightD.Visible = false;
                }
            }
        }

        private void next6_Click(object sender, EventArgs e)
        {
            next6.Visible = false;
            next7.Visible = true;

            spotlightD.Visible = true;
            spotlightE.Visible = true;
            spotlightC.Visible = false;
            noneedC.Visible = false;
            noneedD.Visible = false;
        }

        private void next7_Click(object sender, EventArgs e)
        {
            next7.Visible = false;
            secondpass.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (f >= a && d >= a && c >= a && b >= a && f >= b && d >= b && c >= b && f >= c && d >= c && d > f)
            {

                h = volumeE.Text;
                volumeE.Text = volumeD.Text;
                volumeD.Text = h;

                m = volumeE.BackColor;
                volumeE.BackColor = volumeD.BackColor;
                volumeD.BackColor = m;

                n = bookE.BackColor;
                bookE.BackColor = bookD.BackColor;
                bookD.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightD.Visible = false;
                spotlightE.Visible = false;

                MessageBox.Show("SORTED!");
                secondpass.Visible = false;

            }
            else
            {
                if (d > f)
                {
                    h = volumeE.Text;
                    volumeE.Text = volumeD.Text;
                    volumeD.Text = h;


                    m = volumeE.BackColor;
                    volumeE.BackColor = volumeD.BackColor;
                    volumeD.BackColor = m;

                    n = bookE.BackColor;
                    bookE.BackColor = bookD.BackColor;
                    bookD.BackColor = n;

                }
                else
                {
                    noneedD.Visible = true;
                    noneedE.Visible = true;
                    spotlightD.Visible = false;
                    spotlightE.Visible = false;
                }
            }
        }

        private void secondpass_Click(object sender, EventArgs e)
        {
            secondpass.Visible = false;
            next8.Visible = true;

            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);

            spotlightA.Visible = true;
            spotlightB.Visible = true;

            if (d == f)
            {
                correctE.Visible = true;
                correctD.Visible = true;
                spotlightE.Visible = false;
                spotlightD.Visible = false;
                noneedE.Visible = false;
                noneedD.Visible = false;

            }
            else
            {

                correctE.Visible = true;
                spotlightE.Visible = false;
                spotlightD.Visible = false;
                noneedE.Visible = false;
                noneedD.Visible = false;

            }
        }

        private void next8_Click(object sender, EventArgs e)
        {
            next8.Visible = false;
            next9.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (d >= a && c >= a && d >= b && c >= b && d >= c && a > b)
            {

                h = volumeB.Text;
                volumeB.Text = volumeA.Text;
                volumeA.Text = h;

                m = volumeB.BackColor;
                volumeB.BackColor = volumeA.BackColor;
                volumeA.BackColor = m;

                n = bookB.BackColor;
                bookB.BackColor = bookA.BackColor;
                bookA.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightA.Visible = false;
                spotlightB.Visible = false;
                

                MessageBox.Show("SORTED!");
                next9.Visible = false;


            }
            else
            {
                if (a > b)
                {
                    h = volumeB.Text;
                    volumeB.Text = volumeA.Text;
                    volumeA.Text = h;


                    m = volumeB.BackColor;
                    volumeB.BackColor = volumeA.BackColor;
                    volumeA.BackColor = m;

                    n = bookB.BackColor;
                    bookB.BackColor = bookA.BackColor;
                    bookA.BackColor = n;

                }
                else
                {
                    noneedA.Visible = true;
                    noneedB.Visible = true;
                    spotlightA.Visible = false;
                    spotlightB.Visible = false;
                }
            }
        }

        private void next9_Click(object sender, EventArgs e)
        {
            next9.Visible = false;
            next10.Visible = true;

            spotlightB.Visible = true;
            spotlightC.Visible = true;
            spotlightA.Visible = false;
            noneedA.Visible = false;
            noneedB.Visible = false;
        }

        private void next10_Click(object sender, EventArgs e)
        {
            next10.Visible = false;
            next11.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (d >= a && c >= a && b >= a && d >= b && d >= c && b >= c)
            {

                h = volumeC.Text;
                volumeC.Text = volumeB.Text;
                volumeB.Text = h;

                m = volumeC.BackColor;
                volumeC.BackColor = volumeB.BackColor;
                volumeB.BackColor = m;

                n = bookC.BackColor;
                bookC.BackColor = bookB.BackColor;
                bookB.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightB.Visible = false;
                spotlightC.Visible = false;


                MessageBox.Show("SORTED!");
                next11.Visible = false;


            }
            else
            {
                if (b > c)
                {
                    h = volumeC.Text;
                    volumeC.Text = volumeB.Text;
                    volumeB.Text = h;


                    m = volumeC.BackColor;
                    volumeC.BackColor = volumeB.BackColor;
                    volumeB.BackColor = m;

                    n = bookC.BackColor;
                    bookC.BackColor = bookB.BackColor;
                    bookB.BackColor = n;

                }
                else
                {
                    noneedB.Visible = true;
                    noneedC.Visible = true;
                    spotlightB.Visible = false;
                    spotlightC.Visible = false;
                }
            }
        }

        private void next11_Click(object sender, EventArgs e)
        {
            next11.Visible = false;
            next12.Visible = true;

            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeC.Text);

            if (f == d)
            {
                correctD.Visible = true;
                next12.Visible = false;
                thirdpass.Visible = true;
            }
            else
            {
                spotlightC.Visible = true;
                spotlightD.Visible = true;
                spotlightB.Visible = false;
                noneedB.Visible = false;
                noneedC.Visible = false;
            }
        }


        private void next12_Click(object sender, EventArgs e)
        {
            next12.Visible = false;
            thirdpass.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (f >= a && d >= a && c >= a && b >= a && f >= b && d >= b && c >= b && f >= c && f >= d && c > d)
            {

                h = volumeD.Text;
                volumeD.Text = volumeC.Text;
                volumeC.Text = h;

                m = volumeD.BackColor;
                volumeD.BackColor = volumeC.BackColor;
                volumeC.BackColor = m;

                n = bookD.BackColor;
                bookD.BackColor = bookC.BackColor;
                bookC.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightC.Visible = false;
                spotlightD.Visible = false;


                MessageBox.Show("SORTED!");
                thirdpass.Visible = false;

            }
            else
            {
                if (c > d)
                {
                    h = volumeD.Text;
                    volumeD.Text = volumeC.Text;
                    volumeC.Text = h;


                    m = volumeD.BackColor;
                    volumeD.BackColor = volumeC.BackColor;
                    volumeC.BackColor = m;

                    n = bookD.BackColor;
                    bookD.BackColor = bookC.BackColor;
                    bookC.BackColor = n;

                }
                else
                {
                    noneedC.Visible = true;
                    noneedD.Visible = true;
                    spotlightC.Visible = false;
                    spotlightD.Visible = false;
                }
            }
        }

        private void thirdpass_Click(object sender, EventArgs e)
        {
           thirdpass.Visible = false;
            next13.Visible = true;

            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);

            spotlightA.Visible = true;
            spotlightB.Visible = true;

            if (c == d)
            {
                correctD.Visible = true;
                correctC.Visible = true;
                spotlightD.Visible = false;
                spotlightC.Visible = false;
                noneedD.Visible = false;
                noneedC.Visible = false;

            }
            else
            {

                correctD.Visible = true;
                spotlightD.Visible = false;
                spotlightC.Visible = false;
                noneedD.Visible = false;
                noneedC.Visible = false;

            }
        }

        private void next13_Click(object sender, EventArgs e)
        {
            next13.Visible = false;
            next14.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (c >= a && c >= b && a > b)
            {

                h = volumeB.Text;
                volumeB.Text = volumeA.Text;
                volumeA.Text = h;

                m = volumeB.BackColor;
                volumeB.BackColor = volumeA.BackColor;
                volumeA.BackColor = m;

                n = bookB.BackColor;
                bookB.BackColor = bookA.BackColor;
                bookA.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightA.Visible = false;
                spotlightB.Visible = false;


                MessageBox.Show("SORTED!");
                next14.Visible = false;

            }
            else
            {
                if (a > b)
                {
                    h = volumeB.Text;
                    volumeB.Text = volumeA.Text;
                    volumeA.Text = h;


                    m = volumeB.BackColor;
                    volumeB.BackColor = volumeA.BackColor;
                    volumeA.BackColor = m;

                    n = bookB.BackColor;
                    bookB.BackColor = bookA.BackColor;
                    bookA.BackColor = n;

                }
                else
                {
                    noneedA.Visible = true;
                    noneedB.Visible = true;
                    spotlightA.Visible = false;
                    spotlightB.Visible = false;
                }
            }
        }

        private void next14_Click(object sender, EventArgs e)
        {
            next14.Visible = false;
            next15.Visible = true;

            int b = int.Parse(volumeD.Text);
            int c = int.Parse(volumeE.Text);

            if (b == c)
            {
                correctC.Visible = true;
                next15.Visible = false;
                fourthpass.Visible = true;
            }
            else
            {
                spotlightB.Visible = true;
                spotlightC.Visible = true;
                spotlightA.Visible = false;
                noneedA.Visible = false;
                noneedB.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void next15_Click(object sender, EventArgs e)
        {
            next15.Visible = false;
            fourthpass.Visible = true;

            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
            int d = int.Parse(volumeD.Text);
            int f = int.Parse(volumeE.Text);


            if (c >= a && b >= a && b >= c)
            {

                h = volumeC.Text;
                volumeC.Text = volumeB.Text;
                volumeB.Text = h;

                m = volumeC.BackColor;
                volumeC.BackColor = volumeB.BackColor;
                volumeB.BackColor = m;

                n = bookC.BackColor;
                bookC.BackColor = bookB.BackColor;
                bookB.BackColor = n;

                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                spotlightB.Visible = false;
                spotlightC.Visible = false;


                MessageBox.Show("SORTED!");
                fourthpass.Visible = false;

            }
            else
            {
                if (b > c)
                {
                    h = volumeC.Text;
                    volumeC.Text = volumeB.Text;
                    volumeB.Text = h;


                    m = volumeC.BackColor;
                    volumeC.BackColor = volumeB.BackColor;
                    volumeB.BackColor = m;

                    n = bookC.BackColor;
                    bookC.BackColor = bookB.BackColor;
                    bookB.BackColor = n;

                }
                else
                {
                    noneedB.Visible = true;
                    noneedC.Visible = true;
                    spotlightB.Visible = false;
                    spotlightC.Visible = false;
                }
            }
        }

        private void fourthpass_Click(object sender, EventArgs e)
        {
            fourthpass.Visible = false;
            next16.Visible = true;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);
            int c = int.Parse(volumeC.Text);
           

            if (b == c)
            {
                MessageBox.Show("SORTED!");
                correctA.Visible = true;
                correctB.Visible = true;
                correctC.Visible = true;
                correctD.Visible = true;
                correctE.Visible = true;
                noneedB.Visible = false;
                noneedC.Visible = false;
                spotlightB.Visible = false;
                spotlightC.Visible = false;
                next16.Visible = false;
            }
            else
            {
                spotlightA.Visible = true;
                spotlightB.Visible = true;
                spotlightC.Visible = false;
                correctC.Visible = true;

            }
        }

        private void next16_Click(object sender, EventArgs e)
        {
            next16.Visible = false;
            
            string h;
            Color m;
            Color n;

            int a = int.Parse(volumeA.Text);
            int b = int.Parse(volumeB.Text);

            h = volumeB.Text;
            volumeB.Text = volumeA.Text;
            volumeA.Text = h;


            m = volumeB.BackColor;
            volumeB.BackColor = volumeA.BackColor;
            volumeA.BackColor = m;

            n = bookB.BackColor;
            bookB.BackColor = bookA.BackColor;
            bookA.BackColor = n;

            correctA.Visible = true;
            correctB.Visible = true;
            spotlightA.Visible = false;
            spotlightB.Visible = false;


            MessageBox.Show("SORTED!");
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

