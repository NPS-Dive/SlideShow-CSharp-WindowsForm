
//--------------------------------------------
using System.IO;

namespace WinFormsApp_37_SlideShow
    {
    public partial class Form1 : Form
        {
        public Form1 ()
            {
            InitializeComponent();
            }
        int counter = 0;
        string[] pictureArrayList;

        private void timer1_Tick ( object sender, EventArgs e )
            {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[counter]);

            //for make pictures cycling
            counter = (counter + 1) % openFileDialog1.FileNames.Length;
            }

        private void button1_Click ( object sender, EventArgs e )
            {
            openFileDialog1.Filter = "Picture Files|*.JPG; *.JPEG; *.PNG; *.BMP; *.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                counter = 0;
                timer1.Start();

                }
            }

        private void btnstartStop_Click ( object sender, EventArgs e )
            {
            timer1.Enabled = !timer1.Enabled;
            }

        private void BTNNext_Click ( object sender, EventArgs e )
            {
            //for make pictures cycling
            counter = (counter + 1) % openFileDialog1.FileNames.Length;

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[counter]);
            }

        private void btnPrevious_Click ( object sender, EventArgs e )
            {
            if (counter > 0)
                { //for make pictures cycling
                counter = (counter - 1) % openFileDialog1.FileNames.Length;
                }
            else
                {
                counter = openFileDialog1.FileNames.Length;

                }
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[counter]);

            }

        private void BTNfolderBrowse_Click ( object sender, EventArgs e )
            {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] fileInfos = directoryInfo.GetFiles("*.JPG");

                counter = 0;
                pictureArrayList = new string[fileInfos.Length];

                for (int i = 0; i < fileInfos.Length; i++)
                    {
                    pictureArrayList[i] = fileInfos[i].FullName;
                    timer2.Start();
                    }
                }
            }

        private void timer2_Tick ( object sender, EventArgs e )
            {
            pictureBox1.Image = Image.FromFile(pictureArrayList[counter]);
            counter= (counter+1) % pictureArrayList.Length;

            }
        }
    }