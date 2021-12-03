using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoreTable.Models;
using System.Windows.Forms;

namespace ScoreTable.Services
{
    public class ScoreTableService
    {
        private Timer _timer;
        private Game _model;
        private Forms.Table _table;

        public delegate void OnEdit();
        public event OnEdit Edited;

        public delegate void OnTick();
        public event OnTick Elapsed;

        public bool IsRunning { 
            get {
                return _timer.Enabled;
            } 
        }

        public void EditScore(TeamType type, int score)
        {
            Edited?.Invoke();

            switch (type)
            {
                case TeamType.Home:
                    _model.Home.Score = score;
                    break;
                case TeamType.Host:
                    _model.Host.Score = score;
                    break;
                case TeamType.None:
                    break;
            }
        }

        public void SetTeam(TeamType type, Team model)
        {
            switch (type)
            {
                case TeamType.Home:
                    _model.Home = model;
                    break;
                case TeamType.Host:
                    _model.Host = model;
                    break;
                case TeamType.None:
                    break;
            }

            Edited?.Invoke();
        }

        public Team GetTeam(TeamType type)
        {
            switch (type)
            {
                case TeamType.Home:
                    return _model.Home;
                case TeamType.Host:
                    return _model.Host;
                case TeamType.None:
                    return new Team();
                    default:
                    return null;
            }
        }

        public ScoreTableService()
        {

            _model = new Game()
            {
                Period = Models.GamePeriod.First,
                Home = new Team()
                {
                    Name = "Home",
                    Score = 0,
                },
                Host = new Team()
                {
                    Name = "Host",
                    Score = 0,
                },
                CurrentTime = new TimeSpan(0, 15, 0),
                DefaultTime = new TimeSpan(0, 15, 0),
                StartTime = DateTime.Now,
            };

            SetScoresDictionary();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
        }

        public void SetScoresDictionary(int firstHome = 0, int firstHost = 0, int secondHome = 0, int secondHost = 0, int thirdHome = 0, int thirdHost = 0)
        {
            Dictionary<GamePeriod, int[]> result = new Dictionary<GamePeriod, int[]>();
            result.Add(GamePeriod.First, new int[] {firstHome,firstHost});
            result.Add(GamePeriod.Second, new int[] { secondHome, secondHost });
            result.Add(GamePeriod.Third, new int[] { thirdHome, thirdHost });

            _model.PeriodScores = result;
        }

        public TimeSpan CurrentTime => _model.CurrentTime;
        public TimeSpan DefaultTime => _model.DefaultTime;

        public GamePeriod Period => _model.Period;

        public void Start()
        {
           _timer.Start();
            Edited?.Invoke();
        }

        public void Stop()
        {
            _timer.Stop();
            Edited?.Invoke();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            if (_model.CurrentTime.TotalSeconds > 0)
            {
                _model.CurrentTime = _model.CurrentTime - new TimeSpan(0, 0, 1);
            } else
            {
                Stop();
                _table.StopTimer();
                _table.ShowPeriodButton();

                if (_model.Period == GamePeriod.Fourth)
                {
                    _model.EndTime = DateTime.Now;
                    ScoreTable.Forms.TotalScore formTotal = new Forms.TotalScore(_table);
                    formTotal.Show();
                }
            }

            Elapsed?.Invoke();
        }

        public void SetTable(Forms.Table table)
        {
            _table = table;
        }

        public Forms.Table GetTable()
        {
            if (IsRunning)
                return _table;
            else
                return null;
        }

        public void SetCurrentTimeToDefault()
        {
            _model.CurrentTime = _model.DefaultTime;
        }

        public void NextPeriod()
        {
            switch (Period)
            {
                case GamePeriod.First:
                    _model.Period = GamePeriod.Second;
                    break;
                case GamePeriod.Second:
                    _model.Period = GamePeriod.Third;
                    break;
                case GamePeriod.Third:
                    _model.Period = GamePeriod.Fourth;
                    break;
            }
        }

        public int[] GetScoresDictionary(GamePeriod period)
        {
            switch (period)
            {
                case GamePeriod.First:
                    return _model.PeriodScores[GamePeriod.First];
                case GamePeriod.Second:
                    return _model.PeriodScores[GamePeriod.Second];
                case GamePeriod.Third:
                    return _model.PeriodScores[GamePeriod.Third];
                default:
                    return null;
            }
        }

        public string GetHomeName()
        {
            return _model.Home.Name;
        }

        public string GetHostName()
        {
            return _model.Host.Name;
        }

        public DateTime GetStartDateTime()
        {
            return _model.StartTime;
        }

        public DateTime GetEndDateTime()
        {
            return _model.EndTime;
        }
    }
}
