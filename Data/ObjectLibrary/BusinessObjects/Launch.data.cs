

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Launch
    public partial class Launch
    {

        #region Private Variables
        private int id;
        private DateTime launchDate;
        private Guid siteId;
        private string url;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region DateTime LaunchDate
            public DateTime LaunchDate
            {
                get
                {
                    return launchDate;
                }
                set
                {
                    launchDate = value;
                }
            }
            #endregion

            #region Guid SiteId
            public Guid SiteId
            {
                get
                {
                    return siteId;
                }
                set
                {
                    siteId = value;
                }
            }
            #endregion

            #region string Url
            public string Url
            {
                get
                {
                    return url;
                }
                set
                {
                    url = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
