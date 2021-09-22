
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a script execution resource in a private cloud
.Description
Create or update a script execution resource in a private cloud
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecution
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

HIDDENPARAMETER <IScriptExecutionParameter[]>: Parameters that will be hidden/not visible to ARM, such as passwords and credentials
  Name <String>: The parameter name
  Type <ScriptExecutionParameterType>: The type of execution parameter

PARAMETER <IScriptExecutionParameter[]>: Parameters the script will accept
  Name <String>: The parameter name
  Type <ScriptExecutionParameterType>: The type of execution parameter
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwarescriptexecution
#>
function New-AzVMwareScriptExecution {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecution])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ScriptExecutionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the user-invoked script execution resource
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the private cloud.
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
    ${FailureReason},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[]]
    # Parameters that will be hidden/not visible to ARM, such as passwords and credentials
    # To construct, see NOTES section for HIDDENPARAMETER properties and create a hash table.
    ${HiddenParameter},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs]))]
    [System.Collections.Hashtable]
    # User-defined dictionary.
    ${NamedOutput},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String[]]
    # Standard output stream from the powershell execution
    ${Output},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[]]
    # Parameters the script will accept
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Time to live for the resource.
    # If not provided, will be available for 60 days
    ${Retention},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # A reference to the script cmdlet resource if user is running a AVS script
    ${ScriptCmdletId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Time limit for execution
    ${Timeout},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.private\New-AzVMwareScriptExecution_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
