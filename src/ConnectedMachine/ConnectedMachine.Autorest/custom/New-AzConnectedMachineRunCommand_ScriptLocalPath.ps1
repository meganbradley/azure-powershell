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

function New-AzConnectedMachineRunCommand_ScriptLocalPath {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineRunCommand])]
    [CmdletBinding(PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
        [System.String]
        # The name of the hybrid machine.
        ${MachineName},

        [Parameter(Mandatory)]
        [ArgumentCompleter({ Get-AzResourceGroup | Select-Object -ExpandProperty ResourceGroupName })]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
        [System.String]
        # The name of the run command.
        ${RunCommandName},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.DefaultInfo(Script = '(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter(Mandatory)]
        [ArgumentCompleter({ Get-AzLocation | Where-Object Providers -Contains "Microsoft.HybridCompute" | Select-Object -ExpandProperty Location })]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # The geo-location where the resource lives
        ${Location},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Optional.
        # If set to true, provisioning will complete as soon as script starts and will not wait for script to complete.
        ${AsyncExecution},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Client Id (GUID value) of the user-assigned managed identity.
        # ObjectId should not be used if this is provided.
        ${ErrorBlobManagedIdentityClientId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Object Id (GUID value) of the user-assigned managed identity.
        # ClientId should not be used if this is provided.
        ${ErrorBlobManagedIdentityObjectId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the Azure storage blob where script error stream will be uploaded.
        # Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob.
        # Refer errorBlobManagedIdentity parameter.
        ${ErrorBlobUri},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Client Id (GUID value) of the user-assigned managed identity.
        # ObjectId should not be used if this is provided.
        ${OutputBlobManagedIdentityClientId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Object Id (GUID value) of the user-assigned managed identity.
        # ClientId should not be used if this is provided.
        ${OutputBlobManagedIdentityObjectId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the Azure storage blob where script output stream will be uploaded.
        # Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob.
        # Refer outputBlobManagedIdentity parameter.
        ${OutputBlobUri},

        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IRunCommandInputParameter[]]
        # The parameters used by the script.
        # To construct, see NOTES section for PARAMETER properties and create a hash table.
        ${Parameter},

        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IRunCommandInputParameter[]]
        # The parameters used by the script.
        # To construct, see NOTES section for PROTECTEDPARAMETER properties and create a hash table.
        ${ProtectedParameter},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the user account password on the machine when executing the run command.
        ${RunAsPassword},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the user account on the machine when executing the run command.
        ${RunAsUser},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Client Id (GUID value) of the user-assigned managed identity.
        # ObjectId should not be used if this is provided.
        ${ScriptUriManagedIdentityClientId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Object Id (GUID value) of the user-assigned managed identity.
        # ClientId should not be used if this is provided.
        ${ScriptUriManagedIdentityObjectId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the commandId of predefined built-in script.
        ${SourceCommandId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the script content to be executed on the machine.
        ${SourceScript},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the script download location.
        # It can be either SAS URI of an Azure storage blob with read access or public URI.
        ${SourceScriptUri},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.String]
        # Specifies the commandId of predefined built-in script.
        ${ScriptLocalPath},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(PossibleTypes = ([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceTags]))]
        [System.Collections.Hashtable]
        # Resource tags.
        ${Tag},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
        [System.Int32]
        # The timeout in seconds to execute the run command.
        ${TimeoutInSecond},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        if ($PSBoundParameters.ContainsKey("ScriptLocalPath"))
        {
            # Read Local File and add 
            $script = ""
            if ((Get-ChildItem $scriptLocalPath | Select-Object Extension).Extension -eq ".sh"){
                foreach ($line in Get-Content -Path $scriptLocalPath){
                    $words = $line.trim().split()
                    $commentFound = $false
                    foreach ($word in $words){
                        if ($word[0] -eq "#" -and $commentFound -eq $false){
                            $commentFound = $true
                            $script += "``" + $word + " "
                        }
                        else{
                            $script += $word + " "
                        }
                    }
                    $script = $script.trim()
                    #close 
                    if ($commentFound){
                    $script += "``"
                    }
                    $script += ";"
                }
            }
            else{
                foreach ($line in Get-Content -Path $scriptLocalPath){
                    $words = $line.trim().split()
                    $commentFound = $false
                    foreach ($word in $words){
                        if ($word[0] -eq "#" -and $commentFound -eq $false){
                            $commentFound = $true
                            $script += "<" + $word + " "
                        }
                        else{
                            $script += $word + " "
                        }
                    }
                    $script = $script.trim()
                    #close 
                    if ($commentFound){
                        $script += "#>"
                    }
                    $script += ";"
                }
            }
            
            $PSBoundParameters.Add("SourceScript", $script)
            # If necessary, remove the -ParameterA parameter from the dictionary of bound parameters
            $null = $PSBoundParameters.Remove("ScriptLocalPath")
        }
        Az.ConnectedMachine\New-AzConnectedMachineRunCommand @PSBoundParameters
    }
}