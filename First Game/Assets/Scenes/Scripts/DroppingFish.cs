using UnityEngine;

public class DroppingFish : MonoBehaviour
{

    public GameObject fish;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DropFish", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropFish()
    {
        var position = new Vector2(Random.Range(-9.0f, 9.0f), 5); // source 1
        Instantiate(fish, position, Quaternion.identity); // source 1
    }
}

// Sources:
// 1. https://docs.unity3d.com/ScriptReference/Random.Range.html