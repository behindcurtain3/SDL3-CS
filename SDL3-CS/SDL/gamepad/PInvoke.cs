﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

public static partial class SDL
{
    [LibraryImport(SDLLibrary)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial int SDL_AddGamepadMapping(byte* mapping);
    public static unsafe int AddGamepadMapping(string mapping)
    {
        var utf8NameBufSize = UTF8Size(mapping);
        var utf8Name = stackalloc byte[utf8NameBufSize];
        return SDL_AddGamepadMapping(UTF8Encode(mapping, utf8Name, utf8NameBufSize));
    }
    

    public static int AddGamepadMappingsFromIO(Stream src, bool closeio = true)
    {
        var reader = new StreamReader(src);

        while (!reader.EndOfStream)
        {
            var mapping = reader.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(mapping))
            {
                return AddGamepadMapping(mapping);
            }
        }

        if (closeio) reader.Close();
        return -1;
    }
    
    
    [LibraryImport(SDLLibrary)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial int SDL_AddGamepadMappingsFromFile(byte* file);
    public static unsafe int AddGamepadMappingsFromFile(string file)
    {
        var utf8NameBufSize = UTF8Size(file);
        var utf8Name = stackalloc byte[utf8NameBufSize];
        return SDL_AddGamepadMapping(UTF8Encode(file, utf8Name, utf8NameBufSize));
    }
    
    
    [LibraryImport(SDLLibrary)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial int SDL_ReloadGamepadMappings();
    public static int ReloadGamepadMappings() => SDL_ReloadGamepadMappings();
    
    
    [LibraryImport(SDLLibrary)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe partial IntPtr SDL_GetGamepadMappings(out int count);
    public static string?[] GetGamepadMappings(out int count)
    {
        var arrayPtr = SDL_GetGamepadMappings(out count);
        
        if (arrayPtr == IntPtr.Zero || count == 0)
        {
            return [];
        }

        var mappings = new string?[count];
        var ptrArray = new IntPtr[count];
        Marshal.Copy(arrayPtr, ptrArray, 0, count);
        Free(arrayPtr);

        for (var i = 0; i < count; i++)
        {
            mappings[i] = Marshal.PtrToStringAnsi(ptrArray[i]);
        }

        return mappings;
    }
}