# practice no. 1 create echos, read, if, and var

echo hello
msg=" welcome home! What is your name? "

echo $msg
read UserInput
echo " well, its nice to meet you $UserInput " 

echo 

echo  " May I ask how old you are? "
read UserInput
echo #putting empty echo inside the code in order to create spacing
echo " wow, your only $UserInput years old? "

echo

echo "how old is your dad?"
read number

if [ $number -lt 30 ];
then
	echo "He is very young"
elif [ $number -lt 50 ];
then
	echo "oh, he is not too old"
else
	echo "he is so old"
fi
