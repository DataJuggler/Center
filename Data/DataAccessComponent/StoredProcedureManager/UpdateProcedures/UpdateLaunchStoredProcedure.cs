

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateLaunchStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Launch' object.
    /// </summary>
    public class UpdateLaunchStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateLaunchStoredProcedure' object.
        /// </summary>
        public UpdateLaunchStoredProcedure()
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
                this.ProcedureName = "Launch_Update";

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
