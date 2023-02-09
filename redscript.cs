using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class redscript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public GameObject opponent;
    public GameObject RedSpawn;

    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal2");
        float moveVertical = Input.GetAxis ("Vertical2");

        Vector3 movement = new Vector3 (moveHorizontal,0,moveVertical);

        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("outofbounds"))
        {
           StartCoroutine(Fallen());
        }
    }

    IEnumerator Fallen()
    {
        transform.position = RedSpawn.transform.position;
    }
}
