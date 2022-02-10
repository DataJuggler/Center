
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

    #region class LaunchWriter
    /// <summary>
    /// This class is used for converting a 'Launch' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class LaunchWriter : LaunchWriterBase
    {

        #region Static Methods

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
            public static new FindLaunchStoredProcedure CreateFindLaunchStoredProcedure(Launch launch)
            {
                // Initial Value
                FindLaunchStoredProcedure findLaunchStoredProcedure = null;

                // verify launch exists
                if(launch != null)
                {
                    // Instanciate findLaunchStoredProcedure
                    findLaunchStoredProcedure = new FindLaunchStoredProcedure();

                    // if launch.FindByLaunchDate is true
                    if (launch.FindByLaunchDate)
                    {
                        // Change the procedure name
                        findLaunchStoredProcedure.ProcedureName = "Launch_FindByLaunchDate";
                        
                        // Create the @LaunchDate parameter
                        findLaunchStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@LaunchDate", launch.LaunchDate);
                    }
                    else
                    {
                        // Now create parameters for this procedure
                        findLaunchStoredProcedure.Parameters = CreatePrimaryKeyParameter(launch);
                    }
                }

                // return value
                return findLaunchStoredProcedure;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
