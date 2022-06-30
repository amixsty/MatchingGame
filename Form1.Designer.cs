
namespace MatchingGameAmixsty
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lbltimeleft = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(317, 123);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(13, 20);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = " ";
            // 
            // lbltimeleft
            // 
            this.lbltimeleft.AutoSize = true;
            this.lbltimeleft.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltimeleft.Location = new System.Drawing.Point(317, 215);
            this.lbltimeleft.Name = "lbltimeleft";
            this.lbltimeleft.Size = new System.Drawing.Size(23, 34);
            this.lbltimeleft.TabIndex = 1;
            this.lbltimeleft.Text = " ";
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.Color.Orange;
            this.btnrestart.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnrestart.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnrestart.Location = new System.Drawing.Point(254, 48);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(133, 38);
            this.btnrestart.TabIndex = 2;
            this.btnrestart.Text = "New Game !";
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Times Left:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lbltimeleft);
            this.Controls.Add(this.lblstatus);
            this.Name = "Form1";
            this.Text = "Matching Game Amixsty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbltimeleft;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label label1;
    }
}

