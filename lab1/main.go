package main

import (
	"fmt"
	"strconv"
	"strings"
)

func main() {
	// 	fmt.Println("Hello, World!")
	// 	//
	// 	// code 2
	// 	var name string = "kirti"
	// 	var rollnumber int = 2301010410
	// 	fmt.Printf("Name: %s, Roll Number: %d\n", name, rollnumber)
	// 	//
	// 	// code 3
	// 	num1 := 10
	// 	num2 := 20
	// 	sum := num1 + num2
	// 	fmt.Printf("Sum of %d and %d is %d\n", num1, num2, sum)
	// 	var marks int
	// 	fmt.Print("Enter marks: ")
	// 	fmt.Scan(&marks)

	// 	if marks >= 40 {
	// 		fmt.Println("pass")
	// 	} else {
	// 		fmt.Println("fail")
	// 	}
	// }
	// 	marks1 := 80
	// 	marks2 := 72
	// 	marks3 := 89
	// 	total := marks1 + marks2 + marks3
	// 	if avg := total / 3; avg >= 40 {
	// 		fmt.Println("Pass", avg)
	// 	}
	// }
	//
	// fmt.Print("Enter marks: ")
	// fmt.Scan(&marks)
	// switch {
	// if
	// case marks > 60:
	// 	fmt.Println("first Division")
	// case marks > 50:
	//  fmt.Println("Second Division")
	// case marks > 40:
	//   fmt.Println("Third Division")
	// default:
	//   fmt.Println("Fail")
	//   }
	//
	// fmt.Println("Hello, kirti!")
	// fmt.Println("Integer operations")
	// num1 := 10
	// num2 := 20
	// fmt.Printf("Sum : %d\n", num1+num2)
	// fmt.Printf("Difference : %d\n", num1-num2)
	// fmt.Printf("Multiplication : %d\n", num1*num2)
	// fmt.Printf("Division : %d\n", num1/num2)

	// fmt.Println("Float operations")
	// num3 := 10.5
	// num4 := 20.9
	// fmt.Printf("Sum : %f\n", num3+num4)
	// fmt.Printf("Difference : %f\n", num3-num4)
	// fmt.Printf("Multiplication : %f\n", num3*num4)
	// fmt.Printf("Division : %f\n", num3/num4)

	// Q2
	"strconv"
	"strings"
}
func getInt(prompt string) int {
	for {
		var input string
		fmt.Print(prompt)
		fmt.Scanln(&input)

		value, err := strconv.Atoi(strings.TrimSpace(input))

		if err != nil {
			fmt.Println("Invalid input! Please enter an integer.")
			continue
		}

		if value < -1000 || value > 1000 {
			fmt.Println("Out of range! Enter a value between -1000 and 1000.")
			continue
		}

		return value
	}
}

func getFloat(prompt string) float64 {
	for {
		var input string
		fmt.Print(prompt)
		fmt.Scanln(&input)

		value, err := strconv.ParseFloat(strings.TrimSpace(input), 64)

		if err != nil {
			fmt.Println("Invalid input! Please enter a number.")
			continue
		}

		if value < -1000 || value > 1000 {
			fmt.Println("Out of range! Enter a value between -1000 and 1000.")
			continue
		}

		return value
	}
}

func main() {
	for {
		fmt.Println("\n===== SIMPLE CALCULATOR =====")
		fmt.Println("1. Perform operations using Int")
		fmt.Println("2. Perform operations using Float")
		fmt.Println("3. Exit")

		var choice int
		fmt.Print("Enter your choice: ")
		fmt.Scan(&choice)

		if choice == 1 {
			fmt.Println("\n--- Integer Operations ---")

			a := getInt("Enter first integer: ")
			b := getInt("Enter second integer: ")

			fmt.Println("Addition:", a+b)
			fmt.Println("Subtraction:", a-b)
			fmt.Println("Multiplication:", a*b)

		} else if choice == 2 {
			fmt.Println("\n--- Floating-Point Operations ---")

			a := getFloat("Enter first number: ")
			b := getFloat("Enter second number: ")

			fmt.Println("Addition:", a+b)
			fmt.Println("Subtraction:", a-b)
			fmt.Println("Multiplication:", a*b)

		} else if choice == 3 {
			fmt.Println("Exiting program...")
			break

		} else {
			fmt.Println("Invalid choice! Please select 1, 2, or 3.")
		}
	}
}
