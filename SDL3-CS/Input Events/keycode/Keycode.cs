﻿#region License

#endregion

namespace SDL3;

public static partial class SDL
{
    /// <summary>
    /// <para>The SDL virtual key representation.</para>
    /// <para>Values of this type are used to represent keyboard keys using the current
    /// layout of the keyboard. These values include Unicode values representing
    /// the unmodified character that would be generated by pressing the key, or an
    /// <c>SDLK_*</c> constant for those keys that do not generate characters.</para>
    /// <para>A special exception is the number keys at the top of the keyboard which map
    /// to SDLK_0...SDLK_9 on AZERTY layouts.</para>
    /// </summary>
    /// <since>This datatype is available since SDL 3.1.3.</since>
    public enum Keycode : uint
    {
        /// <summary>
        /// 0
        /// </summary>
        Unknown             = 0x00000000u,
        
        /// <summary>
        /// '\r'
        /// </summary>
        Return              = 0x0000000du,
        
        /// <summary>
        /// '\x1B'
        /// </summary>
        Escape              = 0x0000001bu,
        
        /// <summary>
        /// '\b'
        /// </summary>
        Backspace           = 0x00000008u,
        
        /// <summary>
        /// '\t'
        /// </summary>
        Tab                 = 0x00000009u,
        
        /// <summary>
        /// ' '
        /// </summary>
        Space               = 0x00000020u,
        
        /// <summary>
        /// '!'
        /// </summary>
        Exclaim             = 0x00000021u,
        
        /// <summary>
        /// '"'
        /// </summary>
        DblApostrophe       = 0x00000022u,
        
        /// <summary>
        /// '#'
        /// </summary>
        Hash                = 0x00000023u,
        
        /// <summary>
        /// '$'
        /// </summary>
        Dollar              = 0x00000024u,
        
        /// <summary>
        /// '%'
        /// </summary>
        Percent             = 0x00000025u,
        
        /// <summary>
        /// '&amp;'
        /// </summary>
        Ampersand           = 0x00000026u,
        
        /// <summary>
        /// '\''
        /// </summary>
        Apostrophe          = 0x00000027u,
        
        /// <summary>
        /// '('
        /// </summary>
        LeftParen           = 0x00000028u,
        
        /// <summary>
        /// ')'
        /// </summary>
        RightParen          = 0x00000029u,
        
        /// <summary>
        /// '*'
        /// </summary>
        Asterisk            = 0x0000002au,
        
        /// <summary>
        /// '+'
        /// </summary>
        Plus                = 0x0000002bu,
        
        /// <summary>
        /// ','
        /// </summary>
        Comma               = 0x0000002cu,
        
        /// <summary>
        /// '-'
        /// </summary>
        Minus               = 0x0000002du,
        
        /// <summary>
        /// '.'
        /// </summary>
        Period              = 0x0000002eu,
        
        /// <summary>
        /// '/'
        /// </summary>
        Slash               = 0x0000002fu,
        
        /// <summary>
        /// '0'
        /// </summary>
        Alpha0              = 0x00000030u,
        
        /// <summary>
        /// '1'
        /// </summary>
        Alpha1              = 0x00000031u,
        
        /// <summary>
        /// '2'
        /// </summary>
        Alpha2              = 0x00000032u,
        
        /// <summary>
        /// '3'
        /// </summary>
        Alpha3              = 0x00000033u,
        
        /// <summary>
        /// '4'
        /// </summary>
        Alpha4              = 0x00000034u,
        
        /// <summary>
        /// '5'
        /// </summary>
        Alpha5              = 0x00000035u,
        
        /// <summary>
        /// '6'
        /// </summary>
        Alpha6              = 0x00000036u,
        
        /// <summary>
        /// '7'
        /// </summary>
        Alpha7              = 0x00000037u,
        
        /// <summary>
        /// '8'
        /// </summary>
        Alpha8              = 0x00000038u,
        
        /// <summary>
        /// '9'
        /// </summary>
        Alpha9              = 0x00000039u,
        
        /// <summary>
        /// ':'
        /// </summary>
        Colon               = 0x0000003au,
        
        /// <summary>
        /// ';'
        /// </summary>
        Semicolon           = 0x0000003bu,
        
        /// <summary>
        /// '&lt;'
        /// </summary>
        Less                = 0x0000003cu,
        
        /// <summary>
        /// '='
        /// </summary>
        Equals              = 0x0000003du,
        
        /// <summary>
        /// '>'
        /// </summary>
        Greater             = 0x0000003eu,
        
        /// <summary>
        /// '?'
        /// </summary>
        Question            = 0x0000003fu,
        
        /// <summary>
        /// '@'
        /// </summary>
        At                  = 0x00000040u, 
        
        /// <summary>
        /// '['
        /// </summary>
        LeftBracket         = 0x0000005bu, 
        
        /// <summary>
        /// '\\'
        /// </summary>
        Backslash           = 0x0000005cu, 
        
        /// <summary>
        /// ']'
        /// </summary>
        RightBracket        = 0x0000005du,
        
        /// <summary>
        /// '^'
        /// </summary>
        Caret               = 0x0000005eu,
        
        /// <summary>
        /// '_'
        /// </summary>
        Underscore          = 0x0000005fu, 
        
        /// <summary>
        /// '`'
        /// </summary>
        Grave               = 0x00000060u,
        
        /// <summary>
        /// 'a'
        /// </summary>
        A                   = 0x00000061u,
        
        /// <summary>
        /// 'b'
        /// </summary>
        B                   = 0x00000062u,
        
        /// <summary>
        /// 'c'
        /// </summary>
        C                   = 0x00000063u,
        
        /// <summary>
        /// 'd'
        /// </summary>
        D                   = 0x00000064u,
        
        /// <summary>
        /// 'e'
        /// </summary>
        E                   = 0x00000065u,
        
        /// <summary>
        /// 'f'
        /// </summary>
        F                   = 0x00000066u,
        
        /// <summary>
        /// 'g'
        /// </summary>
        G                   = 0x00000067u,
        
        /// <summary>
        /// 'h'
        /// </summary>
        H                   = 0x00000068u,
        
        /// <summary>
        /// 'i'
        /// </summary>
        I                   = 0x00000069u,
        
        /// <summary>
        /// 'j'
        /// </summary>
        J                   = 0x0000006au,
        
        /// <summary>
        /// 'k'
        /// </summary>
        K                   = 0x0000006bu,
        
        /// <summary>
        /// 'l'
        /// </summary>
        L                   = 0x0000006cu,
        
        /// <summary>
        /// 'm'
        /// </summary>
        M                   = 0x0000006du,
        
        /// <summary>
        /// 'n'
        /// </summary>
        N                   = 0x0000006eu,
        
        /// <summary>
        /// 'o'
        /// </summary>
        O                   = 0x0000006fu,
        
        /// <summary>
        /// 'p'
        /// </summary>
        P                   = 0x00000070u,
        
        /// <summary>
        /// 'q'
        /// </summary>
        Q                   = 0x00000071u,
        
        /// <summary>
        /// 'r'
        /// </summary>
        R                   = 0x00000072u,
        
        /// <summary>
        /// 's'
        /// </summary>
        S                   = 0x00000073u,
        
        /// <summary>
        /// 't'
        /// </summary>
        T                   = 0x00000074u,
        
        /// <summary>
        /// 'u'
        /// </summary>
        U                   = 0x00000075u,
        
        /// <summary>
        /// 'v'
        /// </summary>
        V                   = 0x00000076u,
        
        /// <summary>
        /// 'w'
        /// </summary>
        W                   = 0x00000077u,
        
        /// <summary>
        /// 'x'
        /// </summary>
        X                   = 0x00000078u,
        
        /// <summary>
        /// 'y'
        /// </summary>
        Y                   = 0x00000079u,
        
        /// <summary>
        /// 'z'
        /// </summary>
        Z                   = 0x0000007au,
        
        /// <summary>
        /// '{'
        /// </summary>
        LeftBrace           = 0x0000007bu,
        
        /// <summary>
        /// '|'
        /// </summary>
        Pipe                = 0x0000007cu,
        
        /// <summary>
        /// '}'
        /// </summary>
        RightBrace          = 0x0000007du,
        
        /// <summary>
        /// '~'
        /// </summary>
        Tilde               = 0x0000007eu,
        
        /// <summary>
        /// '\x7F'
        /// </summary>
        Delete              = 0x0000007fu,
        
        /// <summary>
        /// '±'
        /// </summary>
        PlusMinus           = 0x000000b1u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Capslock)
        /// </summary>
        Capslock            = 0x40000039u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F1)
        /// </summary>
        F1                  = 0x4000003au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F2)
        /// </summary>
        F2                  = 0x4000003bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F3)
        /// </summary>
        F3                  = 0x4000003cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F4)
        /// </summary>
        F4                  = 0x4000003du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F5)
        /// </summary>
        F5                  = 0x4000003eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F6)
        /// </summary>
        F6                  = 0x4000003fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F7)
        /// </summary>
        F7                  = 0x40000040u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F8)
        /// </summary>
        F8                  = 0x40000041u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F9)
        /// </summary>
        F9                  = 0x40000042u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F10)
        /// </summary>
        F10                 = 0x40000043u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F11)
        /// </summary>
        F11                 = 0x40000044u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F12)
        /// </summary>
        F12                 = 0x40000045u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.PrintScreen)
        /// </summary>
        PrintScreen         = 0x40000046u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.ScrollLock)
        /// </summary>
        ScrolLlock          = 0x40000047u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Pause)
        /// </summary>
        Pause               = 0x40000048u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Insert)
        /// </summary>
        Insert              = 0x40000049u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Home)
        /// </summary>
        Home                = 0x4000004au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Pageup)
        /// </summary>
        Pageup              = 0x4000004bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.End)
        /// </summary>
        End                 = 0x4000004du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Pagedown)
        /// </summary>
        Pagedown            = 0x4000004eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Right)
        /// </summary>
        Right               = 0x4000004fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Left)
        /// </summary>
        Left                = 0x40000050u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Down)
        /// </summary>
        Down                = 0x40000051u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Up)
        /// </summary>
        Up                  = 0x40000052u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.NumLockClear)
        /// </summary>
        NumLockClear        = 0x40000053u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpDivide)
        /// </summary>
        KpDivide            = 0x40000054u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMultiply)
        /// </summary>
        KpMultiply          = 0x40000055u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMinus)
        /// </summary>
        KpMinus             = 0x40000056u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpPlus)
        /// </summary>
        KpPlus              = 0x40000057u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpEnter)
        /// </summary>
        KpEnter             = 0x40000058u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp1)
        /// </summary>
        Kp1                 = 0x40000059u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp2)
        /// </summary>
        Kp2                 = 0x4000005au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp3)
        /// </summary>
        Kp3                 = 0x4000005bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp4)
        /// </summary>
        Kp4                 = 0x4000005cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp5)
        /// </summary>
        Kp5                 = 0x4000005du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp6)
        /// </summary>
        Kp6                 = 0x4000005eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp7)
        /// </summary>
        Kp7                 = 0x4000005fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp8)
        /// </summary>
        Kp8                 = 0x40000060u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp9)
        /// </summary>
        Kp9                 = 0x40000061u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp0)
        /// </summary>
        Kp0                 = 0x40000062u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpPeriod)
        /// </summary>
        KpPeriod            = 0x40000063u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Application)
        /// </summary>
        Application         = 0x40000065u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Power)
        /// </summary>
        Power               = 0x40000066u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpEquals)
        /// </summary>
        KpEquals            = 0x40000067u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F13)
        /// </summary>
        F13                 = 0x40000068u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F14)
        /// </summary>
        F14                 = 0x40000069u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F15)
        /// </summary>
        F15                 = 0x4000006au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F16)
        /// </summary>
        F16                 = 0x4000006bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F17)
        /// </summary>
        F17                 = 0x4000006cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F18)
        /// </summary>
        F18                 = 0x4000006du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F19)
        /// </summary>
        F19                 = 0x4000006eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F20)
        /// </summary>
        F20                 = 0x4000006fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F21)
        /// </summary>
        F21                 = 0x40000070u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F22)
        /// </summary>
        F22                 = 0x40000071u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F23)
        /// </summary>
        F23                 = 0x40000072u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.F24)
        /// </summary>
        F24                 = 0x40000073u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Execute)
        /// </summary>
        Execute             = 0x40000074u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Help)
        /// </summary>
        Help                = 0x40000075u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Menu)
        /// </summary>
        Menu                = 0x40000076u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Select)
        /// </summary>
        Select              = 0x40000077u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Stop)
        /// </summary>
        Stop                = 0x40000078u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Again)
        /// </summary>
        Again               = 0x40000079u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Undo)
        /// </summary>
        Undo                = 0x4000007au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Cut)
        /// </summary>
        Cut                 = 0x4000007bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Copy)
        /// </summary>
        Copy                = 0x4000007cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Paste)
        /// </summary>
        Paste               = 0x4000007du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Find)
        /// </summary>
        Find                = 0x4000007eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Mute)
        /// </summary>
        Mute                = 0x4000007fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.VolumeUp)
        /// </summary>
        VolumeUp            = 0x40000080u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.VolumeDown)
        /// </summary>
        VolumeDown          = 0x40000081u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpComma)
        /// </summary>
        KpComma             = 0x40000085u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpEqualsAs400)
        /// </summary>
        KpEqualAas400       = 0x40000086u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AltErase)
        /// </summary>
        AltErase            = 0x40000099u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.SysReq)
        /// </summary>
        SysReq              = 0x4000009au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Cancel)
        /// </summary>
        Cancel              = 0x4000009bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Clear)
        /// </summary>
        Clear               = 0x4000009cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Prior)
        /// </summary>
        Prior               = 0x4000009du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Return2)
        /// </summary>
        Return2             = 0x4000009eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Separator)
        /// </summary>
        Separator           = 0x4000009fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Out)
        /// </summary>
        Out                 = 0x400000a0u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Oper)
        /// </summary>
        Oper                = 0x400000a1u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.ClearAgain)
        /// </summary>
        ClearAgain          = 0x400000a2u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.CrSel)
        /// </summary>
        CrSel               = 0x400000a3u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.ExSel)
        /// </summary>
        ExSel               = 0x400000a4u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp00)
        /// </summary>
        Kp00                = 0x400000b0u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Kp000)
        /// </summary>
        Kp000               = 0x400000b1u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.ThousandsSeparator)
        /// </summary>
        ThousandsSeparator  = 0x400000b2u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.DecimalSeparator)
        /// </summary>
        DecimalSeparator    = 0x400000b3u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.CurrencyUnit)
        /// </summary>
        CurrenCyUnit        = 0x400000b4u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.CurrencySubunit)
        /// </summary>
        CurrenCySubunit     = 0x400000b5u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpLeftParen)
        /// </summary>
        KpLeftParen         = 0x400000b6u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpRightParen)
        /// </summary>
        KpRightParen        = 0x400000b7u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpLeftBrace)
        /// </summary>
        KpLeftBrace         = 0x400000b8u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpRightBrace)
        /// </summary>
        KpRightBrace        = 0x400000b9u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpTab)
        /// </summary>
        KpTab               = 0x400000bau,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpBackspace)
        /// </summary>
        KpBackspace         = 0x400000bbu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpA)
        /// </summary>
        KpA                 = 0x400000bcu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpB)
        /// </summary>
        KpB                 = 0x400000bdu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpC)
        /// </summary>
        KpC                 = 0x400000beu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpD)
        /// </summary>
        KpD                 = 0x400000bfu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpE)
        /// </summary>
        KpE                 = 0x400000c0u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpF)
        /// </summary>
        KpF                 = 0x400000c1u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpXor)
        /// </summary>
        KpXor               = 0x400000c2u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpPower)
        /// </summary>
        KpPower             = 0x400000c3u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpPercent)
        /// </summary>
        KpPercent           = 0x400000c4u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpLess)
        /// </summary>
        KpLess              = 0x400000c5u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpGreater)
        /// </summary>
        KpGreater           = 0x400000c6u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpAmpersand)
        /// </summary>
        KpAmpersand         = 0x400000c7u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpDblAmpersand)
        /// </summary>
        KpDblAmpersand      = 0x400000c8u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpVerticalBar)
        /// </summary>
        KpVerticalBar       = 0x400000c9u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpDBLVERTICALBAR)
        /// </summary>
        KpDblVerticalBar    = 0x400000cau,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpDblVerticalBar)
        /// </summary>
        KpColon             = 0x400000cbu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpHash)
        /// </summary>
        KpHash              = 0x400000ccu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpSpace)
        /// </summary>
        KpSpace             = 0x400000cdu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpAt) 
        /// </summary>
        KpAt                = 0x400000ceu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpExClam)
        /// </summary>
        KpExClam            = 0x400000cfu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemStore)
        /// </summary>
        KpMemStore          = 0x400000d0u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemRecall)
        /// </summary>
        KpMemRecall         = 0x400000d1u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemClear)
        /// </summary>
        KpMemClear          = 0x400000d2u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemAdd)
        /// </summary>
        KpMemAdd            = 0x400000d3u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemSubtract)
        /// </summary>
        KpMemSubtract       = 0x400000d4u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemMultiply)
        /// </summary>
        KpMemMultiply       = 0x400000d5u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpMemDivide)
        /// </summary>
        KpMemDivide         = 0x400000d6u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpPlusMinus)
        /// </summary>
        KpPlusMinus         = 0x400000d7u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpClear)
        /// </summary>
        KpClear             = 0x400000d8u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpClearEntry)
        /// </summary>
        KpClearEntry        = 0x400000d9u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpBinary)
        /// </summary>
        KpBinary            = 0x400000dau,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpOctal)
        /// </summary>
        KpOctal             = 0x400000dbu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpDecimal)
        /// </summary>
        KpDecimal           = 0x400000dcu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.KpHexadecimal)
        /// </summary>
        KpHexadecimal       = 0x400000ddu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.LCtrl)
        /// </summary>
        LCtrl               = 0x400000e0u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.LShift)
        /// </summary>
        LShift              = 0x400000e1u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.LAlt)
        /// </summary>
        LAlt                = 0x400000e2u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.LGUI)
        /// </summary>
        LGui                = 0x400000e3u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.RCtrl)
        /// </summary>
        RCtrl               = 0x400000e4u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.RShift)
        /// </summary>
        RShift              = 0x400000e5u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.RAlt)
        /// </summary>
        RAlt                = 0x400000e6u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.RGui)
        /// </summary>
        RGUI                = 0x400000e7u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Mode)
        /// </summary>
        Mode                = 0x40000101u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Sleep)
        /// </summary>
        Sleep               = 0x40000102u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Wake)
        /// </summary>
        Wake                = 0x40000103u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.ChannelIncrement)
        /// </summary>
        ChannelIncrement    = 0x40000104u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.ChannelDecrement)
        /// </summary>
        ChannelDecrement    = 0x40000105u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaPlay)
        /// </summary>
        MediaPlay           = 0x40000106u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaPause)
        /// </summary>
        MediaPause          = 0x40000107u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaRecord)
        /// </summary>
        MediaRecord         = 0x40000108u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaFastForward)
        /// </summary>
        MediaFastForward    = 0x40000109u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaRewind)
        /// </summary>
        MediaRewind         = 0x4000010au,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaNextTrack)
        /// </summary>
        MediaNextTrack      = 0x4000010bu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaPreviousTrack)
        /// </summary>
        MediaPreviousTrack  = 0x4000010cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaStop)
        /// </summary>
        MediaStop           = 0x4000010du, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaEject)
        /// </summary>
        MediaEject          = 0x4000010eu, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaPlayPause)
        /// </summary>
        MediaPlayPause      = 0x4000010fu, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.MediaSelect)
        /// </summary>
        MediaSelect         = 0x40000110u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcNew)
        /// </summary>
        AcNew               = 0x40000111u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcOpen)
        /// </summary>
        AcOpen              = 0x40000112u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcClose)
        /// </summary>
        AcClose             = 0x40000113u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcExit)
        /// </summary>
        AcExit              = 0x40000114u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcSave)
        /// </summary>
        AcSave              = 0x40000115u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcPrint)
        /// </summary>
        AcPrint             = 0x40000116u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcProperties)
        /// </summary>
        AcProperties        = 0x40000117u, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcSearch)
        /// </summary>
        AcSearch            = 0x40000118u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcHome)
        /// </summary>
        AcHome              = 0x40000119u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcBack)
        /// </summary>
        AcBack              = 0x4000011au, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcForward)
        /// </summary>
        AcForward           = 0x4000011bu, 
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcStop)
        /// </summary>
        AcStop              = 0x4000011cu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcRefresh)
        /// </summary>
        AcRefresh           = 0x4000011du,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.AcBookmarks)
        /// </summary>
        AcBookmarks         = 0x4000011eu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.SoftLeft)
        /// </summary>
        SoftLeft            = 0x4000011fu,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.SoftRight)
        /// </summary>
        SoftRight           = 0x40000120u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.Call)
        /// </summary>
        Call                = 0x40000121u,
        
        /// <summary>
        /// SDL.ScancodeToKeycode(SDL.Scancode.EndCall)
        /// </summary>
        EndCall             = 0x40000122u
    }
}