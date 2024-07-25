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

namespace SDL3;

public static partial class SDL
{
    /// <summary>
    /// Standard gamepad types.
    /// </summary>
    /// <remarks>
    /// This type does not necessarily map to first-party controllers from
    /// Microsoft/Sony/Nintendo; in many cases, third-party controllers can report
    /// as these, either because they were designed for a specific console, or they
    /// simply most closely match that console's controllers (does it have A/B/X/Y
    /// buttons or X/O/Square/Triangle? Does it have a touchpad? etc).
    /// </remarks>
    /// <since>This struct is available since SDL 3.0.0.</since>
    public enum GamepadType
    {
        Unknown = 0,
        Standard,
        Xbox360,
        XboxOne,
        PS3,
        PS4,
        PS5,
        NintendoSwitchPro,
        NintendoSwitchJoyconLeft,
        NintendoSwitchJoyconRight,
        NintendoSwitchJoyconPair,
        Max
    }
}