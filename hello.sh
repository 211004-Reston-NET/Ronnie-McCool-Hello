S#This is a comment to add info to your code
#echo comment
echo Hello #<-This is a echo to diplay hello
echo World
echo today

msg="Hello World How Are You Today!"
echo $msg

echo what is your name?
read userInput
echo "Hello" $userInput,  "WELCOME TO PROGRAMMING!!"

#CONTROL FLOW
#types of flow
#for loops- they will repeat something a set number of times
for  var in 1 2 3 4 5
do
echo $var
echo This variable currently holds: $var
done

for i in {1..10..1}
do
	echo $i
done

for words in hello world test hi what
do
echo $words
done

#while loops-they will  repeat something until the condition is not satisfied anymor
condition="true"
dogName="rex"
while [ "$condition" != "false" ]
do
echo "Whats your dogs name"
read dogName
	if [ $dogName == "rex" ]
	then
		echo "hello rex"
        else
                echo "hay your not rex"
        fi
   echo "Do you want to continue (true or  false)"
   read condition
   echo "You typed: $condition"
done


