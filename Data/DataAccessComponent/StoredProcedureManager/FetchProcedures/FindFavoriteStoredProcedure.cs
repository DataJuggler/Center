

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindFavoriteStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Favorite' object.
    /// </summary>
    public class FindFavoriteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindFavoriteStoredProcedure' object.
        /// </summary>
        public FindFavoriteStoredProcedure()
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
                this.ProcedureName = "Favorite_Find";

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
