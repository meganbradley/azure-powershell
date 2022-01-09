// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The properties of a storage account’s Blob service.</summary>
    public partial class BlobServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServiceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGenerated __resourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ResourceAutoGenerated();

        /// <summary>Backing field for <see cref="BlobServiceProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGenerated _blobServiceProperty;

        /// <summary>The properties of a storage account’s Blob service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGenerated BlobServiceProperty { get => (this._blobServiceProperty = this._blobServiceProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.BlobServicePropertiesAutoGenerated()); set => this._blobServiceProperty = value; }

        /// <summary>Automatic Snapshot is enabled if set to true.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? BlobServicePropertyAutomaticSnapshotPolicyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).AutomaticSnapshotPolicyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).AutomaticSnapshotPolicyEnabled = value ?? default(bool); }

        /// <summary>
        /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version
        /// is not specified. Possible values include version 2008-10-27 and all more recent versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string BlobServicePropertyDefaultServiceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DefaultServiceVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DefaultServiceVersion = value ?? null; }

        /// <summary>Indicates whether change feed event logging is enabled for the Blob service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? ChangeFeedEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).ChangeFeedEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).ChangeFeedEnabled = value ?? default(bool); }

        /// <summary>
        /// The List of CORS rules. You can include up to five CorsRule elements in the request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ICorsRule[] CorCorsRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).CorCorsRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).CorCorsRule = value ?? null /* arrayOf */; }

        /// <summary>
        /// Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum
        /// value can be 365.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int? DeleteRetentionPolicyDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DeleteRetentionPolicyDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DeleteRetentionPolicyDay = value ?? default(int); }

        /// <summary>Indicates whether DeleteRetentionPolicy is enabled for the Blob service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? DeleteRetentionPolicyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DeleteRetentionPolicyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DeleteRetentionPolicyEnabled = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type = value; }

        /// <summary>Internal Acessors for BlobServiceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesInternal.BlobServiceProperty { get => (this._blobServiceProperty = this._blobServiceProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.BlobServicePropertiesAutoGenerated()); set { {_blobServiceProperty = value;} } }

        /// <summary>Internal Acessors for BlobServicePropertyChangeFeed</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IChangeFeed Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesInternal.BlobServicePropertyChangeFeed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).ChangeFeed; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).ChangeFeed = value; }

        /// <summary>Internal Acessors for BlobServicePropertyCor</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ICorsRules Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesInternal.BlobServicePropertyCor { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).Cor; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).Cor = value; }

        /// <summary>Internal Acessors for BlobServicePropertyDeleteRetentionPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDeleteRetentionPolicy Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesInternal.BlobServicePropertyDeleteRetentionPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DeleteRetentionPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGeneratedInternal)BlobServiceProperty).DeleteRetentionPolicy = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="BlobServiceProperties" /> instance.</summary>
        public BlobServiceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
        }
    }
    /// The properties of a storage account’s Blob service.
    public partial interface IBlobServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGenerated
    {
        /// <summary>Automatic Snapshot is enabled if set to true.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Automatic Snapshot is enabled if set to true.",
        SerializedName = @"automaticSnapshotPolicyEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BlobServicePropertyAutomaticSnapshotPolicyEnabled { get; set; }
        /// <summary>
        /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version
        /// is not specified. Possible values include version 2008-10-27 and all more recent versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.",
        SerializedName = @"defaultServiceVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BlobServicePropertyDefaultServiceVersion { get; set; }
        /// <summary>Indicates whether change feed event logging is enabled for the Blob service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether change feed event logging is enabled for the Blob service.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ChangeFeedEnabled { get; set; }
        /// <summary>
        /// The List of CORS rules. You can include up to five CorsRule elements in the request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The List of CORS rules. You can include up to five CorsRule elements in the request. ",
        SerializedName = @"corsRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ICorsRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ICorsRule[] CorCorsRule { get; set; }
        /// <summary>
        /// Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum
        /// value can be 365.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum value can be 365.",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(int) })]
        int? DeleteRetentionPolicyDay { get; set; }
        /// <summary>Indicates whether DeleteRetentionPolicy is enabled for the Blob service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether DeleteRetentionPolicy is enabled for the Blob service.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DeleteRetentionPolicyEnabled { get; set; }

    }
    /// The properties of a storage account’s Blob service.
    internal partial interface IBlobServicePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal
    {
        /// <summary>The properties of a storage account’s Blob service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IBlobServicePropertiesAutoGenerated BlobServiceProperty { get; set; }
        /// <summary>Automatic Snapshot is enabled if set to true.</summary>
        bool? BlobServicePropertyAutomaticSnapshotPolicyEnabled { get; set; }
        /// <summary>The blob service properties for change feed events.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IChangeFeed BlobServicePropertyChangeFeed { get; set; }
        /// <summary>
        /// Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule
        /// elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ICorsRules BlobServicePropertyCor { get; set; }
        /// <summary>
        /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version
        /// is not specified. Possible values include version 2008-10-27 and all more recent versions.
        /// </summary>
        string BlobServicePropertyDefaultServiceVersion { get; set; }
        /// <summary>The blob service properties for soft delete.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDeleteRetentionPolicy BlobServicePropertyDeleteRetentionPolicy { get; set; }
        /// <summary>Indicates whether change feed event logging is enabled for the Blob service.</summary>
        bool? ChangeFeedEnabled { get; set; }
        /// <summary>
        /// The List of CORS rules. You can include up to five CorsRule elements in the request.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ICorsRule[] CorCorsRule { get; set; }
        /// <summary>
        /// Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum
        /// value can be 365.
        /// </summary>
        int? DeleteRetentionPolicyDay { get; set; }
        /// <summary>Indicates whether DeleteRetentionPolicy is enabled for the Blob service.</summary>
        bool? DeleteRetentionPolicyEnabled { get; set; }

    }
}