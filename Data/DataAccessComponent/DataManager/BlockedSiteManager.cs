

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

    #region class BlockedSiteManager
    /// <summary>
    /// This class is used to manage a 'BlockedSite' object.
    /// </summary>
    public class BlockedSiteManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'BlockedSiteManager' object.
        /// </summary>
        public BlockedSiteManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteBlockedSite()
            /// <summary>
            /// This method deletes a 'BlockedSite' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteBlockedSite(DeleteBlockedSiteStoredProcedure deleteBlockedSiteProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteBlockedSiteProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllBlockedSites()
            /// <summary>
            /// This method fetches a  'List<BlockedSite>' object.
            /// This method uses the 'BlockedSites_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<BlockedSite>'</returns>
            /// </summary>
            public List<BlockedSite> FetchAllBlockedSites(FetchAllBlockedSitesStoredProcedure fetchAllBlockedSitesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<BlockedSite> blockedSiteCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allBlockedSitesDataSet = this.DataHelper.LoadDataSet(fetchAllBlockedSitesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allBlockedSitesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allBlockedSitesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            blockedSiteCollection = BlockedSiteReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return blockedSiteCollection;
            }
            #endregion

            #region FindBlockedSite()
            /// <summary>
            /// This method finds a  'BlockedSite' object.
            /// This method uses the 'BlockedSite_Find' procedure.
            /// </summary>
            /// <returns>A 'BlockedSite' object.</returns>
            /// </summary>
            public BlockedSite FindBlockedSite(FindBlockedSiteStoredProcedure findBlockedSiteProc, DataConnector databaseConnector)
            {
                // Initial Value
                BlockedSite blockedSite = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet blockedSiteDataSet = this.DataHelper.LoadDataSet(findBlockedSiteProc, databaseConnector);

                    // Verify DataSet Exists
                    if(blockedSiteDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(blockedSiteDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load BlockedSite
                            blockedSite = BlockedSiteReader.Load(row);
                        }
                    }
                }

                // return value
                return blockedSite;
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

            #region InsertBlockedSite()
            /// <summary>
            /// This method inserts a 'BlockedSite' object.
            /// This method uses the 'BlockedSite_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertBlockedSite(InsertBlockedSiteStoredProcedure insertBlockedSiteProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertBlockedSiteProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateBlockedSite()
            /// <summary>
            /// This method updates a 'BlockedSite'.
            /// This method uses the 'BlockedSite_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateBlockedSite(UpdateBlockedSiteStoredProcedure updateBlockedSiteProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateBlockedSiteProc, databaseConnector);
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
