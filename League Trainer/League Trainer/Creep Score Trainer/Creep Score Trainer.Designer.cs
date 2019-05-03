namespace League_Trainer.Creep_Score_Trainer
{
    partial class Creep_Score_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creep_Score_Trainer));
            this.gameTimeDisplay = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox_Instructions = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_recording = new System.Windows.Forms.Panel();
            this.historyGrid = new System.Windows.Forms.DataGridView();
            this.session_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS_at_10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS_missed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_CS_Scores = new System.Windows.Forms.Panel();
            this.mic_Display_Control1 = new League_Trainer.Creep_Score_Trainer.Mic_Display_Control();
            this.groupBox_Instructions.SuspendLayout();
            this.Panel_recording.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimeDisplay
            // 
            this.gameTimeDisplay.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTimeDisplay.Location = new System.Drawing.Point(353, 25);
            this.gameTimeDisplay.Mask = "00:00";
            this.gameTimeDisplay.Name = "gameTimeDisplay";
            this.gameTimeDisplay.Size = new System.Drawing.Size(116, 45);
            this.gameTimeDisplay.TabIndex = 0;
            this.gameTimeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(353, 76);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(62, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(421, 76);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(48, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // groupBox_Instructions
            // 
            this.groupBox_Instructions.Controls.Add(this.label2);
            this.groupBox_Instructions.Location = new System.Drawing.Point(12, 9);
            this.groupBox_Instructions.Name = "groupBox_Instructions";
            this.groupBox_Instructions.Size = new System.Drawing.Size(191, 573);
            this.groupBox_Instructions.TabIndex = 3;
            this.groupBox_Instructions.TabStop = false;
            this.groupBox_Instructions.Text = "Instructions";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 550);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Panel_recording
            // 
            this.Panel_recording.Controls.Add(this.mic_Display_Control1);
            this.Panel_recording.Location = new System.Drawing.Point(255, 116);
            this.Panel_recording.Name = "Panel_recording";
            this.Panel_recording.Size = new System.Drawing.Size(312, 48);
            this.Panel_recording.TabIndex = 4;
            // 
            // historyGrid
            // 
            this.historyGrid.AllowUserToAddRows = false;
            this.historyGrid.AllowUserToDeleteRows = false;
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.session_datetime,
            this.CS_at_10,
            this.CS_missed});
            this.historyGrid.Location = new System.Drawing.Point(209, 284);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.ReadOnly = true;
            this.historyGrid.Size = new System.Drawing.Size(394, 298);
            this.historyGrid.TabIndex = 5;
            // 
            // session_datetime
            // 
            this.session_datetime.HeaderText = "Time";
            this.session_datetime.Name = "session_datetime";
            this.session_datetime.ReadOnly = true;
            this.session_datetime.Width = 140;
            // 
            // CS_at_10
            // 
            this.CS_at_10.HeaderText = "CS @ 10";
            this.CS_at_10.Name = "CS_at_10";
            this.CS_at_10.ReadOnly = true;
            // 
            // CS_missed
            // 
            this.CS_missed.HeaderText = "CS Missed";
            this.CS_missed.Name = "CS_missed";
            this.CS_missed.ReadOnly = true;
            // 
            // Panel_CS_Scores
            // 
            this.Panel_CS_Scores.Location = new System.Drawing.Point(210, 175);
            this.Panel_CS_Scores.Name = "Panel_CS_Scores";
            this.Panel_CS_Scores.Size = new System.Drawing.Size(393, 96);
            this.Panel_CS_Scores.TabIndex = 6;
            // 
            // mic_Display_Control1
            // 
            this.mic_Display_Control1.Location = new System.Drawing.Point(7, 7);
            this.mic_Display_Control1.Name = "mic_Display_Control1";
            this.mic_Display_Control1.Size = new System.Drawing.Size(32, 32);
            this.mic_Display_Control1.state = League_Trainer.Creep_Score_Trainer.Mic_Display_Control.circleColor.Red;
            this.mic_Display_Control1.TabIndex = 0;
            // 
            // Creep_Score_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 594);
            this.Controls.Add(this.Panel_CS_Scores);
            this.Controls.Add(this.historyGrid);
            this.Controls.Add(this.Panel_recording);
            this.Controls.Add(this.groupBox_Instructions);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameTimeDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creep_Score_Trainer";
            this.Text = "Creep_Score_Trainer";
            this.groupBox_Instructions.ResumeLayout(false);
            this.Panel_recording.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox gameTimeDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox_Instructions;
        private System.Windows.Forms.Panel Panel_recording;
        private System.Windows.Forms.DataGridView historyGrid;
        private System.Windows.Forms.Panel Panel_CS_Scores;
        private System.Windows.Forms.DataGridViewTextBoxColumn session_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS_at_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS_missed;
        private System.Windows.Forms.Label label2;
        private Mic_Display_Control mic_Display_Control1;
    }
}