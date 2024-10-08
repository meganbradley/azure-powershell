// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Azure Resource Manager resource envelope.</summary>
    public partial class Schedule :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedule,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.Resource();

        /// <summary>[Required] Specifies the action type of the schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleActionType ActionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).ActionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).ActionType = value ; }

        /// <summary>The asset description text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)Property).Description = value ?? null; }

        /// <summary>Display name of schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Is the schedule enabled?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? IsEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).IsEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).IsEnabled = value ?? default(bool); }

        /// <summary>Internal Acessors for Action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleActionBase Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).Action = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleProperties Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ScheduleProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningStatus? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Trigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBase Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleInternal.Trigger { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).Trigger; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).Trigger = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleProperties _property;

        /// <summary>[Required] Additional attributes of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ScheduleProperties()); set => this._property = value; }

        /// <summary>Provisioning state for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningStatus? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).ProvisioningState; }

        /// <summary>The asset property dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties ResourceBaseProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)Property).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)Property).Property = value ?? null /* model class */; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType)""); }

        /// <summary>Tag dictionary. Tags can be added, removed, and updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)Property).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)Property).Tag = value ?? null /* model class */; }

        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string TriggerEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerEndTime = value ?? null; }

        /// <summary>Specifies start time of schedule in ISO 8601 format, but without a UTC offset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string TriggerStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerStartTime = value ?? null; }

        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string TriggerTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerTimeZone = value ?? null; }

        /// <summary>[Required]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType TriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISchedulePropertiesInternal)Property).TriggerType = value ; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Backing field for <see cref="XmsAsyncOperationTimeout" /> property.</summary>
        private global::System.TimeSpan? _xmsAsyncOperationTimeout;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.TimeSpan? XmsAsyncOperationTimeout { get => this._xmsAsyncOperationTimeout; set => this._xmsAsyncOperationTimeout = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("x-ms-async-operation-timeout", out var __xMSAsyncOperationTimeoutHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleInternal)this).XmsAsyncOperationTimeout = System.Linq.Enumerable.FirstOrDefault(__xMSAsyncOperationTimeoutHeader0) is string __headerXMSAsyncOperationTimeoutHeader0 ? global::System.TimeSpan.TryParse( __headerXMSAsyncOperationTimeoutHeader0, out global::System.TimeSpan __headerXMSAsyncOperationTimeoutHeader0Value ) ? __headerXMSAsyncOperationTimeoutHeader0Value : default(global::System.TimeSpan?) : default(global::System.TimeSpan?);
            }
        }

        /// <summary>Creates an new <see cref="Schedule" /> instance.</summary>
        public Schedule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Azure Resource Manager resource envelope.
    public partial interface ISchedule :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResource
    {
        /// <summary>[Required] Specifies the action type of the schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] Specifies the action type of the schedule",
        SerializedName = @"actionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleActionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleActionType ActionType { get; set; }
        /// <summary>The asset description text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The asset description text.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Display name of schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of schedule.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Is the schedule enabled?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is the schedule enabled?",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEnabled { get; set; }
        /// <summary>Provisioning state for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state for the schedule.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningStatus? ProvisioningState { get;  }
        /// <summary>The asset property dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The asset property dictionary.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties ResourceBaseProperty { get; set; }
        /// <summary>Tag dictionary. Tags can be added, removed, and updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tag dictionary. Tags can be added, removed, and updated.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags Tag { get; set; }
        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        Recommented format would be ""2022-06-01T00:00:01""
        If not present, the schedule will run indefinitely",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(string) })]
        string TriggerEndTime { get; set; }
        /// <summary>Specifies start time of schedule in ISO 8601 format, but without a UTC offset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies start time of schedule in ISO 8601 format, but without a UTC offset.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string TriggerStartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies time zone in which the schedule runs.
        TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TriggerTimeZone { get; set; }
        /// <summary>[Required]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] ",
        SerializedName = @"triggerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType TriggerType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"x-ms-async-operation-timeout",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? XmsAsyncOperationTimeout { get; set; }

    }
    /// Azure Resource Manager resource envelope.
    internal partial interface IScheduleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal
    {
        /// <summary>[Required] Specifies the action of the schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleActionBase Action { get; set; }
        /// <summary>[Required] Specifies the action type of the schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleActionType ActionType { get; set; }
        /// <summary>The asset description text.</summary>
        string Description { get; set; }
        /// <summary>Display name of schedule.</summary>
        string DisplayName { get; set; }
        /// <summary>Is the schedule enabled?</summary>
        bool? IsEnabled { get; set; }
        /// <summary>[Required] Additional attributes of the entity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScheduleProperties Property { get; set; }
        /// <summary>Provisioning state for the schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningStatus? ProvisioningState { get; set; }
        /// <summary>The asset property dictionary.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties ResourceBaseProperty { get; set; }
        /// <summary>Tag dictionary. Tags can be added, removed, and updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags Tag { get; set; }
        /// <summary>[Required] Specifies the trigger details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBase Trigger { get; set; }
        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        string TriggerEndTime { get; set; }
        /// <summary>Specifies start time of schedule in ISO 8601 format, but without a UTC offset.</summary>
        string TriggerStartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        string TriggerTimeZone { get; set; }
        /// <summary>[Required]</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType TriggerType { get; set; }

        global::System.TimeSpan? XmsAsyncOperationTimeout { get; set; }

    }
}