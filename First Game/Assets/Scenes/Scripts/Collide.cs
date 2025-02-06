using UnityEngine;

public class Collide : MonoBehaviour
{

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Fish hits basket
        if (col.gameObject.name == "Fish" || col.gameObject.name == "Fish(Clone)") // Source 1
        {
            Destroy(col.gameObject);
        }
        GameManager.Instance.incScore(1);
        audioSource.Play();
    }
}

// Sources:
// 1. https://discussions.unity.com/t/destroy-clone-objects/721405