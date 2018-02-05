using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public float speed;

    private Rigidbody rb;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = speed * transform.forward;
    }
}
