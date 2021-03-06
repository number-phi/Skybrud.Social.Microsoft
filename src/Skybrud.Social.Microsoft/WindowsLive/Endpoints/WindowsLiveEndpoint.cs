﻿using Skybrud.Social.Microsoft.WindowsLive.Endpoints.Raw;
using Skybrud.Social.Microsoft.WindowsLive.Responses;

namespace Skybrud.Social.Microsoft.WindowsLive.Endpoints {
    
    /// <summary>
    /// Implementation of the Windows Live endpoint.
    /// </summary>
    public class WindowsLiveEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Microsoft service.
        /// </summary>
        public MicrosoftService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public WindowsLiveRawEndpoint Raw {
            get { return Service.Client.WindowsLive; }
        }

        #endregion

        #region Constructors

        internal WindowsLiveEndpoint(MicrosoftService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <see cref="WindowsLiveGetUserResponse"/> representing the response.</returns>
        public WindowsLiveGetUserResponse GetSelf() {
            return WindowsLiveGetUserResponse.ParseResponse(Raw.GetSelf());
        }

        /// <summary>
        /// Gets information about the user with the specified <code>userId</code>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>Returns an instance of <see cref="WindowsLiveGetUserResponse"/> representing the response.</returns>
        public WindowsLiveGetUserResponse GetUser(string userId) {
            return WindowsLiveGetUserResponse.ParseResponse(Raw.GetSelf());
        }

        #endregion

    }

}