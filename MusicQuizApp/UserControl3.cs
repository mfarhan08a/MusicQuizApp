using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicQuizApp
{
    public partial class UserControl3 : UserControl
    {        
        SearchResult res = new SearchResult();
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public UserControl3()
        {
            InitializeComponent();           
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAll();
            richTextBox1.Text = RestHelper.BeautifyJson(response);

            res = JsonConvert.DeserializeObject<SearchResult>(response);
            label2.Text = res.results[0].artistName;            
        }

        private void button2_Click(object sender, EventArgs e)
        {                
            player.URL = res.results[0].previewUrl;
            player.controls.play();
        }       
    }
}
