using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Wants.Software.Dimming.RNWantsSoftwareDimming
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNWantsSoftwareDimmingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNWantsSoftwareDimmingModule"/>.
        /// </summary>
        internal RNWantsSoftwareDimmingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNWantsSoftwareDimming";
            }
        }
    }
}
