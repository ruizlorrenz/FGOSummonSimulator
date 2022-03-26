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
        Rolls rolls = new Rolls();
        Random rng = new Random();
        List<string> summoned = new List<string>(); // TESTING
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding() {
            var bs = new BindingSource();
            bs.DataSource = summoned;
            summonedListBox.DataSource = bs;
        }

        private void multiRollButton_Click(object sender, EventArgs e) { // WIP
            summoned.Clear();
            for(int i = 0; i < 11; i++) {
                DetermineRoll();
            }
        }

        private void singleRollButton_Click(object sender, EventArgs e) {
            summoned.Clear();
            DetermineRoll();
        }

        private void DetermineRoll() {
            int roll = rng.Next(0, 100);

            if (roll >= 0 && roll <= 39) {
                // 3 star servant
                //var ce = rolls.Get3StarCE();
                var servant = rolls.GetNonLimitedServant(3);
                summoned.Add(servant.Info);
                UpdateBinding();
            } else if(roll >= 40 && roll <= 79) {
                // 3 star ce
                //MessageBox.Show($"3 STAR CE ({roll})");
                var ce = rolls.GetNonLimitedCE(3);
                summoned.Add(ce.Info);
                UpdateBinding();
            } else if(roll >= 80 && roll <= 91) {
                // 4 star ce
                //MessageBox.Show($"4 STAR CE ({roll})");
                var ce = rolls.GetNonLimitedCE(4);
                summoned.Add(ce.Info);
                UpdateBinding();
            } else if(roll >= 92 && roll <= 95) {
                // 5 star ce
                //MessageBox.Show($"5 STAR CE ({roll})");
                var ce = rolls.GetNonLimitedCE(5);
                summoned.Add(ce.Info);
                UpdateBinding();
            } else if (roll >= 96 && roll <= 98) {
                // 4 star servant
                //MessageBox.Show($"4 STAR SERVANT ({roll})");
                var servant = rolls.GetNonLimitedServant(4);
                summoned.Add(servant.Info);
                UpdateBinding();
            } else { // roll == 99
                // 5 star servant
                //MessageBox.Show($"5 STAR SERVANT ({roll})");
                var servant = rolls.GetNonLimitedServant(5);
                summoned.Add(servant.Info);
                UpdateBinding();
            }
        }
    }
}
