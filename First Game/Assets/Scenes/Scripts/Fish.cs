using UnityEngine;

public class Fish : MonoBehaviour
{

    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}