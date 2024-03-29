
#region using statements

using ApplicationLogicComponent.Controllers;
using ApplicationLogicComponent.DataOperations;
using DataAccessComponent.DataManager;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

#endregion

namespace DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteBlockedSite(int id, BlockedSite tempBlockedSite = null)
            /// <summary>
            /// This method is used to delete BlockedSite objects.
            /// </summary>
            /// <param name="id">Delete the BlockedSite with this id</param>
            /// <param name="tempBlockedSite">Pass in a tempBlockedSite to perform a custom delete.</param>
            public bool DeleteBlockedSite(int id, BlockedSite tempBlockedSite = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempBlockedSite does not exist
                    if (tempBlockedSite == null)
                    {
                        // create a temp BlockedSite
                        tempBlockedSite = new BlockedSite();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempBlockedSite.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.BlockedSiteController.Delete(tempBlockedSite);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteFavorite(int id, Favorite tempFavorite = null)
            /// <summary>
            /// This method is used to delete Favorite objects.
            /// </summary>
            /// <param name="id">Delete the Favorite with this id</param>
            /// <param name="tempFavorite">Pass in a tempFavorite to perform a custom delete.</param>
            public bool DeleteFavorite(int id, Favorite tempFavorite = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFavorite does not exist
                    if (tempFavorite == null)
                    {
                        // create a temp Favorite
                        tempFavorite = new Favorite();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempFavorite.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.FavoriteController.Delete(tempFavorite);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteLaunch(int id, Launch tempLaunch = null)
            /// <summary>
            /// This method is used to delete Launch objects.
            /// </summary>
            /// <param name="id">Delete the Launch with this id</param>
            /// <param name="tempLaunch">Pass in a tempLaunch to perform a custom delete.</param>
            public bool DeleteLaunch(int id, Launch tempLaunch = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempLaunch does not exist
                    if (tempLaunch == null)
                    {
                        // create a temp Launch
                        tempLaunch = new Launch();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempLaunch.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.LaunchController.Delete(tempLaunch);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.DataManager.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindBlockedSite(int id, BlockedSite tempBlockedSite = null)
            /// <summary>
            /// This method is used to find 'BlockedSite' objects.
            /// </summary>
            /// <param name="id">Find the BlockedSite with this id</param>
            /// <param name="tempBlockedSite">Pass in a tempBlockedSite to perform a custom find.</param>
            public BlockedSite FindBlockedSite(int id, BlockedSite tempBlockedSite = null)
            {
                // initial value
                BlockedSite blockedSite = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempBlockedSite does not exist
                    if (tempBlockedSite == null)
                    {
                        // create a temp BlockedSite
                        tempBlockedSite = new BlockedSite();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempBlockedSite.UpdateIdentity(id);
                    }

                    // perform the find
                    blockedSite = this.AppController.ControllerManager.BlockedSiteController.Find(tempBlockedSite);
                }

                // return value
                return blockedSite;
            }
            #endregion

            #region FindFavorite(int id, Favorite tempFavorite = null)
            /// <summary>
            /// This method is used to find 'Favorite' objects.
            /// </summary>
            /// <param name="id">Find the Favorite with this id</param>
            /// <param name="tempFavorite">Pass in a tempFavorite to perform a custom find.</param>
            public Favorite FindFavorite(int id, Favorite tempFavorite = null)
            {
                // initial value
                Favorite favorite = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFavorite does not exist
                    if (tempFavorite == null)
                    {
                        // create a temp Favorite
                        tempFavorite = new Favorite();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempFavorite.UpdateIdentity(id);
                    }

                    // perform the find
                    favorite = this.AppController.ControllerManager.FavoriteController.Find(tempFavorite);
                }

                // return value
                return favorite;
            }
            #endregion

            #region FindLaunch(int id, Launch tempLaunch = null)
            /// <summary>
            /// This method is used to find 'Launch' objects.
            /// </summary>
            /// <param name="id">Find the Launch with this id</param>
            /// <param name="tempLaunch">Pass in a tempLaunch to perform a custom find.</param>
            public Launch FindLaunch(int id, Launch tempLaunch = null)
            {
                // initial value
                Launch launch = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempLaunch does not exist
                    if (tempLaunch == null)
                    {
                        // create a temp Launch
                        tempLaunch = new Launch();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempLaunch.UpdateIdentity(id);
                    }

                    // perform the find
                    launch = this.AppController.ControllerManager.LaunchController.Find(tempLaunch);
                }

                // return value
                return launch;
            }
            #endregion

            #region FindLaunchByLaunchDate(DateTime launchDate)
            /// <summary>
            /// This method is used to find 'Launch' objects for the LaunchDate given.
            /// </summary>
            public Launch FindLaunchByLaunchDate(DateTime launchDate)
            {
                // initial value
                Launch launch = null;
                
                // Create a temp Launch object
                Launch tempLaunch = new Launch();
                
                // Set the value for FindByLaunchDate to true
                tempLaunch.FindByLaunchDate = true;
                
                // Set the value for LaunchDate
                tempLaunch.LaunchDate = launchDate;
                
                // Perform the find
                launch = FindLaunch(0, tempLaunch);
                
                // return value
                return launch;
            }
            #endregion
            
            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadBlockedSites(BlockedSite tempBlockedSite = null)
            /// <summary>
            /// This method loads a collection of 'BlockedSite' objects.
            /// </summary>
            public List<BlockedSite> LoadBlockedSites(BlockedSite tempBlockedSite = null)
            {
                // initial value
                List<BlockedSite> blockedSites = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    blockedSites = this.AppController.ControllerManager.BlockedSiteController.FetchAll(tempBlockedSite);
                }

                // return value
                return blockedSites;
            }
            #endregion

            #region LoadFavorites(Favorite tempFavorite = null)
            /// <summary>
            /// This method loads a collection of 'Favorite' objects.
            /// </summary>
            public List<Favorite> LoadFavorites(Favorite tempFavorite = null)
            {
                // initial value
                List<Favorite> favorites = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    favorites = this.AppController.ControllerManager.FavoriteController.FetchAll(tempFavorite);
                }

                // return value
                return favorites;
            }
            #endregion

            #region LoadLaunchs(Launch tempLaunch = null)
            /// <summary>
            /// This method loads a collection of 'Launch' objects.
            /// </summary>
            public List<Launch> LoadLaunchs(Launch tempLaunch = null)
            {
                // initial value
                List<Launch> launchs = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    launchs = this.AppController.ControllerManager.LaunchController.FetchAll(tempLaunch);
                }

                // return value
                return launchs;
            }
            #endregion

            #region SaveBlockedSite(ref BlockedSite blockedSite)
            /// <summary>
            /// This method is used to save 'BlockedSite' objects.
            /// </summary>
            /// <param name="blockedSite">The BlockedSite to save.</param>
            public bool SaveBlockedSite(ref BlockedSite blockedSite)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.BlockedSiteController.Save(ref blockedSite);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveFavorite(ref Favorite favorite)
            /// <summary>
            /// This method is used to save 'Favorite' objects.
            /// </summary>
            /// <param name="favorite">The Favorite to save.</param>
            public bool SaveFavorite(ref Favorite favorite)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.FavoriteController.Save(ref favorite);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveLaunch(ref Launch launch)
            /// <summary>
            /// This method is used to save 'Launch' objects.
            /// </summary>
            /// <param name="launch">The Launch to save.</param>
            public bool SaveLaunch(ref Launch launch)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.LaunchController.Save(ref launch);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}

