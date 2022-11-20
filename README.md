# CLM-Bypass
Bypass PowerShell (PS) constrainted language mode (CLM) through runspaces.

## Overview
Each PS session uses a "runspace." By creating our own runspace with C#, it's possible to bypass the restrictions of CLM and execute any PS commands we want.

## Usage
I'd recommend compiling with Visual Studio and at least .NET 3.5. Use a console application template. Edit the source to include the PS command you'd like executed. Execute the compiled executable using your preferred method.

## Warnings

You will probably need to manually add the System.Automation.Management.dll to your project.
