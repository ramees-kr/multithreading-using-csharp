# Fibonacci Number Generator

This Windows Forms application generates Fibonacci numbers asynchronously using threads.

## Description

This program allows users to input a positive integer and generates Fibonacci numbers up to the specified count in a ListBox control. The generation of Fibonacci numbers is performed asynchronously using Task-based asynchronous programming (TAP) and multithreading.

## Features

- Asynchronously generates Fibonacci numbers.
- Validates user input to ensure it is a positive integer.
- Clears previous output before generating new Fibonacci numbers.

## Controls

- **btnGenerate:** Button control to initiate the generation of Fibonacci numbers.
- **txtNumber:** TextBox control for the user to input the count of Fibonacci numbers to generate.
- **listBoxOutput:** ListBox control to display the generated Fibonacci numbers.

## Usage

1. Enter a positive integer in the TextBox.
2. Click the "Generate" button.
3. The generated Fibonacci numbers will be displayed in the ListBox.

## Implementation Details

- **btnGenerate_Click:** Event handler for the button click to start the Fibonacci number generation process. It validates user input and triggers the asynchronous generation of Fibonacci numbers.
- **GenerateFibonacciNumbersAsync:** Asynchronously generates Fibonacci numbers up to the specified count. It uses Task-based asynchronous programming (TAP) and locks the access to the ListBox control to ensure thread safety.
- **GenerateFibonacciNumber:** Recursive function to generate the nth Fibonacci number.

## Technologies Used

- C#
- .NET Framework
- Windows Forms

## Requirements

- .NET Framework installed on the system.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Author

Ramees Karolil Rasheed
