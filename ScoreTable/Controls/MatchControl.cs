using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreTable.Models;
using ScoreTable.Services;

namespace ScoreTable.Controls
{
    public partial class MatchControl : UserControl
    {
        public MatchControl()
        {
            InitializeComponent();
        }

        public void Init(TeamType type, ScoreTableService service)
        {
            var team = service.GetTeam(type);

            _lblState.Text = type.ToString();
            _lblName.Text = team.Name;
            _lblScore.Text = team.Score.ToString();
        }

        public void AddPoint()
        {
            int points = Convert.ToInt32(_lblScore.Text) + 1;
            _lblScore.Text = points.ToString();
        }

        public string GetPoints()
        {
            return _lblScore.Text;
        }

        public void SetPointsToZero()
        {
            _lblScore.Text = "0";
        }

    }
}
