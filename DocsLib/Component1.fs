

module DocsLib
open System
open System.Reflection

module Naming =
    let innerType(info:Type) = info.Namespace + "." + info.Name
    let typeName(info:Type) = "T:" + innerType(info)
    let propName(info:PropertyInfo) = "P:" + innerType(info.DeclaringType) + "." + info.Name
    let eventName(info:EventInfo) = "E:" + innerType(info.DeclaringType) + "." + info.Name
    let eventName(info:EventInfo) = "E:" + innerType(info.DeclaringType) + "." + info.Name



