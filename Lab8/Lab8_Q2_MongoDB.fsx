
#r "nuget: MongoDB.Driver"

open MongoDB.Driver
open MongoDB.Bson

// MongoDB Connection
let client = MongoClient("mongodb://localhost:27017")

// Create Database and Collection
let database = client.GetDatabase("FSharpCRUD")
let collection = database.GetCollection<BsonDocument>("Students")

// Clear old records
collection.DeleteMany(FilterDefinition<BsonDocument>.Empty) |> ignore

printfn "MongoDB Connected Successfully!"

// CREATE Operation
let student =
    BsonDocument()
        .Add("Id", BsonInt32(1))
        .Add("Name", BsonString("Kirti"))
        .Add("Age", BsonInt32(21))
        .Add("Course", BsonString("CSE"))

collection.InsertOne(student)

printfn "\nAfter CREATE:"

// READ Operation
let readData () =
    let students =
        collection.Find(FilterDefinition<BsonDocument>.Empty).ToList()

    for s in students do
        printfn "%s" (s.ToString())

readData()

printfn "\nAfter READ:"
readData()

// UPDATE Operation
let filter =
    Builders<BsonDocument>.Filter.Eq("Id", 1)

let update =
    Builders<BsonDocument>.Update.Set("Age", 22)

collection.UpdateOne(filter, update) |> ignore

printfn "\nAfter UPDATE:"
readData()

// DELETE Operation
collection.DeleteOne(filter) |> ignore

printfn "\nAfter DELETE:"
readData()

printfn "\nAll MongoDB CRUD Operations Completed!"
