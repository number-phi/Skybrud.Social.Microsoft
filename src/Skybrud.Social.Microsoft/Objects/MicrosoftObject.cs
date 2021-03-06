﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Microsoft.Objects {

    /// <summary>
    /// Class representing a basic object from one of the Microsoft APIs derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class MicrosoftObject {

        #region Properties

        /// <summary>
        /// Gets the internal <see cref="JObject"/> the object was created from.
        /// </summary>
        [JsonIgnore]
        public JObject JObject { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected MicrosoftObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}