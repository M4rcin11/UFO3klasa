using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UFO")) // Zak�adamy, �e UFO ma tag "UFO".
        {
            Destroy(gameObject); // Zniszcz kawa�ek z�ota.
        }
    }
}