

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class LaunchReader
    /// <summary>
    /// This class loads a single 'Launch' object or a list of type <Launch>.
    /// </summary>
    public class LaunchReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Launch' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Launch' DataObject.</returns>
            public static Launch Load(DataRow dataRow)
            {
                // Initial Value
                Launch launch = new Launch();

                // Create field Integers
                int idfield = 0;
                int launchDatefield = 1;
                int siteIdfield = 2;
                int urlfield = 3;

                try
                {
                    // Load Each field
                    launch.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    launch.LaunchDate = DataHelper.ParseDate(dataRow.ItemArray[launchDatefield]);
                    launch.SiteId = DataHelper.ParseGuid(dataRow.ItemArray[siteIdfield]);
                    launch.Url = DataHelper.ParseString(dataRow.ItemArray[urlfield]);
                }
                catch
                {
                }

                // return value
                return launch;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Launch' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Launch Collection.</returns>
            public static List<Launch> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Launch> launchs = new List<Launch>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Launch' from rows
                        Launch launch = Load(row);

                        // Add this object to collection
                        launchs.Add(launch);
                    }
                }
                catch
                {
                }

                // return value
                return launchs;
            }
            #endregion

        #endregion

    }
    #endregion

}
