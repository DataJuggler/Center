

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertLaunchStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Launch' object.
    /// </summary>
    public class InsertLaunchStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertLaunchStoredProcedure' object.
        /// </summary>
        public InsertLaunchStoredProcedure()
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
                this.ProcedureName = "Launch_Insert";

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
