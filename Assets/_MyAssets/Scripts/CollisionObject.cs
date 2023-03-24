using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionObject : MonoBehaviour
{
    //Attribut
    //private GameManager _gameManager;
    //private bool _toucher;


    //private void Start()
    //{
    //    _gameManager = FindObjectOfType<GameManager>();
    //    _toucher = false;
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player" && _toucher == false)
    //    {

    //        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    //        _gameManager.AugmenterPointage();
    //        _toucher = true;
    //    }

    //}

    public Color collisionColor = Color.red; // The color to change to when a collision is detected
    private Color initialColor; // The initial color of the object
    private bool isColliding = false; // Whether the object is currently colliding with another object

    void Start()
    {
        initialColor = GetComponent<Renderer>().material.color; // Get the initial color of the object
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isColliding)
        {
            isColliding = true;
            GetComponent<Renderer>().material.color = collisionColor; // Change the color of the object on collision

            // Schedule a coroutine to change the color back after 4 seconds
            StartCoroutine(ResetColor());
        }
    }

    IEnumerator ResetColor()
    {
        yield return new WaitForSeconds(3.0f); // Wait for 3 seconds

        isColliding = false;
        GetComponent<Renderer>().material.color = initialColor; // Reset the color of the object
    }

}