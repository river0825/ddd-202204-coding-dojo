package ddd_202204_coding_dojo

import "testing"

func Test_fizzbuzz(t *testing.T) {
	type args struct {
		value int
	}
	tests := []struct {
		name string
		args args
		want string
	}{
		{name: "return int string", args: args{1}, want: "1"},
		{name: "given 3 should return fizz", args: args{3}, want: "fizz"},
		{name: "given 6 should return fizz", args: args{6}, want: "fizz"},
		{name: "given 5 should return buzz", args: args{5}, want: "buzz"},
		{name: "given 10 should return buzz", args: args{10}, want: "buzz"},
		{name: "given 15 should return fizzbuzz", args: args{15}, want: "fizzbuzz"},
		{name: "given 30 should return fizzbuzz", args: args{30}, want: "fizzbuzz"},
	}
	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			f := NewFizzBuzz(tt.args.value)
			if got := f.ToString(); got != tt.want {
				t.Errorf("fizzbuzz() = %v, want %v", got, tt.want)
			}
		})
	}
}
