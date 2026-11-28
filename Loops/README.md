
# C# Loops

This folder contains simple examples of loops in C#.

## What is a Loop?

A loop repeats code multiple times.

## Types of Loops

### 1. For Loop

Used when you know how many times you want to repeat something.

Example:

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

### 2. While Loop

Repeats while the condition is true.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

### 3. Do While Loop

Always runs at least once.

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

### 4. Foreach Loop

Used to read items from an array or collection.

```csharp
string[] names = { "Ram", "Hari", "Sita" };

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

### 5. Break

Stops the loop immediately.

### 6. Continue

Skips the current iteration and moves to the next one.

### 7. Nested Loop

A loop inside another loop.

### 8. Infinite Loop

A loop that continues forever until you stop it.

## Important

- `for` = Repeat a fixed number of times.
- `while` = Repeat while condition is true.
- `do while` = Run at least once.
- `foreach` = Read collection items.
- `break` = Stop the loop.
- `continue` = Skip one iteration.
- `nested loop` = Loop inside a loop.

## How to Run

```bash
dotnet run
```

## Learning Goal

Understand how loops work in C# through simple examples.
