

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class FavoriteWriterBase
    /// <summary>
    /// This class is used for converting a 'Favorite' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class FavoriteWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Favorite favorite)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='favorite'>The 'Favorite' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Favorite favorite)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (favorite != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", favorite.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteFavoriteStoredProcedure(Favorite favorite)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteFavorite'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Favorite_Delete'.
            /// </summary>
            /// <param name="favorite">The 'Favorite' to Delete.</param>
            /// <returns>An instance of a 'DeleteFavoriteStoredProcedure' object.</returns>
            public static DeleteFavoriteStoredProcedure CreateDeleteFavoriteStoredProcedure(Favorite favorite)
            {
                // Initial Value
                DeleteFavoriteStoredProcedure deleteFavoriteStoredProcedure = new DeleteFavoriteStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteFavoriteStoredProcedure.Parameters = CreatePrimaryKeyParameter(favorite);

                // return value
                return deleteFavoriteStoredProcedure;
            }
            #endregion

            #region CreateFindFavoriteStoredProcedure(Favorite favorite)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindFavoriteStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Favorite_Find'.
            /// </summary>
            /// <param name="favorite">The 'Favorite' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindFavoriteStoredProcedure CreateFindFavoriteStoredProcedure(Favorite favorite)
            {
                // Initial Value
                FindFavoriteStoredProcedure findFavoriteStoredProcedure = null;

                // verify favorite exists
                if(favorite != null)
                {
                    // Instanciate findFavoriteStoredProcedure
                    findFavoriteStoredProcedure = new FindFavoriteStoredProcedure();

                    // Now create parameters for this procedure
                    findFavoriteStoredProcedure.Parameters = CreatePrimaryKeyParameter(favorite);
                }

                // return value
                return findFavoriteStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Favorite favorite)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new favorite.
            /// </summary>
            /// <param name="favorite">The 'Favorite' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Favorite favorite)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify favoriteexists
                if(favorite != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", favorite.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Password] parameter
                    param = new SqlParameter("@Password", favorite.Password);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [StartPage] parameter
                    param = new SqlParameter("@StartPage", favorite.StartPage);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Url] parameter
                    param = new SqlParameter("@Url", favorite.Url);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [UserName] parameter
                    param = new SqlParameter("@UserName", favorite.UserName);

                    // set parameters[4]
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertFavoriteStoredProcedure(Favorite favorite)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertFavoriteStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Favorite_Insert'.
            /// </summary>
            /// <param name="favorite"The 'Favorite' object to insert</param>
            /// <returns>An instance of a 'InsertFavoriteStoredProcedure' object.</returns>
            public static InsertFavoriteStoredProcedure CreateInsertFavoriteStoredProcedure(Favorite favorite)
            {
                // Initial Value
                InsertFavoriteStoredProcedure insertFavoriteStoredProcedure = null;

                // verify favorite exists
                if(favorite != null)
                {
                    // Instanciate insertFavoriteStoredProcedure
                    insertFavoriteStoredProcedure = new InsertFavoriteStoredProcedure();

                    // Now create parameters for this procedure
                    insertFavoriteStoredProcedure.Parameters = CreateInsertParameters(favorite);
                }

                // return value
                return insertFavoriteStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Favorite favorite)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing favorite.
            /// </summary>
            /// <param name="favorite">The 'Favorite' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Favorite favorite)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify favoriteexists
                if(favorite != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", favorite.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Password]
                    param = new SqlParameter("@Password", favorite.Password);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [StartPage]
                    param = new SqlParameter("@StartPage", favorite.StartPage);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Url]
                    param = new SqlParameter("@Url", favorite.Url);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [UserName]
                    param = new SqlParameter("@UserName", favorite.UserName);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", favorite.Id);
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateFavoriteStoredProcedure(Favorite favorite)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateFavoriteStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Favorite_Update'.
            /// </summary>
            /// <param name="favorite"The 'Favorite' object to update</param>
            /// <returns>An instance of a 'UpdateFavoriteStoredProcedure</returns>
            public static UpdateFavoriteStoredProcedure CreateUpdateFavoriteStoredProcedure(Favorite favorite)
            {
                // Initial Value
                UpdateFavoriteStoredProcedure updateFavoriteStoredProcedure = null;

                // verify favorite exists
                if(favorite != null)
                {
                    // Instanciate updateFavoriteStoredProcedure
                    updateFavoriteStoredProcedure = new UpdateFavoriteStoredProcedure();

                    // Now create parameters for this procedure
                    updateFavoriteStoredProcedure.Parameters = CreateUpdateParameters(favorite);
                }

                // return value
                return updateFavoriteStoredProcedure;
            }
            #endregion

            #region CreateFetchAllFavoritesStoredProcedure(Favorite favorite)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllFavoritesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Favorite_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllFavoritesStoredProcedure' object.</returns>
            public static FetchAllFavoritesStoredProcedure CreateFetchAllFavoritesStoredProcedure(Favorite favorite)
            {
                // Initial value
                FetchAllFavoritesStoredProcedure fetchAllFavoritesStoredProcedure = new FetchAllFavoritesStoredProcedure();

                // return value
                return fetchAllFavoritesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
