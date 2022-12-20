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
    public partial class GameOverForm : Form
    {
        public static GameOverForm instance;
        public Label lbl_totalScr;
        public Label lbl_percent;        
        
        public GameOverForm()
        {
            InitializeComponent();
            instance = this;

            lbl_totalScr = lbl_totalScore;
            lbl_percent = lbl_precentage;            
        }        

        private void btn_continue_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
