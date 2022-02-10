

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

    #region class LaunchMethods
    /// <summary>
    /// This class contains methods for modifying a 'Launch' object.
    /// </summary>
    public class LaunchMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'LaunchMethods' object.
        /// </summary>
        public LaunchMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteLaunch(Launch)
            /// <summary>
            /// This method deletes a 'Launch' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Launch' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteLaunch(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteLaunchStoredProcedure deleteLaunchProc = null;

                    // verify the first parameters is a(n) 'Launch'.
                    if (parameters[0].ObjectValue as Launch != null)
                    {
                        // Create Launch
                        Launch launch = (Launch) parameters[0].ObjectValue;

                        // verify launch exists
                        if(launch != null)
                        {
                            // Now create deleteLaunchProc from LaunchWriter
                            // The DataWriter converts the 'Launch'
                            // to the SqlParameter[] array needed to delete a 'Launch'.
                            deleteLaunchProc = LaunchWriter.CreateDeleteLaunchStoredProcedure(launch);
                        }
                    }

                    // Verify deleteLaunchProc exists
                    if(deleteLaunchProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.LaunchManager.DeleteLaunch(deleteLaunchProc, dataConnector);

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
            /// This method fetches all 'Launch' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Launch' to delete.
            /// <returns>A PolymorphicObject object with all  'Launchs' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Launch> launchListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllLaunchsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get LaunchParameter
                    // Declare Parameter
                    Launch paramLaunch = null;

                    // verify the first parameters is a(n) 'Launch'.
                    if (parameters[0].ObjectValue as Launch != null)
                    {
                        // Get LaunchParameter
                        paramLaunch = (Launch) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllLaunchsProc from LaunchWriter
                    fetchAllProc = LaunchWriter.CreateFetchAllLaunchsStoredProcedure(paramLaunch);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    launchListCollection = this.DataManager.LaunchManager.FetchAllLaunchs(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(launchListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = launchListCollection;
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

            #region FindLaunch(Launch)
            /// <summary>
            /// This method finds a 'Launch' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Launch' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindLaunch(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Launch launch = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindLaunchStoredProcedure findLaunchProc = null;

                    // verify the first parameters is a 'Launch'.
                    if (parameters[0].ObjectValue as Launch != null)
                    {
                        // Get LaunchParameter
                        Launch paramLaunch = (Launch) parameters[0].ObjectValue;

                        // verify paramLaunch exists
                        if(paramLaunch != null)
                        {
                            // Now create findLaunchProc from LaunchWriter
                            // The DataWriter converts the 'Launch'
                            // to the SqlParameter[] array needed to find a 'Launch'.
                            findLaunchProc = LaunchWriter.CreateFindLaunchStoredProcedure(paramLaunch);
                        }

                        // Verify findLaunchProc exists
                        if(findLaunchProc != null)
                        {
                            // Execute Find Stored Procedure
                            launch = this.DataManager.LaunchManager.FindLaunch(findLaunchProc, dataConnector);

                            // if dataObject exists
                            if(launch != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = launch;
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

            #region InsertLaunch (Launch)
            /// <summary>
            /// This method inserts a 'Launch' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Launch' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertLaunch(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Launch launch = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertLaunchStoredProcedure insertLaunchProc = null;

                    // verify the first parameters is a(n) 'Launch'.
                    if (parameters[0].ObjectValue as Launch != null)
                    {
                        // Create Launch Parameter
                        launch = (Launch) parameters[0].ObjectValue;

                        // verify launch exists
                        if(launch != null)
                        {
                            // Now create insertLaunchProc from LaunchWriter
                            // The DataWriter converts the 'Launch'
                            // to the SqlParameter[] array needed to insert a 'Launch'.
                            insertLaunchProc = LaunchWriter.CreateInsertLaunchStoredProcedure(launch);
                        }

                        // Verify insertLaunchProc exists
                        if(insertLaunchProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.LaunchManager.InsertLaunch(insertLaunchProc, dataConnector);
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

            #region UpdateLaunch (Launch)
            /// <summary>
            /// This method updates a 'Launch' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Launch' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateLaunch(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Launch launch = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateLaunchStoredProcedure updateLaunchProc = null;

                    // verify the first parameters is a(n) 'Launch'.
                    if (parameters[0].ObjectValue as Launch != null)
                    {
                        // Create Launch Parameter
                        launch = (Launch) parameters[0].ObjectValue;

                        // verify launch exists
                        if(launch != null)
                        {
                            // Now create updateLaunchProc from LaunchWriter
                            // The DataWriter converts the 'Launch'
                            // to the SqlParameter[] array needed to update a 'Launch'.
                            updateLaunchProc = LaunchWriter.CreateUpdateLaunchStoredProcedure(launch);
                        }

                        // Verify updateLaunchProc exists
                        if(updateLaunchProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.LaunchManager.UpdateLaunch(updateLaunchProc, dataConnector);

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
