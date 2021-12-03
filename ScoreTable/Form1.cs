using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreTable.Services;

namespace ScoreTable
{
    public partial class Form1 : Form
    {
        private ScoreTableService _service;
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            _service = new ScoreTableService();
            _service.Elapsed += _service_Elapsed;

            _home.Init(Models.TeamType.Home, _service);
            _host.Init(Models.TeamType.Host, _service);

            SetButtons();
        }

        private void _service_Elapsed()
        {
            _lblCurrentTime.Text = _service.CurrentTime.ToString();
        }

        private void _btnStop_Click(object sender, EventArgs e)
        {
            _service.Stop();
            SetButtons();
        }

        public void SetButtons()
        {
            _btnStop.Enabled = _service.IsRunning;
            _btnStart.Enabled = !_service.IsRunning;
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            _service.Start();
            SetButtons();

            Forms.Table table = new ScoreTable.Forms.Table(_service, this);
            if (!CheckOpened(table))
            {
                table.Show();
                _service.SetTable(table);
                table.SetPeriodImage();
                table.FillScores();
            }
        }

        private bool CheckOpened(Forms.Table table)
        {
            FormCollection collection = Application.OpenForms;

            foreach (Form fr in collection)
            {
                if (fr.Name == table.Name)
                {
                    return true;
                }
            }

            return false;
        }

        public void ClearScores()
        {
            _home.SetScoreToZero();
            _host.SetScoreToZero();
        }
    }
}
