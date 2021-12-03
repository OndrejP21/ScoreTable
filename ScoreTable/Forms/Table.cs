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
using ScoreTable.Services;

namespace ScoreTable.Forms
{
    public partial class Table : Form
    {
        ScoreTable.Services.ScoreTableService _service;
        private Form1 _form;

        public Table(ScoreTable.Services.ScoreTableService service, Form1 form)
        {
            _service = service;
            _form = form;
            InitializeComponent();
            SetMatches();
            SetPeriodImage();
            FillScores();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;

            if (_service.IsRunning)
                _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _lblTime.Text = _service.CurrentTime.ToString();

        }

        private void SetMatches()
        {
            _lblTime.Text = _service.CurrentTime.ToString();
            _matchHome.Init(Models.TeamType.Home, _service);
            _matchHost.Init(Models.TeamType.Host, _service);
        }

        public void SetPeriodImage()
        {
            switch (_service.Period)
            {
                case Models.GamePeriod.First:
                    _pctPeriod1.Visible = true;
                    break;
                case Models.GamePeriod.Second:
                    _pctPeriod1.Visible = false;
                    _pctPeriod2.Visible = true;
                    break;
                case Models.GamePeriod.Third:
                    _pctPeriod2.Visible= false;
                    _pctPeriod3.Visible = true;
                    break;
                case Models.GamePeriod.Fourth:
                    _pctPeriod3.Visible= false;
                    _pctPeriod4.Visible = true;
                    break;
            }
        }

        public void AddPoint(Models.TeamType type)
        {
            switch (type)
            {
                case Models.TeamType.Home:
                    _matchHome.AddPoint();
                    break;
                case Models.TeamType.Host:
                    _matchHost.AddPoint();
                    break;
            }
        }

        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            SetScoresToDictionary();
            _service.Stop();
            _form.SetButtons();
            _timer.Stop();
        }

        public void StopTimer()
        {
            _timer.Stop();
        }

        public void StartTimer()
        {
            if (_service.CurrentTime != new TimeSpan(0, 0, 0))
                _timer.Start();
        }

        private void _btnNextPeriod_Click(object sender, EventArgs e)
        {
            if (_service.Period == Models.GamePeriod.Fourth)
            {
                //TODO: Dodělat ukládání výsledků do souboru!

                SaveFile();
            } else
            {
                switch (_service.Period)
                {
                    case Models.GamePeriod.First:
                        _lblFirstHome.Text = _matchHome.GetPoints();
                        _lblFirstHost.Text = _matchHost.GetPoints();
                        break;
                    case Models.GamePeriod.Second:
                        _lblSecondHome.Text = _matchHome.GetPoints();
                        _lblSecondHost.Text = _matchHost.GetPoints();
                        break;
                    case Models.GamePeriod.Third:
                        _lblThirdHome.Text = _matchHome.GetPoints();
                        _lblThirdHost.Text = _matchHost.GetPoints();
                        break;
                }

                _matchHome.SetPointsToZero();
                _matchHost.SetPointsToZero();

                _service.SetCurrentTimeToDefault();
                _service.Start();
                StartTimer();
                _form.ClearScores();
                _service.NextPeriod();
                SetPeriodImage();
            }

            HidePeriodButton();
        }

        public void HidePeriodButton()
        {
            if (_service.Period == Models.GamePeriod.Fourth)
                _btnNextPeriod.Text = "Export to file";
            _btnNextPeriod.Visible = false;
        }

        public void ShowPeriodButton()
        {
            _btnNextPeriod.Visible = true;
        }

        private void SetScoresToDictionary()
        {
            int firstHome = Convert.ToInt32(_lblFirstHome.Text);
            int firstHost = Convert.ToInt32(_lblFirstHost.Text);
            int secondHome = Convert.ToInt32(_lblSecondHome.Text);
            int secondHost = Convert.ToInt32(_lblSecondHost.Text);
            int thirdHome = Convert.ToInt32(_lblThirdHome.Text);
            int thirdHost = Convert.ToInt32(_lblThirdHost.Text);
            _service.SetScoresDictionary(firstHome, firstHost, secondHome, secondHost, thirdHome, thirdHost);
        }

        public void FillScores()
        {
            _lblFirstHome.Text = _service.GetScoresDictionary(Models.GamePeriod.First)[0].ToString();
            _lblFirstHost.Text = _service.GetScoresDictionary(Models.GamePeriod.First)[1].ToString();
            _lblSecondHome.Text = _service.GetScoresDictionary(Models.GamePeriod.Second)[0].ToString();
            _lblSecondHost.Text = _service.GetScoresDictionary(Models.GamePeriod.Second)[1].ToString();
            _lblThirdHome.Text = _service.GetScoresDictionary(Models.GamePeriod.Third)[0].ToString();
            _lblThirdHost.Text = _service.GetScoresDictionary(Models.GamePeriod.Third)[1].ToString();
        }

        public int GetTotalHome()
        {
            int total = 0;

            total += Convert.ToInt32(_lblFirstHome.Text);
            total += Convert.ToInt32(_lblSecondHome.Text);
            total += Convert.ToInt32(_lblThirdHome.Text);
            total += Convert.ToInt32(_matchHome.GetPoints());

            return total;
        }

        public int GetTotalHost()
        {
            int total = 0;

            total += Convert.ToInt32(_lblFirstHost.Text);
            total += Convert.ToInt32(_lblSecondHost.Text);
            total += Convert.ToInt32(_lblThirdHost.Text);
            total += Convert.ToInt32(_matchHost.GetPoints());

            return total;
        }

        public string[] GetAllScores()
        {
            string[] array = new string[8];
            array[0] = _lblFirstHome.Text;
            array[1] = _lblFirstHost.Text;
            array[2] = _lblSecondHome.Text;
            array[3] = _lblSecondHost.Text;
            array[4] = _lblThirdHome.Text;
            array[5] = _lblThirdHost.Text;
            array[6] = _matchHome.GetPoints();
            array[7] = _matchHost.GetPoints();

            return array;
        }

        private Form _export;

        private void SaveFile()
        {
            _export = new Form();
            _export.Size = new Size(200, 200);
            _export.Name = "export";
            _export.Text = "Export File";
            Label lbl = new Label();
            lbl.Text = "Enter name of File:";
            lbl.Location = new Point(20, 20);
            TextBox txtBox = new TextBox();
            txtBox.Name = "_txtInput";
            txtBox.Location = new Point(20, 40);
            txtBox.PlaceholderText = "Name of File";
            Button btn = new Button();
            btn.Size = new Size(70, 40);
            btn.Location = new Point(20, 110);
            btn.Text = "Save";
            Label lblInfo = new Label();
            lblInfo.Location = new Point(20, 90);
            lblInfo.Text = "Write name of File!";
            lblInfo.Visible = false;
            _export.Controls.Add(lbl);
            _export.Controls.Add(txtBox);
            _export.Controls.Add(btn);
            _export.Controls.Add(lblInfo);

            btn.Click += Btn_Click;
            txtBox.TextChanged += TxtBox_TextChanged;
            _export.Show();
        }

        private void TxtBox_TextChanged(object? sender, EventArgs e)
        {
            Label lbl = (Label)_export.Controls[3];
            if (lbl.Visible)
                lbl.Visible = false;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            TextBox txtBox = (TextBox) _export.Controls[1];
            if (txtBox.Name == "_txtInput" && !string.IsNullOrWhiteSpace(txtBox.Text))
            {

                SaveFileService save = new SaveFileService();
                string path = save.GetPath();
                if (string.IsNullOrWhiteSpace(path)){
                    MessageBox.Show("You don't choose any Path!", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                } else
                {

                    string pathFull = Path.Combine(path, txtBox.Text, ".txt");

                    if (File.Exists(pathFull)) {
                        MessageBox.Show("This file is already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        
                        save.CreateFile(pathFull, save.ArrayToSave(this, _service, _service.GetEndDateTime()));
                    }

                }
            } else
            {
                Label lbl = (Label) _export.Controls[3];

                lbl.Visible = true;
            }
        }
    }
}
