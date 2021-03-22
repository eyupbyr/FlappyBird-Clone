using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    private const float destroyPosition = -200f;
    bool addedToScore = false; //if the bird passes this pipe then +1 can be added to score

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(30 * Time.deltaTime, 0f,0f);
        if (transform.position.x < destroyPosition)
            Destroy(gameObject);
        if (transform.position.x + 15f < Game_Manager.Bird.transform.position.x && !addedToScore)
        {
            Game_Manager.PipesPassedByBird++;
            addedToScore = true;
        }
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
