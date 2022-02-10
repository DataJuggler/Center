

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateFavoriteStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Favorite' object.
    /// </summary>
    public class UpdateFavoriteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateFavoriteStoredProcedure' object.
        /// </summary>
        public UpdateFavoriteStoredProcedure()
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
                this.ProcedureName = "Favorite_Update";

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
