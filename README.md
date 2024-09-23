## This is the C Sharp Code created in Visual Studio for parsing an EDI document.

Any document file type, ie, 204, 850, 210, etc can be added to the ediFileName on line  11.

I used Notepad ++ to open the EDI file and find the position of the element and line (or segment) seperators.

Because C Sharp positions start at 0, when you put the position number in line 17 for your element seperator you will need to subtract one to get the correct positon reference. For instance my * on the ISA line for the file used was in position 104.

So the code reads -- string elementSeperator = ediFileContents.Substring(103,1);

![position reference](https://github.com/user-attachments/assets/e3514815-3be9-4bca-8bdd-630aa2f3cb3a)

Same as above for the line seperator entered on line 19. For instance the ~, line seperator, was 2 spaces to the right from the * in position 106 on the ISA line on the file used.

So the code reads-- string lineSeperator = ediFileContents.Substring(105, 1);
