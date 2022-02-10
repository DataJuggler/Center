

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

    #region class FavoriteManager
    /// <summary>
    /// This class is used to manage a 'Favorite' object.
    /// </summary>
    public class FavoriteManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FavoriteManager' object.
        /// </summary>
        public FavoriteManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteFavorite()
            /// <summary>
            /// This method deletes a 'Favorite' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteFavorite(DeleteFavoriteStoredProcedure deleteFavoriteProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteFavoriteProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllFavorites()
            /// <summary>
            /// This method fetches a  'List<Favorite>' object.
            /// This method uses the 'Favorites_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Favorite>'</returns>
            /// </summary>
            public List<Favorite> FetchAllFavorites(FetchAllFavoritesStoredProcedure fetchAllFavoritesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Favorite> favoriteCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allFavoritesDataSet = this.DataHelper.LoadDataSet(fetchAllFavoritesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allFavoritesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allFavoritesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            favoriteCollection = FavoriteReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return favoriteCollection;
            }
            #endregion

            #region FindFavorite()
            /// <summary>
            /// This method finds a  'Favorite' object.
            /// This method uses the 'Favorite_Find' procedure.
            /// </summary>
            /// <returns>A 'Favorite' object.</returns>
            /// </summary>
            public Favorite FindFavorite(FindFavoriteStoredProcedure findFavoriteProc, DataConnector databaseConnector)
            {
                // Initial Value
                Favorite favorite = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet favoriteDataSet = this.DataHelper.LoadDataSet(findFavoriteProc, databaseConnector);

                    // Verify DataSet Exists
                    if(favoriteDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(favoriteDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Favorite
                            favorite = FavoriteReader.Load(row);
                        }
                    }
                }

                // return value
                return favorite;
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

            #region InsertFavorite()
            /// <summary>
            /// This method inserts a 'Favorite' object.
            /// This method uses the 'Favorite_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertFavorite(InsertFavoriteStoredProcedure insertFavoriteProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertFavoriteProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateFavorite()
            /// <summary>
            /// This method updates a 'Favorite'.
            /// This method uses the 'Favorite_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateFavorite(UpdateFavoriteStoredProcedure updateFavoriteProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateFavoriteProc, databaseConnector);
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
