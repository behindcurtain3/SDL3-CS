﻿#region License
/* SDL3# - C# Wrapper for SDL3
 *
 * Copyright (c) 2024 Eduard Gushchin.
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
 *
 * Eduard "edwardgushchin" Gushchin <eduardgushchin@yandex.ru>
 *
 */
#endregion

using System.Runtime.InteropServices;

namespace SDL3;

public static partial class SDL
{
    /// <summary>
    /// <para>A user-defined event type (event.user.*)</para>
    /// <para>This event is unique; it is never created by SDL, but only by the
    /// application. The event can be pushed onto the event queue using
    /// SDL_PushEvent(). The contents of the structure members are completely up to
    /// the programmer; the only requirement is that '''type''' is a value obtained
    /// from <see cref="RegisterEvents"/>.</para>
    /// </summary>
    /// <since>This struct is available since SDL 3.0.0.</since>
    [StructLayout(LayoutKind.Sequential)]
    public struct UserEvent
    {
        /// <summary>
        /// <see cref="EventType.User"/> through <see cref="EventType.Last"/>-1,
        /// Uint32 because these are not in the <see cref="EventType"/> enumeration
        /// </summary>
        public UInt64 Type;
        private UInt64 reserved;
        
        /// <summary>
        /// In nanoseconds, populated using <see cref="GetTicksNS"/>
        /// </summary>
        public UInt64 Timestamp;
        
        /// <summary>
        /// The associated window if any
        /// </summary>
        public UInt32 WindowID;
        
        /// <summary>
        /// User defined event code 
        /// </summary>
        public Int32 Code;
        
        /// <summary>
        /// User defined data pointer
        /// </summary>
        public IntPtr Data1;
        
        /// <summary>
        /// User defined data pointer
        /// </summary>
        public IntPtr Data2;
    }
}