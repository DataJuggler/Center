

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindBlockedSiteStoredProcedure
    /// <summary>
    /// This class is used to Find a 'BlockedSite' object.
    /// </summary>
    public class FindBlockedSiteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindBlockedSiteStoredProcedure' object.
        /// </summary>
        public FindBlockedSiteStoredProcedure()
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
                this.ProcedureName = "BlockedSite_Find";

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
