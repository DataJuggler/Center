

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllFavoritesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Favorite' objects.
    /// </summary>
    public class FetchAllFavoritesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllFavoritesStoredProcedure' object.
        /// </summary>
        public FetchAllFavoritesStoredProcedure()
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
                this.ProcedureName = "Favorite_FetchAll";

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
