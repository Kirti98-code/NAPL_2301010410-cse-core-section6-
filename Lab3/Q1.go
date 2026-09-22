package main

import (
	"bufio"
	"fmt"
	"os"
)

type Person struct {
	Name   string
	Age    int
	Job    string
	Salary float64
}

func (p *Person) ReadData(reader *bufio.Reader) {

	fmt.Print("Enter Name: ")
	name, _, _ := reader.ReadLine()
	p.Name = string(name)

	fmt.Print("Enter Age: ")
	fmt.Fscan(reader, &p.Age)
	reader.ReadLine()

	fmt.Print("Enter Job: ")
	job, _, _ := reader.ReadLine()
	p.Job = string(job)

	fmt.Print("Enter Salary: ")
	fmt.Fscan(reader, &p.Salary)
	reader.ReadLine()
}

func (p Person) PrintData() {
	fmt.Println("\n----- Person Details -----")
	fmt.Println("Name:", p.Name)
	fmt.Println("Age:", p.Age)
	fmt.Println("Job:", p.Job)
	fmt.Println("Salary:", p.Salary)
}

func main() {

	reader := bufio.NewReader(os.Stdin)

	var person1 Person
	var person2 Person

	fmt.Println("Enter details for Person 1:")
	person1.ReadData(reader)
	person1.PrintData()

	fmt.Println("\nEnter details for Person 2:")
	person2.ReadData(reader)
	person2.PrintData()
}