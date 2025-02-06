using UnityEngine;

public class DroppingFish : MonoBehaviour
{

    public GameObject fish;
    private bool harder = false;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DropFish", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (harder == true){
            InvokeRepeating("DropFish", Random.Range(0.6f, 1.6f), Random.Range(2.4f, 2.7f));
            harder = false;
        }
        
    }

    void DropFish()
    {
        var position = new Vector2(Random.Range(-9.0f, 9.0f), 5); // source 1
        Instantiate(fish, position, Quaternion.identity);
        if (GameManager.Instance.getScore() == 25){
            harder = true;
        }
        if (GameManager.Instance.getScore() == 50){
            harder = true;
        }
         if (GameManager.Instance.getScore() == 75){
            harder = true;
         }
        if (GameManager.Instance.getScore() == 100){
            harder = true;
        }


    }
}

// Sources:
// 1. https://docs.unity3d.com/ScriptReference/Random.Range.html