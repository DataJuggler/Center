

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class BlockedSiteMethods
    /// <summary>
    /// This class contains methods for modifying a 'BlockedSite' object.
    /// </summary>
    public class BlockedSiteMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'BlockedSiteMethods' object.
        /// </summary>
        public BlockedSiteMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteBlockedSite(BlockedSite)
            /// <summary>
            /// This method deletes a 'BlockedSite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'BlockedSite' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteBlockedSite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteBlockedSiteStoredProcedure deleteBlockedSiteProc = null;

                    // verify the first parameters is a(n) 'BlockedSite'.
                    if (parameters[0].ObjectValue as BlockedSite != null)
                    {
                        // Create BlockedSite
                        BlockedSite blockedSite = (BlockedSite) parameters[0].ObjectValue;

                        // verify blockedSite exists
                        if(blockedSite != null)
                        {
                            // Now create deleteBlockedSiteProc from BlockedSiteWriter
                            // The DataWriter converts the 'BlockedSite'
                            // to the SqlParameter[] array needed to delete a 'BlockedSite'.
                            deleteBlockedSiteProc = BlockedSiteWriter.CreateDeleteBlockedSiteStoredProcedure(blockedSite);
                        }
                    }

                    // Verify deleteBlockedSiteProc exists
                    if(deleteBlockedSiteProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.BlockedSiteManager.DeleteBlockedSite(deleteBlockedSiteProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'BlockedSite' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'BlockedSite' to delete.
            /// <returns>A PolymorphicObject object with all  'BlockedSites' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<BlockedSite> blockedSiteListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllBlockedSitesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get BlockedSiteParameter
                    // Declare Parameter
                    BlockedSite paramBlockedSite = null;

                    // verify the first parameters is a(n) 'BlockedSite'.
                    if (parameters[0].ObjectValue as BlockedSite != null)
                    {
                        // Get BlockedSiteParameter
                        paramBlockedSite = (BlockedSite) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllBlockedSitesProc from BlockedSiteWriter
                    fetchAllProc = BlockedSiteWriter.CreateFetchAllBlockedSitesStoredProcedure(paramBlockedSite);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    blockedSiteListCollection = this.DataManager.BlockedSiteManager.FetchAllBlockedSites(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(blockedSiteListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = blockedSiteListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindBlockedSite(BlockedSite)
            /// <summary>
            /// This method finds a 'BlockedSite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'BlockedSite' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindBlockedSite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                BlockedSite blockedSite = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindBlockedSiteStoredProcedure findBlockedSiteProc = null;

                    // verify the first parameters is a 'BlockedSite'.
                    if (parameters[0].ObjectValue as BlockedSite != null)
                    {
                        // Get BlockedSiteParameter
                        BlockedSite paramBlockedSite = (BlockedSite) parameters[0].ObjectValue;

                        // verify paramBlockedSite exists
                        if(paramBlockedSite != null)
                        {
                            // Now create findBlockedSiteProc from BlockedSiteWriter
                            // The DataWriter converts the 'BlockedSite'
                            // to the SqlParameter[] array needed to find a 'BlockedSite'.
                            findBlockedSiteProc = BlockedSiteWriter.CreateFindBlockedSiteStoredProcedure(paramBlockedSite);
                        }

                        // Verify findBlockedSiteProc exists
                        if(findBlockedSiteProc != null)
                        {
                            // Execute Find Stored Procedure
                            blockedSite = this.DataManager.BlockedSiteManager.FindBlockedSite(findBlockedSiteProc, dataConnector);

                            // if dataObject exists
                            if(blockedSite != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = blockedSite;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertBlockedSite (BlockedSite)
            /// <summary>
            /// This method inserts a 'BlockedSite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'BlockedSite' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertBlockedSite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                BlockedSite blockedSite = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertBlockedSiteStoredProcedure insertBlockedSiteProc = null;

                    // verify the first parameters is a(n) 'BlockedSite'.
                    if (parameters[0].ObjectValue as BlockedSite != null)
                    {
                        // Create BlockedSite Parameter
                        blockedSite = (BlockedSite) parameters[0].ObjectValue;

                        // verify blockedSite exists
                        if(blockedSite != null)
                        {
                            // Now create insertBlockedSiteProc from BlockedSiteWriter
                            // The DataWriter converts the 'BlockedSite'
                            // to the SqlParameter[] array needed to insert a 'BlockedSite'.
                            insertBlockedSiteProc = BlockedSiteWriter.CreateInsertBlockedSiteStoredProcedure(blockedSite);
                        }

                        // Verify insertBlockedSiteProc exists
                        if(insertBlockedSiteProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.BlockedSiteManager.InsertBlockedSite(insertBlockedSiteProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateBlockedSite (BlockedSite)
            /// <summary>
            /// This method updates a 'BlockedSite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'BlockedSite' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateBlockedSite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                BlockedSite blockedSite = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateBlockedSiteStoredProcedure updateBlockedSiteProc = null;

                    // verify the first parameters is a(n) 'BlockedSite'.
                    if (parameters[0].ObjectValue as BlockedSite != null)
                    {
                        // Create BlockedSite Parameter
                        blockedSite = (BlockedSite) parameters[0].ObjectValue;

                        // verify blockedSite exists
                        if(blockedSite != null)
                        {
                            // Now create updateBlockedSiteProc from BlockedSiteWriter
                            // The DataWriter converts the 'BlockedSite'
                            // to the SqlParameter[] array needed to update a 'BlockedSite'.
                            updateBlockedSiteProc = BlockedSiteWriter.CreateUpdateBlockedSiteStoredProcedure(blockedSite);
                        }

                        // Verify updateBlockedSiteProc exists
                        if(updateBlockedSiteProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.BlockedSiteManager.UpdateBlockedSite(updateBlockedSiteProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
