

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteBlockedSiteStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'BlockedSite' object.
    /// </summary>
    public class DeleteBlockedSiteStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteBlockedSiteStoredProcedure' object.
        /// </summary>
        public DeleteBlockedSiteStoredProcedure()
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
                this.ProcedureName = "BlockedSite_Delete";

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
