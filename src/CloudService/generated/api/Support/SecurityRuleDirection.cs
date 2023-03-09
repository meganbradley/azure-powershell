// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support
{

    /// <summary>
    /// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
    /// </summary>
    public partial struct SecurityRuleDirection :
        System.IEquatable<SecurityRuleDirection>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection Inbound = @"Inbound";

        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection Outbound = @"Outbound";

        /// <summary>the value for an instance of the <see cref="SecurityRuleDirection" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SecurityRuleDirection</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SecurityRuleDirection" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SecurityRuleDirection(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SecurityRuleDirection</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SecurityRuleDirection (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SecurityRuleDirection && Equals((SecurityRuleDirection)obj);
        }

        /// <summary>Returns hashCode for enum SecurityRuleDirection</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SecurityRuleDirection"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SecurityRuleDirection(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SecurityRuleDirection</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SecurityRuleDirection</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SecurityRuleDirection" />.</param>

        public static implicit operator SecurityRuleDirection(string value)
        {
            return new SecurityRuleDirection(value);
        }

        /// <summary>Implicit operator to convert SecurityRuleDirection to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SecurityRuleDirection" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SecurityRuleDirection</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection e1, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SecurityRuleDirection</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection e1, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection e2)
        {
            return e2.Equals(e1);
        }
    }
}