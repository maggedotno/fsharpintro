﻿#r "FSharp.Data.TypeProviders"
#r @"packages\FSharpx.TypeProviders.Regex.1.6.122\lib\40\Fsharpx.TypeProviders.Regex.dll"

type DateRegex = FSharpx.Regex< @"(?<Day>\d{2}).(?<Month>\d{2}).(?<Year>\d{4})">

let isMatch = DateRegex.IsMatch "17.12.2012"

let dateMatch = DateRegex().Match("17.12.2012")


// We get intellisense for the regex match.
let day = dateMatch.Day.Value
let month = dateMatch.Month.Value
let year = dateMatch.Year.Value