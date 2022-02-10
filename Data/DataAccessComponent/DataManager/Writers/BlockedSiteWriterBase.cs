

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

    #region class BlockedSiteWriterBase
    /// <summary>
    /// This class is used for converting a 'BlockedSite' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class BlockedSiteWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(BlockedSite blockedSite)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='blockedSite'>The 'BlockedSite' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(BlockedSite blockedSite)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (blockedSite != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", blockedSite.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteBlockedSiteStoredProcedure(BlockedSite blockedSite)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteBlockedSite'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'BlockedSite_Delete'.
            /// </summary>
            /// <param name="blockedSite">The 'BlockedSite' to Delete.</param>
            /// <returns>An instance of a 'DeleteBlockedSiteStoredProcedure' object.</returns>
            public static DeleteBlockedSiteStoredProcedure CreateDeleteBlockedSiteStoredProcedure(BlockedSite blockedSite)
            {
                // Initial Value
                DeleteBlockedSiteStoredProcedure deleteBlockedSiteStoredProcedure = new DeleteBlockedSiteStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteBlockedSiteStoredProcedure.Parameters = CreatePrimaryKeyParameter(blockedSite);

                // return value
                return deleteBlockedSiteStoredProcedure;
            }
            #endregion

            #region CreateFindBlockedSiteStoredProcedure(BlockedSite blockedSite)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindBlockedSiteStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'BlockedSite_Find'.
            /// </summary>
            /// <param name="blockedSite">The 'BlockedSite' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindBlockedSiteStoredProcedure CreateFindBlockedSiteStoredProcedure(BlockedSite blockedSite)
            {
                // Initial Value
                FindBlockedSiteStoredProcedure findBlockedSiteStoredProcedure = null;

                // verify blockedSite exists
                if(blockedSite != null)
                {
                    // Instanciate findBlockedSiteStoredProcedure
                    findBlockedSiteStoredProcedure = new FindBlockedSiteStoredProcedure();

                    // Now create parameters for this procedure
                    findBlockedSiteStoredProcedure.Parameters = CreatePrimaryKeyParameter(blockedSite);
                }

                // return value
                return findBlockedSiteStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(BlockedSite blockedSite)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new blockedSite.
            /// </summary>
            /// <param name="blockedSite">The 'BlockedSite' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(BlockedSite blockedSite)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify blockedSiteexists
                if(blockedSite != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", blockedSite.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Password] parameter
                    param = new SqlParameter("@Password", blockedSite.Password);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Url] parameter
                    param = new SqlParameter("@Url", blockedSite.Url);

                    // set parameters[2]
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertBlockedSiteStoredProcedure(BlockedSite blockedSite)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertBlockedSiteStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'BlockedSite_Insert'.
            /// </summary>
            /// <param name="blockedSite"The 'BlockedSite' object to insert</param>
            /// <returns>An instance of a 'InsertBlockedSiteStoredProcedure' object.</returns>
            public static InsertBlockedSiteStoredProcedure CreateInsertBlockedSiteStoredProcedure(BlockedSite blockedSite)
            {
                // Initial Value
                InsertBlockedSiteStoredProcedure insertBlockedSiteStoredProcedure = null;

                // verify blockedSite exists
                if(blockedSite != null)
                {
                    // Instanciate insertBlockedSiteStoredProcedure
                    insertBlockedSiteStoredProcedure = new InsertBlockedSiteStoredProcedure();

                    // Now create parameters for this procedure
                    insertBlockedSiteStoredProcedure.Parameters = CreateInsertParameters(blockedSite);
                }

                // return value
                return insertBlockedSiteStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(BlockedSite blockedSite)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing blockedSite.
            /// </summary>
            /// <param name="blockedSite">The 'BlockedSite' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(BlockedSite blockedSite)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify blockedSiteexists
                if(blockedSite != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", blockedSite.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Password]
                    param = new SqlParameter("@Password", blockedSite.Password);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Url]
                    param = new SqlParameter("@Url", blockedSite.Url);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", blockedSite.Id);
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateBlockedSiteStoredProcedure(BlockedSite blockedSite)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateBlockedSiteStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'BlockedSite_Update'.
            /// </summary>
            /// <param name="blockedSite"The 'BlockedSite' object to update</param>
            /// <returns>An instance of a 'UpdateBlockedSiteStoredProcedure</returns>
            public static UpdateBlockedSiteStoredProcedure CreateUpdateBlockedSiteStoredProcedure(BlockedSite blockedSite)
            {
                // Initial Value
                UpdateBlockedSiteStoredProcedure updateBlockedSiteStoredProcedure = null;

                // verify blockedSite exists
                if(blockedSite != null)
                {
                    // Instanciate updateBlockedSiteStoredProcedure
                    updateBlockedSiteStoredProcedure = new UpdateBlockedSiteStoredProcedure();

                    // Now create parameters for this procedure
                    updateBlockedSiteStoredProcedure.Parameters = CreateUpdateParameters(blockedSite);
                }

                // return value
                return updateBlockedSiteStoredProcedure;
            }
            #endregion

            #region CreateFetchAllBlockedSitesStoredProcedure(BlockedSite blockedSite)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllBlockedSitesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'BlockedSite_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllBlockedSitesStoredProcedure' object.</returns>
            public static FetchAllBlockedSitesStoredProcedure CreateFetchAllBlockedSitesStoredProcedure(BlockedSite blockedSite)
            {
                // Initial value
                FetchAllBlockedSitesStoredProcedure fetchAllBlockedSitesStoredProcedure = new FetchAllBlockedSitesStoredProcedure();

                // return value
                return fetchAllBlockedSitesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
