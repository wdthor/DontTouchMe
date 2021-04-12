using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 2f;
    MeshRenderer rendering;
    Rigidbody gravity;
    // Start is called before the first frame update
    void Start()
    {
        rendering = GetComponent<MeshRenderer>();
        gravity = GetComponent<Rigidbody>();
        gravity.useGravity = false;
        rendering.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait) {
            gravity.useGravity = true;
            rendering.enabled = true;
        }
    }
}
