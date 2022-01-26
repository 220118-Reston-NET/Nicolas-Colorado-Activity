#this is my first shell scripting program, holy smokes!

repeat="true"

num1="1.50"
num2="4.25"
num3="8.00"

while [ "$repeat" == true ]
do 
echo "Welcome to the empanada cafe!"
echo "What would you like to order today?"
echo "Enter 1 for the single empanada."
echo "Enter 2 for the empanada and coffee combo."
echo "Enter 3 for the 6 empanada to-go pack."
echo "Enter 4 to exit the menu."
read ans

if [ "$ans" == "1" ]
then
echo "Here's your single empanada! That will be $num1!"
echo "Press enter to go back to the main menu."
read flkwije
elif [ "$ans" == "2" ] 
then 
echo "Here's your empanada and coffee combo. That will be $num2!"
echo "Press enter to go back to the main menu."
read flkwije
elif [ "$ans" == "3" ] 
then 
echo "Here's your 6 empanada to-go pack! That will be $num3!"
echo "Press enter to go back to the main menu."
elif [ "$ans" == "4" ] 
then 
echo "Thank you for your patronage!"
repeat="false"
else
echo "Your input in invalid. Press enter to go back to the main menu."
read flkwije
fi

clear 
done
