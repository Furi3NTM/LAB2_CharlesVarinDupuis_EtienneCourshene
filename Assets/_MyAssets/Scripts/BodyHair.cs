using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHair : MonoBehaviour
{
    // Attributes
    private bool irritated = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Poil irrité");
    }

}
