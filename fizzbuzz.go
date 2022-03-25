package ddd_202204_coding_dojo

import "strconv"

type FizzBuzz struct {
	value int
}

func NewFizzBuzz(value int) FizzBuzz {
	return FizzBuzz{
		value: value,
	}
}

func (f FizzBuzz) ToString() string {
	return fizzbuzz(f.value)
}

func fizzbuzz(value int) string {
	if isDividedBy5(value) && isDividedBy3(value) {
		return replacedWord(3) + replacedWord(5)
	}
	if isDividedBy3(value) {
		return replacedWord(3)
	}
	if isDividedBy5(value) {
		return replacedWord(5)
	}
	return strconv.Itoa(value)
}

func replacedWord(value int) string {
	words := map[int]string{3: "fizz", 5: "buzz"}
	return words[value]
}

func isDividedBy5(value int) bool {
	return value%5 == 0
}

func isDividedBy3(value int) bool {
	return value%3 == 0
}
