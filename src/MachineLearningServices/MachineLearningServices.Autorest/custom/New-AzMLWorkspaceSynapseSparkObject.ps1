
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for SynapseSpark.
.Description
Create an in-memory object for SynapseSpark.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark
.Link
https://learn.microsoft.com/powershell/module/Az.MachineLearningServices/new-AzMLWorkspaceSynapseSparkObject
#>
function New-AzMLWorkspaceSynapseSparkObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter()]
        [int]
        $AutoPausePropertyDelayInMinute,
        [Parameter()]
        [bool]
        $AutoPausePropertyEnabled,
        [Parameter()]
        [bool]
        $AutoScalePropertyEnabled,
        [Parameter()]
        [int]
        $AutoScalePropertyMaxNodeCount,
        [Parameter()]
        [int]
        $AutoScalePropertyMinNodeCount,
        [Parameter(HelpMessage="The number of compute nodes currently assigned to the compute.")]
        [int]
        $NodeCount,
        [Parameter(HelpMessage="Node size.")]
        [string]
        $NodeSize,
        [Parameter(HelpMessage="Node size family.")]
        [string]
        $NodeSizeFamily,
        [Parameter(HelpMessage="Pool name.")]
        [string]
        $PoolName,
        [Parameter(HelpMessage="Name of the resource group in which workspace is located.")]
        [string]
        $ResourceGroup,
        [Parameter(HelpMessage="Spark version.")]
        [string]
        $SparkVersion,
        [Parameter(HelpMessage="Azure subscription identifier.")]
        [string]
        $SubscriptionId,
        [Parameter(HelpMessage="Name of Azure Machine Learning workspace.")]
        [string]
        $WorkspaceName,
        [Parameter(HelpMessage="The description of the Machine Learning compute.")]
        [string]
        $Description,
        [Parameter(HelpMessage="Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.")]
        [bool]
        $DisableLocalAuth,
        [Parameter(HelpMessage="ARM resource id of the underlying compute.")]
        [string]
        $ResourceId
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark]::New()
        $Object.Type = 'SynapseSpark'

        if ($PSBoundParameters.ContainsKey('AutoPausePropertyDelayInMinute')) {
            $Object.AutoPausePropertyDelayInMinute = $AutoPausePropertyDelayInMinute
        }
        if ($PSBoundParameters.ContainsKey('AutoPausePropertyEnabled')) {
            $Object.AutoPausePropertyEnabled = $AutoPausePropertyEnabled
        }
        if ($PSBoundParameters.ContainsKey('AutoScalePropertyEnabled')) {
            $Object.AutoScalePropertyEnabled = $AutoScalePropertyEnabled
        }
        if ($PSBoundParameters.ContainsKey('AutoScalePropertyMaxNodeCount')) {
            $Object.AutoScalePropertyMaxNodeCount = $AutoScalePropertyMaxNodeCount
        }
        if ($PSBoundParameters.ContainsKey('AutoScalePropertyMinNodeCount')) {
            $Object.AutoScalePropertyMinNodeCount = $AutoScalePropertyMinNodeCount
        }
        if ($PSBoundParameters.ContainsKey('NodeCount')) {
            $Object.NodeCount = $NodeCount
        }
        if ($PSBoundParameters.ContainsKey('NodeSize')) {
            $Object.NodeSize = $NodeSize
        }
        if ($PSBoundParameters.ContainsKey('NodeSizeFamily')) {
            $Object.NodeSizeFamily = $NodeSizeFamily
        }
        if ($PSBoundParameters.ContainsKey('PoolName')) {
            $Object.PoolName = $PoolName
        }
        if ($PSBoundParameters.ContainsKey('ResourceGroup')) {
            $Object.ResourceGroup = $ResourceGroup
        }
        if ($PSBoundParameters.ContainsKey('SparkVersion')) {
            $Object.SparkVersion = $SparkVersion
        }
        if ($PSBoundParameters.ContainsKey('SubscriptionId')) {
            $Object.SubscriptionId = $SubscriptionId
        }
        if ($PSBoundParameters.ContainsKey('WorkspaceName')) {
            $Object.WorkspaceName = $WorkspaceName
        }
        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('DisableLocalAuth')) {
            $Object.DisableLocalAuth = $DisableLocalAuth
        }
        if ($PSBoundParameters.ContainsKey('ResourceId')) {
            $Object.ResourceId = $ResourceId
        }
        return $Object
    }
}

