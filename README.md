# Prework-CodeChallenges
# Table of Content

[Array Max Result](#Array-Max-Result)
[Leap Year Calculator](#Leap-Year-Calculator)

# Array Max Result
### Date 1/9/2021

### Instructions
Create a Console application that requests 5 numbers between 1-10 from the user. 
Output the array to the console and ask the user to select a number. After the selection, output the “score” of the number chosen.
Method needs to take in an int [] and a int if the users selected input.
The score is whatever number the iser selected * the number of times it is in the array.

### Approach & Efficiency
Space: O(n)
Time:  O(n)
* Create a method to ask user for 5 integers to populate the int array.
* Check that input from user is a number between 1-10 before saving it to the array.
* After array is filled display list of numbers and ask user to select one to calculate score with.
* Check that number entered by user is in the int array
* Send array and number for score to ArrayMaxResult method.
* Create counter variable
* Step through int array and compare each int to number ented by user for score
* If they match increase counter by one
* Print number for score * the amount of times it was found in int array

### ScreenShot
[Screenshot](Prework-CodeChallenges\img\ArrayMaxResultScreenshot.png)
---------------------------------------------------------------------------

# Leap Year Calculator
### Date 1/9/2021

### Instructions
Given a year, report if it is a leap year.
The tricky thing here is that a leap year in the Gregorian calendar occurs:
on every year that is evenly divisible by 4.
except every year that is evenly divisible by 100.
unless the year is also evenly divisible by 400.

### Approach & Efficiency
Space: O(1)
Time:  O(1)
* Test if year is evenly divisible by 400 first and return true if it is.
* Test if year is evenly divisible by 4 and that it is not evenly divisible by 100. return true if it passes both.
* If year doesn't pass any of the above test return false.

### ScreenShot
[Screenshot](Prework-CodeChallenges\img\LeapYearCalcScreenshot.png)
--------------------------------------------------------------------