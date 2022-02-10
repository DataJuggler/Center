

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class DataManager
    /// <summary>
    /// This class manages data operations for this project.
    /// </summary>
    public class DataManager
    {

        #region Private Variables
        private DataConnector dataConnector;
        private string connectionName;
        private BlockedSiteManager blockedsiteManager;
        private FavoriteManager favoriteManager;
        private LaunchManager launchManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new instance of a(n) 'DataManager' object.
        /// </summary>
        public DataManager(string connectionName = "")
        {
            // Store the ConnectionName arg
            this.ConnectionName = connectionName;

            // Perform Initializations For This Object.
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Perform Initializations For This Object.
            /// Create the DataConnector and the Child Object Managers.
            /// </summary>
            private void Init()
            {
                // Create New DataConnector
                this.DataConnector = new DataConnector();

                // Create Child Object Managers
                this.BlockedSiteManager = new BlockedSiteManager(this);
                this.FavoriteManager = new FavoriteManager(this);
                this.LaunchManager = new LaunchManager(this);
            }
            #endregion

        #endregion

        #region Properties

            #region DataConnector
            public DataConnector DataConnector
            {
                get { return dataConnector; }
                set { dataConnector = value; }
            }
            #endregion

            #region ConnectionName
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion

            #region BlockedSiteManager
            public BlockedSiteManager BlockedSiteManager
            {
                get { return blockedsiteManager; }
                set { blockedsiteManager = value; }
            }
            #endregion

            #region FavoriteManager
            public FavoriteManager FavoriteManager
            {
                get { return favoriteManager; }
                set { favoriteManager = value; }
            }
            #endregion

            #region LaunchManager
            public LaunchManager LaunchManager
            {
                get { return launchManager; }
                set { launchManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
