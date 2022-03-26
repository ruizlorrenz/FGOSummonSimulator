using FGOSummonSimulator.Entities;
using FGOSummonSimulator.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGOSummonSimulator
{
    public partial class Dashboard : Form
    {
        List<Servant> servants = new List<Servant>();
        List<Servant> ssrServants = new List<Servant>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding() {
            testListBox.DataSource = servants;
            testListBox.DisplayMember = "Info";

            summonedListBox.DataSource = ssrServants;
            summonedListBox.DisplayMember = "Info";
        }
        // TEST CLASS
        private void testButton_Click(object sender, EventArgs e) {
            DataAccess db = new DataAccess();

            servants = db.GetServantsByName(testTextbox.Text);

            UpdateBinding();
        }

        private void multiRollButton_Click(object sender, EventArgs e) { // WIP
            DataAccess db = new DataAccess();

            //ssrServants = db.GetServantsByRarity(int.Parse(testTextbox.Text));   
            ssrServants = db.GetServantsByRarityAndLimitedYN(5, 'N');

            UpdateBinding();
        }

        private void singleRollButton_Click(object sender, EventArgs e) {
            DataAccess db = new DataAccess();
        }

        private void DetermineRoll() {

        }
    }
}
