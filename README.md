# themis-maui-prototype
Prototype project which uses themis SecureCell in C# on iOS and android with MAUI toolchain


---

This demo has `no UI`. So you should look at the `Application Output` in your visual studio. There you should see two set of logs :
1. `cross-platform demo` - the code is invoked by the managed C# logic of the .net MAUI application
2. demo for a target platform - the code is invoked from `MainActivity`or `AppDelegate` according to your target platform.

See the examples below:


## Expected logs for Android demo
```
[DOTNET] [themis demo] Initial Text: Droid binding plain text message
[DOTNET] [themis demo] Encrypting...
[DOTNET] [themis demo] Initial Text base64: RHJvaWQgYmluZGluZyBwbGFpbiB0ZXh0IG1lc3NhZ2U=
[DOTNET] [themis demo] Done.
[DOTNET] [themis demo] cipher Text: 
[DOTNET] [themis demo] cipher Text base64: AAEBQAwAAAAQAAAAIAAAABXw4V8Ci3eAJvZvPky/7C7sWW5taPsqaRVmtzrgGi3QNzouwWw3ddvPYqHybmISK1EiZVIhtXoar1Ik6g==
[DOTNET] [themis demo] Decrypted Text: Droid binding plain text message
[DOTNET] [themis demo] Decrypted Text base64: RHJvaWQgYmluZGluZyBwbGFpbiB0ZXh0IG1lc3NhZ2U=
```


## Expected logs for iOS demo
```
2023-03-13 13:47:59.976 ThemisMauiSample[11168:2329276] Initial Text: iOS binding plain text message
2023-03-13 13:47:59.976 ThemisMauiSample[11168:2329276] Initial Text base64: aU9TIGJpbmRpbmcgcGxhaW4gdGV4dCBtZXNzYWdl
2023-03-13 13:47:59.976 ThemisMauiSample[11168:2329276] Encrypting...
2023-03-13 13:47:59.999 ThemisMauiSample[11168:2329276] ciphertext: <cannot be printed from NSData in Xamarin.iOS> | probably a security measure by themis team
2023-03-13 13:47:59.999 ThemisMauiSample[11168:2329276] ciphertext base64: AAEBQAwAAAAQAAAAHgAAAOOJqkhVA1xNu9yjMP+3Mgac1DIUJw9lOvwTCnzmra7k0B3ZSs+48bNMGBTWq1ZD8rcB4nvD3kgZSeI=
2023-03-13 13:48:00.000 ThemisMauiSample[11168:2329276] Decrypting...
2023-03-13 13:48:00.001 ThemisMauiSample[11168:2329276] Decrypted text: iOS binding plain text message
2023-03-13 13:48:00.002 ThemisMauiSample[11168:2329276] Decrypted text base64: aU9TIGJpbmRpbmcgcGxhaW4gdGV4dCBtZXNzYWdl
```


## Expected logs for cross-platform (.net MAUI) demo
```
2023-03-13 13:48:03.376 ThemisMauiSample[11168:2329276] [themis demo forms] Initial Text: Xamarin.Forms plain text message
2023-03-13 13:48:03.376 ThemisMauiSample[11168:2329276] [themis demo forms] Initial Text base64: WGFtYXJpbi5Gb3JtcyBwbGFpbiB0ZXh0IG1lc3NhZ2U=
2023-03-13 13:48:03.377 ThemisMauiSample[11168:2329276] [themis demo forms] Encrypting...
2023-03-13 13:48:03.378 ThemisMauiSample[11168:2329276] [themis demo forms] Done.
2023-03-13 13:48:03.382 ThemisMauiSample[11168:2329276] [themis demo forms] cipher Text: 
2023-03-13 13:48:03.382 ThemisMauiSample[11168:2329276] [themis demo forms] cipher Text base64: AAEBQAwAAAAQAAAAIAAAADBaC5zD6F6lW78xZvpFuaHNxFsbhOWgViRBX3Up9ZsOHOrUnPwimkRWUqVNVPYofonG3wHGKqYHEAIj2w==
2023-03-13 13:48:03.383 ThemisMauiSample[11168:2329276] [themis demo forms] Decrypted Text: Xamarin.Forms plain text message
2023-03-13 13:48:03.383 ThemisMauiSample[11168:2329276] [themis demo forms] Decrypted Text base64: WGFtYXJpbi5Gb3JtcyBwbGFpbiB0ZXh0IG1lc3NhZ2U=
```
