package strop

import "strings"

func CountVowels(s string) int {
	count := 0
	for _, char := range strings.ToLower(s) {
		if strings.ContainsRune("aeiou", char) {
			count++
		}
	}
	return count
}
