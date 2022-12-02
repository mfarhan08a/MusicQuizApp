using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicQuizApp
{
    public partial class Form1 : Form
    {
        SearchResult res = new SearchResult();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<int> randomTrack = new List<int>();
        List<SearchResult.Result> songs = new List<SearchResult.Result>();       
        int questionNumber = 0;
        int score = 0;
        int totalQuestion = 10;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pnl_welcome.Visible = true;
            pnl_play.Visible = false;
            pnl_settings.Visible = false;
            pnl_welcome.BringToFront();
            // pop
            var response = await RestHelper.GetAll("country");
            res = JsonConvert.DeserializeObject<SearchResult>(response);
            songs.AddRange(res.results);

            var response2 = await RestHelper.GetAll("pop");
            res = JsonConvert.DeserializeObject<SearchResult>(response2);
            songs.AddRange(res.results);            

            songs = songs.GroupBy(s => s.trackId).Select(s => s.First()).ToList();


            guessBox.KeyDown += new KeyEventHandler(tb_KeyDown);
        }        

        private void btn_play_Click(object sender, EventArgs e)
        {
            pnl_welcome.Visible = false;
            pnl_play.Visible = true;
            pnl_settings.Visible = false;
            pnl_play.BringToFront();

            btn_skip.Visible = true;

            score = 0;
            questionNumber = 0;
            randomTrack.Clear();

            Random rnd = new Random();
            int MyNumber = 0;
            void NewNumber()
            {
                MyNumber = rnd.Next(0, songs.Count - 1);
                if (!randomTrack.Contains(MyNumber))
                {
                    Console.WriteLine(MyNumber);
                    randomTrack.Add(MyNumber);
                }
            }

            for (int i = 0; i < totalQuestion + 5; i++)
            {
                NewNumber();
            }

            play(questionNumber);
        }
        public void play(int questionNumber)
        {
            //Console.WriteLine(questionNumber);
            player.URL = songs[randomTrack[questionNumber]].previewUrl;
            player.controls.play();
        }

        public void checkAnswer()
        {

        SkipToEnd:
            if (questionNumber == totalQuestion)
            {
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have guessed " + score + " songs correctly." + Environment.NewLine +
                    "Click OK to Continue"
                    );
                score = 0;
                questionNumber = 0;
                randomTrack.Clear();
                player.controls.stop();
                pnl_play.Visible = false;
                pnl_welcome.Visible = true;
                pnl_welcome.BringToFront();
            }
            else
            {
                Console.WriteLine(songs[randomTrack[questionNumber]].trackName);
                if (guessBox.Text.Trim().ToLower() == songs[randomTrack[questionNumber]].trackName.Trim().ToLower())
                {
                    score++;
                    label5.Text = "benar";
                    questionNumber++;
                    guessBox.Text = "";
                    if (questionNumber == totalQuestion)
                    {
                        goto SkipToEnd;
                    }
                    else
                    {
                        play(questionNumber);
                    }
                }
                else
                {
                    label5.Text = "salah";
                }
            }
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }
        private void btn_skip_Click(object sender, EventArgs e)
        {
            questionNumber++;
            Console.WriteLine(questionNumber);
            guessBox.Text = "";
            if (questionNumber == totalQuestion)
            {
                checkAnswer();
            }
            else
            {
                Console.WriteLine(randomTrack[questionNumber]);
                play(questionNumber);
                checkAnswer();
            }

        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {
            pnl_welcome.Visible = true;
            pnl_play.Visible = false;
            pnl_settings.Visible = false;
            pnl_welcome.BringToFront();
            player.controls.stop();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            pnl_welcome.Visible = false;
            pnl_play.Visible = false;
            pnl_settings.Visible = true;
            pnl_settings.BringToFront();

            dataSongsView.DataSource = songs;
            player.controls.stop();

            Console.WriteLine(songs.Count());           
            
        }


        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
