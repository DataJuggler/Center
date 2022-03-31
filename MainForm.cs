

#region using statements

using DataJuggler.Net6;
using Microsoft.Web.WebView2;
using System.Collections.Generic;
using ObjectLibrary.BusinessObjects;
using DataGateway;
using ApplicationLogicComponent;
using DataJuggler.UltimateHelper;
using System.Linq;
using System.Diagnostics;

#endregion

namespace Center
{

    #region class MainForm
    /// <summary>
    /// Main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private List<Favorite> favorites;
        private List<BlockedSite> blockedSites;
        private string selectedUrl;
        private Gateway gateway;
        private bool fullscreen;
        private ulong currentNavigationId;
        private bool startupComplete;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region BackButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'BackButton' is clicked.
            /// </summary>
            private void BackButton_Click(object sender, EventArgs e)
            {
                // Go Forward
                Browser.GoBack();
            }
            #endregion
            
            #region BackButton_EnabledChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Back Button _ Enabled Changed
            /// </summary>
            private void BackButton_EnabledChanged(object sender, EventArgs e)
            {
                // if Enabled
                if (BackButton.Enabled)
                {
                    // Show blue
                    BackButton.BackgroundImage = Properties.Resources.BlueWhiteArrow;
                }
                else
                {
                    // Show gray
                    BackButton.BackgroundImage = Properties.Resources.GrayWhiteArrow;
                }
            }
            #endregion
            
            #region Browser_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
            /// <summary>
            /// event is fired when Browser _ Navigation Completed
            /// </summary>
            private void Browser_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
            {
                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region CoreWebView2_ContainsFullScreenElementChanged(object sender, object e)
            /// <summary>
            /// event is fired when Core Web View 2_ Contains Full Screen Element Changed
            /// </summary>
            private void CoreWebView2_ContainsFullScreenElementChanged(object sender, object e)
            {
                // Toggle
                Fullscreen = !Fullscreen;

                // Show or hide the top panel
                TopPanel.Visible = !Fullscreen;
            }
            #endregion
            
            #region CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
            /// <summary>
            /// event is fired when Core Web View 2_ New Window Requested
            /// </summary>
            private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
            {
                // I handled this, you go away popup
                e.Handled = true;

                // get the uri
                string url = e.Uri;

                // get the path
                string path = Application.ExecutablePath;

                // If the strings path and url both exist
                if (TextHelper.Exists(path, url))
                {
                    // Create a new instance of a 'Launch' object.
                    Launch launch = new Launch();   

                    // create a Guid
                    launch.SiteId = Guid.NewGuid();
                    launch.Url = url;

                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway(ApplicationLogicComponent.Connection.Connection.Name);

                    // Save the launch entry
                    bool saved = gateway.SaveLaunch(ref launch);

                    // if the value for saved is true
                    if (saved)
                    {
                        Process process = new Process();
                
                        process.StartInfo = new ProcessStartInfo();
                        { 
                            // Set the working directory                    
                            process.StartInfo.UseShellExecute = true;
                            process.StartInfo.FileName = path;                    
                        };
                        bool started = process.Start();
                    }
                    else
                    {  
                        // Show a message for now
                        MessageBox.Show("Houston, we have a problem.", "Oops");
                    }
                }
                else
                {
                    // show error?
                }
            }
            #endregion
            
            #region CoverRight_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CoverRight' is clicked.
            /// </summary>
            private void CoverRight_Click(object sender, EventArgs e)
            {
                MouseEventArgs m = e as MouseEventArgs;

                // if right button
                if (m.Button == MouseButtons.Right)
                {
                    // set to minimum for now
                    CoverRight.Width = 16;
                }
                else
                {
                    // set to minimum for now
                    CoverRight.Width = 420;
                }
            }
            #endregion
            
            #region FavoritesButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'FavoritesButton' is clicked.
            /// </summary>
            private void FavoritesButton_Click(object sender, EventArgs e)
            {
                // get the url
                string url = UrlTextBox.Text;
                
                // get the name
                string name = url.Replace("https://", "").Replace(".com", "").Replace(".net", "").Replace(".org", "").Trim();
                name = TextHelper.CapitalizeFirstChar(name);

                SitesForm sitesForm = new SitesForm();
                sitesForm.Setup(this, Favorites, name, url);
                sitesForm.Location = new Point(this.Width - sitesForm.Width - 80, 200);
                sitesForm.ShowDialog();
            }
            #endregion
            
            #region ForwardButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ForwardButton' is clicked.
            /// </summary>
            private void ForwardButton_Click(object sender, EventArgs e)
            {
                // Go Forward
                Browser.GoForward();
            }
            #endregion
            
            #region ForwardButton_EnabledChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Forward Button _ Enabled Changed
            /// </summary>
            private void ForwardButton_EnabledChanged(object sender, EventArgs e)
            {
                // if Enabled
                if (ForwardButton.Enabled)
                {
                    // Show blue
                    ForwardButton.BackgroundImage = Properties.Resources.BlueWhiteArrow2;
                }
                else
                {
                    // Show gray
                    ForwardButton.BackgroundImage = Properties.Resources.GrayWhiteArrow2;
                }
            }
            #endregion
            
            #region IncreaseButtonRight_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'IncreaseButtonRight' is clicked.
            /// </summary>
            private void IncreaseButtonRight_Click(object sender, EventArgs e)
            {
                CoverRight.Width = CoverRight.Width + 16;
            }
            #endregion
            
            #region LeftSplitter_SplitterMoved(object sender, SplitterEventArgs e)
            /// <summary>
            /// event is fired when Left Splitter _ Splitter Moved
            /// </summary>
            private void LeftSplitter_SplitterMoved(object sender, SplitterEventArgs e)
            {
               // Set the width
                int adjustment = e.SplitX - (CoverLeft.Width / 2);

                // Set the Width
                CoverLeft.Width = adjustment;

                // refresh
                Refresh();
                Application.DoEvents();
            }
            #endregion
            
            #region MainForm_Activated(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Main Form _ Activated
            /// </summary>
            private void MainForm_Activated(object sender, EventArgs e)
            {
                // if the value for StartupComplete is false
                if (!StartupComplete)
                {
                    // only fire once
                    StartupComplete = true;

                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway(ApplicationLogicComponent.Connection.Connection.Name);

                    // find the last launch
                    Launch launch = gateway.FindLaunchByLaunchDate(DateTime.Now);

                    // If the launch string exists
                    if (NullHelper.Exists(launch))
                    {
                        // Delete this launch so it isn't stored
                        gateway.DeleteLaunch(launch.Id);

                        // verify this is a url
                        if (launch.Url.StartsWith("https://"))
                        {
                            // Set the tag
                            StartUrlTimer.Tag = launch.Url;
                            StartUrlTimer.Enabled = true;
                        }                        
                    }                   
                }
            }
            #endregion
            
            #region RightSplitter_SplitterMoved(object sender, SplitterEventArgs e)
            /// <summary>
            /// event is fired when Right Splitter _ Splitter Moved
            /// </summary>
            private void RightSplitter_SplitterMoved(object sender, SplitterEventArgs e)
            {
                // Set the width
                int adjustment = (Screen.PrimaryScreen.Bounds.Width - e.SplitX) * 2;

                // Set the Width
                CoverRight.Width = adjustment;

                // refresh
                Refresh();
                Application.DoEvents();
            }
            #endregion
            
            #region StartUrlTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Start Url Timer _ Tick
            /// </summary>
            private void StartUrlTimer_Tick(object sender, EventArgs e)
            {
                 // if the Browser is ready
                if (NullHelper.Exists(Browser, Browser.CoreWebView2))
                {
                    // get the string
                    string tag = StartUrlTimer.Tag as string;

                    // If the tag string exists
                    if (TextHelper.Exists(tag))
                    {   
                        // Go to website
                        NavigateTo(tag);

                        // Stop
                        StartUrlTimer.Stop();

                        // Erase, sorry only way I could get this to work. I will do a database method later.
                        Clipboard.Clear();

                        // erase
                        StartUrlTimer.Tag = null;
                    }
                }                
            }
            #endregion
            
            #region UrlTextBox_KeyDown(object sender, KeyEventArgs e)
            /// <summary>
            /// event is fired when Url Text Box _ Key Down
            /// </summary>
            private void UrlTextBox_KeyDown(object sender, KeyEventArgs e)
            {
                // get the url
                string url = UrlTextBox.Text;

                // local
                bool blocked = false;
                bool valid = false;

                // if the user hit enter
                if (e.KeyCode == Keys.Enter)
                {
                    // If the BlockedSites collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(BlockedSites))
                    {
                        // To Do: Lookup is this site blocked
                        BlockedSite site = BlockedSites.FirstOrDefault(x => x.Url.Contains(url));

                        // If the site object exists
                        if (NullHelper.Exists(site))
                        {
                            // this site is blocked
                            blocked = true;
                        }
                        else
                        {
                            // the user OK'ed this
                            valid = true;
                        }
                    }
                    else
                    {
                        // valid
                        valid = true;
                    }
                }

                // if the value for blocked is false
                if ((!blocked) && (valid))
                {
                    // remove any ending new line chars
                    url = url.Replace(Environment.NewLine, String.Empty);

                    // if not start with https
                    if (!url.StartsWith("https://"))
                    {
                        // add to url
                        url = "https://" + url;
                    }

                    // Display full Url
                    UrlTextBox.Text = url;

                    // Go to this site
                    Browser.CoreWebView2.Navigate(url);
                }
            }
            #endregion
            
            #region UrlTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Url Text Box _ Text Changed
            /// </summary>
            private void UrlTextBox_TextChanged(object sender, EventArgs e)
            {
                // get the current text
                string text = UrlTextBox.Text;

                // if the text exists
                if ((TextHelper.Exists(text)) && (ListHelper.HasOneOrMoreItems(Favorites)))
                {
                    // to do: Add control to display lists as you type
                }
            }
            #endregion
            
        #endregion

        #region Methods
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public async void Init()
            {
                // ensure Browser works
                await Browser.EnsureCoreWebView2Async();

                // fake out too appear as Edge, so I can sign into Google/YouTube                
                string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36";
                Browser.CoreWebView2.Settings.UserAgent = userAgent;

                // Handle the new window requested
                Browser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;

                // Set the Zoom
                Browser.ZoomFactor = 1.5;

                // Create a new instance of a 'Gateway' object.
                Gateway = new Gateway(ApplicationLogicComponent.Connection.Connection.Name);

                // Load all favorites
                Favorites = Gateway.LoadFavorites();

                // Load Blocked Sites
                BlockedSites = Gateway.LoadBlockedSites();

                // Setup the FullScreen Chagned Event
                Browser.CoreWebView2.ContainsFullScreenElementChanged += CoreWebView2_ContainsFullScreenElementChanged;                
            }
            #endregion

            #region NavigateTo(string url)
            /// <summary>
            /// Navigate To
            /// </summary>
            public void NavigateTo(string url)
            {
                // if the Browser is ready
                if (NullHelper.Exists(Browser, Browser.CoreWebView2))
                {
                    // Display the Url
                    UrlTextBox.Text = url;

                    // Go to
                    Browser.CoreWebView2.Navigate(url);
                }
                else
                {
                    // debugging
                    throw new Exception("Error Launching");
                }
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Enable the button if it can go back
                BackButton.Enabled = Browser.CanGoBack;
                ForwardButton.Enabled = Browser.CanGoForward;

                // Refresh
                Refresh();
                Application.DoEvents();
            }
            #endregion
            
        #endregion

        #region Properties  
            
            #region BlockedSites
            /// <summary>
            /// This property gets or sets the value for 'BlockedSites'.
            /// </summary>
            public List<BlockedSite> BlockedSites
            {
                get { return blockedSites; }
                set { blockedSites = value; }
            }
            #endregion
            
            #region CurrentNavigationId
            /// <summary>
            /// This property gets or sets the value for 'CurrentNavigationId'.
            /// </summary>
            public ulong CurrentNavigationId
            {
                get { return currentNavigationId; }
                set { currentNavigationId = value; }
            }
            #endregion
            
            #region Favorites
            /// <summary>
            /// This property gets or sets the value for 'Favorites'.
            /// </summary>
            public List<Favorite> Favorites
            {
                get { return favorites; }
                set { favorites = value; }
            }
            #endregion
            
            #region Fullscreen
            /// <summary>
            /// This property gets or sets the value for 'Fullscreen'.
            /// </summary>
            public bool Fullscreen
            {
                get { return fullscreen; }
                set { fullscreen = value; }
            }
            #endregion
            
            #region Gateway
            /// <summary>
            /// This property gets or sets the value for 'Gateway'.
            /// </summary>
            public Gateway Gateway
            {
                get { return gateway; }
                set { gateway = value; }
            }
            #endregion
            
            #region HasBlockedSites
            /// <summary>
            /// This property returns true if this object has a 'BlockedSites'.
            /// </summary>
            public bool HasBlockedSites
            {
                get
                {
                    // initial value
                    bool hasBlockedSites = (this.BlockedSites != null);
                    
                    // return value
                    return hasBlockedSites;
                }
            }
            #endregion
            
            #region HasFavorites
            /// <summary>
            /// This property returns true if this object has a 'Favorites'.
            /// </summary>
            public bool HasFavorites
            {
                get
                {
                    // initial value
                    bool hasFavorites = (this.Favorites != null);
                    
                    // return value
                    return hasFavorites;
                }
            }
            #endregion
            
            #region HasGateway
            /// <summary>
            /// This property returns true if this object has a 'Gateway'.
            /// </summary>
            public bool HasGateway
            {
                get
                {
                    // initial value
                    bool hasGateway = (this.Gateway != null);
                    
                    // return value
                    return hasGateway;
                }
            }
        #endregion
           
            #region SelectedUrl
            /// <summary>
            /// This property gets or sets the value for 'SelectedUrl'.
            /// </summary>
            public string SelectedUrl
            {
                get { return selectedUrl; }
                set { selectedUrl = value; }
            }
        #endregion

            #region StartupComplete
            /// <summary>
            /// This property gets or sets the value for 'StartupComplete'.
            /// </summary>
            public bool StartupComplete
            {
                get { return startupComplete; }
                set { startupComplete = value; }
            }
        #endregion

        #endregion
    }
    #endregion

}
