// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Extensions;

    /// <summary>The aggregation expression to be used in the forecast.</summary>
    public partial class ForecastAggregation :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastAggregation,
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastAggregationInternal
    {

        /// <summary>Backing field for <see cref="Function" /> property.</summary>
        private string _function= @"Sum";

        /// <summary>The name of the aggregation function to use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Function { get => this._function; }

        /// <summary>Internal Acessors for Function</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastAggregationInternal.Function { get => this._function; set { {_function = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName _name;

        /// <summary>The name of the column to aggregate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ForecastAggregation" /> instance.</summary>
        public ForecastAggregation()
        {

        }
    }
    /// The aggregation expression to be used in the forecast.
    public partial interface IForecastAggregation :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.IJsonSerializable
    {
        /// <summary>The name of the aggregation function to use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The name of the aggregation function to use.",
        SerializedName = @"function",
        PossibleTypes = new [] { typeof(string) })]
        string Function { get;  }
        /// <summary>The name of the column to aggregate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the column to aggregate.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName Name { get; set; }

    }
    /// The aggregation expression to be used in the forecast.
    public partial interface IForecastAggregationInternal

    {
        /// <summary>The name of the aggregation function to use.</summary>
        string Function { get; set; }
        /// <summary>The name of the column to aggregate.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.FunctionName Name { get; set; }

    }
}