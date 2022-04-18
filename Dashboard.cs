using FGOSummonSimulator.Entities;
using FGOSummonSimulator.Utility;
using FGOSummonSimulator.Utility.Interfaces.Services;
using FGOSummonSimulator.Utility.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGOSummonSimulator {
    public partial class Dashboard : Form {
        private readonly IGetRollService _getRollService;

        Random rng = new Random();
        List<string> summoned = new List<string>(); // TESTING
        public Dashboard() {
            _getRollService = new GetRollService();
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
            for (int i = 0; i < 11; i++) {
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
                var servant = _getRollService.GetNonLimitedServant(3);
                summoned.Add(servant.Info);
                UpdateBinding();
            } else if (roll >= 40 && roll <= 79) {
                // 3 star ce
                var ce = _getRollService.GetNonLimitedCE(3);
                summoned.Add(ce.Info);
                UpdateBinding();
            } else if (roll >= 80 && roll <= 91) {
                // 4 star ce
                var ce = _getRollService.GetNonLimitedCE(4);
                summoned.Add(ce.Info);
                UpdateBinding();
            } else if (roll >= 92 && roll <= 95) {
                // 5 star ce
                var ce = _getRollService.GetNonLimitedCE(5);
                summoned.Add(ce.Info);
                UpdateBinding();
            } else if (roll >= 96 && roll <= 98) {
                // 4 star servant
                var servant = _getRollService.GetNonLimitedServant(4);
                summoned.Add(servant.Info);
                UpdateBinding();
            } else { // roll == 99
                // 5 star servant
                var servant = _getRollService.GetNonLimitedServant(5);
                summoned.Add(servant.Info);
                UpdateBinding();
            }
        }

        
    }
}
