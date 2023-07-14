[Good python beginners guide](https://www.youtube.com/watch?v=LzYNWme1W6Q)

## Basics
**[Python](https://www.python.org/)** is a [high-level](https://en.wikipedia.org/wiki/High-level_programming_language "High-level programming language"), [general-purpose programming language](https://en.wikipedia.org/wiki/General-purpose_programming_language "General-purpose programming language"), [dynamically typed](https://en.wikipedia.org/wiki/Type_system#DYNAMIC "Type system") and [garbage-collected](https://en.wikipedia.org/wiki/Garbage_collection_(computer_science) "Garbage collection (computer science)").

<details><summary>Python's statements</summary>

- ```if elif else```
- ```for```
```python
for item in items:
	print(item)
```
Loop through dictionary:
```python
for key, value in person.items():
	print(f"{key}, {value}")
```
- ```while```
```python
i = 0
while i < 10:
	print(i)
	i += 1
```
- The `break` statement, which exits a loop
- The `continue` statement, which skips the rest of the current iteration and continues with the next
- ```try```
- The `raise` statement, used to raise a specified exception or re-raise a caught exception
- The `class` statement, which executes a block of code and attaches its local namespace to a [class](https://en.wikipedia.org/wiki/Class_(computer_science) "Class (computer science)"), for use in object-oriented programming
- The `def` statement, which defines a [function](https://en.wikipedia.org/wiki/Function_(computing) "Function (computing)") or [method](https://en.wikipedia.org/wiki/Method_(computing) "Method (computing)")
- ```with``` frees resources  after exiting block of code
- The `del` statement, which removes a variable—deleting the reference from the name to the value, and producing an error if the variable is referred to before it is redefined
- The `pass` statement, serving as a [NOP](https://en.wikipedia.org/wiki/NOP_(code) "NOP (code)"), syntactically needed to create an empty code block
- The [assert](https://en.wikipedia.org/wiki/Assertion_(programming) "Assertion (programming)") statement, used in debugging to check for conditions that should apply
- The `yield` statement, which returns a value from a [generator](https://en.wikipedia.org/wiki/Generator_(computer_programming)#Python "Generator (computer programming)") function (and also an operator); used to implement [coroutines](https://en.wikipedia.org/wiki/Coroutine "Coroutine")
- The `return` statement, used to return a value from a function
- The [import](https://en.wikipedia.org/wiki/Include_directive "Include directive") and `from` statements, used to import modules whose functions or variables can be used in the current program
</details>

<details><summary>Python's expressions</summary>
- `+`, `-`, `*`, `/`
- `//` integer division
- `**` operator for exponentiation
- `==` compares by value
- `and`, `or`, `not` - **boolean** operators
- `#` comment
- """Multi line comments"""
- [Anonymous functions](https://en.wikipedia.org/wiki/Anonymous_function "Anonymous function") are implemented using [lambda expressions](https://en.wikipedia.org/wiki/Lambda_(programming) "Lambda (programming)"); however, there may be only one expression in each body.
- Conditional expressions are written as `x if c else y`
- **Lists** are written as `[1, 2, 3]`
- **Tuples**, written as `(1, 2, 3)`
- **Dictionaries** are key-value pairs like: `{'key1': 1.0, 'key2': False, 2: 'text'}`
</details>

<details><summary>Types</summary>

Python doe's not have `date` type, but we can import a module named `datetime` to work with dates as date objects.
```python
import datetime
# or
from datetime import datetime
from datetime import date
```

|Type|[Mutability](https://en.wikipedia.org/wiki/Immutable_object "Immutable object")|Description|Syntax examples|
|---|---|---|---|
|`bool`|immutable|[Boolean value](https://en.wikipedia.org/wiki/Boolean_value "Boolean value")|`True`  <br>`False`|
|`bytearray`|mutable|Sequence of [bytes](https://en.wikipedia.org/wiki/Byte "Byte")|`bytearray(b'Some ASCII')`  <br>`bytearray(b"Some ASCII")`  <br>`bytearray([119, 105, 107, 105])`|
|`bytes`|immutable|Sequence of bytes|`b'Some ASCII'`  <br>`b"Some ASCII"`  <br>`bytes([119, 105, 107, 105])`|
|`complex`|immutable|[Complex number](https://en.wikipedia.org/wiki/Complex_number "Complex number") with real and imaginary parts|`3+2.7j`  <br>`3 + 2.7j`|
|`dict`|mutable|[Associative array](https://en.wikipedia.org/wiki/Associative_array "Associative array") (or dictionary) of key and value pairs; can contain mixed types (keys and values), keys must be a hashable type|`{'key1': 1.0, 3: False}`  <br>`{}`|
|`types.EllipsisType`|immutable|An [ellipsis](https://en.wikipedia.org/wiki/Ellipsis_(programming_operator) "Ellipsis (programming operator)") placeholder to be used as an index in [NumPy](https://en.wikipedia.org/wiki/NumPy "NumPy") arrays|`...`  <br>`Ellipsis`|
|`float`|immutable|[Double-precision](https://en.wikipedia.org/wiki/Double-precision_floating-point_format "Double-precision floating-point format") [floating-point number](https://en.wikipedia.org/wiki/Floating-point_arithmetic "Floating-point arithmetic"). The precision is machine-dependent but in practice is generally implemented as a 64-bit [IEEE 754](https://en.wikipedia.org/wiki/IEEE_754 "IEEE 754") number with 53 bits of precision.[[105]](https://en.wikipedia.org/wiki/Python_(programming_language)#cite_note-105)|`1.33333`|
|`frozenset`|immutable|Unordered [set](https://en.wikipedia.org/wiki/Set_(computer_science) "Set (computer science)"), contains no duplicates; can contain mixed types, if hashable|`frozenset([4.0, 'string', True])`|
|`int`|immutable|[Integer](https://en.wikipedia.org/wiki/Integer_(computer_science) "Integer (computer science)") of unlimited magnitude[[106]](https://en.wikipedia.org/wiki/Python_(programming_language)#cite_note-pep0237-106)|`42`|
|`list`|mutable|[List](https://en.wikipedia.org/wiki/List_(computer_science) "List (computer science)"), can contain mixed types|`[4.0, 'string', True]`  <br>`[]`|
|`types.NoneType`|immutable|An object representing the absence of a value, often called [null](https://en.wikipedia.org/wiki/Null_pointer "Null pointer") in other languages|`None`|
|`types.NotImplementedType`|immutable|A placeholder that can be returned from [overloaded operators](https://en.wikipedia.org/wiki/Operator_overloading "Operator overloading") to indicate unsupported operand types.|`NotImplemented`|
|`range`|immutable|An _immutable sequence_ of numbers commonly used for looping a specific number of times in `for` loops[[107]](https://en.wikipedia.org/wiki/Python_(programming_language)#cite_note-107)|`range(-1, 10)`  <br>`range(10, -5, -2)`|
|`set`|mutable|Unordered [set](https://en.wikipedia.org/wiki/Set_(computer_science) "Set (computer science)"), contains no duplicates; can contain mixed types, if hashable|`{4.0, 'string', True}`  <br>`set()`|
|`str`|immutable|A [character string](https://en.wikipedia.org/wiki/String_(computer_science) "String (computer science)"): sequence of Unicode codepoints|`'Wikipedia'`  <br>`"Wikipedia"`<br><br>"""Spanning<br>multiple<br>lines"""<br><br>Spanning<br>multiple<br>lines|
|`tuple`|immutable|Can contain mixed types|`(4.0, 'string', True)`  <br>`('single element',)`  <br>`()`|
</details>

**Functions**
```python
def hello(name):
	print(f"Hello {name}!")

hello('John Doe')
```

**Class**
```python
class Person:
	def __init__(self, name, age):# Constractor
		self.name = name
		self.age = age
```
**Override methods**
```python
class Person:
	def __str__(self) -> str:    # -> str - declares method return type
		return super().__str__() # super().__str__() - calling to_String from base class
```

**Importing modules**
```python
import math
import pandas as pd
from datetime import date
```

**List vs Set**

Set - duplicates are not allowed, will hold only unique values. Does not keep order in which elements were added.

**Date formatting**

```python
from datetime import datetime
from datetime import date

now = datetime.now()
print(now.strftime("%d %m %Y %H %M %S"))
```
%m - two digit month

%B - full string month

%b - short string month