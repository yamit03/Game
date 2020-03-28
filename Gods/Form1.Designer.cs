namespace Gods
{
    partial class Form1
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
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.line = new System.Windows.Forms.Label();
            this.scr1 = new System.Windows.Forms.Label();
            this.scr2 = new System.Windows.Forms.Label();
            this.turnof = new System.Windows.Forms.Label();
            this.turnofpl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first.Font = new System.Drawing.Font("Microsoft Yi Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.first.Location = new System.Drawing.Point(1389, 178);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(133, 97);
            this.first.TabIndex = 0;
            this.first.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.first.Click += new System.EventHandler(this.First_Click);
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.second.Font = new System.Drawing.Font("Microsoft Yi Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.second.Location = new System.Drawing.Point(1389, 292);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(133, 95);
            this.second.TabIndex = 0;
            this.second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.second.Click += new System.EventHandler(this.Second_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(70, -21);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1165, 134);
            this.line.TabIndex = 1;
            this.line.Text = "Memory Game";
            this.line.Click += new System.EventHandler(this.Line_Click);
            // 
            // scr1
            // 
            this.scr1.BackColor = System.Drawing.Color.Transparent;
            this.scr1.Font = new System.Drawing.Font("Parchment", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr1.Location = new System.Drawing.Point(1141, 178);
            this.scr1.Name = "scr1";
            this.scr1.Size = new System.Drawing.Size(244, 89);
            this.scr1.TabIndex = 2;
            this.scr1.Text = "score of player 1:";
            this.scr1.Click += new System.EventHandler(this.Scr1_Click);
            // 
            // scr2
            // 
            this.scr2.BackColor = System.Drawing.Color.Transparent;
            this.scr2.Font = new System.Drawing.Font("Parchment", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr2.Location = new System.Drawing.Point(1141, 298);
            this.scr2.Name = "scr2";
            this.scr2.Size = new System.Drawing.Size(244, 89);
            this.scr2.TabIndex = 3;
            this.scr2.Text = "score of player 2:";
            this.scr2.Click += new System.EventHandler(this.Scr2_Click);
            // 
            // turnof
            // 
            this.turnof.BackColor = System.Drawing.Color.Transparent;
            this.turnof.Font = new System.Drawing.Font("Parchment", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnof.Location = new System.Drawing.Point(1622, 72);
            this.turnof.Name = "turnof";
            this.turnof.Size = new System.Drawing.Size(313, 89);
            this.turnof.TabIndex = 5;
            this.turnof.Text = "Turn of player:";
            // 
            // turnofpl
            // 
            this.turnofpl.BackColor = System.Drawing.Color.Bisque;
            this.turnofpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnofpl.Font = new System.Drawing.Font("Microsoft Yi Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnofpl.ForeColor = System.Drawing.Color.Black;
            this.turnofpl.Location = new System.Drawing.Point(1696, 161);
            this.turnofpl.Name = "turnofpl";
            this.turnofpl.Size = new System.Drawing.Size(133, 97);
            this.turnofpl.TabIndex = 6;
            this.turnofpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gods.Properties.Resources.olympus;
            this.ClientSize = new System.Drawing.Size(1924, 513);
            this.Controls.Add(this.turnofpl);
            this.Controls.Add(this.turnof);
            this.Controls.Add(this.scr2);
            this.Controls.Add(this.scr1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label scr1;
        private System.Windows.Forms.Label scr2;
        private System.Windows.Forms.Label turnof;
        private System.Windows.Forms.Label turnofpl;
    }
}

