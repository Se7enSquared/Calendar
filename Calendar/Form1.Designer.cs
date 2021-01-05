namespace Calendar
{
  partial class frmDate
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
            this.components = new System.ComponentModel.Container();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDayOfMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(107, 71);
            this.lblDayOfWeek.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(81, 29);
            this.lblDayOfWeek.TabIndex = 0;
            this.lblDayOfWeek.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(114, 178);
            this.lblTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 29);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label2";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(716, 71);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(81, 29);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "label3";
            // 
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.AutoSize = true;
            this.lblDayOfMonth.Location = new System.Drawing.Point(723, 178);
            this.lblDayOfMonth.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDayOfMonth.Name = "lblDayOfMonth";
            this.lblDayOfMonth.Size = new System.Drawing.Size(81, 29);
            this.lblDayOfMonth.TabIndex = 3;
            this.lblDayOfMonth.Text = "label4";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(723, 294);
            this.lblYear.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 29);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "label5";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(121, 477);
            this.btnStart.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 51);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timTime
            // 
            this.timTime.Interval = 1000;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 627);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDayOfMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDayOfWeek);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDayOfMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timTime;
    }
}

