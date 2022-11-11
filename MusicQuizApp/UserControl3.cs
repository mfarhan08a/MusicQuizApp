using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicQuizApp
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAll();
            richTextBox1.Text = RestHelper.BeautifyJson(response);

            SearchResult res = JsonConvert.DeserializeObject<SearchResult>(response);
            label2.Text = res.results[0].artistName;
        }
    }
}
