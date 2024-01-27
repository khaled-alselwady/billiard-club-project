using System.Windows.Forms;
using static Billiard_Club_Project.ucPoolTable;

namespace Billiard_Club_Project
{
    public partial class frmBilliardClub : Form
    {
        public frmBilliardClub()
        {
            InitializeComponent();
        }
       
        private void ucPoolTable1_OnRoundComplete_1(object sender, PoolTableEventHandler e)
        {
            MessageBox.Show($"Total Consumed {e.TimeConsumed}, Total Seconds = {e.TotalSecond}," +
                            $" Houlry Rate = {e.HourlyRate}, Tootal Fees = {e.TotalFees}");
        }
    }
}
