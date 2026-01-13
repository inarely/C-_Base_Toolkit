# CSharp Base Toolkit

A console application written in C# that demonstrates core programming fundamentals (without OOP).  
The project contains small utility modules with safe input validation and simple menu navigation.

## Features

### 1) Calculator
- Basic operations: addition, subtraction, multiplication, division
- Input validation (no crashes on invalid input)
- Division-by-zero handling

### 2) Percent Helper
- Calculate X% of a number
- Increase a number by X%
- Decrease a number by X%
- Input validation for menu and decimal values

### 3) Mini Notes
- Add notes
- View notes
- Save notes to a file
- Notes are saved in `Data/notes.txt` inside the project folder

## Technologies

- C#
- .NET Console Application
- System.IO (file operations)

## How to Run

1. Open the solution/project in Visual Studio (or any C# IDE).
2. Build the project.
3. Run the program.
4. Use the menu to navigate between modules.

## Data Storage (Mini Notes)

- Notes are stored as plain text.
- Each note is saved as a separate line.
- File path is created automatically if it does not exist:
  - `CSharp_Base_Toolkit/Data/notes.txt`

## License

This project is provided for educational purposes without any warranty. Use and modify freely.
