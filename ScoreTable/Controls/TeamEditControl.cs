using ScoreTable.Models;
using ScoreTable.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTable.Controls
{
    public partial class TeamEditControl : UserControl
    {
        public TeamEditControl()
        {
            InitializeComponent();
        }

        TeamType _type;
        ScoreTableService _service;

        public void Init(TeamType type, ScoreTableService service)
        {
            _type = type;
            _service = service;

            UpdateUi();
        }

        private void UpdateUi()
        {
            var team = _service.GetTeam(_type);

            _lblTeamType.Text = _type.ToString();
            _txtTeamName.Text = team.Name;
            _numScore.Value = team.Score;
        }

        private void _numScore_ValueChanged(object sender, EventArgs e)
        {
            _service.EditScore(_type, Convert.ToInt32(_numScore.Value));
        }

        private void _btnApply_Click(object sender, EventArgs e)
        {
            _service.SetTeam(_type, new Team()
            {
                Name = _txtTeamName.Text,
                Score = Convert.ToInt32(_numScore.Value),
            });
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            _numScore.Value++;
            if (_service.IsRunning)
            {
                _service.GetTable().AddPoint(_type);
            }
        }

        public void SetScoreToZero()
        {
            _numScore.Value = 0;
        }
    }
}
