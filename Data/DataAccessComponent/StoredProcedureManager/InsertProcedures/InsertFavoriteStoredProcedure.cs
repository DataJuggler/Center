

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertFavoriteStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Favorite' object.
    /// </summary>
    public class InsertFavoriteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertFavoriteStoredProcedure' object.
        /// </summary>
        public InsertFavoriteStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "Favorite_Insert";

                // Set tableName
                this.TableName = "Favorite";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
