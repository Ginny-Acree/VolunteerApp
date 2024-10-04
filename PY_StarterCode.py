import pandas as pd
import random as random

#input CSV File
#Need to put r in front of the path so it's read only
file = r"C:\Users\baezej\Documents\GitHub\ClassroomNamePickerPY\Names.csv"
dataFrame = pd.read_csv(file)
output = "Nothing to see here"
userSelectedBlock = input ("Please type the desired block you would like to randomize a student from: ")





def filterBlock (input):

    filteredBlock = dataFrame [(dataFrame['Block']) == input]
    # Check if the filtered block is not empty
    if not filteredBlock.empty:
        
        #sample(n=1) is a pandas library for random selection I could have used but I like random better
        length = len(filteredBlock)
        randomIndex = random.randint(0, length -1)# Randomly select an index value 
        randomStudent = filteredBlock.iloc[randomIndex]
        output = f"Randomly selected student: {randomStudent['FirstName']} is in {randomStudent['Class']}"
        
        # Display the selected student's information
        print(output)

    else:
        output = "No students found for the selected block. Are you sure you typed the name correct?"
        print(output)

    return output

#Calls the procedure here
filterBlock(userSelectedBlock)

#print (dataFrame) prints all the frames
#print(dataFrame.header) will print out the first 10
#print(dataFrame.header) will print out the last 10
#filteredBlock.to_csv('newCSV.csv') this will create a new csv file and export all in first block
