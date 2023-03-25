using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugStore : MonoBehaviour
{
    private bool _estActive = false;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("condom on");

        if (collision.gameObject.tag == "Player" && !_estActive)
        {
            GameObject.Find("Condom").SetActive(true);
            _estActive = true;
        }
        GameObject.Find("Condom").SetActive(true);

    }
}
