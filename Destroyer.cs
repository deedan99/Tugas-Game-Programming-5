using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D col){
        string tag = col.gameObject.tag;
        if (tag == "Bird" || tag == "Enemy" || tag == "Obstacle"){
            Destroy(col.gameObject);
        }
    }
}
