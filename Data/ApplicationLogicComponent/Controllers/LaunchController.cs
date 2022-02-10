

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

    #region class LaunchController
    /// <summary>
    /// This class controls a(n) 'Launch' object.
    /// </summary>
    public class LaunchController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'LaunchController' object.
        /// </summary>
        public LaunchController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateLaunchParameter
            /// <summary>
            /// This method creates the parameter for a 'Launch' data operation.
            /// </summary>
            /// <param name='launch'>The 'Launch' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateLaunchParameter(Launch launch)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = launch;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Launch tempLaunch)
            /// <summary>
            /// Deletes a 'Launch' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Launch_Delete'.
            /// </summary>
            /// <param name='launch'>The 'Launch' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Launch tempLaunch)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteLaunch";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify templaunch exists before attemptintg to delete
                    if(tempLaunch != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteLaunchMethod = this.AppController.DataBridge.DataOperations.LaunchMethods.DeleteLaunch;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLaunchParameter(tempLaunch);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteLaunchMethod, parameters);

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

            #region FetchAll(Launch tempLaunch)
            /// <summary>
            /// This method fetches a collection of 'Launch' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Launch_FetchAll'.</summary>
            /// <param name='tempLaunch'>A temporary Launch for passing values.</param>
            /// <returns>A collection of 'Launch' objects.</returns>
            public List<Launch> FetchAll(Launch tempLaunch)
            {
                // Initial value
                List<Launch> launchList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.LaunchMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateLaunchParameter(tempLaunch);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Launch> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        launchList = (List<Launch>) returnObject.ObjectValue;
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
                return launchList;
            }
            #endregion

            #region Find(Launch tempLaunch)
            /// <summary>
            /// Finds a 'Launch' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Launch_Find'</param>
            /// </summary>
            /// <param name='tempLaunch'>A temporary Launch for passing values.</param>
            /// <returns>A 'Launch' object if found else a null 'Launch'.</returns>
            public Launch Find(Launch tempLaunch)
            {
                // Initial values
                Launch launch = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempLaunch != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.LaunchMethods.FindLaunch;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLaunchParameter(tempLaunch);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Launch != null))
                        {
                            // Get ReturnObject
                            launch = (Launch) returnObject.ObjectValue;
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
                return launch;
            }
            #endregion

            #region Insert(Launch launch)
            /// <summary>
            /// Insert a 'Launch' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Launch_Insert'.</param>
            /// </summary>
            /// <param name='launch'>The 'Launch' object to insert.</param>
            /// <returns>The id (int) of the new  'Launch' object that was inserted.</returns>
            public int Insert(Launch launch)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Launchexists
                    if(launch != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.LaunchMethods.InsertLaunch;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLaunchParameter(launch);

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

            #region Save(ref Launch launch)
            /// <summary>
            /// Saves a 'Launch' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='launch'>The 'Launch' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Launch launch)
            {
                // Initial value
                bool saved = false;

                // If the launch exists.
                if(launch != null)
                {
                    // Is this a new Launch
                    if(launch.IsNew)
                    {
                        // Insert new Launch
                        int newIdentity = this.Insert(launch);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            launch.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Launch
                        saved = this.Update(launch);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Launch launch)
            /// <summary>
            /// This method Updates a 'Launch' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Launch_Update'.</param>
            /// </summary>
            /// <param name='launch'>The 'Launch' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Launch launch)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(launch != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.LaunchMethods.UpdateLaunch;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLaunchParameter(launch);
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
