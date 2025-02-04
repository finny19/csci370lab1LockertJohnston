using UnityEngine;

public class CatchFish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
        Destroy(col.gameObject);
        GameManager.Instance.incScore(1);
    }
}
