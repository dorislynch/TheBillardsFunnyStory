using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace The.Billards.Funny.Story.RNTheBillardsFunnyStory
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTheBillardsFunnyStoryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTheBillardsFunnyStoryModule"/>.
        /// </summary>
        internal RNTheBillardsFunnyStoryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTheBillardsFunnyStory";
            }
        }
    }
}
