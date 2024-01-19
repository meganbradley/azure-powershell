$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzResourceMoverMoveCollection.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzResourceMoverMoveCollection' {
    It 'Delete' {
        $moveCollectionName  = "MoveColRemoveTest"
        $moveCollection = New-AzResourceMoverMoveCollection -Name $moveCollectionName  -ResourceGroupName $env.moveCollectionMetadataRG -SubscriptionId $env.SubscriptionId -SourceRegion "eastus" -TargetRegion "westus2" -Location "eastus2euap" -EnableSystemAssignedIdentity
        $moveCollection.Name | Should -Be $moveCollectionName
        $removeResp = Remove-AzResourceMoverMoveCollection -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.moveCollectionMetadataRG -MoveCollectionName $moveCollectionName
        $removeResp.Status | Should -Be "Succeeded"
    }
}
