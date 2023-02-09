using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bluescript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public GameObject opponent;
    public GameObject BlueSpawn;

    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

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
        transform.position = BlueSpawn.transform.position;
    }

}
