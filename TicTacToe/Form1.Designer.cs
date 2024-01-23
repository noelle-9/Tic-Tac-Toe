namespace TicTacToe
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
            components = new System.ComponentModel.Container();
            gameSetup = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            resetBtn = new Button();
            startBtn = new Button();
            p2SymbolText = new TextBox();
            p1SymbolText = new TextBox();
            p2NameText = new TextBox();
            p1NameText = new TextBox();
            gameArea = new GroupBox();
            currentTurnText = new TextBox();
            label8 = new Label();
            btnBR = new Button();
            btnBC = new Button();
            btnBL = new Button();
            btnCR = new Button();
            btnCC = new Button();
            btnCL = new Button();
            btnTR = new Button();
            btnTC = new Button();
            btnTL = new Button();
            gameResult = new GroupBox();
            label5 = new Label();
            contBtn = new Button();
            winnerText = new TextBox();
            gameStats = new GroupBox();
            overallWText = new TextBox();
            label6 = new Label();
            statsListBox = new ListBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            toolTip6 = new ToolTip(components);
            toolTip7 = new ToolTip(components);
            gameSetup.SuspendLayout();
            gameArea.SuspendLayout();
            gameResult.SuspendLayout();
            gameStats.SuspendLayout();
            SuspendLayout();
            // 
            // gameSetup
            // 
            gameSetup.BackColor = Color.AntiqueWhite;
            gameSetup.Controls.Add(label4);
            gameSetup.Controls.Add(label3);
            gameSetup.Controls.Add(label2);
            gameSetup.Controls.Add(label1);
            gameSetup.Controls.Add(resetBtn);
            gameSetup.Controls.Add(startBtn);
            gameSetup.Controls.Add(p2SymbolText);
            gameSetup.Controls.Add(p1SymbolText);
            gameSetup.Controls.Add(p2NameText);
            gameSetup.Controls.Add(p1NameText);
            gameSetup.Location = new Point(14, 12);
            gameSetup.Name = "gameSetup";
            gameSetup.Size = new Size(526, 145);
            gameSetup.TabIndex = 0;
            gameSetup.TabStop = false;
            gameSetup.Text = "Game Setup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 89);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "P2 Symbol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "P1 Symbol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 23);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 7;
            label2.Text = "P2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 6;
            label1.Text = "P1";
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(255, 192, 192);
            resetBtn.Location = new Point(207, 93);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(124, 40);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "&Reset";
            toolTip6.SetToolTip(resetBtn, "Resets The Form");
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(255, 192, 192);
            startBtn.Location = new Point(207, 47);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(124, 40);
            startBtn.TabIndex = 4;
            startBtn.Text = "&Start";
            toolTip5.SetToolTip(startBtn, "Starts The Game");
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // p2SymbolText
            // 
            p2SymbolText.Location = new Point(379, 112);
            p2SymbolText.Name = "p2SymbolText";
            p2SymbolText.Size = new Size(140, 27);
            p2SymbolText.TabIndex = 3;
            toolTip4.SetToolTip(p2SymbolText, "Enter Player 2 Symbol");
            // 
            // p1SymbolText
            // 
            p1SymbolText.Location = new Point(7, 112);
            p1SymbolText.Name = "p1SymbolText";
            p1SymbolText.Size = new Size(140, 27);
            p1SymbolText.TabIndex = 2;
            toolTip3.SetToolTip(p1SymbolText, "Enter Player 1 Symbol");
            // 
            // p2NameText
            // 
            p2NameText.Location = new Point(379, 47);
            p2NameText.Name = "p2NameText";
            p2NameText.Size = new Size(140, 27);
            p2NameText.TabIndex = 1;
            toolTip2.SetToolTip(p2NameText, "Enter Player 2 Name");
            // 
            // p1NameText
            // 
            p1NameText.Location = new Point(7, 47);
            p1NameText.Name = "p1NameText";
            p1NameText.Size = new Size(140, 27);
            p1NameText.TabIndex = 0;
            toolTip1.SetToolTip(p1NameText, "Enter Player 1 Name");
            // 
            // gameArea
            // 
            gameArea.Controls.Add(currentTurnText);
            gameArea.Controls.Add(label8);
            gameArea.Controls.Add(btnBR);
            gameArea.Controls.Add(btnBC);
            gameArea.Controls.Add(btnBL);
            gameArea.Controls.Add(btnCR);
            gameArea.Controls.Add(btnCC);
            gameArea.Controls.Add(btnCL);
            gameArea.Controls.Add(btnTR);
            gameArea.Controls.Add(btnTC);
            gameArea.Controls.Add(btnTL);
            gameArea.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point);
            gameArea.Location = new Point(14, 163);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(387, 370);
            gameArea.TabIndex = 1;
            gameArea.TabStop = false;
            // 
            // currentTurnText
            // 
            currentTurnText.Enabled = false;
            currentTurnText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            currentTurnText.Location = new Point(133, 0);
            currentTurnText.Name = "currentTurnText";
            currentTurnText.ReadOnly = true;
            currentTurnText.Size = new Size(245, 27);
            currentTurnText.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(0, -3);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 18;
            label8.Text = "Current Turn";
            // 
            // btnBR
            // 
            btnBR.Enabled = false;
            btnBR.Location = new Point(259, 258);
            btnBR.Name = "btnBR";
            btnBR.Size = new Size(119, 107);
            btnBR.TabIndex = 17;
            btnBR.TabStop = false;
            btnBR.UseVisualStyleBackColor = true;
            btnBR.Click += btn_Click;
            // 
            // btnBC
            // 
            btnBC.Enabled = false;
            btnBC.Location = new Point(133, 258);
            btnBC.Name = "btnBC";
            btnBC.Size = new Size(119, 107);
            btnBC.TabIndex = 16;
            btnBC.TabStop = false;
            btnBC.UseVisualStyleBackColor = true;
            btnBC.Click += btn_Click;
            // 
            // btnBL
            // 
            btnBL.Enabled = false;
            btnBL.Location = new Point(7, 258);
            btnBL.Name = "btnBL";
            btnBL.Size = new Size(119, 107);
            btnBL.TabIndex = 15;
            btnBL.TabStop = false;
            btnBL.UseVisualStyleBackColor = true;
            btnBL.Click += btn_Click;
            // 
            // btnCR
            // 
            btnCR.Enabled = false;
            btnCR.Location = new Point(259, 145);
            btnCR.Name = "btnCR";
            btnCR.Size = new Size(119, 107);
            btnCR.TabIndex = 14;
            btnCR.TabStop = false;
            btnCR.UseVisualStyleBackColor = true;
            btnCR.Click += btn_Click;
            // 
            // btnCC
            // 
            btnCC.Enabled = false;
            btnCC.Location = new Point(133, 145);
            btnCC.Name = "btnCC";
            btnCC.Size = new Size(119, 107);
            btnCC.TabIndex = 13;
            btnCC.TabStop = false;
            btnCC.UseVisualStyleBackColor = true;
            btnCC.Click += btn_Click;
            // 
            // btnCL
            // 
            btnCL.Enabled = false;
            btnCL.Location = new Point(7, 145);
            btnCL.Name = "btnCL";
            btnCL.Size = new Size(119, 107);
            btnCL.TabIndex = 12;
            btnCL.TabStop = false;
            btnCL.UseVisualStyleBackColor = true;
            btnCL.Click += btn_Click;
            // 
            // btnTR
            // 
            btnTR.Enabled = false;
            btnTR.Location = new Point(259, 32);
            btnTR.Name = "btnTR";
            btnTR.Size = new Size(119, 107);
            btnTR.TabIndex = 11;
            btnTR.TabStop = false;
            btnTR.UseVisualStyleBackColor = true;
            btnTR.Click += btn_Click;
            // 
            // btnTC
            // 
            btnTC.Enabled = false;
            btnTC.Location = new Point(133, 32);
            btnTC.Name = "btnTC";
            btnTC.Size = new Size(119, 107);
            btnTC.TabIndex = 10;
            btnTC.TabStop = false;
            btnTC.UseVisualStyleBackColor = true;
            btnTC.Click += btn_Click;
            // 
            // btnTL
            // 
            btnTL.Enabled = false;
            btnTL.Location = new Point(7, 32);
            btnTL.Name = "btnTL";
            btnTL.Size = new Size(119, 107);
            btnTL.TabIndex = 9;
            btnTL.TabStop = false;
            btnTL.UseVisualStyleBackColor = true;
            btnTL.Click += btn_Click;
            // 
            // gameResult
            // 
            gameResult.BackColor = Color.AntiqueWhite;
            gameResult.Controls.Add(label5);
            gameResult.Controls.Add(contBtn);
            gameResult.Controls.Add(winnerText);
            gameResult.Location = new Point(14, 529);
            gameResult.Name = "gameResult";
            gameResult.Size = new Size(526, 59);
            gameResult.TabIndex = 2;
            gameResult.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 7;
            label5.Text = "WINNER";
            // 
            // contBtn
            // 
            contBtn.BackColor = Color.FromArgb(255, 192, 192);
            contBtn.Enabled = false;
            contBtn.Location = new Point(394, 15);
            contBtn.Name = "contBtn";
            contBtn.Size = new Size(126, 40);
            contBtn.TabIndex = 6;
            contBtn.Text = "&Continue";
            toolTip7.SetToolTip(contBtn, "Continue With The Current Players");
            contBtn.UseVisualStyleBackColor = false;
            contBtn.Click += contBtn_Click;
            // 
            // winnerText
            // 
            winnerText.Enabled = false;
            winnerText.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            winnerText.Location = new Point(109, 19);
            winnerText.Name = "winnerText";
            winnerText.ReadOnly = true;
            winnerText.Size = new Size(254, 31);
            winnerText.TabIndex = 0;
            winnerText.TextAlign = HorizontalAlignment.Center;
            // 
            // gameStats
            // 
            gameStats.BackColor = Color.AntiqueWhite;
            gameStats.Controls.Add(overallWText);
            gameStats.Controls.Add(label6);
            gameStats.Controls.Add(statsListBox);
            gameStats.Location = new Point(407, 163);
            gameStats.Name = "gameStats";
            gameStats.Size = new Size(133, 370);
            gameStats.TabIndex = 3;
            gameStats.TabStop = false;
            gameStats.Text = "Stats";
            // 
            // overallWText
            // 
            overallWText.Enabled = false;
            overallWText.Location = new Point(7, 50);
            overallWText.Name = "overallWText";
            overallWText.ReadOnly = true;
            overallWText.Size = new Size(119, 27);
            overallWText.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 27);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 1;
            label6.Text = "Overall Winner";
            // 
            // statsListBox
            // 
            statsListBox.Enabled = false;
            statsListBox.FormattingEnabled = true;
            statsListBox.ItemHeight = 20;
            statsListBox.Location = new Point(7, 92);
            statsListBox.Name = "statsListBox";
            statsListBox.Size = new Size(119, 264);
            statsListBox.TabIndex = 0;
            // 
            // Form1
            // 
            AcceptButton = startBtn;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            CancelButton = resetBtn;
            ClientSize = new Size(554, 600);
            Controls.Add(gameStats);
            Controls.Add(gameResult);
            Controls.Add(gameArea);
            Controls.Add(gameSetup);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(128, 64, 0);
            MaximizeBox = false;
            MaximumSize = new Size(572, 647);
            MinimizeBox = false;
            MinimumSize = new Size(572, 647);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            gameSetup.ResumeLayout(false);
            gameSetup.PerformLayout();
            gameArea.ResumeLayout(false);
            gameArea.PerformLayout();
            gameResult.ResumeLayout(false);
            gameResult.PerformLayout();
            gameStats.ResumeLayout(false);
            gameStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gameSetup;
        private GroupBox gameArea;
        private Button btnBR;
        private Button btnBC;
        private Button btnBL;
        private Button btnCR;
        private Button btnCC;
        private Button btnCL;
        private Button btnTR;
        private Button btnTC;
        private Button btnTL;
        private GroupBox gameResult;
        private GroupBox gameStats;
        private TextBox p2SymbolText;
        private TextBox p1SymbolText;
        private TextBox p2NameText;
        private TextBox p1NameText;
        private TextBox winnerText;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button resetBtn;
        private Button startBtn;
        private Button contBtn;
        private Label label5;
        private TextBox overallWText;
        private Label label6;
        private ListBox statsListBox;
        private TextBox currentTurnText;
        private Label label8;
        private ToolTip toolTip6;
        private ToolTip toolTip5;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
        private ToolTip toolTip7;
    }
}