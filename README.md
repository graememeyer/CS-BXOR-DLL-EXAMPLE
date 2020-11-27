# CS-BXOR-DLL-EXAMPLE
An example project written in C# that demonstrates how to import a function from a C-compiled DLL. 

The DLL used in this example comes from my [BXOR-DLL](https://github.com/graememeyer/BXOR-DLL) project and implements a [bitwise XOR operation](https://en.wikipedia.org/wiki/Bitwise_operation#XOR).

# Usage
This project is a simple dotnet console application and should run in the standard dotnet debugger (e.g. through VSCode), as long as you have an appropriate version of .NET installed that can target "netcoreapp3.1". 

The expected output:

```
-------------------------------------------------------------------
You may only use the Microsoft .NET Core Debugger (vsdbg) with
Visual Studio Code, Visual Studio or Visual Studio for Mac software
to help you develop and test your applications.
-------------------------------------------------------------------

Initial string: This is a plaintext string.
Encoded string: >JJJJD
Decoded string: This is a plaintext string.

The program '[10476] CS-BXOR-DLL-Example.dll' has exited with code 0 (0x0).
```