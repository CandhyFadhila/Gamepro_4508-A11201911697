using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-3, 0);

    void Start(){
        GetComponent<Rigidbody2D>().velocity = veloc;

        float range = 0.1f;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }
}
