

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class BlockedSiteReader
    /// <summary>
    /// This class loads a single 'BlockedSite' object or a list of type <BlockedSite>.
    /// </summary>
    public class BlockedSiteReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'BlockedSite' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'BlockedSite' DataObject.</returns>
            public static BlockedSite Load(DataRow dataRow)
            {
                // Initial Value
                BlockedSite blockedSite = new BlockedSite();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;
                int passwordfield = 2;
                int urlfield = 3;

                try
                {
                    // Load Each field
                    blockedSite.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    blockedSite.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    blockedSite.Password = DataHelper.ParseString(dataRow.ItemArray[passwordfield]);
                    blockedSite.Url = DataHelper.ParseString(dataRow.ItemArray[urlfield]);
                }
                catch
                {
                }

                // return value
                return blockedSite;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'BlockedSite' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A BlockedSite Collection.</returns>
            public static List<BlockedSite> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<BlockedSite> blockedSites = new List<BlockedSite>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'BlockedSite' from rows
                        BlockedSite blockedSite = Load(row);

                        // Add this object to collection
                        blockedSites.Add(blockedSite);
                    }
                }
                catch
                {
                }

                // return value
                return blockedSites;
            }
            #endregion

        #endregion

    }
    #endregion

}
