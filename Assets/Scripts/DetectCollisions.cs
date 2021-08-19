using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    static public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (score == -5) {
            Debug.Log("Game Over");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Steak(Clone)")
        {
            score += 1;
            this.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(other.gameObject);
            Debug.Log("Score: " + score);
        }
        if (other.name == "Player")
        {
            score -= 1;
            Destroy(gameObject);
            Debug.Log("Score: " + score);
        }
    }
}
