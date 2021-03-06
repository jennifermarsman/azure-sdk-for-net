// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VirtualNetworkUsage
    {
        internal static VirtualNetworkUsage DeserializeVirtualNetworkUsage(JsonElement element)
        {
            double? currentValue = default;
            string id = default;
            double? limit = default;
            VirtualNetworkUsageName name = default;
            string unit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = VirtualNetworkUsageName.DeserializeVirtualNetworkUsageName(property.Value);
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworkUsage(currentValue, id, limit, name, unit);
        }
    }
}
