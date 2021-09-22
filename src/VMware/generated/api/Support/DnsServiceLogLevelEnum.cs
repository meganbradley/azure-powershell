// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>DNS Service log level.</summary>
    public partial struct DnsServiceLogLevelEnum :
        System.IEquatable<DnsServiceLogLevelEnum>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum Debug = @"DEBUG";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum Error = @"ERROR";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum Fatal = @"FATAL";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum Info = @"INFO";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum Warning = @"WARNING";

        /// <summary>the value for an instance of the <see cref="DnsServiceLogLevelEnum" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DnsServiceLogLevelEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DnsServiceLogLevelEnum" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DnsServiceLogLevelEnum(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DnsServiceLogLevelEnum" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DnsServiceLogLevelEnum(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DnsServiceLogLevelEnum</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DnsServiceLogLevelEnum (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DnsServiceLogLevelEnum && Equals((DnsServiceLogLevelEnum)obj);
        }

        /// <summary>Returns hashCode for enum DnsServiceLogLevelEnum</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DnsServiceLogLevelEnum</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DnsServiceLogLevelEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DnsServiceLogLevelEnum" />.</param>

        public static implicit operator DnsServiceLogLevelEnum(string value)
        {
            return new DnsServiceLogLevelEnum(value);
        }

        /// <summary>Implicit operator to convert DnsServiceLogLevelEnum to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DnsServiceLogLevelEnum" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DnsServiceLogLevelEnum</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DnsServiceLogLevelEnum</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DnsServiceLogLevelEnum e2)
        {
            return e2.Equals(e1);
        }
    }
}