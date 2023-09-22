# Pierre's Bakery

#### By Richard Barbour II

#### C# console application for a bakery that prompts the user for an order and returns a total price that reflects quantity-based discounts.


## Technologies Used

* C#
* .Net 7.0.400 SDK (incl. MSTest)
* NuGet



## Description

This console-based application informs the user of the price of bread and pastries in the bakery, as well as quantity-based discounts for the two goods. The user is then prompted to enter the number of loaves of bread and pastries the user would like to purchase. The program returns the total price which reflects any discounts as appropriate.

## Setup/Installation Requirements

1. Navigate to https://github.com/rbarcode/w8-bakery-console-app in an internet browser.
2. Click on the green “<> Code” on the far right-hand side of the page's main column.
3. On the “Local” tab of the mini-window that opens underneath the “<>Code” button, copy the HTTPS link in the gray bar to your clipboard.
4. In GitBash (or a terminal shell of your choice), navigate to the directory where you wish to download the project and enter the following prompt (replacing the italicized word with the appropriate link): git clone *url-of-the-repository-copied-in-the-previous-step*
5. Your chosen directory will now contain a folder titled BakeryApp.Solution.
6. Navigate into the folder called BakeryApp.Tests within BakeryApp.Solution.
7. If you don't have the .Net Software Development Kit already installed on your computer, do so now. You will also need to download the REPL (read-evaluate-print-loop) tool called dotnet-script. 
7. To run MSTest from the terminal, enter the following command from within the BakeryApp.Tests directory: dotnet test.
8. Since this is a console application, you'll interact with it through text commands in your terminal. Navigate back up from BakeryApp.Tests and into the BakeryApp directory. In the command line, enter the following command to compile and execute the console application: dotnet run 
9. Optionally, you can run the following command to compile the console application without running it by entering the following command in the command line: dotnet build


## Known Bugs

No known bugs.

## License

MIT License

Copyright (c) 2023 Richard Barbour II

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.