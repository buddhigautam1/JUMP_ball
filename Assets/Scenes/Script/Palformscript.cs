using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Palformscript : MonoBehaviour
{
    //calling next and active scenes or level
    public int scenename;
    public int nextscene;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left*UnityEngine.Random.Range(0.2f,1.2f), ForceMode.VelocityChange);
        
    }

    // Update is called once per frame
    void Update()

    {
      

}
    void OnCollisionEnter(Collision collision)
    {
        //if candy collide with platform goes to  next level

        if
            (collision.gameObject.CompareTag("Candy"))
            SceneManager.LoadScene(nextscene);


        //Respawn colliding another object then game over
        if
           (collision.gameObject.CompareTag("Respawn"))
            SceneManager.LoadScene(scenename);

    }
}
