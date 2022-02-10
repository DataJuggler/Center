namespace Center
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.FavoritesButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.PictureBox();
            this.CoverLeft = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.CoverRight = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.Browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.RightSplitter = new System.Windows.Forms.Splitter();
            this.LeftSplitter = new System.Windows.Forms.Splitter();
            this.StartUrlTimer = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.UrlTextBox);
            this.TopPanel.Controls.Add(this.FavoritesButton);
            this.TopPanel.Controls.Add(this.BackButton);
            this.TopPanel.Controls.Add(this.ForwardButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1143, 32);
            this.TopPanel.TabIndex = 0;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.BackColor = System.Drawing.Color.White;
            this.UrlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlTextBox.Location = new System.Drawing.Point(64, 0);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrlTextBox.Multiline = true;
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(1047, 32);
            this.UrlTextBox.TabIndex = 8;
            this.UrlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyDown);
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.BackgroundImage = global::Center.Properties.Resources.Star;
            this.FavoritesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavoritesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FavoritesButton.Location = new System.Drawing.Point(1111, 0);
            this.FavoritesButton.Margin = new System.Windows.Forms.Padding(4);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(32, 32);
            this.FavoritesButton.TabIndex = 0;
            this.FavoritesButton.TabStop = false;
            this.FavoritesButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            this.FavoritesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.FavoritesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::Center.Properties.Resources.GrayWhiteArrow;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.Enabled = false;
            this.BackButton.Location = new System.Drawing.Point(32, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.TabIndex = 1;
            this.BackButton.TabStop = false;
            this.BackButton.EnabledChanged += new System.EventHandler(this.BackButton_EnabledChanged);
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::Center.Properties.Resources.GrayWhiteArrow2;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForwardButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ForwardButton.Enabled = false;
            this.ForwardButton.Location = new System.Drawing.Point(0, 0);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(4);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(32, 32);
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.TabStop = false;
            this.ForwardButton.EnabledChanged += new System.EventHandler(this.ForwardButton_EnabledChanged);
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            this.ForwardButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ForwardButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // CoverLeft
            // 
            this.CoverLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.CoverLeft.Location = new System.Drawing.Point(0, 32);
            this.CoverLeft.MinimumSize = new System.Drawing.Size(16, 0);
            this.CoverLeft.Name = "CoverLeft";
            this.CoverLeft.Size = new System.Drawing.Size(16, 508);
            this.CoverLeft.TabIndex = 12;
            // 
            // CoverRight
            // 
            this.CoverRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoverRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.CoverRight.Location = new System.Drawing.Point(1127, 32);
            this.CoverRight.MinimumSize = new System.Drawing.Size(16, 0);
            this.CoverRight.Name = "CoverRight";
            this.CoverRight.Size = new System.Drawing.Size(16, 508);
            this.CoverRight.TabIndex = 13;
            this.CoverRight.Click += new System.EventHandler(this.CoverRight_Click);
            // 
            // Browser
            // 
            this.Browser.CreationProperties = null;
            this.Browser.DefaultBackgroundColor = System.Drawing.Color.Black;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 32);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1143, 508);
            this.Browser.TabIndex = 17;
            this.Browser.ZoomFactor = 1D;
            // 
            // RightSplitter
            // 
            this.RightSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSplitter.Location = new System.Drawing.Point(1124, 32);
            this.RightSplitter.Name = "RightSplitter";
            this.RightSplitter.Size = new System.Drawing.Size(3, 508);
            this.RightSplitter.TabIndex = 18;
            this.RightSplitter.TabStop = false;
            this.RightSplitter.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.RightSplitter_SplitterMoved);
            // 
            // LeftSplitter
            // 
            this.LeftSplitter.Location = new System.Drawing.Point(16, 32);
            this.LeftSplitter.Name = "LeftSplitter";
            this.LeftSplitter.Size = new System.Drawing.Size(3, 508);
            this.LeftSplitter.TabIndex = 19;
            this.LeftSplitter.TabStop = false;
            this.LeftSplitter.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.LeftSplitter_SplitterMoved);
            // 
            // StartUrlTimer
            // 
            this.StartUrlTimer.Interval = 500;
            this.StartUrlTimer.Tick += new System.EventHandler(this.StartUrlTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 540);
            this.Controls.Add(this.LeftSplitter);
            this.Controls.Add(this.RightSplitter);
            this.Controls.Add(this.CoverRight);
            this.Controls.Add(this.CoverLeft);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center 1.0.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.Objects.PanelExtender TopPanel;
        private PictureBox FavoritesButton;
        private PictureBox ForwardButton;
        private PictureBox BackButton;
        private TextBox UrlTextBox;
        private DataJuggler.Win.Controls.Objects.PanelExtender CoverLeft;
        private DataJuggler.Win.Controls.Objects.PanelExtender CoverRight;
        private Microsoft.Web.WebView2.WinForms.WebView2 Browser;
        private Splitter RightSplitter;
        private Splitter LeftSplitter;
        private System.Windows.Forms.Timer StartUrlTimer;
    }
}