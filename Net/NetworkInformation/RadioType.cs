﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.

namespace System.Net.NetworkInformation
{
    /// <summary>
    /// Specifies the type of radio that the wireless network uses.
    /// </summary>
    public enum RadioType : byte
    {
        /// <summary>
        /// Not specified.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// 802.11a-compatible radio.
        /// </summary>
        _802_11a = 1,

        /// <summary>
        /// 802.11b-compatible radio.
        /// </summary>
        _802_11b = 2,

        /// <summary>
        /// 802.11g-compatible radio.
        /// </summary>
        _802_11g = 4,

        /// <summary>
        /// 802.11n-compatible radio.
        /// </summary>
        _802_11n = 8,
    }
}
