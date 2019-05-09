# Character-Creator
A DnD character creation tool

This program has a prerequisite, the computer on which is running needs the .NET framework in order to work.

This repository includes an executable file, that will install the final product.  These are named `setup.exe` and `SetupProject.msi` that
will launch the installer and you will be able to install the program.

Once installed make sure to run as admin to gain full access to the read/write functions of the program.

On the home page the characters created are displayed, the first time the program is run that page will be empty. At the bottom of that page there would be two options for the user to select. Create a new character or load an existing one, if the load option is chosen but there is no character to load the program would redirect to the creation of  a new character.

The characters you create will be located in the directory to which you installed the Character Creator folder with the file names respectively `charFile1.dat` `charFile2.dat` `charFile3.dat` and `charFile4.dat`

On the next page the user will be directed to select the general information of the character, once that is done and the user saves the selections the program will redirect to stats. There the user will enter the numbers that were rolled, as per the game instructions (not related to the program), and finally the program will redirect to the overview page where the character's whole information will be displayed. On the click of finalize the created character will appear on the home page.

To work on it using Visual Studio, open the solution on the main folder.
