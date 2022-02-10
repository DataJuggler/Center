

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class ControllerManager
    /// <summary>
    /// This class manages the child controllers for this application.
    /// </summary>
    public class ControllerManager
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        private BlockedSiteController blockedsiteController;
        private FavoriteController favoriteController;
        private LaunchController launchController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ControllerManager' object.
        /// </summary>
        public ControllerManager(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;

            // Create Child Controllers
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child Controllers
            /// </summary>
            private void Init()
            {
                // Create Child Controllers
                this.BlockedSiteController = new BlockedSiteController(this.ErrorProcessor, this.AppController);
                this.FavoriteController = new FavoriteController(this.ErrorProcessor, this.AppController);
                this.LaunchController = new LaunchController(this.ErrorProcessor, this.AppController);
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

            #region BlockedSiteController
            public BlockedSiteController BlockedSiteController
            {
                get { return blockedsiteController; }
                set { blockedsiteController = value; }
            }
            #endregion

            #region FavoriteController
            public FavoriteController FavoriteController
            {
                get { return favoriteController; }
                set { favoriteController = value; }
            }
            #endregion

            #region LaunchController
            public LaunchController LaunchController
            {
                get { return launchController; }
                set { launchController = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
