

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class DataOperationsManager
    /// <summary>
    /// This class manages DataOperations for this project.
    /// </summary>
    public class DataOperationsManager
    {

        #region Private Variables
        private DataManager dataManager;
        private SystemMethods systemMethods;
        private BlockedSiteMethods blockedsiteMethods;
        private FavoriteMethods favoriteMethods;
        private LaunchMethods launchMethods;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'DataOperationsManager' object.
        /// </summary>
        public DataOperationsManager(DataManager dataManagerArg)
        {
            // Save Arguments
            this.DataManager = dataManagerArg;

            // Create Child DataOperationMethods
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child DataOperationMethods
            /// </summary>
            private void Init()
            {
                // Create Child DataOperatonMethods
                this.SystemMethods = new SystemMethods();
                this.BlockedSiteMethods = new BlockedSiteMethods(this.DataManager);
                this.FavoriteMethods = new FavoriteMethods(this.DataManager);
                this.LaunchMethods = new LaunchMethods(this.DataManager);
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager
            public DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

            #region SystemMethods
            public SystemMethods SystemMethods
            {
                get { return systemMethods; }
                set { systemMethods = value; }
            }
            #endregion

            #region BlockedSiteMethods
            public BlockedSiteMethods BlockedSiteMethods
            {
                get { return blockedsiteMethods; }
                set { blockedsiteMethods = value; }
            }
            #endregion

            #region FavoriteMethods
            public FavoriteMethods FavoriteMethods
            {
                get { return favoriteMethods; }
                set { favoriteMethods = value; }
            }
            #endregion

            #region LaunchMethods
            public LaunchMethods LaunchMethods
            {
                get { return launchMethods; }
                set { launchMethods = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
