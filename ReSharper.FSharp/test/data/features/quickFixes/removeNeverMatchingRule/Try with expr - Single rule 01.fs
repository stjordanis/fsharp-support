module Module

do        
    try
        ()
    with
        | _ -> ()
        |{caret} deleted -> ()
    ()
