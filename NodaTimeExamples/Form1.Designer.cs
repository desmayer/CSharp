namespace NodaTimeExamples
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
            this.txtFormattedDate = new System.Windows.Forms.TextBox();
            this.cmbCultures = new System.Windows.Forms.ComboBox();
            this.txtCultureInfo = new System.Windows.Forms.TextBox();
            this.txtNodaTimeInstant = new System.Windows.Forms.TextBox();
            this.txtTimeZoneInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFormattedDate
            // 
            this.txtFormattedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormattedDate.Location = new System.Drawing.Point(136, 145);
            this.txtFormattedDate.Name = "txtFormattedDate";
            this.txtFormattedDate.Size = new System.Drawing.Size(358, 23);
            this.txtFormattedDate.TabIndex = 0;
            // 
            // cmbCultures
            // 
            this.cmbCultures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCultures.FormattingEnabled = true;
            this.cmbCultures.Location = new System.Drawing.Point(136, 112);
            this.cmbCultures.Name = "cmbCultures";
            this.cmbCultures.Size = new System.Drawing.Size(224, 24);
            this.cmbCultures.TabIndex = 2;
            this.cmbCultures.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCultureInfo
            // 
            this.txtCultureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCultureInfo.Location = new System.Drawing.Point(136, 174);
            this.txtCultureInfo.Multiline = true;
            this.txtCultureInfo.Name = "txtCultureInfo";
            this.txtCultureInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCultureInfo.Size = new System.Drawing.Size(437, 73);
            this.txtCultureInfo.TabIndex = 3;
            // 
            // txtNodaTimeInstant
            // 
            this.txtNodaTimeInstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodaTimeInstant.Location = new System.Drawing.Point(136, 46);
            this.txtNodaTimeInstant.Name = "txtNodaTimeInstant";
            this.txtNodaTimeInstant.Size = new System.Drawing.Size(358, 23);
            this.txtNodaTimeInstant.TabIndex = 4;
            // 
            // txtTimeZoneInfo
            // 
            this.txtTimeZoneInfo.Location = new System.Drawing.Point(136, 253);
            this.txtTimeZoneInfo.Multiline = true;
            this.txtTimeZoneInfo.Name = "txtTimeZoneInfo";
            this.txtTimeZoneInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimeZoneInfo.Size = new System.Drawing.Size(437, 188);
            this.txtTimeZoneInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "NodaTime && CultureInfo Examples";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Zone";
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(136, 78);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(224, 24);
            this.cmbTimeZone.TabIndex = 9;
            this.cmbTimeZone.SelectedIndexChanged += new System.EventHandler(this.cmbTimeZone_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Culture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Formatted Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Culture Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "NodaTime Info\r\nDateTime > Instant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTimeZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeZoneInfo);
            this.Controls.Add(this.txtNodaTimeInstant);
            this.Controls.Add(this.txtCultureInfo);
            this.Controls.Add(this.cmbCultures);
            this.Controls.Add(this.txtFormattedDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormattedDate;
        private System.Windows.Forms.ComboBox cmbCultures;
        private System.Windows.Forms.TextBox txtCultureInfo;
        private System.Windows.Forms.TextBox txtNodaTimeInstant;
        private System.Windows.Forms.TextBox txtTimeZoneInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

