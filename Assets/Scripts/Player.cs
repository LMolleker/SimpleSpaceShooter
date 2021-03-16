using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject shoot;
    public Transform posShoot;
    public GameObject asteroid;
    private Transform transform;
    private Rigidbody rb;
    private float speed;
    private float h;
    private float v;
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;

    // Start is called before the first frame update
    void Start()
    {
        zMin = -5f;
        zMax = 5f;
        xMin = -6.62f;
        xMax = 6.62f;
        speed = 400f;
        transform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        StartCoroutine("createAsteroid");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //Velocity represent the rate of change of the position
        rb.velocity = new Vector3(h * speed, 0, v * speed) * Time.deltaTime;

        //Mathf.Clamp is for limite a value between two ranges
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, xMin, xMax), 5, Mathf.Clamp(rb.position.z,zMin,zMax));

        //Quaternion is used to represent rotation
        //Euler return a rotation based on three values
        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x * -5);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shoot, posShoot.position, Quaternion.identity);
            GetComponent<AudioSource>().Play();
        }
        
    }

    //Continuosly execute the code 
    IEnumerator createAsteroid()
    {
        while (true)
        {
        yield return new WaitForSeconds(0.3f);
        Instantiate(asteroid, new Vector3(Random.Range(xMin, xMax),5,7), Quaternion.identity);
        }
    }


}
