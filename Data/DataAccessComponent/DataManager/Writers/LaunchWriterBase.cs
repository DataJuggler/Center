

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

    #region class LaunchWriterBase
    /// <summary>
    /// This class is used for converting a 'Launch' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class LaunchWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Launch launch)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='launch'>The 'Launch' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Launch launch)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (launch != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", launch.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteLaunchStoredProcedure(Launch launch)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteLaunch'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Launch_Delete'.
            /// </summary>
            /// <param name="launch">The 'Launch' to Delete.</param>
            /// <returns>An instance of a 'DeleteLaunchStoredProcedure' object.</returns>
            public static DeleteLaunchStoredProcedure CreateDeleteLaunchStoredProcedure(Launch launch)
            {
                // Initial Value
                DeleteLaunchStoredProcedure deleteLaunchStoredProcedure = new DeleteLaunchStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteLaunchStoredProcedure.Parameters = CreatePrimaryKeyParameter(launch);

                // return value
                return deleteLaunchStoredProcedure;
            }
            #endregion

            #region CreateFindLaunchStoredProcedure(Launch launch)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindLaunchStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Launch_Find'.
            /// </summary>
            /// <param name="launch">The 'Launch' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindLaunchStoredProcedure CreateFindLaunchStoredProcedure(Launch launch)
            {
                // Initial Value
                FindLaunchStoredProcedure findLaunchStoredProcedure = null;

                // verify launch exists
                if(launch != null)
                {
                    // Instanciate findLaunchStoredProcedure
                    findLaunchStoredProcedure = new FindLaunchStoredProcedure();

                    // Now create parameters for this procedure
                    findLaunchStoredProcedure.Parameters = CreatePrimaryKeyParameter(launch);
                }

                // return value
                return findLaunchStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Launch launch)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new launch.
            /// </summary>
            /// <param name="launch">The 'Launch' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Launch launch)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify launchexists
                if(launch != null)
                {
                    // Create [LaunchDate] Parameter
                    param = new SqlParameter("@LaunchDate", SqlDbType.DateTime);

                    // If launch.LaunchDate does not exist.
                    if (launch.LaunchDate.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = launch.LaunchDate;
                    }
                    // set parameters[0]
                    parameters[0] = param;

                    // Create [SiteId] parameter
                    param = new SqlParameter("@SiteId", launch.SiteId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Url] parameter
                    param = new SqlParameter("@Url", launch.Url);

                    // set parameters[2]
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertLaunchStoredProcedure(Launch launch)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertLaunchStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Launch_Insert'.
            /// </summary>
            /// <param name="launch"The 'Launch' object to insert</param>
            /// <returns>An instance of a 'InsertLaunchStoredProcedure' object.</returns>
            public static InsertLaunchStoredProcedure CreateInsertLaunchStoredProcedure(Launch launch)
            {
                // Initial Value
                InsertLaunchStoredProcedure insertLaunchStoredProcedure = null;

                // verify launch exists
                if(launch != null)
                {
                    // Instanciate insertLaunchStoredProcedure
                    insertLaunchStoredProcedure = new InsertLaunchStoredProcedure();

                    // Now create parameters for this procedure
                    insertLaunchStoredProcedure.Parameters = CreateInsertParameters(launch);
                }

                // return value
                return insertLaunchStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Launch launch)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing launch.
            /// </summary>
            /// <param name="launch">The 'Launch' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Launch launch)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify launchexists
                if(launch != null)
                {
                    // Create parameter for [LaunchDate]
                    // Create [LaunchDate] Parameter
                    param = new SqlParameter("@LaunchDate", SqlDbType.DateTime);

                    // If launch.LaunchDate does not exist.
                    if (launch.LaunchDate.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = launch.LaunchDate;
                    }

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [SiteId]
                    param = new SqlParameter("@SiteId", launch.SiteId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Url]
                    param = new SqlParameter("@Url", launch.Url);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", launch.Id);
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateLaunchStoredProcedure(Launch launch)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateLaunchStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Launch_Update'.
            /// </summary>
            /// <param name="launch"The 'Launch' object to update</param>
            /// <returns>An instance of a 'UpdateLaunchStoredProcedure</returns>
            public static UpdateLaunchStoredProcedure CreateUpdateLaunchStoredProcedure(Launch launch)
            {
                // Initial Value
                UpdateLaunchStoredProcedure updateLaunchStoredProcedure = null;

                // verify launch exists
                if(launch != null)
                {
                    // Instanciate updateLaunchStoredProcedure
                    updateLaunchStoredProcedure = new UpdateLaunchStoredProcedure();

                    // Now create parameters for this procedure
                    updateLaunchStoredProcedure.Parameters = CreateUpdateParameters(launch);
                }

                // return value
                return updateLaunchStoredProcedure;
            }
            #endregion

            #region CreateFetchAllLaunchsStoredProcedure(Launch launch)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllLaunchsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Launch_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllLaunchsStoredProcedure' object.</returns>
            public static FetchAllLaunchsStoredProcedure CreateFetchAllLaunchsStoredProcedure(Launch launch)
            {
                // Initial value
                FetchAllLaunchsStoredProcedure fetchAllLaunchsStoredProcedure = new FetchAllLaunchsStoredProcedure();

                // return value
                return fetchAllLaunchsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
