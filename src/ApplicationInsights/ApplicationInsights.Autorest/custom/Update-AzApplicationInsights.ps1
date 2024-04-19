
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
Creates (or updates) an Application Insights component.
Note: You cannot specify a different value for InstrumentationKey nor AppId in the Put operation.
.Description
Creates (or updates) an Application Insights component.
Note: You cannot specify a different value for InstrumentationKey nor AppId in the Put operation.
.Link
https://learn.microsoft.com/powershell/module/az.applicationinsights/update-azapplicationinsights
#>
function Update-AzApplicationInsights {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IApplicationInsightsComponent])]
    [CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},
    
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
        [Alias("ApplicationInsightsComponentName", "ComponentName")]
        [System.String]
        # The name of the Application Insights component resource.
        ${Name},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},
    
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType])]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.ApplicationType]
        # Type of application being monitored.
        ${ApplicationType},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Disable IP masking.
        ${DisableIPMasking},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Disable Non-AAD based Auth.
        ${DisableLocalAuth},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.String]
        # Resource etag
        ${Etag},
    
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType])]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.FlowType]
        # Used by the Application Insights system to determine what kind of flow this component was created by.
        # This is to be set to 'Bluefield' when creating/updating a component via the REST API.
        ${FlowType},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Force users to create their own storage account for profiler and debugger.
        ${ForceCustomerStorageForProfiler},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.String]
        # The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp.
        ${HockeyAppId},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Purge data immediately after 30 days.
        ${ImmediatePurgeDataOn30Day},
    
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode])]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.IngestionMode]
        # Indicates the flow of the ingestion.
        ${IngestionMode},
    
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType])]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType]
        # The network access type for accessing Application Insights ingestion.
        ${PublicNetworkAccessForIngestion},
    
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType])]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.PublicNetworkAccessType]
        # The network access type for accessing Application Insights query.
        ${PublicNetworkAccessForQuery},
    
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource])]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.RequestSource]
        # Describes what tool created this Application Insights component.
        # Customers using this API should set this to the default 'rest'.
        ${RequestSource},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.Int32]
        # Retention period in days.
        ${RetentionInDays},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.Double]
        # Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry.
        ${SamplingPercentage},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [Alias("Tags")]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentsResourceTags]))]
        [System.Collections.Hashtable]
        # Resource tags
        ${Tag},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
        [System.String]
        # Resource Id of the log analytics workspace which the data will be ingested to.
        # This property is required to create an application with this API version.
        # Applications from older versions will not have this property.
        ${WorkspaceResourceId},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        # add PS bound parameters to run test
        $EnvPSBoundParameters = @{}
        if ($PSBoundParameters.ContainsKey('Debug')) {
            $EnvPSBoundParameters['Debug'] = $Debug
        }
        if ($PSBoundParameters.ContainsKey('HttpPipelineAppend')) {
            $EnvPSBoundParameters['HttpPipelineAppend'] = $HttpPipelineAppend
        }
        if ($PSBoundParameters.ContainsKey('HttpPipelinePrepend')) {
            $EnvPSBoundParameters['HttpPipelinePrepend'] = $HttpPipelinePrepend
        }
        if ($PSBoundParameters.ContainsKey('Proxy')) {
            $EnvPSBoundParameters['Proxy'] = $Proxy
        }
        if ($PSBoundParameters.ContainsKey('ProxyCredential')) {
            $EnvPSBoundParameters['ProxyCredential'] = $ProxyCredential
        }
        if ($PSBoundParameters.ContainsKey('ProxyUseDefaultCredentials')) {
            $EnvPSBoundParameters['ProxyUseDefaultCredentials'] = $ProxyUseDefaultCredentials
        }
        if ($PSBoundParameters.ContainsKey('SubscriptionId')) {
            $EnvPSBoundParameters['SubscriptionId'] = $SubscriptionId
        }
        if ($PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $EnvPSBoundParameters['ResourceGroupName'] = $ResourceGroupName
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $EnvPSBoundParameters['Name'] = $Name
        }

        try {
            $component = . Get-AzApplicationInsights @EnvPSBoundParameters
        } catch {
            Write-Warning "component $($PSBoundParameters['Name']) is not existed in Resource Group $($PSBoundParameters["ResourceGroupName"])"
            return
        }
        $PSBoundParameters["Location"] = $component.Location
        $PSBoundParameters["Kind"] = $component.Kind

        if (!$PSBoundParameters.ContainsKey("ApplicationType") -and ($null -ne $component.ApplicationType)) {
            $PSBoundParameters["ApplicationType"] = $component.ApplicationType
        }
        if (!$PSBoundParameters.ContainsKey("DisableIPMasking") -and ($null -ne $component.DisableIPMasking)) {
            $PSBoundParameters["DisableIPMasking"] = $component.DisableIPMasking
        }
        if (!$PSBoundParameters.ContainsKey("DisableLocalAuth") -and ($null -ne $component.DisableLocalAuth)) {
            $PSBoundParameters["DisableLocalAuth"] = $component.DisableLocalAuth
        }
        if (!$PSBoundParameters.ContainsKey("Etag") -and ($null -ne $component.Etag)) {
            $PSBoundParameters["Etag"] = $component.Etag
        }
        if (!$PSBoundParameters.ContainsKey("FlowType") -and ($null -ne $component.FlowType)) {
            $PSBoundParameters["FlowType"] = $component.FlowType
        }
        if (!$PSBoundParameters.ContainsKey("ForceCustomerStorageForProfiler") -and ($null -ne $component.ForceCustomerStorageForProfiler)) {
            $PSBoundParameters["ForceCustomerStorageForProfiler"] = $component.ForceCustomerStorageForProfiler
        }
        if (!$PSBoundParameters.ContainsKey("HockeyAppId") -and ($null -ne $component.HockeyAppId)) {
            $PSBoundParameters["HockeyAppId"] = $component.HockeyAppId
        }
        if (!$PSBoundParameters.ContainsKey("ImmediatePurgeDataOn30Day") -and ($null -ne $component.ImmediatePurgeDataOn30Day)) {
            $PSBoundParameters["ImmediatePurgeDataOn30Day"] = $component.ImmediatePurgeDataOn30Day
        }
        if (!$PSBoundParameters.ContainsKey("IngestionMode") -and ($null -ne $component.IngestionMode)) {
            $PSBoundParameters["IngestionMode"] = $component.IngestionMode
        }
        if (!$PSBoundParameters.ContainsKey("PublicNetworkAccessForIngestion") -and ($null -ne $component.PublicNetworkAccessForIngestion)) {
            $PSBoundParameters["PublicNetworkAccessForIngestion"] = $component.PublicNetworkAccessForIngestion
        }
        if (!$PSBoundParameters.ContainsKey("PublicNetworkAccessForQuery") -and ($null -ne $component.PublicNetworkAccessForQuery)) {
            $PSBoundParameters["PublicNetworkAccessForQuery"] = $component.PublicNetworkAccessForQuery
        }
        if (!$PSBoundParameters.ContainsKey("RequestSource") -and ($null -ne $component.RequestSource)) {
            $PSBoundParameters["RequestSource"] = $component.RequestSource
        }
        if (!$PSBoundParameters.ContainsKey("RetentionInDays") -and ($null -ne $component.RetentionInDay)) {
            $PSBoundParameters["RetentionInDays"] = $component.RetentionInDay
        }
        if (!$PSBoundParameters.ContainsKey("SamplingPercentage") -and ($null -ne $component.SamplingPercentage)) {
            $PSBoundParameters["SamplingPercentage"] = $component.SamplingPercentage
        }
        if (!$PSBoundParameters.ContainsKey("Tag") -and ($null -ne $component.Tag)) {
            $PSBoundParameters["Tag"] = [System.Collections.Hashtable]$component.Tag.AdditionalProperties
        }
        if (!$PSBoundParameters.ContainsKey("WorkspaceResourceId") -and ![System.String]::IsNullOrEmpty($component.WorkspaceResourceId)) {
            $PSBoundParameters["WorkspaceResourceId"] = $component.WorkspaceResourceId
        }

        . New-AzApplicationInsights @PSBoundParameters
    }
}
    
