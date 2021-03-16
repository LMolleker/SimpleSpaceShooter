using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float speed;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.2f;
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset = new Vector2(0, speed * Time.time);
    }
}
