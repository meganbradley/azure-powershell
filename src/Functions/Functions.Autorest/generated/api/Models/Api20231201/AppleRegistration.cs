// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The configuration settings of the registration for the Apple provider</summary>
    public partial class AppleRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppleRegistration,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppleRegistrationInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The Client ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; set => this._clientId = value; }

        /// <summary>Backing field for <see cref="ClientSecretSettingName" /> property.</summary>
        private string _clientSecretSettingName;

        /// <summary>The app setting name that contains the client secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string ClientSecretSettingName { get => this._clientSecretSettingName; set => this._clientSecretSettingName = value; }

        /// <summary>Creates an new <see cref="AppleRegistration" /> instance.</summary>
        public AppleRegistration()
        {

        }
    }
    /// The configuration settings of the registration for the Apple provider
    public partial interface IAppleRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>The Client ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Client ID of the app used for login.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get; set; }
        /// <summary>The app setting name that contains the client secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app setting name that contains the client secret.",
        SerializedName = @"clientSecretSettingName",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecretSettingName { get; set; }

    }
    /// The configuration settings of the registration for the Apple provider
    internal partial interface IAppleRegistrationInternal

    {
        /// <summary>The Client ID of the app used for login.</summary>
        string ClientId { get; set; }
        /// <summary>The app setting name that contains the client secret.</summary>
        string ClientSecretSettingName { get; set; }

    }
}