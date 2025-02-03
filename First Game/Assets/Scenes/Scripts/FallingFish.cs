using UnityEngine;
using System.Collections;

public class FallingFish : MonoBehaviour
{

    float fallSpeed = 5;

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
}
