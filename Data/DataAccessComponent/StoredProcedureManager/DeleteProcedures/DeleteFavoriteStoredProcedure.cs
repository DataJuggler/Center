

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteFavoriteStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Favorite' object.
    /// </summary>
    public class DeleteFavoriteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteFavoriteStoredProcedure' object.
        /// </summary>
        public DeleteFavoriteStoredProcedure()
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
                this.ProcedureName = "Favorite_Delete";

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
