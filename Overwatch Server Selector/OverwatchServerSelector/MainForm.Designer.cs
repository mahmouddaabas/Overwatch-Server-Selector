namespace OverwatchServerSelector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.background_picturebox = new System.Windows.Forms.PictureBox();
            this.playNA_btn = new System.Windows.Forms.Button();
            this.playMENA_btn = new System.Windows.Forms.Button();
            this.unblock_btn = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // background_picturebox
            // 
            this.background_picturebox.Image = global::OverwatchServerSelector.Properties.Resources.background;
            this.background_picturebox.Location = new System.Drawing.Point(-2, -1);
            this.background_picturebox.Name = "background_picturebox";
            this.background_picturebox.Size = new System.Drawing.Size(803, 565);
            this.background_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_picturebox.TabIndex = 0;
            this.background_picturebox.TabStop = false;
            // 
            // playNA_btn
            // 
            this.playNA_btn.BackColor = System.Drawing.Color.Transparent;
            this.playNA_btn.BackgroundImage = global::OverwatchServerSelector.Properties.Resources.background;
            this.playNA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playNA_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playNA_btn.ForeColor = System.Drawing.Color.White;
            this.playNA_btn.Location = new System.Drawing.Point(71, 69);
            this.playNA_btn.Name = "playNA_btn";
            this.playNA_btn.Size = new System.Drawing.Size(146, 54);
            this.playNA_btn.TabIndex = 1;
            this.playNA_btn.Text = "Play NA";
            this.playNA_btn.UseVisualStyleBackColor = false;
            this.playNA_btn.Click += new System.EventHandler(this.playNA_btn_Click);
            // 
            // playMENA_btn
            // 
            this.playMENA_btn.BackColor = System.Drawing.Color.Transparent;
            this.playMENA_btn.BackgroundImage = global::OverwatchServerSelector.Properties.Resources.background;
            this.playMENA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playMENA_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playMENA_btn.ForeColor = System.Drawing.Color.White;
            this.playMENA_btn.Location = new System.Drawing.Point(71, 149);
            this.playMENA_btn.Name = "playMENA_btn";
            this.playMENA_btn.Size = new System.Drawing.Size(146, 56);
            this.playMENA_btn.TabIndex = 4;
            this.playMENA_btn.Text = "Play Middle East";
            this.playMENA_btn.UseVisualStyleBackColor = false;
            this.playMENA_btn.Click += new System.EventHandler(this.playMENA_btn_Click);
            // 
            // unblock_btn
            // 
            this.unblock_btn.BackColor = System.Drawing.Color.Transparent;
            this.unblock_btn.BackgroundImage = global::OverwatchServerSelector.Properties.Resources.background;
            this.unblock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unblock_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unblock_btn.ForeColor = System.Drawing.Color.White;
            this.unblock_btn.Location = new System.Drawing.Point(318, 486);
            this.unblock_btn.Name = "unblock_btn";
            this.unblock_btn.Size = new System.Drawing.Size(146, 56);
            this.unblock_btn.TabIndex = 6;
            this.unblock_btn.Text = "Unblock All";
            this.unblock_btn.UseVisualStyleBackColor = false;
            this.unblock_btn.Click += new System.EventHandler(this.unblock_btn_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.BackColor = System.Drawing.Color.Transparent;
            this.info_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info_label.ForeColor = System.Drawing.Color.White;
            this.info_label.Image = global::OverwatchServerSelector.Properties.Resources.label_color;
            this.info_label.Location = new System.Drawing.Point(517, 504);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(162, 21);
            this.info_label.TabIndex = 7;
            this.info_label.Text = "No servers selected.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 564);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.unblock_btn);
            this.Controls.Add(this.playMENA_btn);
            this.Controls.Add(this.playNA_btn);
            this.Controls.Add(this.background_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Overwatch Server Selector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.background_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox background_picturebox;
        private Button playNA_btn;
        private Button playMENA_btn;
        private Button unblock_btn;
        private Label info_label;
    }
}