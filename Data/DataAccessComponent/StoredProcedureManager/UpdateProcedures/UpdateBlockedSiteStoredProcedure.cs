

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateBlockedSiteStoredProcedure
    /// <summary>
    /// This class is used to Update a 'BlockedSite' object.
    /// </summary>
    public class UpdateBlockedSiteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateBlockedSiteStoredProcedure' object.
        /// </summary>
        public UpdateBlockedSiteStoredProcedure()
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
                this.ProcedureName = "BlockedSite_Update";

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
