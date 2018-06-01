namespace ContainerSchipNew
{
    partial class ContainerShip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddShipButton = new System.Windows.Forms.Button();
            this.ShipNummeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddContainerButton = new System.Windows.Forms.Button();
            this.CooledRadio = new System.Windows.Forms.RadioButton();
            this.ValuableRadio = new System.Windows.Forms.RadioButton();
            this.StandardRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.WeightContainerDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessagesRichbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.containerList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ContainerLabel = new System.Windows.Forms.Label();
            this.ShipLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.placeList1 = new System.Windows.Forms.ListBox();
            this.placeList2 = new System.Windows.Forms.ListBox();
            this.placeList3 = new System.Windows.Forms.ListBox();
            this.placeList4 = new System.Windows.Forms.ListBox();
            this.placeList5 = new System.Windows.Forms.ListBox();
            this.placeList6 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ContainerRow1Label = new System.Windows.Forms.Label();
            this.ContainerRow2Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipNummeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddShipButton);
            this.groupBox1.Controls.Add(this.ShipNummeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ship";
            // 
            // AddShipButton
            // 
            this.AddShipButton.Location = new System.Drawing.Point(6, 58);
            this.AddShipButton.Name = "AddShipButton";
            this.AddShipButton.Size = new System.Drawing.Size(188, 23);
            this.AddShipButton.TabIndex = 3;
            this.AddShipButton.Text = "Add";
            this.AddShipButton.UseVisualStyleBackColor = true;
            this.AddShipButton.Click += new System.EventHandler(this.AddShipButton_Click);
            // 
            // ShipNummeric
            // 
            this.ShipNummeric.Location = new System.Drawing.Point(6, 32);
            this.ShipNummeric.Maximum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.ShipNummeric.Minimum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.ShipNummeric.Name = "ShipNummeric";
            this.ShipNummeric.Size = new System.Drawing.Size(188, 20);
            this.ShipNummeric.TabIndex = 2;
            this.ShipNummeric.Value = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weight";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddContainerButton);
            this.groupBox2.Controls.Add(this.CooledRadio);
            this.groupBox2.Controls.Add(this.ValuableRadio);
            this.groupBox2.Controls.Add(this.StandardRadio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.WeightContainerDropdown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Container";
            // 
            // AddContainerButton
            // 
            this.AddContainerButton.Enabled = false;
            this.AddContainerButton.Location = new System.Drawing.Point(6, 141);
            this.AddContainerButton.Name = "AddContainerButton";
            this.AddContainerButton.Size = new System.Drawing.Size(188, 23);
            this.AddContainerButton.TabIndex = 6;
            this.AddContainerButton.Text = "Add";
            this.AddContainerButton.UseVisualStyleBackColor = true;
            this.AddContainerButton.Click += new System.EventHandler(this.AddContainerButton_Click);
            // 
            // CooledRadio
            // 
            this.CooledRadio.AutoSize = true;
            this.CooledRadio.Location = new System.Drawing.Point(6, 118);
            this.CooledRadio.Name = "CooledRadio";
            this.CooledRadio.Size = new System.Drawing.Size(58, 17);
            this.CooledRadio.TabIndex = 5;
            this.CooledRadio.TabStop = true;
            this.CooledRadio.Text = "Cooled";
            this.CooledRadio.UseVisualStyleBackColor = true;
            // 
            // ValuableRadio
            // 
            this.ValuableRadio.AutoSize = true;
            this.ValuableRadio.Location = new System.Drawing.Point(6, 95);
            this.ValuableRadio.Name = "ValuableRadio";
            this.ValuableRadio.Size = new System.Drawing.Size(66, 17);
            this.ValuableRadio.TabIndex = 4;
            this.ValuableRadio.TabStop = true;
            this.ValuableRadio.Text = "Valuable";
            this.ValuableRadio.UseVisualStyleBackColor = true;
            // 
            // StandardRadio
            // 
            this.StandardRadio.AutoSize = true;
            this.StandardRadio.Checked = true;
            this.StandardRadio.Location = new System.Drawing.Point(6, 72);
            this.StandardRadio.Name = "StandardRadio";
            this.StandardRadio.Size = new System.Drawing.Size(68, 17);
            this.StandardRadio.TabIndex = 3;
            this.StandardRadio.TabStop = true;
            this.StandardRadio.Text = "Standard";
            this.StandardRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // WeightContainerDropdown
            // 
            this.WeightContainerDropdown.FormattingEnabled = true;
            this.WeightContainerDropdown.Location = new System.Drawing.Point(6, 32);
            this.WeightContainerDropdown.Name = "WeightContainerDropdown";
            this.WeightContainerDropdown.Size = new System.Drawing.Size(188, 21);
            this.WeightContainerDropdown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Weight";
            // 
            // MessagesRichbox
            // 
            this.MessagesRichbox.Enabled = false;
            this.MessagesRichbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MessagesRichbox.Location = new System.Drawing.Point(12, 314);
            this.MessagesRichbox.Name = "MessagesRichbox";
            this.MessagesRichbox.Size = new System.Drawing.Size(200, 205);
            this.MessagesRichbox.TabIndex = 3;
            this.MessagesRichbox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Messages";
            // 
            // containerList
            // 
            this.containerList.FormattingEnabled = true;
            this.containerList.Location = new System.Drawing.Point(218, 138);
            this.containerList.Name = "containerList";
            this.containerList.Size = new System.Drawing.Size(200, 381);
            this.containerList.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Controls.Add(this.SortButton);
            this.groupBox3.Location = new System.Drawing.Point(218, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 88);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(6, 59);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(188, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Enabled = false;
            this.SortButton.Location = new System.Drawing.Point(6, 32);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(188, 23);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "List with container";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ContainerRow2Label);
            this.groupBox4.Controls.Add(this.ContainerRow1Label);
            this.groupBox4.Controls.Add(this.ContainerLabel);
            this.groupBox4.Controls.Add(this.ShipLabel);
            this.groupBox4.Location = new System.Drawing.Point(424, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(555, 88);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info";
            // 
            // ContainerLabel
            // 
            this.ContainerLabel.AutoSize = true;
            this.ContainerLabel.Location = new System.Drawing.Point(198, 16);
            this.ContainerLabel.Name = "ContainerLabel";
            this.ContainerLabel.Size = new System.Drawing.Size(70, 13);
            this.ContainerLabel.TabIndex = 1;
            this.ContainerLabel.Text = "ContainerInfo";
            // 
            // ShipLabel
            // 
            this.ShipLabel.AutoSize = true;
            this.ShipLabel.Location = new System.Drawing.Point(6, 16);
            this.ShipLabel.Name = "ShipLabel";
            this.ShipLabel.Size = new System.Drawing.Size(46, 13);
            this.ShipLabel.TabIndex = 0;
            this.ShipLabel.Text = "ShipInfo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Back of the ship";
            // 
            // placeList1
            // 
            this.placeList1.FormattingEnabled = true;
            this.placeList1.Location = new System.Drawing.Point(424, 138);
            this.placeList1.Name = "placeList1";
            this.placeList1.Size = new System.Drawing.Size(183, 160);
            this.placeList1.TabIndex = 11;
            // 
            // placeList2
            // 
            this.placeList2.FormattingEnabled = true;
            this.placeList2.Location = new System.Drawing.Point(613, 138);
            this.placeList2.Name = "placeList2";
            this.placeList2.Size = new System.Drawing.Size(187, 160);
            this.placeList2.TabIndex = 12;
            // 
            // placeList3
            // 
            this.placeList3.FormattingEnabled = true;
            this.placeList3.Location = new System.Drawing.Point(806, 138);
            this.placeList3.Name = "placeList3";
            this.placeList3.Size = new System.Drawing.Size(173, 160);
            this.placeList3.TabIndex = 13;
            // 
            // placeList4
            // 
            this.placeList4.FormattingEnabled = true;
            this.placeList4.Location = new System.Drawing.Point(424, 359);
            this.placeList4.Name = "placeList4";
            this.placeList4.Size = new System.Drawing.Size(183, 160);
            this.placeList4.TabIndex = 14;
            // 
            // placeList5
            // 
            this.placeList5.FormattingEnabled = true;
            this.placeList5.Location = new System.Drawing.Point(613, 359);
            this.placeList5.Name = "placeList5";
            this.placeList5.Size = new System.Drawing.Size(187, 160);
            this.placeList5.TabIndex = 15;
            // 
            // placeList6
            // 
            this.placeList6.FormattingEnabled = true;
            this.placeList6.Location = new System.Drawing.Point(806, 359);
            this.placeList6.Name = "placeList6";
            this.placeList6.Size = new System.Drawing.Size(173, 160);
            this.placeList6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Front of the ship";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Center of the ship";
            // 
            // ContainerRow1Label
            // 
            this.ContainerRow1Label.AutoSize = true;
            this.ContainerRow1Label.Location = new System.Drawing.Point(319, 16);
            this.ContainerRow1Label.Name = "ContainerRow1Label";
            this.ContainerRow1Label.Size = new System.Drawing.Size(98, 13);
            this.ContainerRow1Label.TabIndex = 2;
            this.ContainerRow1Label.Text = "ContainerRow1Info";
            // 
            // ContainerRow2Label
            // 
            this.ContainerRow2Label.AutoSize = true;
            this.ContainerRow2Label.Location = new System.Drawing.Point(319, 32);
            this.ContainerRow2Label.Name = "ContainerRow2Label";
            this.ContainerRow2Label.Size = new System.Drawing.Size(98, 13);
            this.ContainerRow2Label.TabIndex = 3;
            this.ContainerRow2Label.Text = "ContainerRow2Info";
            // 
            // ContainerShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(991, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.placeList6);
            this.Controls.Add(this.placeList5);
            this.Controls.Add(this.placeList4);
            this.Controls.Add(this.placeList3);
            this.Controls.Add(this.placeList2);
            this.Controls.Add(this.placeList1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.containerList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessagesRichbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ContainerShip";
            this.Text = "Container ship";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipNummeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ShipNummeric;
        private System.Windows.Forms.Button AddShipButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WeightContainerDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton StandardRadio;
        private System.Windows.Forms.RadioButton ValuableRadio;
        private System.Windows.Forms.RadioButton CooledRadio;
        private System.Windows.Forms.Button AddContainerButton;
        private System.Windows.Forms.RichTextBox MessagesRichbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox containerList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ShipLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox placeList1;
        private System.Windows.Forms.ListBox placeList2;
        private System.Windows.Forms.ListBox placeList3;
        private System.Windows.Forms.ListBox placeList4;
        private System.Windows.Forms.ListBox placeList5;
        private System.Windows.Forms.ListBox placeList6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ContainerLabel;
        private System.Windows.Forms.Label ContainerRow1Label;
        private System.Windows.Forms.Label ContainerRow2Label;
    }
}

