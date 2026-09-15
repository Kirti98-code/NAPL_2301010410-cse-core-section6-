package main

import (
	"fmt"
	"lab2/mathutil"
	"lab2/strop"
)

func main() {
	var a, b int
	fmt.Println("Enter first number:")
	fmt.Scan(&a)
	fmt.Println("Enter second number:")
	fmt.Scan(&b)
	result := mathutil.Factorial(a)
	fmt.Println("factorial =", result)
	text := "Hello"
	fmt.Println("Original String:", text)
	fmt.Println("Reversed String:", strop.Reverse(text))
	fmt.Println("Number of Vowels:", strop.CountVowels(text))

	fmt.Println("Factorial of 5:", mathutil.Factorial(5))
	fmt.Println("2 Power 5:", mathutil.Power(2, 5))
}
