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
    protected bool pauseCounter;        //Pause the Counter
    Vector3 velocity = new Vector3(1.0f, 0.0f, 0.0f);

	// Initialization of Counter
	void Start () {
        counter = 0;
        StartCoroutine(MyCounter());
        switchMove = false;
        pauseCounter = false;
        animateObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    //Counts in Terms of Seconds for Unity
    IEnumerator MyCounter()
    {
        //Debug.Log(counter);
        while (true) { 
            if (pauseCounter == false)
            {
                yield return new WaitForSeconds(1);
                counter++;
            }
            else
            {
                yield return null;
            }
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
    }


    // Move Sets
    void moveForwardX()
    {
        //float myFront = transform.position.x + (moveCounter / 32);
        //Debug.Log("Transform X Positive: " + myFront);

        //animateObject.transform.position = new Vector3(transform.position.x + (moveCounter / 32), transform.position.y, transform.position.z);
        //animateObject.transform.position += animateObject.Transform.forward * Time.deltaTime; 
        //Debug.Log("Velocity Pos Change in positive: " + velocity * Time.fixedDeltaTime);
        animateObject.transform.position += velocity * Time.deltaTime;
    }

    void moveBackwardX()
    {
        //float myBack = transform.position.x - (moveCounter / 32);
        //Debug.Log("Transform X Negative: " + myBack);

        //animateObject.transform.position = new Vector3(transform.position.x - (moveCounter / 32), transform.position.y, transform.position.z);
        //animateObject.transform.position -= animateObject.Transform.forward * Time.deltaTime;
        //Debug.Log("Velocity Pos Change in negative: " + velocity * Time.fixedDeltaTime);
        animateObject.transform.position -= velocity * Time.deltaTime;
    }

    /*
    void moveForwardZ()
    {
        animateObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (moveCounter / 32));
    }

    void moveBackwardZ()
    {
        animateObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (moveCounter / 32));
    }
    */

    //MoveByXAxis
    void moveByXAxis()
    {
        //User wants to let this run until 10 seconds and then 
        if (counter % timeToTurn == 0) {
            pauseCounter = true;
            //Swap MoveForward with MoveBackward
            if (switchMove == false)
            {
                switchMove = true;
            }
            else
            {
                switchMove = false;
            }

            //This creates a coroutine to rotate the object
            StartCoroutine(RotateMe(Vector3.up * 90, 1f));



        } else
        {
            pauseCounter = false;
            if (switchMove == false)
            {
                moveForwardX();
                //Debug.Log("Moving Forward!");
            } else if (switchMove == true)
            {
                moveBackwardX();
                //Debug.Log("Moving Backwards!");
            }
        }
            //Update MoveCounter
            if (pauseCounter == false)
            {
                moveCounter++;
            }
    }


    void moveByZAxis()
    {

    }


    // Update is called once per frame (I was a bit drunk when coding this so beware)
    void Update() {

        //Debug.Log(counter);
        //Debug.Log(moveCounter);

        moveByXAxis();



        //if ((counter % timeToTurn != 0) && (isRotateActive == false) && (switchMove == false))
        //{
        //    moveForwardX();
        //} else if ((counter % timeToTurn != 0) && (isRotateActive == false) && (switchMove == true))
        //{
        //    moveBackwardX();
        //}
        //else
        //{
        //    StartCoroutine(RotateMe(Vector3.up * 90, 5f));
        //    moveCounter++;
        //}
        //moveForwardX();
        //if (counter%timeToTurn != 0)
        //{
        //}
        //Update MoveCounter by Frame
    }
}
