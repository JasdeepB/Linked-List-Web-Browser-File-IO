using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Grapple
{
    public partial class Grapple : Form
    {
        public string filePath = @"";

        private VideoHistory top = null;

        public Grapple()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (progressBar.Value != 0)
            {
                progressBar.Value = 0;
            }

            if (filePath != "")
            {
                for (int i = 0; i < 100; i++)
                {
                    progressBar.Increment(1);
                }

                currentStateBanner.Visible = true;
                currentStateBanner.Text = "       Now Visiting";

                FindPath();
            }
            else
            {
                string message = "\tNo file is currently selected! \n Click 'Change File' then select the target file";
                string title = "Reference file not found!";

                MessageBox.Show(message, title);
            }
        }

        public void FindPath()
        {
            try
            {
                char[] delimimeters = { '\n' };
                int itemsOnList = 0;


                using (TextReader file = new StreamReader(filePath))
                {

                    string sLine = file.ReadLine();

                    while (sLine != null)
                    {
                        string[] tokensFromLine = sLine.Split(delimimeters, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string token in tokensFromLine)
                        {
                            //Console.WriteLine("{0}", tokensFromLine[0]);
                            itemsOnList++;
                            break;
                        }

                        sLine = file.ReadLine();
                    }

                }

                FindVideo(itemsOnList);
            }
            catch(System.ArgumentException)
            {
                string message = "\tNo file is currently selected! \n Click 'Change File' then select the target file";
                string title = "Reference file not found!";

                MessageBox.Show(message, title);
            }
        }

        public void FindVideo(int librarySize)
        {
            try
            {
                Random generateThis = new Random();
                char[] delimimeters = { '\n' };
                string[] video = new string[librarySize];
                int index = 0;

                using (TextReader theFile = new StreamReader(filePath))
                {
                    string sLine = theFile.ReadLine();

                    while (sLine != null)
                    {
                        string[] tokensFromLine = sLine.Split(delimimeters, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string token in tokensFromLine)
                        {
                            video[index] = tokensFromLine[0];
                            index++;
                        }

                        sLine = theFile.ReadLine();
                    }
                    int videoFound = generateThis.Next(0, librarySize);
                    nowPlayingTextBox.Text = video[videoFound];
                    AddToHistory(video[videoFound]);

                    using (var process = new Process())
                    {
                        process.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                        process.StartInfo.Arguments = video[videoFound] + " --incognito";

                        process.Start();
                    }

                    //**DEBUG**
                    //Console.WriteLine("{0}", video[videoFound]);
                    //Console.WriteLine("Loop {0}", index);
                }
            }
            catch (IndexOutOfRangeException)
            {
                string message = "A wild IndexOutOfRangeException has been spotted.\n\nTry again?";
                string title = "Error!";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    FindVideo(librarySize);
                }
                else
                {
                    this.Close();
                }
            }
            
        }
        private class VideoHistory
        {
            public string data;
            public VideoHistory next;

            public VideoHistory(string x)
            {
                data = x;
            }
        }

        public void AddToHistory(string videoToAdd)
        {
            if (top == null)
            {
                VideoHistory newVideo = new VideoHistory(videoToAdd);
                top = newVideo;
            }
            else
            {
                VideoHistory newVideo = new VideoHistory(videoToAdd);

                newVideo.next = top;
                top = newVideo;
            }
        }

        public void PrintHistory()
        {
            VideoHistory cur = top;
            string currentHistory = "";
            int videoNumber = 1;

            while (cur != null)
            {
                currentHistory += videoNumber + ": " + cur.data + Environment.NewLine;
                videoNumber++;
                cur = cur.next;
            }

            browserHistoryBox.Text = currentHistory;
        }


        private void NowPlayingTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ViewHistory_Click(object sender, EventArgs e)
        {
            if (top == null)
            {
                return;
            }
            else
            {
                browserHistoryBox.Visible = true;
                hideHistoryButton.Visible = true;
                currentStateBanner.Visible = true;
                clearHistoryBtn.Visible = true;
                currentStateBanner.Text = "     Viewing History";
                PrintHistory();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddToLibrary_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                currentStateBanner.Visible = true;
                currentStateBanner.Text = "     Editing Library";
                Process.Start("explorer.exe", "/select," + filePath);
            }
        }

        private void NowPlayingBanner_TextChanged(object sender, EventArgs e)
        {
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void HistoryBanner_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (browserHistoryBox.Visible == true && hideHistoryButton.Visible == true)
            {
                browserHistoryBox.Visible = false;
                hideHistoryButton.Visible = false;
                clearHistoryBtn.Visible = false;
                currentStateBanner.Text = "           Grapple";
            }
        }

        public void SelectFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text file (*.txt)|*.txt";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
            }
        }

        private void NewFileBtn_Click(object sender, EventArgs e)
        {
            currentStateBanner.Visible = true;
            currentStateBanner.Text = "   Selecting Source";
            SelectFile();
            filePathTextBox.Text = filePath;
            
            if (filePath == "")
            {
                clearPathBtn.Visible = false;
            }
            else
            {
                clearPathBtn.Visible = true;
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            currentStateBanner.Visible = true;
            currentStateBanner.Text = "Viewing Demo File";
            Process.Start("notepad.exe", "C:\\Program Files (x86)\\Grapple Tech\\Grapple\\Example File.txt");
        }

        private void ClearPathBtn_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                currentStateBanner.Text = "Cleared file reference";

                filePath = "";
                filePathTextBox.Text = filePath;
                clearPathBtn.Visible = false;
            }
        }

        private void ClearHistoryBtn_Click(object sender, EventArgs e)
        {
            if (top != null)
            {
                top = null;
                PrintHistory();
            }
        }
    }
}
