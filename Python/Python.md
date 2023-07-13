![](https://www.youtube.com/watch?v=LzYNWme1W6Q)

## Basics
**Python** is a [high-level](https://en.wikipedia.org/wiki/High-level_programming_language "High-level programming language"), [general-purpose programming language](https://en.wikipedia.org/wiki/General-purpose_programming_language "General-purpose programming language"), [dynamically typed](https://en.wikipedia.org/wiki/Type_system#DYNAMIC "Type system") and [garbage-collected](https://en.wikipedia.org/wiki/Garbage_collection_(computer_science) "Garbage collection (computer science)").

**Python's [statements](https://en.wikipedia.org/wiki/Statement_(computer_science) "Statement (computer science)") include:**

- ```if elif else```
- ```for```
- ```while```
- ```try```
- The `raise` statement, used to raise a specified exception or re-raise a caught exception
- The `class` statement, which executes a block of code and attaches its local namespace to a [class](https://en.wikipedia.org/wiki/Class_(computer_science) "Class (computer science)"), for use in object-oriented programming
- The `def` statement, which defines a [function](https://en.wikipedia.org/wiki/Function_(computing) "Function (computing)") or [method](https://en.wikipedia.org/wiki/Method_(computing) "Method (computing)")
- ```with``` frees resources  after exiting block of code
- The [break](https://en.wikipedia.org/wiki/Break_statement) statement, which exits a loop
- The `continue` statement, which skips the rest of the current iteration and continues with the next
- The `del` statement, which removes a variable—deleting the reference from the name to the value, and producing an error if the variable is referred to before it is redefined
- The `pass` statement, serving as a [NOP](https://en.wikipedia.org/wiki/NOP_(code) "NOP (code)"), syntactically needed to create an empty code block
- The [assert](https://en.wikipedia.org/wiki/Assertion_(programming) "Assertion (programming)") statement, used in debugging to check for conditions that should apply
- The `yield` statement, which returns a value from a [generator](https://en.wikipedia.org/wiki/Generator_(computer_programming)#Python "Generator (computer programming)") function (and also an operator); used to implement [coroutines](https://en.wikipedia.org/wiki/Coroutine "Coroutine")
- The `return` statement, used to return a value from a function
- The [import](https://en.wikipedia.org/wiki/Include_directive "Include directive") and `from` statements, used to import modules whose functions or variables can be used in the current program

**Python's expressions include:**
- `+`, `-`, `*`, `/`
- `//` integer division
- `**` operator for exponentiation
- `==` compares by value
- `and`, `or`, `not` - **boolean** operators
- [Anonymous functions](https://en.wikipedia.org/wiki/Anonymous_function "Anonymous function") are implemented using [lambda expressions](https://en.wikipedia.org/wiki/Lambda_(programming) "Lambda (programming)"); however, there may be only one expression in each body.
- Conditional expressions are written as `x if c else y`
- **Lists** are written as `[1, 2, 3]`
- **Tuples**, written as `(1, 2, 3)`

**Types**

|Type|[Mutability](https://en.wikipedia.org/wiki/Immutable_object "Immutable object")|Description|Syntax examples|
|---|---|---|---|
|`bool`|immutable|[Boolean value](https://en.wikipedia.org/wiki/Boolean_value "Boolean value")|`True`  <br>`False`|
|`bytearray`|mutable|Sequence of [bytes](https://en.wikipedia.org/wiki/Byte "Byte")|`bytearray(b'Some ASCII')`  <br>`bytearray(b"Some ASCII")`  <br>`bytearray([119, 105, 107, 105])`|
|`bytes`|immutable|Sequence of bytes|`b'Some ASCII'`  <br>`b"Some ASCII"`  <br>`bytes([119, 105, 107, 105])`|
|`complex`|immutable|[Complex number](https://en.wikipedia.org/wiki/Complex_number "Complex number") with real and imaginary parts|`3+2.7j`  <br>`3 + 2.7j`|
|`dict`|mutable|[Associative array](https://en.wikipedia.org/wiki/Associative_array "Associative array") (or dictionary) of key and value pairs; can contain mixed types (keys and values), keys must be a hashable type|`{'key1': 1.0, 3: False`}  <br>`{`}|
|`types.EllipsisType`|immutable|An [ellipsis](https://en.wikipedia.org/wiki/Ellipsis_(programming_operator) "Ellipsis (programming operator)") placeholder to be used as an index in [NumPy](https://en.wikipedia.org/wiki/NumPy "NumPy") arrays|`...`  <br>`Ellipsis`|
|`float`|immutable|[Double-precision](https://en.wikipedia.org/wiki/Double-precision_floating-point_format "Double-precision floating-point format") [floating-point number](https://en.wikipedia.org/wiki/Floating-point_arithmetic "Floating-point arithmetic"). The precision is machine-dependent but in practice is generally implemented as a 64-bit [IEEE 754](https://en.wikipedia.org/wiki/IEEE_754 "IEEE 754") number with 53 bits of precision.[[105]](https://en.wikipedia.org/wiki/Python_(programming_language)#cite_note-105)|`1.33333`|
|`frozenset`|immutable|Unordered [set](https://en.wikipedia.org/wiki/Set_(computer_science) "Set (computer science)"), contains no duplicates; can contain mixed types, if hashable|`frozenset([4.0, 'string', True])`|
|`int`|immutable|[Integer](https://en.wikipedia.org/wiki/Integer_(computer_science) "Integer (computer science)") of unlimited magnitude[[106]](https://en.wikipedia.org/wiki/Python_(programming_language)#cite_note-pep0237-106)|`42`|
|`list`|mutable|[List](https://en.wikipedia.org/wiki/List_(computer_science) "List (computer science)"), can contain mixed types|`[4.0, 'string', True]`  <br>`[]`|
|`types.NoneType`|immutable|An object representing the absence of a value, often called [null](https://en.wikipedia.org/wiki/Null_pointer "Null pointer") in other languages|`None`|
|`types.NotImplementedType`|immutable|A placeholder that can be returned from [overloaded operators](https://en.wikipedia.org/wiki/Operator_overloading "Operator overloading") to indicate unsupported operand types.|`NotImplemented`|
|`range`|immutable|An _immutable sequence_ of numbers commonly used for looping a specific number of times in `for` loops[[107]](https://en.wikipedia.org/wiki/Python_(programming_language)#cite_note-107)|`range(-1, 10)`  <br>`range(10, -5, -2)`|
|`set`|mutable|Unordered [set](https://en.wikipedia.org/wiki/Set_(computer_science) "Set (computer science)"), contains no duplicates; can contain mixed types, if hashable|`{4.0, 'string', True`}  <br>`set()`|
|`str`|immutable|A [character string](https://en.wikipedia.org/wiki/String_(computer_science) "String (computer science)"): sequence of Unicode codepoints|`'Wikipedia'`  <br>`"Wikipedia"`<br><br>"""Spanning<br>multiple<br>lines"""<br><br>Spanning<br>multiple<br>lines|
|`tuple`|immutable|Can contain mixed types|`(4.0, 'string', True)`  <br>`('single element',)`  <br>`()`|
