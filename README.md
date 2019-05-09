# Character-Creator
A DnD character creation tool

This program has a prerequisite, the computer on which is running needs the .NET framework in order to work.

This repository includes an executable file, that can be found on `CharacterCreator/bin/debug/CharacterCreator.exe`
Launch the file and you will be able to see the program.

On the home page the characters created are displayed, the first time the program is run that page will be empty. At the bottom of that page there would be two options for the user to select. Create a new character or load an existing one, if the load option is chosen but there is no character to load the program would redirect to the creation of  a new character.

The characters you create will be located in the `CharacterCreator/bin/debug/` folder with the names: `charFile1` `charFile2` `charFile3` and `charFile4`

On the next page the user will be directed to select the general information of the character, once that is done and the user saves the selections the program will redirect to stats. There the user will enter the numbers that were rolled, as per the game instructions (not related to the program), and finally the program will redirect to the overview page where the character's whole information will be displayed. On the click of finalize the created character will appear on the home page.

To work on it using Visual Studio, open the solution on the main folder.
