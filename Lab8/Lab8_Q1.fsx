// Base Abstract Class
[<AbstractClass>]
type Shape() =
    abstract member Area: unit -> float

// Derived Class - Circle
type Circle(radius: float) =
    inherit Shape()

    override this.Area() =
        3.14 * radius * radius

// Derived Class - Rectangle
type Rectangle(length: float, width: float) =
    inherit Shape()

    override this.Area() =
        length * width

// Creating Objects
let circle = Circle(5.0)
let rectangle = Rectangle(4.0, 6.0)

// Calling Methods
printfn "Circle Area: %f" (circle.Area())
printfn "Rectangle Area: %f" (rectangle.Area())

// Polymorphism
let shapes: Shape list =
    [ circle :> Shape
      rectangle :> Shape ]

printfn "\nPolymorphism:"
shapes |> List.iter (fun shape ->
    printfn "Area: %f" (shape.Area()))