module FinFunSharp.Library

open NodaTime

let GenerateDatesList (dateFrom:ZonedDateTime)
                      (dateTo:ZonedDateTime)
                      (nextPay : ZonedDateTime -> ZonedDateTime)
                      (dateCorrection : ZonedDateTime -> ZonedDateTime)
                      : ZonedDateTime list =
    let rec go dateCurrent =
        if dateCurrent >= dateTo
        then [dateTo]
        else let dateNext = dateCurrent |> nextPay |> dateCorrection
             if dateNext <= dateCurrent then failwithf "The generated date %A is before the old date %A" dateNext dateCurrent
             dateCurrent :: go dateNext
    if dateFrom > dateTo then failwithf "dateFrom %A is after dateTo %A" dateFrom dateTo
    if dateFrom <> dateCorrection dateFrom then failwithf "dateFrom %A is not usable." dateFrom
    if dateTo <> dateCorrection dateTo then failwithf "dateTo %A is not usable." dateTo
    go dateFrom


let GenerateDatesArray (dateFrom:ZonedDateTime)
                       (dateTo:ZonedDateTime)
                       (nextPay : ZonedDateTime -> ZonedDateTime)
                       (dateCorrection : ZonedDateTime -> ZonedDateTime)
                       : ZonedDateTime[] =
    if dateFrom > dateTo then failwithf "dateFrom %A is after dateTo %A" dateFrom dateTo
    if dateFrom <> dateCorrection dateFrom then failwithf "dateFrom %A is not usable." dateFrom
    if dateTo <> dateCorrection dateTo then failwithf "dateTo %A is not usable." dateTo
    let dateCurrent = ref dateFrom
    [| while !dateCurrent < dateTo do
           yield !dateCurrent
           let dateNext = !dateCurrent |> nextPay |> dateCorrection
           if dateNext <= !dateCurrent then failwithf "The generated date %A is before the old date %A" dateNext !dateCurrent
           dateCurrent := dateNext
       yield dateTo
    |]


let GenerateDatesSeq (dateFrom:ZonedDateTime)
                     (dateTo:ZonedDateTime)
                     (nextPay : ZonedDateTime -> ZonedDateTime)
                     (dateCorrection : ZonedDateTime -> ZonedDateTime)
                     : seq<ZonedDateTime> =
    let generator dateCurrent =
        if dateCurrent >= dateTo
        then None
        else let dateNext = dateCurrent |> nextPay |> dateCorrection
             if dateNext <= dateCurrent then failwithf "The generated date %A is before the old date %A" dateNext dateCurrent
             Some (dateCurrent, dateNext)
    if dateFrom > dateTo then failwithf "dateFrom %A is after dateTo %A" dateFrom dateTo
    if dateFrom <> dateCorrection dateFrom then failwithf "dateFrom %A is not usable." dateFrom
    if dateTo <> dateCorrection dateTo then failwithf "dateTo %A is not usable." dateTo
    Seq.unfold generator dateFrom
    |> Seq.append (Seq.singleton dateTo)
