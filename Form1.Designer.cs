namespace Pairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerOneSelected1 = new System.Windows.Forms.PictureBox();
            this.playerOneSelected2 = new System.Windows.Forms.PictureBox();
            this.playerOnePairCount = new System.Windows.Forms.Label();
            this.tb_Player1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.boardSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Player2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playerTwoSelected1 = new System.Windows.Forms.PictureBox();
            this.playerTwoSelected2 = new System.Windows.Forms.PictureBox();
            this.playerTwoPairCount = new System.Windows.Forms.Label();
            this.cardGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneSelected1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneSelected2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoSelected1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoSelected2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.playerOnePairCount);
            this.panel1.Controls.Add(this.tb_Player1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 842);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerOneSelected1);
            this.groupBox1.Controls.Add(this.playerOneSelected2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cards Selected:";
            // 
            // playerOneSelected1
            // 
            this.playerOneSelected1.Location = new System.Drawing.Point(12, 24);
            this.playerOneSelected1.Name = "playerOneSelected1";
            this.playerOneSelected1.Size = new System.Drawing.Size(130, 130);
            this.playerOneSelected1.TabIndex = 3;
            this.playerOneSelected1.TabStop = false;
            // 
            // playerOneSelected2
            // 
            this.playerOneSelected2.Location = new System.Drawing.Point(12, 166);
            this.playerOneSelected2.Name = "playerOneSelected2";
            this.playerOneSelected2.Size = new System.Drawing.Size(130, 130);
            this.playerOneSelected2.TabIndex = 2;
            this.playerOneSelected2.TabStop = false;
            // 
            // playerOnePairCount
            // 
            this.playerOnePairCount.AutoSize = true;
            this.playerOnePairCount.ForeColor = System.Drawing.Color.White;
            this.playerOnePairCount.Location = new System.Drawing.Point(12, 47);
            this.playerOnePairCount.Name = "playerOnePairCount";
            this.playerOnePairCount.Size = new System.Drawing.Size(94, 20);
            this.playerOnePairCount.TabIndex = 1;
            this.playerOnePairCount.Text = "Current Pairs:";
            // 
            // tb_Player1
            // 
            this.tb_Player1.BackColor = System.Drawing.Color.White;
            this.tb_Player1.Location = new System.Drawing.Point(8, 9);
            this.tb_Player1.Name = "tb_Player1";
            this.tb_Player1.PlaceholderText = "Player 1 Name:";
            this.tb_Player1.Size = new System.Drawing.Size(154, 27);
            this.tb_Player1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.About});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1222, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 24);
            this.toolStripDropDownButton1.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGame);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGame_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boardSizeToolStripMenuItem});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(76, 24);
            this.toolStripDropDownButton2.Text = "Settings";
            // 
            // boardSizeToolStripMenuItem
            // 
            this.boardSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x6ToolStripMenuItem,
            this.x10ToolStripMenuItem,
            this.x16ToolStripMenuItem});
            this.boardSizeToolStripMenuItem.Name = "boardSizeToolStripMenuItem";
            this.boardSizeToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.boardSizeToolStripMenuItem.Text = "Board Size";
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.x6ToolStripMenuItem.Text = "6 X 6";
            this.x6ToolStripMenuItem.Click += new System.EventHandler(this.x6ToolStripMenuItem_Click);
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.x10ToolStripMenuItem.Text = "10 X 10";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x16ToolStripMenuItem
            // 
            this.x16ToolStripMenuItem.Name = "x16ToolStripMenuItem";
            this.x16ToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.x16ToolStripMenuItem.Text = "16 X 16";
            this.x16ToolStripMenuItem.Click += new System.EventHandler(this.x16ToolStripMenuItem_Click);
            // 
            // About
            // 
            this.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(55, 24);
            this.About.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // tb_Player2
            // 
            this.tb_Player2.BackColor = System.Drawing.Color.White;
            this.tb_Player2.Location = new System.Drawing.Point(8, 9);
            this.tb_Player2.Name = "tb_Player2";
            this.tb_Player2.PlaceholderText = "Player 2 Name:";
            this.tb_Player2.Size = new System.Drawing.Size(154, 27);
            this.tb_Player2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.playerTwoPairCount);
            this.panel2.Controls.Add(this.tb_Player2);
            this.panel2.Location = new System.Drawing.Point(1039, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 842);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playerTwoSelected1);
            this.groupBox2.Controls.Add(this.playerTwoSelected2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 308);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cards Selected:";
            // 
            // playerTwoSelected1
            // 
            this.playerTwoSelected1.Location = new System.Drawing.Point(12, 24);
            this.playerTwoSelected1.Name = "playerTwoSelected1";
            this.playerTwoSelected1.Size = new System.Drawing.Size(130, 130);
            this.playerTwoSelected1.TabIndex = 3;
            this.playerTwoSelected1.TabStop = false;
            // 
            // playerTwoSelected2
            // 
            this.playerTwoSelected2.Location = new System.Drawing.Point(12, 166);
            this.playerTwoSelected2.Name = "playerTwoSelected2";
            this.playerTwoSelected2.Size = new System.Drawing.Size(130, 130);
            this.playerTwoSelected2.TabIndex = 2;
            this.playerTwoSelected2.TabStop = false;
            // 
            // playerTwoPairCount
            // 
            this.playerTwoPairCount.AutoSize = true;
            this.playerTwoPairCount.ForeColor = System.Drawing.Color.White;
            this.playerTwoPairCount.Location = new System.Drawing.Point(12, 47);
            this.playerTwoPairCount.Name = "playerTwoPairCount";
            this.playerTwoPairCount.Size = new System.Drawing.Size(98, 20);
            this.playerTwoPairCount.TabIndex = 1;
            this.playerTwoPairCount.Text = "Current Pairs: ";
            // 
            // cardGrid
            // 
            this.cardGrid.ColumnCount = 6;
            this.cardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.Location = new System.Drawing.Point(191, 41);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.RowCount = 6;
            this.cardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.cardGrid.Size = new System.Drawing.Size(840, 840);
            this.cardGrid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1222, 896);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1240, 943);
            this.MinimumSize = new System.Drawing.Size(1240, 943);
            this.Name = "Form1";
            this.Text = "Pairs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerOneSelected1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneSelected2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoSelected1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoSelected2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private ToolStripMenuItem loadGameToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem boardSizeToolStripMenuItem;
        private ToolStripMenuItem x6ToolStripMenuItem;
        private ToolStripMenuItem x10ToolStripMenuItem;
        private ToolStripMenuItem x16ToolStripMenuItem;
        private ToolStripDropDownButton About;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox tb_Player1;
        private Label playerOnePairCount;
        private GroupBox groupBox1;
        private PictureBox playerOneSelected1;
        private PictureBox playerOneSelected2;
        private TextBox tb_Player2;
        private Panel panel2;
        private GroupBox groupBox2;
        private PictureBox playerTwoSelected1;
        private PictureBox playerTwoSelected2;
        private Label playerTwoPairCount;
        private TableLayoutPanel cardGrid;
    }
}