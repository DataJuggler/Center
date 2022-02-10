

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteLaunchStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Launch' object.
    /// </summary>
    public class DeleteLaunchStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteLaunchStoredProcedure' object.
        /// </summary>
        public DeleteLaunchStoredProcedure()
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
                this.ProcedureName = "Launch_Delete";

                // Set tableName
                this.TableName = "Launch";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
