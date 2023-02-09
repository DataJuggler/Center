namespace Center
{
    partial class SitesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SitesForm));
            this.SearchTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.FavoritesListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new DataJuggler.Win.Controls.Button();
            this.EditButton = new DataJuggler.Win.Controls.Button();
            this.DeleteButton = new DataJuggler.Win.Controls.Button();
            this.UrlControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.SiteNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.CancelButton = new DataJuggler.Win.Controls.Button();
            this.SaveButton = new DataJuggler.Win.Controls.Button();
            this.IsStartPage = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.GoButton = new DataJuggler.Win.Controls.Button();
            this.GoButton2 = new DataJuggler.Win.Controls.Button();
            this.AddCollectionButton = new DataJuggler.Win.Controls.Button();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BottomMargin = 0;
            this.SearchTextBox.Editable = true;
            this.SearchTextBox.Encrypted = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.Inititialized = true;
            this.SearchTextBox.LabelBottomMargin = 0;
            this.SearchTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SearchTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.LabelText = "Search:";
            this.SearchTextBox.LabelTopMargin = 0;
            this.SearchTextBox.LabelWidth = 120;
            this.SearchTextBox.Location = new System.Drawing.Point(20, 182);
            this.SearchTextBox.MultiLine = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.OnTextChangedListener = null;
            this.SearchTextBox.PasswordMode = false;
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.Size = new System.Drawing.Size(471, 32);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextBoxBottomMargin = 0;
            this.SearchTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SearchTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.SearchTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.TextBoxTopMargin = 0;
            this.SearchTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FavoritesListBox
            // 
            this.FavoritesListBox.FormattingEnabled = true;
            this.FavoritesListBox.ItemHeight = 18;
            this.FavoritesListBox.Location = new System.Drawing.Point(140, 220);
            this.FavoritesListBox.Name = "FavoritesListBox";
            this.FavoritesListBox.Size = new System.Drawing.Size(351, 328);
            this.FavoritesListBox.TabIndex = 1;
            this.FavoritesListBox.SelectedIndexChanged += new System.EventHandler(this.FavoritesListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.ButtonText = "Add";
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddButton.Location = new System.Drawing.Point(140, 556);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.ButtonText = "Edit";
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.EditButton.Location = new System.Drawing.Point(260, 556);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 40);
            this.EditButton.TabIndex = 3;
            this.EditButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.ButtonText = "Delete";
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DeleteButton.Location = new System.Drawing.Point(379, 556);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 40);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UrlControl
            // 
            this.UrlControl.BackColor = System.Drawing.Color.Transparent;
            this.UrlControl.BottomMargin = 0;
            this.UrlControl.Editable = true;
            this.UrlControl.Encrypted = false;
            this.UrlControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrlControl.Inititialized = true;
            this.UrlControl.LabelBottomMargin = 0;
            this.UrlControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.UrlControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UrlControl.LabelText = "Url:";
            this.UrlControl.LabelTopMargin = 0;
            this.UrlControl.LabelWidth = 120;
            this.UrlControl.Location = new System.Drawing.Point(20, 24);
            this.UrlControl.MultiLine = false;
            this.UrlControl.Name = "UrlControl";
            this.UrlControl.OnTextChangedListener = null;
            this.UrlControl.PasswordMode = false;
            this.UrlControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UrlControl.Size = new System.Drawing.Size(836, 32);
            this.UrlControl.TabIndex = 5;
            this.UrlControl.TextBoxBottomMargin = 0;
            this.UrlControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.UrlControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.UrlControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrlControl.TextBoxTopMargin = 0;
            this.UrlControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // SiteNameControl
            // 
            this.SiteNameControl.BackColor = System.Drawing.Color.Transparent;
            this.SiteNameControl.BottomMargin = 0;
            this.SiteNameControl.Editable = true;
            this.SiteNameControl.Encrypted = false;
            this.SiteNameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiteNameControl.Inititialized = true;
            this.SiteNameControl.LabelBottomMargin = 0;
            this.SiteNameControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SiteNameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SiteNameControl.LabelText = "Name:";
            this.SiteNameControl.LabelTopMargin = 0;
            this.SiteNameControl.LabelWidth = 120;
            this.SiteNameControl.Location = new System.Drawing.Point(20, 70);
            this.SiteNameControl.MultiLine = false;
            this.SiteNameControl.Name = "SiteNameControl";
            this.SiteNameControl.OnTextChangedListener = null;
            this.SiteNameControl.PasswordMode = false;
            this.SiteNameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SiteNameControl.Size = new System.Drawing.Size(471, 32);
            this.SiteNameControl.TabIndex = 6;
            this.SiteNameControl.TextBoxBottomMargin = 0;
            this.SiteNameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SiteNameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.SiteNameControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiteNameControl.TextBoxTopMargin = 0;
            this.SiteNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.ButtonText = "Cancel";
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton.Location = new System.Drawing.Point(744, 129);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 40);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.Location = new System.Drawing.Point(625, 129);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 40);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IsStartPage
            // 
            this.IsStartPage.BackColor = System.Drawing.Color.Transparent;
            this.IsStartPage.CheckBoxHorizontalOffSet = 0;
            this.IsStartPage.CheckBoxVerticalOffSet = 3;
            this.IsStartPage.CheckChangedListener = null;
            this.IsStartPage.Checked = false;
            this.IsStartPage.Editable = true;
            this.IsStartPage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsStartPage.LabelColor = System.Drawing.Color.LemonChiffon;
            this.IsStartPage.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IsStartPage.LabelText = "Start Page:";
            this.IsStartPage.LabelWidth = 120;
            this.IsStartPage.Location = new System.Drawing.Point(20, 112);
            this.IsStartPage.Name = "IsStartPage";
            this.IsStartPage.Size = new System.Drawing.Size(280, 28);
            this.IsStartPage.TabIndex = 9;
            this.IsStartPage.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusLabel.Location = new System.Drawing.Point(0, 631);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(905, 32);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Transparent;
            this.GoButton.ButtonText = "Go";
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.GoButton.Location = new System.Drawing.Point(744, 62);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(112, 40);
            this.GoButton.TabIndex = 11;
            this.GoButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // GoButton2
            // 
            this.GoButton2.BackColor = System.Drawing.Color.Transparent;
            this.GoButton2.ButtonText = "Go";
            this.GoButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoButton2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.GoButton2.Location = new System.Drawing.Point(20, 220);
            this.GoButton2.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton2.Name = "GoButton2";
            this.GoButton2.Size = new System.Drawing.Size(112, 40);
            this.GoButton2.TabIndex = 12;
            this.GoButton2.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.GoButton2.Click += new System.EventHandler(this.GoButton2_Click);
            // 
            // AddCollectionButton
            // 
            this.AddCollectionButton.BackColor = System.Drawing.Color.Transparent;
            this.AddCollectionButton.ButtonText = "Add Collection";
            this.AddCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCollectionButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCollectionButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddCollectionButton.Location = new System.Drawing.Point(140, 608);
            this.AddCollectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddCollectionButton.Name = "AddCollectionButton";
            this.AddCollectionButton.Size = new System.Drawing.Size(232, 40);
            this.AddCollectionButton.TabIndex = 13;
            this.AddCollectionButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // SitesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(905, 663);
            this.Controls.Add(this.AddCollectionButton);
            this.Controls.Add(this.GoButton2);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.IsStartPage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SiteNameControl);
            this.Controls.Add(this.UrlControl);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FavoritesListBox);
            this.Controls.Add(this.SearchTextBox);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SitesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Favorites";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl SearchTextBox;
        private ListBox FavoritesListBox;
        private DataJuggler.Win.Controls.Button AddButton;
        private DataJuggler.Win.Controls.Button EditButton;
        private DataJuggler.Win.Controls.Button DeleteButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl UrlControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl SiteNameControl;
        private new DataJuggler.Win.Controls.Button CancelButton;
        private DataJuggler.Win.Controls.Button SaveButton;
        private Label StatusLabel;
        private DataJuggler.Win.Controls.LabelCheckBoxControl IsStartPage;
        private DataJuggler.Win.Controls.Button GoButton;
        private DataJuggler.Win.Controls.Button GoButton2;
        private DataJuggler.Win.Controls.Button AddCollectionButton;
    }
}