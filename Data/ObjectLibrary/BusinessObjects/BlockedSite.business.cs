

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class BlockedSite
    [Serializable]
    public partial class BlockedSite
    {

        #region Private Variables
        #endregion

        #region Constructor
        public BlockedSite()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public BlockedSite Clone()
            {
                // Create New Object
                BlockedSite newBlockedSite = (BlockedSite) this.MemberwiseClone();

                // Return Cloned Object
                return newBlockedSite;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
