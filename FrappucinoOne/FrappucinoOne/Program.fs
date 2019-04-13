// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System.Runtime.InteropServices
open System

module NativeWrapper =
    [<DllImport(@"C:\Users\tyler.kvochick\Dropbox (TEECOM)\git\frappucino\FrappucinoOne\Debug\FOCore.dll", CallingConvention=CallingConvention.Cdecl)>]
    extern void HelloWorld()

[<EntryPoint>]
let main argv = 
    NativeWrapper.HelloWorld()
    Console.ReadLine() |> ignore
    0 // return an integer exit code
