namespace Robot
{
    partial class ToyRobot
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.Place = new System.Windows.Forms.Panel();
            this.PlaceCommand = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.clrReport = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.displayOutput = new System.Windows.Forms.TextBox();
            this.Place.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(46, 49);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            this.txtX.Text = "0";
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(46, 100);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 3;
            this.txtY.Text = "0";
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(258, 13);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 4;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.SetValues);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(258, 53);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 5;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.SetValues);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(258, 89);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 6;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.SetValues);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(258, 127);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 7;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.SetValues);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(66, 216);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<- Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.DirectionControl);
            // 
            // btnMove
            // 
            this.btnMove.Enabled = false;
            this.btnMove.Location = new System.Drawing.Point(162, 216);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 9;
            this.btnMove.Text = "Move +1";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(263, 216);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "Right ->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.DirectionControl);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(15, 318);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // Place
            // 
            this.Place.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Place.Controls.Add(this.PlaceCommand);
            this.Place.Controls.Add(this.btnNorth);
            this.Place.Controls.Add(this.btnEast);
            this.Place.Controls.Add(this.btnSouth);
            this.Place.Controls.Add(this.btnWest);
            this.Place.Location = new System.Drawing.Point(15, 12);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(391, 182);
            this.Place.TabIndex = 13;
            // 
            // PlaceCommand
            // 
            this.PlaceCommand.AutoSize = true;
            this.PlaceCommand.Location = new System.Drawing.Point(27, 119);
            this.PlaceCommand.Name = "PlaceCommand";
            this.PlaceCommand.Size = new System.Drawing.Size(150, 13);
            this.PlaceCommand.TabIndex = 17;
            this.PlaceCommand.Text = "Place Command First To Start:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.error);
            this.panel1.Location = new System.Drawing.Point(15, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 97);
            this.panel1.TabIndex = 14;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(26, 52);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(61, 13);
            this.error.TabIndex = 17;
            this.error.Text = "Error Msg";
            this.error.Visible = false;
            // 
            // clrReport
            // 
            this.clrReport.Location = new System.Drawing.Point(703, 315);
            this.clrReport.Name = "clrReport";
            this.clrReport.Size = new System.Drawing.Size(117, 23);
            this.clrReport.TabIndex = 15;
            this.clrReport.Text = "Clear";
            this.clrReport.UseVisualStyleBackColor = true;
            this.clrReport.Click += new System.EventHandler(this.ClrReport_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(156, 337);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(72, 24);
            this.result.TabIndex = 16;
            this.result.Text = "Report";
            this.result.Visible = false;
            // 
            // displayOutput
            // 
            this.displayOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.displayOutput.Location = new System.Drawing.Point(464, 12);
            this.displayOutput.Multiline = true;
            this.displayOutput.Name = "displayOutput";
            this.displayOutput.ReadOnly = true;
            this.displayOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayOutput.Size = new System.Drawing.Size(356, 285);
            this.displayOutput.TabIndex = 17;
            // 
            // ToyRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 431);
            this.Controls.Add(this.displayOutput);
            this.Controls.Add(this.result);
            this.Controls.Add(this.clrReport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.panel1);
            this.Name = "ToyRobot";
            this.Text = "Toy Robot";
            this.Place.ResumeLayout(false);
            this.Place.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel Place;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clrReport;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label PlaceCommand;
        public System.Windows.Forms.TextBox displayOutput;
        public System.Windows.Forms.TextBox txtX;
        public System.Windows.Forms.TextBox txtY;
    }
}

