// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SnapshotApplyMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SnapshotApplyMode
    {
        [EnumMember(Value = "CreateNew")]
        CreateNew
    }
    internal static class SnapshotApplyModeEnumExtension
    {
        internal static string ToSerializedValue(this SnapshotApplyMode? value)
        {
            return value == null ? null : ((SnapshotApplyMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SnapshotApplyMode value)
        {
            switch( value )
            {
                case SnapshotApplyMode.CreateNew:
                    return "CreateNew";
            }
            return null;
        }

        internal static SnapshotApplyMode? ParseSnapshotApplyMode(this string value)
        {
            switch( value )
            {
                case "CreateNew":
                    return SnapshotApplyMode.CreateNew;
            }
            return null;
        }
    }
}
