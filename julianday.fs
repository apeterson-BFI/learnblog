namespace julianday

module julianmod = 
  open System

  let daysOfMonth =      [| 0; 31; 28; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31 |]
  let leapDaysOfMonth  = [| 0; 31; 29; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31 |]

  let errorMessage = "mono julianday.exe [mode] [modeoption]"

  let julDaysOfMonth (leap : bool) = 
    match leap with
    | false -> daysOfMonth
    | true -> leapDaysOfMonth

  let getJulian (month : int) (day : int) (leap : bool) =
    let julDays = leap |> julDaysOfMonth

    if month < 1 then failwith errorMessage
    elif month > 12 then failwith errorMessage
    elif day < 1 then failwith errorMessage 
    elif day > julDays.[month] then failwith errorMessage
    else
      julDays
      |> Seq.take month  // Taking n months takes from 0 to n - 1 (up to prev month)
      |> Seq.sum
      |> (+) day         // nth of month = sum of prior months + n

  let getLeap (year : int) =
    if year % 4 <> 0 then false
    elif year % 100 <> 0 then true
    elif year % 400 <> 0 then false
    else true 

  let (|Int|_|) str = 
    match System.Int32.TryParse(str) with 
    | (true,int) -> Some(int)
    | _ -> None

  let julianParse (monthText : string) (dayText : string) (leap : bool) = 
    match monthText, dayText with
    | Int month, Int day -> getJulian month day leap
    | _ -> failwith errorMessage

  let julianAutoParse (yearText : string) (monthText : string) (dayText : string) =
    match yearText with
    | Int year -> julianParse monthText dayText (getLeap year)
    | _ -> failwith errorMessage

  let julianCalc (args : string list) =
    match args with
    | ["md-normal"; monthText; dayText] -> julianParse monthText dayText false 
    | ["md-leap"; monthText; dayText] -> julianParse monthText dayText true
    | ["dm-normal"; dayText; monthText] -> julianParse monthText dayText false
    | ["dm-leap"; dayText; monthText] -> julianParse monthText dayText true
    | ["mdy-auto"; monthText; dayText; yearText] -> julianAutoParse yearText monthText dayText
    | ["dmy-auto"; dayText; monthText; yearText] -> julianAutoParse yearText monthText dayText
    | ["ymd-auto"; yearText; monthText; dayText] -> julianAutoParse yearText monthText dayText
    | _ -> failwith "mono julianday.exe [mode] [mode params]"

  [<EntryPoint>]
  let Main(args) = 
    try
      let jul = julianCalc (List.ofArray args)
      printfn "%i" jul
    with
      | :? System.Exception as ermess -> printfn "%s" (ermess.Message)

    0
