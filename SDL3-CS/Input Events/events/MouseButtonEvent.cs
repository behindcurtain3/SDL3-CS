﻿#region License
/* Copyright (c) 2024 Eduard Gushchin.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 */
#endregion

using System.Runtime.InteropServices;

namespace SDL3;

public static partial class SDL
{
    /// <summary>
    /// Mouse button event structure (event.button.*)
    /// </summary>
    /// <since>This struct is available since SDL 3.1.3.</since>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseButtonEvent
    {
        /// <summary>
        /// <see cref="EventType.GamepadButtonDown"/> or <see cref="EventType.MouseButtonUp"/>
        /// </summary>
        public EventType Type;
        
        private UInt32 _reserved;
        
        /// <summary>
        /// In nanoseconds, populated using <see cref="GetTicksNS"/>
        /// </summary>
        public UInt64 Timestamp;
        
        /// <summary>
        /// The window with mouse focus, if any
        /// </summary>
        public UInt32 WindowID;
        
        /// <summary>
        /// The mouse instance id or <see cref="TouchMouseID"/>
        /// </summary>
        public UInt32 Which;
        
        /// <summary>
        /// The mouse button index
        /// </summary>
        public Byte Button;

        /// <summary>
        /// true if the button is pressed
        /// </summary>
        public Byte Down;

        /// <summary>
        /// 1 for single-click, 2 for double-click, etc.
        /// </summary>
        public Byte Clicks;

        private Byte _padding;

        /// <summary>
        /// X coordinate, relative to window
        /// </summary>
        public float X;

        /// <summary>
        /// Y coordinate, relative to window
        /// </summary>
        public float Y;
    }
}