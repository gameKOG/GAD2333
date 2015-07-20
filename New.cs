using UnityEngine;
using System.Collections;

public class New : MonoBehaviour {

	public int length = 7;
	public int width = 6;
	public int area;


	// Use this for initialization
	void Start () 
	{
		area = length*width;
		print (area);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
