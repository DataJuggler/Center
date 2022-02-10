

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

    #region class FavoriteController
    /// <summary>
    /// This class controls a(n) 'Favorite' object.
    /// </summary>
    public class FavoriteController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'FavoriteController' object.
        /// </summary>
        public FavoriteController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateFavoriteParameter
            /// <summary>
            /// This method creates the parameter for a 'Favorite' data operation.
            /// </summary>
            /// <param name='favorite'>The 'Favorite' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateFavoriteParameter(Favorite favorite)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = favorite;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Favorite tempFavorite)
            /// <summary>
            /// Deletes a 'Favorite' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Favorite_Delete'.
            /// </summary>
            /// <param name='favorite'>The 'Favorite' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Favorite tempFavorite)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteFavorite";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempfavorite exists before attemptintg to delete
                    if(tempFavorite != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteFavoriteMethod = this.AppController.DataBridge.DataOperations.FavoriteMethods.DeleteFavorite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFavoriteParameter(tempFavorite);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteFavoriteMethod, parameters);

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

            #region FetchAll(Favorite tempFavorite)
            /// <summary>
            /// This method fetches a collection of 'Favorite' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Favorite_FetchAll'.</summary>
            /// <param name='tempFavorite'>A temporary Favorite for passing values.</param>
            /// <returns>A collection of 'Favorite' objects.</returns>
            public List<Favorite> FetchAll(Favorite tempFavorite)
            {
                // Initial value
                List<Favorite> favoriteList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.FavoriteMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateFavoriteParameter(tempFavorite);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Favorite> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        favoriteList = (List<Favorite>) returnObject.ObjectValue;
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
                return favoriteList;
            }
            #endregion

            #region Find(Favorite tempFavorite)
            /// <summary>
            /// Finds a 'Favorite' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Favorite_Find'</param>
            /// </summary>
            /// <param name='tempFavorite'>A temporary Favorite for passing values.</param>
            /// <returns>A 'Favorite' object if found else a null 'Favorite'.</returns>
            public Favorite Find(Favorite tempFavorite)
            {
                // Initial values
                Favorite favorite = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempFavorite != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.FavoriteMethods.FindFavorite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFavoriteParameter(tempFavorite);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Favorite != null))
                        {
                            // Get ReturnObject
                            favorite = (Favorite) returnObject.ObjectValue;
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
                return favorite;
            }
            #endregion

            #region Insert(Favorite favorite)
            /// <summary>
            /// Insert a 'Favorite' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Favorite_Insert'.</param>
            /// </summary>
            /// <param name='favorite'>The 'Favorite' object to insert.</param>
            /// <returns>The id (int) of the new  'Favorite' object that was inserted.</returns>
            public int Insert(Favorite favorite)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Favoriteexists
                    if(favorite != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.FavoriteMethods.InsertFavorite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFavoriteParameter(favorite);

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

            #region Save(ref Favorite favorite)
            /// <summary>
            /// Saves a 'Favorite' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='favorite'>The 'Favorite' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Favorite favorite)
            {
                // Initial value
                bool saved = false;

                // If the favorite exists.
                if(favorite != null)
                {
                    // Is this a new Favorite
                    if(favorite.IsNew)
                    {
                        // Insert new Favorite
                        int newIdentity = this.Insert(favorite);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            favorite.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Favorite
                        saved = this.Update(favorite);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Favorite favorite)
            /// <summary>
            /// This method Updates a 'Favorite' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Favorite_Update'.</param>
            /// </summary>
            /// <param name='favorite'>The 'Favorite' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Favorite favorite)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(favorite != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.FavoriteMethods.UpdateFavorite;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFavoriteParameter(favorite);
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
