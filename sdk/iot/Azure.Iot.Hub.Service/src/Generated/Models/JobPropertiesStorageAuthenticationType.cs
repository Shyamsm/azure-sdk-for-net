// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Specifies authentication type being used for connecting to storage account. </summary>
    public readonly partial struct JobPropertiesStorageAuthenticationType : IEquatable<JobPropertiesStorageAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobPropertiesStorageAuthenticationType"/> values are the same. </summary>
        public JobPropertiesStorageAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyBasedValue = "keyBased";
        private const string IdentityBasedValue = "identityBased";

        /// <summary> keyBased. </summary>
        public static JobPropertiesStorageAuthenticationType KeyBased { get; } = new JobPropertiesStorageAuthenticationType(KeyBasedValue);
        /// <summary> identityBased. </summary>
        public static JobPropertiesStorageAuthenticationType IdentityBased { get; } = new JobPropertiesStorageAuthenticationType(IdentityBasedValue);
        /// <summary> Determines if two <see cref="JobPropertiesStorageAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(JobPropertiesStorageAuthenticationType left, JobPropertiesStorageAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobPropertiesStorageAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(JobPropertiesStorageAuthenticationType left, JobPropertiesStorageAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobPropertiesStorageAuthenticationType"/>. </summary>
        public static implicit operator JobPropertiesStorageAuthenticationType(string value) => new JobPropertiesStorageAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobPropertiesStorageAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobPropertiesStorageAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}