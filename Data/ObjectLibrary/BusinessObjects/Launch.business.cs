
#region using statements

using System;

#endregion

namespace ObjectLibrary.BusinessObjects
{

    #region class Launch
    [Serializable]
    public partial class Launch
    {

        #region Private Variables
        private bool findByLaunchDate;
        #endregion

        #region Constructor
        public Launch()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Launch Clone()
            {
                // Create New Object
                Launch newLaunch = (Launch) this.MemberwiseClone();

                // Return Cloned Object
                return newLaunch;
            }
            #endregion

        #endregion

        #region Properties

            #region FindByLaunchDate
            /// <summary>
            /// This property gets or sets the value for 'FindByLaunchDate'.
            /// </summary>
            public bool FindByLaunchDate
            {
                get { return findByLaunchDate; }
                set { findByLaunchDate = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
