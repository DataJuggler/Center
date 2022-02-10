

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class BlockedSiteController
    /// <summary>
    /// This class controls a(n) 'BlockedSite' object.
    /// </summary>
    public class BlockedSiteController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'BlockedSiteController' object.
        /// </summary>
        public BlockedSiteController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateBlockedSiteParameter
            /// <summary>
            /// This method creates the parameter for a 'BlockedSite' data operation.
            /// </summary>
            /// <param name='blockedsite'>The 'BlockedSite' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateBlockedSiteParameter(BlockedSite blockedSite)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = blockedSite;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(BlockedSite tempBlockedSite)
            /// <summary>
            /// Deletes a 'BlockedSite' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'BlockedSite_Delete'.
            /// </summary>
            /// <param name='blockedsite'>The 'BlockedSite' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(BlockedSite tempBlockedSite)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteBlockedSite";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempblockedSite exists before attemptintg to delete
                    if(tempBlockedSite != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteBlockedSiteMethod = this.AppController.DataBridge.DataOperations.BlockedSiteMethods.DeleteBlockedSite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateBlockedSiteParameter(tempBlockedSite);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteBlockedSiteMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(BlockedSite tempBlockedSite)
            /// <summary>
            /// This method fetches a collection of 'BlockedSite' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'BlockedSite_FetchAll'.</summary>
            /// <param name='tempBlockedSite'>A temporary BlockedSite for passing values.</param>
            /// <returns>A collection of 'BlockedSite' objects.</returns>
            public List<BlockedSite> FetchAll(BlockedSite tempBlockedSite)
            {
                // Initial value
                List<BlockedSite> blockedSiteList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.BlockedSiteMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateBlockedSiteParameter(tempBlockedSite);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<BlockedSite> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        blockedSiteList = (List<BlockedSite>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return blockedSiteList;
            }
            #endregion

            #region Find(BlockedSite tempBlockedSite)
            /// <summary>
            /// Finds a 'BlockedSite' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'BlockedSite_Find'</param>
            /// </summary>
            /// <param name='tempBlockedSite'>A temporary BlockedSite for passing values.</param>
            /// <returns>A 'BlockedSite' object if found else a null 'BlockedSite'.</returns>
            public BlockedSite Find(BlockedSite tempBlockedSite)
            {
                // Initial values
                BlockedSite blockedSite = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempBlockedSite != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.BlockedSiteMethods.FindBlockedSite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateBlockedSiteParameter(tempBlockedSite);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as BlockedSite != null))
                        {
                            // Get ReturnObject
                            blockedSite = (BlockedSite) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return blockedSite;
            }
            #endregion

            #region Insert(BlockedSite blockedSite)
            /// <summary>
            /// Insert a 'BlockedSite' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'BlockedSite_Insert'.</param>
            /// </summary>
            /// <param name='blockedSite'>The 'BlockedSite' object to insert.</param>
            /// <returns>The id (int) of the new  'BlockedSite' object that was inserted.</returns>
            public int Insert(BlockedSite blockedSite)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If BlockedSiteexists
                    if(blockedSite != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.BlockedSiteMethods.InsertBlockedSite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateBlockedSiteParameter(blockedSite);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref BlockedSite blockedSite)
            /// <summary>
            /// Saves a 'BlockedSite' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='blockedSite'>The 'BlockedSite' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref BlockedSite blockedSite)
            {
                // Initial value
                bool saved = false;

                // If the blockedSite exists.
                if(blockedSite != null)
                {
                    // Is this a new BlockedSite
                    if(blockedSite.IsNew)
                    {
                        // Insert new BlockedSite
                        int newIdentity = this.Insert(blockedSite);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            blockedSite.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update BlockedSite
                        saved = this.Update(blockedSite);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(BlockedSite blockedSite)
            /// <summary>
            /// This method Updates a 'BlockedSite' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'BlockedSite_Update'.</param>
            /// </summary>
            /// <param name='blockedSite'>The 'BlockedSite' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(BlockedSite blockedSite)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(blockedSite != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.BlockedSiteMethods.UpdateBlockedSite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateBlockedSiteParameter(blockedSite);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
