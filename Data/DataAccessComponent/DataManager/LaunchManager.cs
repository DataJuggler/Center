

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

    #region class LaunchManager
    /// <summary>
    /// This class is used to manage a 'Launch' object.
    /// </summary>
    public class LaunchManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'LaunchManager' object.
        /// </summary>
        public LaunchManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteLaunch()
            /// <summary>
            /// This method deletes a 'Launch' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteLaunch(DeleteLaunchStoredProcedure deleteLaunchProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteLaunchProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllLaunchs()
            /// <summary>
            /// This method fetches a  'List<Launch>' object.
            /// This method uses the 'Launchs_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Launch>'</returns>
            /// </summary>
            public List<Launch> FetchAllLaunchs(FetchAllLaunchsStoredProcedure fetchAllLaunchsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Launch> launchCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allLaunchsDataSet = this.DataHelper.LoadDataSet(fetchAllLaunchsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allLaunchsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allLaunchsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            launchCollection = LaunchReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return launchCollection;
            }
            #endregion

            #region FindLaunch()
            /// <summary>
            /// This method finds a  'Launch' object.
            /// This method uses the 'Launch_Find' procedure.
            /// </summary>
            /// <returns>A 'Launch' object.</returns>
            /// </summary>
            public Launch FindLaunch(FindLaunchStoredProcedure findLaunchProc, DataConnector databaseConnector)
            {
                // Initial Value
                Launch launch = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet launchDataSet = this.DataHelper.LoadDataSet(findLaunchProc, databaseConnector);

                    // Verify DataSet Exists
                    if(launchDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(launchDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Launch
                            launch = LaunchReader.Load(row);
                        }
                    }
                }

                // return value
                return launch;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertLaunch()
            /// <summary>
            /// This method inserts a 'Launch' object.
            /// This method uses the 'Launch_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertLaunch(InsertLaunchStoredProcedure insertLaunchProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertLaunchProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateLaunch()
            /// <summary>
            /// This method updates a 'Launch'.
            /// This method uses the 'Launch_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateLaunch(UpdateLaunchStoredProcedure updateLaunchProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateLaunchProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
