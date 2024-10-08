// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxDeploymentListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeploymentListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeployment[] _value;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeployment[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="NginxDeploymentListResponse" /> instance.</summary>
        public NginxDeploymentListResponse()
        {

        }
    }
    public partial interface INginxDeploymentListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeployment) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeployment[] Value { get; set; }

    }
    internal partial interface INginxDeploymentListResponseInternal

    {
        string NextLink { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api202401Preview.INginxDeployment[] Value { get; set; }

    }
}