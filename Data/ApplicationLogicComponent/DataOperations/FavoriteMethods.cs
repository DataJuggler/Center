

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

    #region class FavoriteMethods
    /// <summary>
    /// This class contains methods for modifying a 'Favorite' object.
    /// </summary>
    public class FavoriteMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'FavoriteMethods' object.
        /// </summary>
        public FavoriteMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteFavorite(Favorite)
            /// <summary>
            /// This method deletes a 'Favorite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Favorite' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteFavorite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteFavoriteStoredProcedure deleteFavoriteProc = null;

                    // verify the first parameters is a(n) 'Favorite'.
                    if (parameters[0].ObjectValue as Favorite != null)
                    {
                        // Create Favorite
                        Favorite favorite = (Favorite) parameters[0].ObjectValue;

                        // verify favorite exists
                        if(favorite != null)
                        {
                            // Now create deleteFavoriteProc from FavoriteWriter
                            // The DataWriter converts the 'Favorite'
                            // to the SqlParameter[] array needed to delete a 'Favorite'.
                            deleteFavoriteProc = FavoriteWriter.CreateDeleteFavoriteStoredProcedure(favorite);
                        }
                    }

                    // Verify deleteFavoriteProc exists
                    if(deleteFavoriteProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.FavoriteManager.DeleteFavorite(deleteFavoriteProc, dataConnector);

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
            /// This method fetches all 'Favorite' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Favorite' to delete.
            /// <returns>A PolymorphicObject object with all  'Favorites' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Favorite> favoriteListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllFavoritesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get FavoriteParameter
                    // Declare Parameter
                    Favorite paramFavorite = null;

                    // verify the first parameters is a(n) 'Favorite'.
                    if (parameters[0].ObjectValue as Favorite != null)
                    {
                        // Get FavoriteParameter
                        paramFavorite = (Favorite) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllFavoritesProc from FavoriteWriter
                    fetchAllProc = FavoriteWriter.CreateFetchAllFavoritesStoredProcedure(paramFavorite);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    favoriteListCollection = this.DataManager.FavoriteManager.FetchAllFavorites(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(favoriteListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = favoriteListCollection;
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

            #region FindFavorite(Favorite)
            /// <summary>
            /// This method finds a 'Favorite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Favorite' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindFavorite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Favorite favorite = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindFavoriteStoredProcedure findFavoriteProc = null;

                    // verify the first parameters is a 'Favorite'.
                    if (parameters[0].ObjectValue as Favorite != null)
                    {
                        // Get FavoriteParameter
                        Favorite paramFavorite = (Favorite) parameters[0].ObjectValue;

                        // verify paramFavorite exists
                        if(paramFavorite != null)
                        {
                            // Now create findFavoriteProc from FavoriteWriter
                            // The DataWriter converts the 'Favorite'
                            // to the SqlParameter[] array needed to find a 'Favorite'.
                            findFavoriteProc = FavoriteWriter.CreateFindFavoriteStoredProcedure(paramFavorite);
                        }

                        // Verify findFavoriteProc exists
                        if(findFavoriteProc != null)
                        {
                            // Execute Find Stored Procedure
                            favorite = this.DataManager.FavoriteManager.FindFavorite(findFavoriteProc, dataConnector);

                            // if dataObject exists
                            if(favorite != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = favorite;
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

            #region InsertFavorite (Favorite)
            /// <summary>
            /// This method inserts a 'Favorite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Favorite' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertFavorite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Favorite favorite = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertFavoriteStoredProcedure insertFavoriteProc = null;

                    // verify the first parameters is a(n) 'Favorite'.
                    if (parameters[0].ObjectValue as Favorite != null)
                    {
                        // Create Favorite Parameter
                        favorite = (Favorite) parameters[0].ObjectValue;

                        // verify favorite exists
                        if(favorite != null)
                        {
                            // Now create insertFavoriteProc from FavoriteWriter
                            // The DataWriter converts the 'Favorite'
                            // to the SqlParameter[] array needed to insert a 'Favorite'.
                            insertFavoriteProc = FavoriteWriter.CreateInsertFavoriteStoredProcedure(favorite);
                        }

                        // Verify insertFavoriteProc exists
                        if(insertFavoriteProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.FavoriteManager.InsertFavorite(insertFavoriteProc, dataConnector);
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

            #region UpdateFavorite (Favorite)
            /// <summary>
            /// This method updates a 'Favorite' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Favorite' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateFavorite(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Favorite favorite = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateFavoriteStoredProcedure updateFavoriteProc = null;

                    // verify the first parameters is a(n) 'Favorite'.
                    if (parameters[0].ObjectValue as Favorite != null)
                    {
                        // Create Favorite Parameter
                        favorite = (Favorite) parameters[0].ObjectValue;

                        // verify favorite exists
                        if(favorite != null)
                        {
                            // Now create updateFavoriteProc from FavoriteWriter
                            // The DataWriter converts the 'Favorite'
                            // to the SqlParameter[] array needed to update a 'Favorite'.
                            updateFavoriteProc = FavoriteWriter.CreateUpdateFavoriteStoredProcedure(favorite);
                        }

                        // Verify updateFavoriteProc exists
                        if(updateFavoriteProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.FavoriteManager.UpdateFavorite(updateFavoriteProc, dataConnector);

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
