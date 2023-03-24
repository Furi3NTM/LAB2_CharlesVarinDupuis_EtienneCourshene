using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs 
    [SerializeField] private float _vitesse = 800;
    private bool _estActif = true;                     //??
    private Rigidbody _rb;


    // Méthodes privées
   private void Start()
    { 
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (_estActif)
        {
         MouvementsJoueur();
        }
   
    }
    

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        //transform.Translate(direction * Time.deltaTime * _vitesse);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;

        if (Input.GetKey("up"))
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetKey("down"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey("right"))
        {
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        else if (Input.GetKey("left"))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    }

    public void StopJoueur()
    {
        this.gameObject.SetActive(false);
    }
   
}