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
        public static Form1 instance;
        public static int totalScore;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer guessSound = new WindowsMediaPlayer();
        string wrongSoundPath = @"D:\Kuliah\#SEMESTER 5\Pemrograman Platform Desktop dan Embedded\MusicQuizApp\assets\wrong.mp3";
        string correctSoundPath = @"D:\Kuliah\#SEMESTER 5\Pemrograman Platform Desktop dan Embedded\MusicQuizApp\assets\correct.mp3";
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

        GameOverForm goForm = new GameOverForm();

        Random rnd = new Random();
        int MyNumber = 0;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            totalScore = score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelControls(pnl_loading);

            syncSongs(genres);

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
            loadingSettings.Stop();

            btn_skip.Visible = false;
            lbl_title.Text = "Title : ";
            lbl_artist.Text = "Artist : ";
            lbl_year.Text = "Year : ";
            lbl_guess.ForeColor = Color.Black;
            lbl_guess.Text = "Your Guess : ";

            score = 0;
            questionNumber = 0;
            randomTrack.Clear();
            MyNumber = 0;
            countdown.Stop();

            try
            {
                for (int i = 0; i < totalQuestion + 1; i++)
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
            else
            {
                NewNumber(list);
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
            Console.WriteLine(songs[randomTrack[questionNumber]].trackName);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == randomTrack[questionNumber])
            {
                score++;
                lbl_guess.ForeColor = Color.Green;
                lbl_guess.Text = "Your Guess : Correct";
                guessSound.URL = correctSoundPath;
                guessSound.controls.play();
                questionNumber++;
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
                lbl_guess.ForeColor = Color.Red;
                lbl_guess.Text = "Your Guess : Wrong";
                guessSound.URL = wrongSoundPath;
                guessSound.controls.play();
                questionNumber++;
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
            double percentage = (Convert.ToDouble(score) / totalQuestion) * 100;
            Console.WriteLine(percentage);
            GameOverForm.instance.lbl_totalScr.Text = "You have guess " + score + " of " + totalQuestion + " songs Correctly!";
            GameOverForm.instance.lbl_percent.Text = "You have pass " + percentage + "% accuration on the quiz.";

            score = 0;
            questionNumber = 0;
            randomTrack.Clear();

            goForm.ShowDialog();

            player.controls.stop();
            panelControls(pnl_welcome);
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            questionNumber++;
            Console.WriteLine(questionNumber);
            if (questionNumber == totalQuestion)
            {
                previousSongShow();
                gameOver();
            }
            else
            {
                Console.WriteLine(randomTrack[questionNumber]);
                play(questionNumber);
            }
        }

        public void btn_welcome_Click(object sender, EventArgs e)
        {
            panelControls(pnl_welcome);

            player.controls.stop();
            countdown.Stop();
            loadingSettings.Stop();
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

            //songs and quiz info
            lbl_totalQuestions.Text = "Total Questions : " + totalQuestion.ToString();
            lbl_totalSongs.Text = "Total Songs : " + songs.Count().ToString();
            lbl_genreSelected.Text = "Genre Selected : " + string.Join(", ", genres).ToString();
            lbl_countDownTimer.Text = "Countdown Timer : " + time.ToString();
            loadingSettings.Stop();
        }


        private void countdown_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = seconds--.ToString();
            if (seconds < 0)
            {
                countdown.Stop();
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

            //songs and quiz info
            lbl_totalQuestions.Text = "Total Questions : " + totalQuestion.ToString();
            lbl_totalSongs.Text = "Total Songs : " + songs.Count().ToString();
            lbl_genreSelected.Text = "Genre Selected : " + string.Join(", ", genres).ToString();
            lbl_countDownTimer.Text = "Countdown Timer : " + time.ToString();

            //loading settings            
            loadingSettings.Start();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            panelControls(pnl_about);

            player.controls.stop();
            countdown.Stop();
            loadingSettings.Stop();

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
            Console.WriteLine(songs.Count().ToString());
            if (songs.Count > 1200)
            {
                loading.Stop();
                panelControls(pnl_welcome);
            }
        }

        private void loadingSettings_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(2);
            if (progressBar.Value > 120)
            {
                //songs and quiz info
                lbl_totalQuestions.Text = "Total Questions : " + totalQuestion.ToString();
                lbl_totalSongs.Text = "Total Songs : " + songs.Count().ToString();
                lbl_genreSelected.Text = "Genre Selected : " + string.Join(", ", genres).ToString();
                lbl_countDownTimer.Text = "Countdown Timer : " + time.ToString();
            }
        }
    }
}
