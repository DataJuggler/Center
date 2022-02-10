

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllLaunchsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Launch' objects.
    /// </summary>
    public class FetchAllLaunchsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllLaunchsStoredProcedure' object.
        /// </summary>
        public FetchAllLaunchsStoredProcedure()
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
                this.ProcedureName = "Launch_FetchAll";

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
