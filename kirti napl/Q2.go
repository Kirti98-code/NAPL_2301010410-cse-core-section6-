package main

import "fmt"

func main() {
	students := []string{"kirti", "gaurav", "riya"}
	fmt.Println("Initial slice:", students)
	students = append(students, "sneha")
	fmt.Println("Slice after add:", students)
	index := 1
	students = append(students[:index], students[index+1:]...)
	fmt.Println("After remove:", students)
	// update an element
	students[1] = "riya"
	fmt.Println("After update:", students)
	// ......map
	marks := map[string]int{
		"Math":    90,
		"Science": 80,
		"English": 70,
	}
	fmt.Println("Initial Marks:", marks)
	// insert
	marks["computer"] = 85
	fmt.Println("After insert:", marks)
	// delete
	delete(marks, "English")
	fmt.Println("After delete:", marks)
	// lookup
	mark, found := marks["Math"]
	if found {
		fmt.Println("Math marks:", mark)
	} else {
		fmt.Println("Math marks not found")
	}
}
