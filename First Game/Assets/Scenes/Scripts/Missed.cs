using UnityEngine;

public class Missed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Fish hits ground
        if (col.gameObject.name == "Fish" || col.gameObject.name == "Fish(Clone)") // Source 1
        {
            Destroy(col.gameObject);
        }
        GameManager.Instance.missScore(1);
    }
}
