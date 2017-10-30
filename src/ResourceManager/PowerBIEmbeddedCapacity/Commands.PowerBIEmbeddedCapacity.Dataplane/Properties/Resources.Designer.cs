﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.PowerBIEmbeddedCapacity.Dataplane.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.PowerBIEmbeddedCapacity.Dataplane.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure PowerShell collects usage data in order to improve your experience.
        ///The data is anonymous and does not include commandline argument values.
        ///The data is collected by Microsoft.
        ///
        ///Use the Disable-AzureRmDataCollection cmdlet to turn the feature Off. The cmdlet can be found in the AzureRM.Profile module.  To disable data collection: PS &gt; Disable-AzureRmDataCollection.
        ///Use the Enable-AzureRmDataCollection cmdlet to turn the feature On. The cmdlet can be found in the AzureRM.Profile module.  To enable  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ARMDataCollectionMessage {
            get {
                return ResourceManager.GetString("ARMDataCollectionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string Confirm {
            get {
                return ResourceManager.GetString("Confirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export log from PowerBI Embedded Capacity.
        /// </summary>
        internal static string ExportingLogFromPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("ExportingLogFromPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing log to file {0}.
        /// </summary>
        internal static string ExportingLogOverwriteWarning {
            get {
                return ResourceManager.GetString("ExportingLogOverwriteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The capacity name {0} is not valid in the current rollout environment. Please login to a specific rollout environment or specify the fully qualified capacityname..
        /// </summary>
        internal static string InvalidCapacityName {
            get {
                return ResourceManager.GetString("InvalidCapacityName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login to {0}.
        /// </summary>
        internal static string LoginTarget {
            get {
                return ResourceManager.GetString("LoginTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run Login-PowerBIEmbeddedCapacityAzureAccount to login to PowerBI Embedded Capacity {0}.
        /// </summary>
        internal static string NotLoggedInMessage {
            get {
                return ResourceManager.GetString("NotLoggedInMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to send sync request to specified capacity. CapacityName: {0}, RootActivityId: {1}, Date (UTC): {2}, Details: {3}..
        /// </summary>
        internal static string PostSyncRequestFailureMessage {
            get {
                return ResourceManager.GetString("PostSyncRequestFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restart PowerBI Embedded Capacity.
        /// </summary>
        internal static string RestartingPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("RestartingPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get the status of the sync operation. CapacityName: {0}, RootActivityId: {1}, Date (UTC): {2}. Details: {3}.
        /// </summary>
        internal static string SyncASPollStatusFailureMessage {
            get {
                return ResourceManager.GetString("SyncASPollStatusFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get the status of the synchronization request for the specified database. CapacityName: {0}, RootActivityId: {1}, Date (UTC): {2}, Details: {3}..
        /// </summary>
        internal static string SyncASPollStatusUnknownMessage {
            get {
                return ResourceManager.GetString("SyncASPollStatusUnknownMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Synchronization failed with an exception..
        /// </summary>
        internal static string SynchronizationFailedException {
            get {
                return ResourceManager.GetString("SynchronizationFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replicate databases from the processing InvalidCapacityName to the query scale-out capacities.
        /// </summary>
        internal static string SynchronizingPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("SynchronizingPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown PowerBI Embedded Capacity environment name specified..
        /// </summary>
        internal static string UnknownEnvironment {
            get {
                return ResourceManager.GetString("UnknownEnvironment", resourceCulture);
            }
        }
    }
}