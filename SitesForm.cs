

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGateway;
using ObjectLibrary.BusinessObjects;
using DataJuggler.UltimateHelper;

#endregion

namespace Center
{

    #region class SitesForm
    /// <summary>
    /// This form is used add and manage favorites
    /// </summary>
    public partial class SitesForm : Form
    {
        
        #region Private Variables
        private List<Favorite> favorites;
        private Favorite selectedFavorite;
        private MainForm parent;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'SitesForm' object.
        /// </summary>
        public SitesForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region DeleteButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'DeleteButton' is clicked.
            /// </summary>
            private void DeleteButton_Click(object sender, EventArgs e)
            {
                // if the value for HasSelectedFavorite is true
                if (HasSelectedFavorite)
                {
                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway(ApplicationLogicComponent.Connection.Connection.Name);
                    
                    // perform the delete
                    bool deleted = gateway.DeleteFavorite(SelectedFavorite.Id);

                    // if the value for deleted is true
                    if (deleted)
                    {   
                        // load all favorites
                        Favorites = gateway.LoadFavorites();

                        // Display favorites
                        DisplayFavorites();
                    }
                }
            }
            #endregion
            
            #region FavoritesListBox_SelectedIndexChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a selection is made in the 'FavoritesListBox_'.
            /// </summary>
            private void FavoritesListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Set the SelectedFavorite
                SelectedFavorite = Favorites[FavoritesListBox.SelectedIndex];

                // If the SelectedFavorite object exists
                if (NullHelper.Exists(SelectedFavorite))
                {
                    // Display
                    UrlControl.Text = SelectedFavorite.Url;
                    SiteNameControl.Text = SelectedFavorite.Name;
                }

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region GoButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'GoButton' is clicked.
            /// </summary>
            private void GoButton_Click(object sender, EventArgs e)
            {
                // If there is a selected parent and a SelectedFavorite
                if ((HasParent) && (HasSelectedFavorite))
                {
                    // Go to
                    Parent.NavigateTo(SelectedFavorite.Url);

                    // Close this form
                    Close();
                }
            }
            #endregion
            
            #region GoButton2_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'GoButton2' is clicked.
            /// </summary>
            private void GoButton2_Click(object sender, EventArgs e)
            {
                // Send the user
                GoButton_Click(sender, e);
            }
            #endregion
            
            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SaveButton' is clicked.
            /// </summary>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // Create a new instance of a 'Favorite' object.
                Favorite favorite = new Favorite();

                // set properties
                favorite.Url = UrlControl.Text;
                favorite.StartPage = IsStartPage.Checked;
                favorite.Name = SiteNameControl.Text;
                
                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway("CenterConnString");

                // Save this favorite
                bool saved = gateway.SaveFavorite(ref favorite);

                // if the value for saved is true
                if (saved)
                {
                    // load the favorites
                    Favorites = gateway.LoadFavorites();

                    // Display the Favorites
                    DisplayFavorites(favorite);
                }
                else
                {
                    // debugging why not saved
                    Exception exception = gateway.GetLastException();
                }
            }
            #endregion
            
        #endregion
        
        #region Methods
            
            #region DisplayFavorites(Favorite selectedItem = null)
            /// <summary>
            /// Display Favorites
            /// </summary>
            public void DisplayFavorites(Favorite selectedItem = null)
            {
                // local
                int index = -1;

                // set the selected index
                int selectedIndex = -1;

                 // If the favorites collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(favorites))
                {
                    // Just in case
                    FavoritesListBox.Items.Clear();

                    // Iterate the collection of Favorite objects
                    foreach (Favorite favorite in favorites)
                    {
                        // Increment the value for index
                        index++;

                        // Add this item
                        FavoritesListBox.Items.Add(favorite);

                        // If the selectedItem object exists
                        if ((NullHelper.Exists(selectedItem)) && (TextHelper.IsEqual(favorite.Name, selectedItem.Name)))
                        {
                            // set the selectedIndex
                            selectedIndex = index;
                        }                        
                    }

                    // Set the selected index
                    FavoritesListBox.SelectedIndex = selectedIndex;
                    FavoritesListBox.Focus();
                }
            }
            #endregion
            
            #region Setup(List<Favorite> favorites, string newFavoriteName, string newFavoriteUrl)
            /// <summary>
            /// Setup
            /// </summary>
            public void Setup(MainForm parent, List<Favorite> favorites, string newFavoriteName, string newFavoriteUrl)
            {
                // create a favorite
                SelectedFavorite = new Favorite();

                // set these properties
                SelectedFavorite.Url = newFavoriteUrl;
                selectedFavorite.Name = newFavoriteName;

                // Store
                Parent = parent;

                // populate controls
                SiteNameControl.Text = newFavoriteName;
                UrlControl.Text = newFavoriteUrl;

                // store the arg
                Favorites = favorites;

                // display the favorites list
                DisplayFavorites();

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Enable the button if we have a selected favorite
                GoButton.Enabled = HasSelectedFavorite;
                GoButton2.Enabled = HasSelectedFavorite;
            }
            #endregion
            
        #endregion

        #region Properties

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
            
            #region HasParent
            /// <summary>
            /// This property returns true if this object has a 'Parent'.
            /// </summary>
            public bool HasParent
            {
                get
                {
                    // initial value
                    bool hasParent = (this.Parent != null);
                    
                    // return value
                    return hasParent;
                }
            }
            #endregion
            
            #region HasSelectedFavorite
            /// <summary>
            /// This property returns true if this object has a 'SelectedFavorite'.
            /// </summary>
            public bool HasSelectedFavorite
            {
                get
                {
                    // initial value
                    bool hasSelectedFavorite = (this.SelectedFavorite != null);
                    
                    // return value
                    return hasSelectedFavorite;
                }
            }
            #endregion
            
            #region Parent
            /// <summary>
            /// This property gets or sets the value for 'Parent'.
            /// </summary>
            public new MainForm Parent
            {
                get { return parent; }
                set { parent = value; }
            }
            #endregion
            
            #region SelectedFavorite
            /// <summary>
            /// This property gets or sets the value for 'SelectedFavorite'.
            /// </summary>
            public Favorite SelectedFavorite
            {
                get { return selectedFavorite; }
                set { selectedFavorite = value; }
            }
        #endregion

        #endregion

    }
    #endregion

}
