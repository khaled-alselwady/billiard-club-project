using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Billiard_Club_Project
{
    public partial class ucPoolTable : UserControl
    {

        private string _TableName = "Table";
        // The Category attribute tells the designer to display it in the Flash grouping.
        // The Description attribute provides a description of the property.
        [
        Category("Pool Config"),
        Description("The table Name.")
        ]
        public string TableName
        {
            get => _TableName;
            set
            {
                gbTable.Text = _TableName = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        private string _PlayerName = "Player";
        [
        Category("Pool Config"),
        Description("The Player Name.")
        ]
        public string PlayerName
        {
            get => _PlayerName;
            set
            {
                lblPlayerName.Text = _PlayerName = value;
                btnStartStop.Enabled = true;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        private float _HourlyRate = 10.00f;
        [
        Category("Pool Config"),
        Description("Rate Per Hour.")
        ]
        public float HourlyRate
        {
            get => _HourlyRate;
            set => _HourlyRate = value;
        }


        private TimeSpan _Time = TimeSpan.Zero;
        private short _TotalSecond;

        public ucPoolTable()
        {
            InitializeComponent();
        }

        #region Declare Event
        public class PoolTableEventHandler : EventArgs
        {
            public string TimeConsumed { get; }
            public short TotalSecond { get; }
            public float HourlyRate { get; }
            public float TotalFees { get; }

            public PoolTableEventHandler(string timeConsumed, short totalSecond, float hourlyRate, float totalFees)
            {
                this.TimeConsumed = timeConsumed;
                this.TotalSecond = totalSecond;
                this.HourlyRate = hourlyRate;
                this.TotalFees = totalFees;
            }
        }
        public event EventHandler<PoolTableEventHandler> OnRoundComplete;
        public void RaiseOnRoundComplete(string TimeConsumed, short TotalSecond, float HourlyRate, float TotalFees)
        {
            RaiseOnRoundComplete(new PoolTableEventHandler(TimeConsumed, TotalSecond, HourlyRate, TotalFees));
        }
        protected void RaiseOnRoundComplete(PoolTableEventHandler e)
        {
            OnRoundComplete?.Invoke(this, e);
        }
        #endregion

        private void _SetPlayerName(string PlayerName)
        {
            this.PlayerName = PlayerName;
        }

        private void _Reset()
        {
            _Time = TimeSpan.Zero;
            _TotalSecond = 0;
            gbTable.Text = "Table";
            lblPlayerName.Text = "Player";
            lblTimer.Text = "00:00:00";
            btnStartStop.Text = "Start";
            btnEnd.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Stop")
            {
                btnStartStop.Text = "Start";
                timer1.Stop();
            }
            else
            {
                btnStartStop.Text = "Stop";

                if (lblTimer.Text == "00:00:00")
                {
                    // open the form jsut one time
                    frmEnterPlayerName EnterPlayerName = new frmEnterPlayerName();
                    EnterPlayerName.PlayerNameBack += _SetPlayerName;
                    EnterPlayerName.ShowDialog();
                }

                timer1.Start();

                btnEnd.Enabled = true;
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _TotalSecond++;

            _Time = TimeSpan.FromSeconds(_TotalSecond);

            lblTimer.Text = _Time.ToString(@"hh\:mm\:ss");
            lblTimer.Refresh();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            float TotalFees = HourlyRate * (_TotalSecond / (float)3600);

            RaiseOnRoundComplete(lblTimer.Text, _TotalSecond, HourlyRate, TotalFees);

            _Reset();
        }

        private void ucPoolTable_Load(object sender, EventArgs e)
        {
            gbTable.Text = _TableName;
            lblPlayerName.Text = _PlayerName;
        }
    }
}
