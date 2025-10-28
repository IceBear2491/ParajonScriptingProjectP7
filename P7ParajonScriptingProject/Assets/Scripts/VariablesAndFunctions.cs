using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Creating Int
    public int myInt = 6;


    // Start is called before the first frame update
    void Start()
    {
        //Running the int
        myInt = MultiplyByTwo(myInt);
        //Displaying the Int
        Debug.Log (myInt);
    }
    //Function to multiply by 2
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
