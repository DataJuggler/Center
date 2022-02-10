

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertBlockedSiteStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'BlockedSite' object.
    /// </summary>
    public class InsertBlockedSiteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertBlockedSiteStoredProcedure' object.
        /// </summary>
        public InsertBlockedSiteStoredProcedure()
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
                this.ProcedureName = "BlockedSite_Insert";

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
