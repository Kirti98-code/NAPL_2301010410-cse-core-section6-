
#r "nuget: Microsoft.Data.Sqlite"

open Microsoft.Data.Sqlite

// Database Connection
let connection =
    new SqliteConnection("Data Source=students.db")

connection.Open()

// Create Table
let createTable =
    new SqliteCommand(
        "DROP TABLE IF EXISTS Students;
         CREATE TABLE Students (
             Id INTEGER PRIMARY KEY,
             Name TEXT,
             Age INTEGER,
             Course TEXT
         );",
        connection
    )

createTable.ExecuteNonQuery() |> ignore

printfn "Table Created Successfully!"

// CREATE Operation
let insert =
    new SqliteCommand(
        "INSERT INTO Students VALUES (1, 'Kirti', 21, 'CSE')",
        connection
    )

insert.ExecuteNonQuery() |> ignore

printfn "\nAfter CREATE:"

// READ Operation
let readData () =
    let cmd =
        new SqliteCommand("SELECT * FROM Students", connection)

    use reader = cmd.ExecuteReader()

    while reader.Read() do
        printfn "ID: %d, Name: %s, Age: %d, Course: %s"
            (reader.GetInt32(0))
            (reader.GetString(1))
            (reader.GetInt32(2))
            (reader.GetString(3))

readData()

printfn "\nAfter READ:"
readData()

// UPDATE Operation
let update =
    new SqliteCommand(
        "UPDATE Students SET Age = 22 WHERE Id = 1",
        connection
    )

update.ExecuteNonQuery() |> ignore

printfn "\nAfter UPDATE:"
readData()

// DELETE Operation
let delete =
    new SqliteCommand(
        "DELETE FROM Students WHERE Id = 1",
        connection
    )

delete.ExecuteNonQuery() |> ignore

printfn "\nAfter DELETE:"
readData()

printfn "\nAll CRUD Operations Completed!"

connection.Close()
