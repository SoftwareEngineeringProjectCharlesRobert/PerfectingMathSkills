# PerfectingMathSkills
# 352 Project
# Authors: Charles Clayton and Robert Rayburn
# Last date modified: December 1, 2016
# File: README.md
# Description: Contains documentation for the program.

main class:
  Takes a window, grid, textblock, and series of buttens, then sets values for all objects.
  Adds everything to the grid then sets teh windows content to equal the grid.
  
Mode window classes:
  -Each mode has a class where it constructs its own window.
  -The content of the window is set to a grid that contains a series of buttons and textboxs/blocks.
  -The layout of the grid will show two numbers and the operation that is being performed on it.
  -The user can either press buttons, or type into the keyboard, a number that they believe is the solution to the problem.
  -There is an enter button to allow the user to check their answer, and a backspace to remove the last digit entered.
  -If the user's solution matches the correct solution, then a window will appear showing the user they got it right.
    +When the user chooses to go to the next problem the mode window is updated with new numbers and the correct and attempt
      textblocks are updated.
  -If the user's solution is not the correct solution, then a different window will appear telling the user it was wrong.
    +A button is provided to allow the user to go back and attempt the problem again, where the attempt textblock is updated,
      but the numbers and correct textblocks are unchanged.
  -A main window button is provided to allow the user to go back to the main window and select a new mode.
    +Once clicked, a window pops up that shows the user how many they got right and how many they attempted.

Exit window class:
  -Creates the window that will display the results for your run of a mode.

Counter class:
  -Contains the variables that will hold values for the number of times the user answered a problem and how many they
    answered correctly.
