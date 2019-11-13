using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Mob_Animation : MonoBehaviour {


    public GameObject animateObject;
    public int timeToTurn;              //What Second to Turn the Object
    protected int counter;              //Second Timer for Turning
    protected float moveCounter;        //Move Smoothly by frame
    protected bool switchMove;          //Switch MoveSet
    protected bool isRotateActive;      //isRotateActive

	// Initialization of Counter
	void Start () {
        counter = 0;
        StartCoroutine(MyCounter());
        isRotateActive = false;
        switchMove = false;
    }

    //Counts in Terms of Seconds for Unity
    IEnumerator MyCounter()
    {
        //Debug.Log(counter);
        while (true) { 
        yield return new WaitForSeconds(1);
        counter++;
        }
    }

    //Rotate Smooth for GameObject
    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = animateObject.transform.rotation;
        var toAngle = Quaternion.Euler(animateObject.transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            animateObject.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }

        isRotateActive = false;

        if (switchMove == false)
        {
            switchMove = true;
        }
        else
        {
            switchMove = false;
        }
    }

    void moveForwardX()
    {
        animateObject.transform.position = new Vector3(transform.position.x + (moveCounter/32), transform.position.y, transform.position.z);
    }

    void moveBackwardX()
    {
        animateObject.transform.position = new Vector3(transform.position.x - (moveCounter / 32), transform.position.y, transform.position.z);
    }

    void moveForwardZ()
    {
        animateObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (moveCounter / 32));
    }

    void moveBackwardZ()
    {
        animateObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (moveCounter / 32));
    }

    // Update is called once per frame (I was a bit drunk when coding this so beware)
    void Update() {

       //Debug.Log(counter);
        Debug.Log(moveCounter);

        if ((counter % timeToTurn != 0) && (isRotateActive == false) && (switchMove == false))
        {
            moveForwardX();
        } else if ((counter % timeToTurn != 0) && (isRotateActive == false) && (switchMove == true))
        {
            moveBackwardX();
        }
        else
        {
            isRotateActive = true;
            StartCoroutine(RotateMe(Vector3.up * 90, 5f));
            moveCounter++;
        }

        //moveForwardX();

        //if (counter%timeToTurn != 0)
        //{
        //}


        //Update MoveCounter by Frame
        
    }
}
