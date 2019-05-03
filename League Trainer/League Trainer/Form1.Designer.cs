namespace League_Trainer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_show_map_awareness_trainer = new System.Windows.Forms.Button();
            this.button_show_CS_Trainer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_show_map_awareness_trainer);
            this.groupBox1.Controls.Add(this.button_show_CS_Trainer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainers";
            // 
            // button_show_map_awareness_trainer
            // 
            this.button_show_map_awareness_trainer.Image = global::League_Trainer.Properties.Resources.map;
            this.button_show_map_awareness_trainer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_show_map_awareness_trainer.Location = new System.Drawing.Point(113, 32);
            this.button_show_map_awareness_trainer.Name = "button_show_map_awareness_trainer";
            this.button_show_map_awareness_trainer.Size = new System.Drawing.Size(91, 92);
            this.button_show_map_awareness_trainer.TabIndex = 1;
            this.button_show_map_awareness_trainer.Text = "Map Awareness";
            this.button_show_map_awareness_trainer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_show_map_awareness_trainer.UseVisualStyleBackColor = true;
            this.button_show_map_awareness_trainer.Click += new System.EventHandler(this.Button_show_map_awareness_trainer_Click);
            // 
            // button_show_CS_Trainer
            // 
            this.button_show_CS_Trainer.Image = global::League_Trainer.Properties.Resources.coins;
            this.button_show_CS_Trainer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_show_CS_Trainer.Location = new System.Drawing.Point(16, 32);
            this.button_show_CS_Trainer.Name = "button_show_CS_Trainer";
            this.button_show_CS_Trainer.Size = new System.Drawing.Size(91, 92);
            this.button_show_CS_Trainer.TabIndex = 0;
            this.button_show_CS_Trainer.Text = "Creep Score";
            this.button_show_CS_Trainer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_show_CS_Trainer.UseVisualStyleBackColor = true;
            this.button_show_CS_Trainer.Click += new System.EventHandler(this.Button_show_CS_Trainer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "League Trainer";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_show_map_awareness_trainer;
        private System.Windows.Forms.Button button_show_CS_Trainer;
    }
}

