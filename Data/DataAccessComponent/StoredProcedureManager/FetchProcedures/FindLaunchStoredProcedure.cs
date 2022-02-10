

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindLaunchStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Launch' object.
    /// </summary>
    public class FindLaunchStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindLaunchStoredProcedure' object.
        /// </summary>
        public FindLaunchStoredProcedure()
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
                this.ProcedureName = "Launch_Find";

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
