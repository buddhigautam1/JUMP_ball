using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //providing audio source
    public AudioSource touchsound;

    public float KeyInput;
    // Start is called before the first frame update
    void Start()
    {
        touchsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*2, ForceMode.VelocityChange);
        }

        KeyInput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(KeyInput,GetComponent<Rigidbody>().velocity.y,0);
    }
    //collide then produce sound we use method OnCollisonEnter()

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        touchsound.Play();
    }
}
