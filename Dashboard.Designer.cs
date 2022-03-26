namespace FGOSummonSimulator
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.summonedListBox = new System.Windows.Forms.ListBox();
            this.testListBox = new System.Windows.Forms.ListBox();
            this.summonSimulatorLabel = new System.Windows.Forms.Label();
            this.singleRollButton = new System.Windows.Forms.Button();
            this.multiRollButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.testTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // summonedListBox
            // 
            this.summonedListBox.FormattingEnabled = true;
            this.summonedListBox.ItemHeight = 25;
            this.summonedListBox.Location = new System.Drawing.Point(27, 111);
            this.summonedListBox.Name = "summonedListBox";
            this.summonedListBox.Size = new System.Drawing.Size(298, 279);
            this.summonedListBox.TabIndex = 0;
            // 
            // testListBox
            // 
            this.testListBox.FormattingEnabled = true;
            this.testListBox.ItemHeight = 25;
            this.testListBox.Location = new System.Drawing.Point(449, 111);
            this.testListBox.Name = "testListBox";
            this.testListBox.Size = new System.Drawing.Size(272, 279);
            this.testListBox.TabIndex = 1;
            // 
            // summonSimulatorLabel
            // 
            this.summonSimulatorLabel.AutoSize = true;
            this.summonSimulatorLabel.Location = new System.Drawing.Point(27, 13);
            this.summonSimulatorLabel.Name = "summonSimulatorLabel";
            this.summonSimulatorLabel.Size = new System.Drawing.Size(243, 25);
            this.summonSimulatorLabel.TabIndex = 2;
            this.summonSimulatorLabel.Text = "FGO Summon Simulator";
            // 
            // singleRollButton
            // 
            this.singleRollButton.Location = new System.Drawing.Point(27, 62);
            this.singleRollButton.Name = "singleRollButton";
            this.singleRollButton.Size = new System.Drawing.Size(116, 43);
            this.singleRollButton.TabIndex = 3;
            this.singleRollButton.Text = "Single";
            this.singleRollButton.UseVisualStyleBackColor = true;
            this.singleRollButton.Click += new System.EventHandler(this.singleRollButton_Click);
            // 
            // multiRollButton
            // 
            this.multiRollButton.Location = new System.Drawing.Point(209, 62);
            this.multiRollButton.Name = "multiRollButton";
            this.multiRollButton.Size = new System.Drawing.Size(116, 43);
            this.multiRollButton.TabIndex = 4;
            this.multiRollButton.Text = "Multi";
            this.multiRollButton.UseVisualStyleBackColor = true;
            this.multiRollButton.Click += new System.EventHandler(this.multiRollButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(449, 66);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(103, 39);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testTextbox
            // 
            this.testTextbox.Location = new System.Drawing.Point(449, 29);
            this.testTextbox.Name = "testTextbox";
            this.testTextbox.Size = new System.Drawing.Size(100, 31);
            this.testTextbox.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testTextbox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.multiRollButton);
            this.Controls.Add(this.singleRollButton);
            this.Controls.Add(this.summonSimulatorLabel);
            this.Controls.Add(this.testListBox);
            this.Controls.Add(this.summonedListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Text = "Summon Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox summonedListBox;
        private System.Windows.Forms.ListBox testListBox;
        private System.Windows.Forms.Label summonSimulatorLabel;
        private System.Windows.Forms.Button singleRollButton;
        private System.Windows.Forms.Button multiRollButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox testTextbox;
    }
}

