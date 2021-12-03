using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreTable.Forms;
using ScoreTable.Services;

namespace ScoreTable.Forms
{
    public partial class TotalScore : Form
    {
        private Table _table;

        public TotalScore(Table table)
        {
            _table = table;
            InitializeComponent();
            Init();
            System.Media.SystemSounds.Asterisk.Play();
        }

        public void Init()
        {
            int totalHome = _table.GetTotalHome();
            int totalHost = _table.GetTotalHost();
            _lblHomeTotalScore.Text = totalHome.ToString();
            _lblHostTotalScore.Text = totalHost.ToString();

            if (totalHost == totalHome)
            {
                _lblWinner.Text = "TIE";
            } else if (totalHost > totalHome)
            {
                _lblWinner.Text = "HOST";
            } else
            {
                _lblWinner.Text = "HOME";
            }
        }
    }
}
