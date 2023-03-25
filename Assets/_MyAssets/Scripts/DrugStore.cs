using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugStore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Condom").SetActive(true);
    }
}
