// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;

    /// <summary>Storage Profile properties of a server</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageTypeConverter))]
    public partial class Storage
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Storage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Storage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Storage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Storage(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Storage" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Storage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Storage(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).SizeGb = (int?) content.GetValueForProperty("SizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).SizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Iop = (int?) content.GetValueForProperty("Iop",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Iop, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).AutoGrow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("AutoGrow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).AutoGrow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Sku, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.Storage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Storage(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).SizeGb = (int?) content.GetValueForProperty("SizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).SizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Iop = (int?) content.GetValueForProperty("Iop",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Iop, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).AutoGrow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("AutoGrow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).AutoGrow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorageInternal)this).Sku, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Storage Profile properties of a server
    [System.ComponentModel.TypeConverter(typeof(StorageTypeConverter))]
    public partial interface IStorage

    {

    }
}