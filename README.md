# C# NullReferenceException Bug

This repository demonstrates a common error in C#: the `NullReferenceException`.  The `bug.cs` file contains code that is susceptible to this exception. The `bugSolution.cs` file provides a corrected version. 

## Problem
The `MyMethod` function in `bug.cs` attempts to perform arithmetic on `MyProperty` without checking if it's null. If `MyProperty` hasn't been initialized, this results in a `NullReferenceException`.

## Solution
The `bugSolution.cs` file shows how to prevent the error by implementing a null check before accessing `MyProperty`.