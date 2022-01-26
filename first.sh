]# This is 

ten=10
five=5
thirteen=13

echo "===First IF==="
if [ "$ten" -ge "$five" ]
then 
echo "greater!"
echo "$ten >$five"


echo "===Second IF==="
if [ "$five " -ge "$ten"]
then
echo "lesser!"
echo "$five > $ten"


echo "===Third IF==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
elif [ "$ten" -ge "$five" ]
then
echo "greater!"
echo "$ten > $five"


echo "===Fourth IF==="
if ["$five" -ge "$ten" ]
then 
echo "lesser!"
echo "$five > $thirteen"
elif [ "

echo "Mothing Works!"
fi


#Loop Statements

echo "===For Loop==="
for num in 1 2 3 4 5
do 
echo "Repaeating!"
echo $num
done

for num in {1..10}
do
echo "Repeating"
echo $num
done

echo "===while loop==="
while [ "$ten" -ge "$five" ]
do 
echo "Greater!"
echo $five
five=$(($five+1)) # $((mathematical operation)) is the synatax)
done

# Input and Output
# we can ask the input from user that is currently using the shell script for
# some sort of information we will use

echo "What is your name?"
#read name
echo "hello $name, welcome"


clear #clear terminal
repeat="true"

while [ "$repeat" == true ]
do
echo "Welcome tto shell script"
echo "Wahat do you want to do today"
echo "enter 1 if you want to add two number"
echo "enter 2 if you want to exit out the program"
read ans

if [ "@ans" == "1" ]
then 
echo "Give me two numbers"
read num1 
read num2
echo "this iss our number $(($num1+$num2))"


elif [ "$ans" == "2" ] 
then 
echo "Goodbye!"
repeat='false"
else 
echo "Command not found"
fi

done
