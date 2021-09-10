using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkover : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("WALKED INTO THE THING!!!");
    }
}
