It covers:

- `if`
- `if-else`
- `if-else if-else`
- Nested `if`
- `switch`
- Switch expressions
- Ternary operator (`?:`)
- Null-coalescing operator (`??`)
- Pattern matching (`is`)
- Logical operators (`&&`, `||`, `!`)
- `break`, `continue`, and `return`

## Quick understanding guide

| Statement | When to use | 
|---|---| 
| `if` | Check one condition | 
| `if-else` | Choose between two options | 
| `else if` | Check multiple conditions | 
| Nested `if` | Check conditions inside conditions | 
| `switch` | Choose from multiple fixed values | 
| `switch expression` | Return a value based on conditions | 
| `?:` | Short if-else | 
| `&&` | Both conditions must be true | 
| `!` | Reverse a Boolean condition | 
| `??` | Provide a default when null | 
| `?.` | Safely access a possibly null object | 
| `break` | Stop a loop or switch | 
| `continue` | Skip the current loop iteration | 
| `return` | Exit a method |
<!-- | `||` | At least one condition must be true |  -->

## How to run this program

Open your terminal and execute:

bash

```bash
dotnet new console -n DecisionLearning

cd DecisionLearning

dotnet run
```

Replace the generated `Program.cs` with the code above.

## My recommended learning order

1. Understand `if` and `else`.
2. Practice `else if`.
3. Learn nested `if`.
4. Understand `switch`.
5. Learn logical operators (`&&`, `||`, `!`).
6. Practice ternary operators.
7. Learn pattern matching and modern switch expressions.
8. Understand `break`, `continue`, and `return`.

Important: In C#, `if`, `else`, and `switch` are decision-making statements. Operators such as `&&`, `||`, `!`, and `?:` help you build or simplify conditions.