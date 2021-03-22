using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] private GameObject pipesPrefab = default;
    [SerializeField] private float maxHeight;

    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if(timer > 1.2f)
        {
            CreatePipes(maxHeight);
            timer = 0f;
        }
        timer += Time.deltaTime;
    }

    private void CreatePipes(float height)
    {
        GameObject pipes = Instantiate(pipesPrefab);
        pipes.transform.position = new Vector2(transform.position.x + 75f, Random.Range(-height,height));
    }
}
