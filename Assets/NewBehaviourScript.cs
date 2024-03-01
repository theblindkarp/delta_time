using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float x0 = 0;
    public float units = 1;
    public int fps = 30;
    public int updateLimit = 10;

    int updateCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(x0, transform.position.y, 0);
        updateCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        updateCount++;

        float speed = units * fps * Time.deltaTime;

        Vector3 move = new Vector3(speed, 0, 0);

        if (updateCount <= updateLimit)
        {
            this.transform.position += move;
        }
    }
}
