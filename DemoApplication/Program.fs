// Needed to read the console
open System
// Create a immutable game type (immutable data, defining data models)
type GameState = { Target: int; Attempts: int }
// Generates a random target number between 1 and 100
let generateTarget () = 
    let rand = Random()
    rand.Next(1, 101)

//////// IMPLEMENT -> Check if the guess is correct, too high or too low
let checkGuess guess state = 
    ()



//////// IMPLEMENT -> gameloop with pattern matching (|>)
let rec gameLoop state =
    printf "Enter your guess: "
    let input = Console.ReadLine()
    ()



// Main functionality
[<EntryPoint>]
let main argv =
    printfn "Welcome to the Number Guessing Game!"
    // Generate the target number and initialize the game state
    let initialState = { Target = generateTarget(); Attempts = 0 }
    // Start the game loop
    initialState |> gameLoop
    0 // Return an integer exit code
