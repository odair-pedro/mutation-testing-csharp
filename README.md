# Mutation Testing with C# and .NET Core

[![Build](https://github.com/odair-pedro/mutation-testing-csharp/workflows/Build/badge.svg)](https://github.com/odair-pedro/mutation-testing-csharp/actions?query=workflow%3ABuild)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Fodair-pedro%2Fmutation-testing-csharp%2Fmaster)](https://dashboard.stryker-mutator.io/reports/github.com/odair-pedro/mutation-testing-csharp/master)

A simple example to demonstrate you how to implement mutation testing into your .NET Core/C# application

## What mutation testing is?
Mutation testing is an approach to help you to check if your unit tests are effective though.

The main idea is to create a mutant code which is a modified version of your code and run the existing unit tests agains this mutant code, instead of original code.
If the mutation code break tests, it mean that the mutant has killed, which is good. If the mutation code doesn't break tests then the mutant survived, which is not so good. In other words... we espect that the unit tests fails.

`mutated code + failed tests = killed mutant` :heavy_check_mark:

`mutated code + passed tests = survived mutant` :x:

### Basic mutation examples

#### Arithmetic operators

|Original|Mutated|
|--|--|
|var value = a + b;|var value = a – b;|
|var value = a * b;|var value = a / b;|

#### Equality operators

|Original|Mutated|
|--|--|
|if (a == b) { … }|if (a != b) { … }|
|if (a > b) { … }|if (a < b) { … }|

#### Logical operators

|Original|Mutated|
|--|--|
|if (a && b) { … }|if (a \|\| b) { … }|
|if (a \|\| b) { … }|if (a && b) { … }|

#### Negation operator

|Original|Mutated|
|--|--|
|var x = y;|var x = !y;|
|if (!x) { … }|if (x) { … }|





## References

https://stryker-mutator.io/ 

http://csharp.academy/mutation-testing/
