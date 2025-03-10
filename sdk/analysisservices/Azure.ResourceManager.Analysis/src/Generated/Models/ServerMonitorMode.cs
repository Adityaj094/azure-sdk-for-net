// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> The server monitor mode for AS server. </summary>
    public readonly partial struct ServerMonitorMode : IEquatable<ServerMonitorMode>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="ServerMonitorMode"/>. </summary>
        public ServerMonitorMode(int value)
        {
            _value = value;
        }

        private const int ZeroValue = 0;
        private const int OneValue = 1;

        /// <summary> 0. </summary>
        public static ServerMonitorMode Zero { get; } = new ServerMonitorMode(ZeroValue);
        /// <summary> 1. </summary>
        public static ServerMonitorMode One { get; } = new ServerMonitorMode(OneValue);
        /// <summary> Determines if two <see cref="ServerMonitorMode"/> values are the same. </summary>
        public static bool operator ==(ServerMonitorMode left, ServerMonitorMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerMonitorMode"/> values are not the same. </summary>
        public static bool operator !=(ServerMonitorMode left, ServerMonitorMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerMonitorMode"/>. </summary>
        public static implicit operator ServerMonitorMode(int value) => new ServerMonitorMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerMonitorMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerMonitorMode other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
