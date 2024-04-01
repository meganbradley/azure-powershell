if(($null -eq $TestName) -or ($TestName -contains 'Read-AzMySqlMaintenance'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Read-AzMySqlMaintenance.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Read-AzMySqlMaintenance' {
    It 'Read' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ReadViaIdentityFlexibleServer' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ReadViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
