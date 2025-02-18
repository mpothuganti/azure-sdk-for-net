// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabVirtualMachineResetPasswordContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("username");
            writer.WriteStringValue(Username);
            writer.WritePropertyName("password");
            writer.WriteStringValue(Password);
            writer.WriteEndObject();
        }
    }
}
