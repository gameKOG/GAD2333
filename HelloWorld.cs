using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour 
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
	*/

	public float speed = 10.0f;
	public bool isGrounded = false;
	public int lives = 4;
	public GameObject player;
	void Start ()
	{
		print("Hello World! " + speed);
	
	}

	void Update ()
	{

	}
	
}
