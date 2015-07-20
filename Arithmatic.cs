using UnityEngine;
using System.Collections;

public class Arithmatic : MonoBehaviour 
{
	/*
	 *Assignment Operators:
	=
	+= x=x+y  (x+=y)
	-= x=x-y  (x-=y)
	*=
	/=
	%=

	Arithmetic Operators:
	+ Addition
	- Subtraction
	* Multiplication
	/ Division
	% Modulus (remainder of division)
	++ increment +1
	-- decrement -1

	Comparison Operators:
	== Is equal to (as opposed to setting a value)
	!= Not equal to
	>
	<
	>=
	<=

	Logical Operators:
	&& And 
	|| Or
	! Not
	
	*/
	
	public float speed = 5.0f;
	public float distance = 2.0f;
	public float time = 5.0f;

	public float maxSpeedLimit = 70.0f;
	public float minSpeedLimit = 40.0f;


	void Start ()
	{
		speed = distance / time;
		if (speed > maxSpeedLimit)
		{
			print ("You are exceeding the speed limit!");
		}
		else if (speed < minSpeedLimit)
		{
			print ("You are not going fast enough!");
		}
		else if (speed == maxSpeedLimit || speed == minSpeedLimit)
		{
			print ("You are close to breaking the law!");
		}
		else
		{
			print ("You are within the speed limit.");
		}
		print("You are traveling at " + speed + "mph.");
		
	}
	
	void Update ()
	{
		
	}
	
}
