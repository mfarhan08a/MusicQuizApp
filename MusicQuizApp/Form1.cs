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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MusicQuizApp
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<int> randomTrack = new List<int>();
        List<int> randomAnswer = new List<int>();
        List<SearchResult.Result> songs = new List<SearchResult.Result>();
        List<string> genres = new List<string> { "pop", "country", "rock", "dance", "j-pop", "k-pop", "indo-pop", "soundtrack", "anime" };       
        int questionNumber = 0;
        int score = 0;
        int totalQuestion = 10;
        Timer timer = new Timer();
        int seconds;
        int time = 45;

        Random rnd = new Random();
        int MyNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            panelControls(pnl_loading);

            syncSongs(genres);

            guessBox.KeyDown += new KeyEventHandler(tb_KeyDown);
            dataSongsView.Hide();
        }

        public async void syncSongs(List<string> genres)
        {
            songs.Clear();
            dataSongsView.DataSource = null;
            foreach (var genre in genres)
            {
                var response = await RestHelper.GetAll(genre);
                var res = JsonConvert.DeserializeObject<SearchResult>(response);
                songs.AddRange(res.results);
            }
            songs = songs.GroupBy(s => s.trackId).Select(s => s.First()).ToList();
            dataSongsView.DataSource = songs;
        }
        public void panelControls(Panel panel)
        {
            pnl_welcome.Visible = false;
            pnl_play.Visible = false;
            pnl_settings.Visible = false;
            pnl_about.Visible = false;
            pnl_loading.Visible = false;

            panel.Visible = true;
            panel.BringToFront();

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            // panel controls           
            panelControls(pnl_play);

            btn_skip.Visible = true;
            lbl_title.Text = "Title : ";
            lbl_artist.Text = "Artist : ";
            lbl_year.Text = "Year : ";

            score = 0;
            questionNumber = 0;

            randomTrack.Clear();
            
            MyNumber = 0;            

            try
            {
                for (int i = 0; i < totalQuestion + 20; i++)
                {
                    NewNumber(randomTrack);
                }

                play(questionNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NewNumber(List<int> list)
        {
            MyNumber = rnd.Next(0, songs.Count - 1);
            if (!list.Contains(MyNumber))
            {                
                list.Add(MyNumber);
            }
        }        

        public void play(int questionNumber)
        {
            //Console.WriteLine(questionNumber);
            player.URL = songs[randomTrack[questionNumber]].previewUrl;
            player.controls.play();
            seconds = time;
            countdown.Start();
            lbl_questionNumber.Text = (questionNumber + 1).ToString() + " / " + totalQuestion.ToString();
            if (questionNumber > 0)
                previousSongShow();

            // multiple choice generator
            randomAnswer.Clear();
            randomAnswer.Add(randomTrack[questionNumber]);
            MyNumber = 0;
            for (int i = 0; i < totalQuestion + 20; i++)
            {
                NewNumber(randomAnswer);
            }            
            randomAnswer.RemoveRange(6, randomAnswer.Count - 6);            
            randomAnswer = randomAnswer.OrderBy(a => rnd.Next()).ToList();
            Console.WriteLine("[{0}]", string.Join(", ", randomAnswer));

            int inc = 0;
            var answerButton = new List<Button> { button1, button2, button3, button4, button5, button6 };
            foreach (var button in answerButton)
            {
                button.Text = songs[randomAnswer[inc]].trackName;
                button.Tag = randomAnswer[inc];
                inc++;
            }

        }

        public void checkAnswer()
        {        
            if (questionNumber == totalQuestion)
            {
                previousSongShow();
                gameOver();
            }
            else
            {                
                var index = songs[randomTrack[questionNumber]].trackName.IndexOf('(');
                Console.WriteLine(songs[randomTrack[questionNumber]].trackName);
                var answer = songs[randomTrack[questionNumber]].trackName;
                if (index >= 0)
                {
                    Console.WriteLine(songs[randomTrack[questionNumber]].trackName.Remove(index));
                    answer = songs[randomTrack[questionNumber]].trackName.Remove(index);
                }
                if (guessBox.Text.Trim().ToLower() == answer.Trim().ToLower())
                {
                    score++;
                    lbl_guess.Text = "Your Guess : Correct";
                    questionNumber++;
                    guessBox.Text = "";
                    if (questionNumber == totalQuestion)
                    {
                        previousSongShow();
                        gameOver();
                    }
                    else
                    {
                        play(questionNumber);                        
                    }
                }
                else
                {
                    lbl_guess.Text = "Your Guess : Wrong";
                }                
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (questionNumber == totalQuestion)
            {
                previousSongShow();
                gameOver();
            }
            else
            {
                var index = songs[randomTrack[questionNumber]].trackName.IndexOf('(');
                Console.WriteLine(songs[randomTrack[questionNumber]].trackName);
                var answer = songs[randomTrack[questionNumber]].trackName;
                if (index >= 0)
                {
                    Console.WriteLine(songs[randomTrack[questionNumber]].trackName.Remove(index));
                    answer = songs[randomTrack[questionNumber]].trackName.Remove(index);
                }
                if (buttonTag == randomTrack[questionNumber])
                {
                    score++;
                    lbl_guess.Text = "Your Guess : Correct";
                    questionNumber++;
                    guessBox.Text = "";
                    if (questionNumber == totalQuestion)
                    {
                        previousSongShow();
                        gameOver();
                    }
                    else
                    {
                        play(questionNumber);
                    }
                }
                else
                {
                    lbl_guess.Text = "Your Guess : Wrong";
                    questionNumber++;
                    play(questionNumber);
                }
            }
        }

        public void previousSongShow()
        {            
            lbl_title.Text = "Title : " + songs[randomTrack[questionNumber - 1]].trackName.ToString();
            lbl_artist.Text = "Artist : " + songs[randomTrack[questionNumber - 1]].artistName.ToString();
            lbl_year.Text = "Year : " + songs[randomTrack[questionNumber - 1]].releaseDate.Year.ToString();
        }

        public void gameOver()
        {
            countdown.Stop();
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
            panelControls(pnl_welcome);

            player.controls.stop();
            countdown.Stop();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            // panel controls            
            panelControls(pnl_settings);

            //default settings
            for (int i = 0; i < clb_genreSelection.Items.Count; i++)
            {
                clb_genreSelection.SetItemChecked(i, true);
            }
            rb_totalquestion10.Checked = true;
            rb_timer45.Checked = true;

            dataSongsView.Refresh();
            player.controls.stop();
            countdown.Stop();

            Console.WriteLine(songs.Count());
            Console.WriteLine("[{0}]", string.Join(", ", genres));

        }


        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
            }
        }
        private void countdown_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = seconds--.ToString();
            if (seconds < 0)
            {
                countdown.Stop();
                checkAnswer();
                btn_skip_Click(sender, e);
            }
        }

        private void btn_applySettings_Click(object sender, EventArgs e)
        {
            //genre settings
            genres.Clear();
            for (int i = 0; i < clb_genreSelection.CheckedIndices.Count; i++)
            {
                switch (clb_genreSelection.CheckedIndices[i])
                {
                    case 0:
                        genres.Add("pop");
                        break;
                    case 1:
                        genres.Add("country");
                        break;
                    case 2:
                        genres.Add("rock");
                        break;
                    case 3:
                        genres.Add("dance");
                        break;
                    case 4:
                        genres.Add("j-pop");
                        break;
                    case 5:
                        genres.Add("k-pop");
                        break;
                    case 6:
                        genres.Add("indo-pop");
                        break;
                    case 7:
                        genres.Add("soundtrack");
                        break;
                    case 8:
                        genres.Add("anime");
                        break;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", genres));

            syncSongs(genres);
            dataSongsView.Refresh();

            //total question settings
            if (rb_totalquestion10.Checked)
            {
                totalQuestion = 10;
            }
            else if (rb_totalquestion20.Checked)
            {
                totalQuestion = 20;
            }
            else if (rb_totalquestion50.Checked)
            {
                totalQuestion = 50;
            }
            else if (rb_totalquestion80.Checked)
            {
                totalQuestion = 80;
            }
            else if (rb_totalquestion100.Checked)
            {
                totalQuestion = 100;
            }
            Console.WriteLine("total question : " + totalQuestion);

            //countdown timer settings
            if (rb_timer45.Checked)
            {
                time = 45;
            }
            else if (rb_timer25.Checked)
            {
                time = 25;
            }
            else if (rb_timer15.Checked)
            {
                time = 15;
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            panelControls(pnl_about);

            player.controls.stop();
            countdown.Stop();

        }

        private void linkLabel_instagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_instagram.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.instagram.com/mfarhan08a");
        }

        private void linkLabel_itunes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_instagram.LinkVisited = true;
            System.Diagnostics.Process.Start("https://performance-partners.apple.com/search-api");
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            loading.Start();
            progressBar.Increment(1);
            if (songs.Count > 1600)
            {
                loading.Stop();
                panelControls(pnl_welcome);
            }
        }
        
    }
}
