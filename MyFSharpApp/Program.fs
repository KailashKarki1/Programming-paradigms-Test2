// Define a record type for Movie
type Movie = {
    Name: string
    RunLength: int
    Genre: string
    Director: string
    DirectorNumberOfMovies: int
    ImdbRating: float
}

// Create instances of movies according to the table
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = "Drama"; Director = "Sian Heder"; DirectorNumberOfMovies = 9; ImdbRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = "Comedy"; Director = "Kenneth Branagh"; DirectorNumberOfMovies = 23; ImdbRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = "Comedy"; Director = "Adam McKay"; DirectorNumberOfMovies = 27; ImdbRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = "Drama"; Director = "Ryusuke Hamaguchi"; DirectorNumberOfMovies = 16; ImdbRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = "Fantasy"; Director = "Denis Villeneuve"; DirectorNumberOfMovies = 24; ImdbRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = "Sport"; Director = "Reinaldo Marcus Green"; DirectorNumberOfMovies = 15; ImdbRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = "Comedy"; Director = "Paul Thomas Anderson"; DirectorNumberOfMovies = 49; ImdbRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = "Thriller"; Director = "Guillermo Del Toro"; DirectorNumberOfMovies = 22; ImdbRating = 7.1 }
]

// Identify probable Oscar winners with IMDB rating greater than 7.4
let probableOscarWinners = movies |> List.filter (fun movie -> movie.ImdbRating > 7.4)

// Convert movie run length to hours and minutes format
let convertRunLengthToHoursMinutes runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let runLengthsInHoursMinutes = movies |> List.map (fun movie -> convertRunLengthToHoursMinutes movie.RunLength)

// Print the results
printfn "Probable Oscar Winners:"
probableOscarWinners |> List.iter (fun movie -> printfn "%s" movie.Name)

printfn "\nRun Lengths in Hours and Minutes:"
runLengthsInHoursMinutes |> List.iter (fun runLength -> printfn "%s" runLength)
