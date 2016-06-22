﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Qualia.WPF")>]
[<assembly: AssemblyProductAttribute("FSharp.Qualia")>]
[<assembly: AssemblyDescriptionAttribute("Event stream/rx based UI Framework and architecture")>]
[<assembly: AssemblyVersionAttribute("0.1.4")>]
[<assembly: AssemblyFileVersionAttribute("0.1.4")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.4"
    let [<Literal>] InformationalVersion = "0.1.4"
