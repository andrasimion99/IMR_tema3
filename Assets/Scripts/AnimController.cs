using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public GameObject objectToAnimate;
    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            objectToAnimate.GetComponent<Animator>().Play("FirstTry");
        }
        if (Input.GetButtonDown("2Key"))
        {
            objectToAnimate.GetComponent<Animator>().Play("Rock'nRoll");
        }
        if (Input.GetButtonDown("3Key"))
        {
            objectToAnimate.GetComponent<Animator>().Play("Foarfec");
        }
    }
}
