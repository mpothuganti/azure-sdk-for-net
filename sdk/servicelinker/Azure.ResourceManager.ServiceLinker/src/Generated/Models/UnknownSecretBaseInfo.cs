// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The UnknownSecretBaseInfo. </summary>
    internal partial class UnknownSecretBaseInfo : SecretBaseInfo
    {
        /// <summary> Initializes a new instance of UnknownSecretBaseInfo. </summary>
        /// <param name="secretType"> The secret type. </param>
        internal UnknownSecretBaseInfo(LinkerSecretType secretType) : base(secretType)
        {
            SecretType = secretType;
        }
    }
}
