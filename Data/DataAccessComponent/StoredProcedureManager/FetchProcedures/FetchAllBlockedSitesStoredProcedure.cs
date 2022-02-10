

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllBlockedSitesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'BlockedSite' objects.
    /// </summary>
    public class FetchAllBlockedSitesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllBlockedSitesStoredProcedure' object.
        /// </summary>
        public FetchAllBlockedSitesStoredProcedure()
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
                this.ProcedureName = "BlockedSite_FetchAll";

                // Set tableName
                this.TableName = "BlockedSite";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
