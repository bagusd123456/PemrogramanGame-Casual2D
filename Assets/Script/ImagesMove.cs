using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesMove : MonoBehaviour
{
    int[] posX = new int[] { 0, -18, -36, -54};
    public int idx = 0;
    public int scrollSpeed = 50;

    public AudioSource[] audio;

    // Start is called before the first frame update
    void Start()
    {
        audio[idx].Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (idx < posX.Length - 1)
            {
                idx++;
                audio[idx].Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (idx > 0)
            {
                idx--;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(posX[idx],
            transform.position.y), scrollSpeed * Time.deltaTime);
    }
}
