using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeMovement : MonoBehaviour
{
    public List<Transform> trs ;

    public int count = 0;

    public float journeyTime = 1f;
    Vector3 startPos, endPos;
    float t, startTime;
    bool updateRoute = true;

    private void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {
        if(updateRoute == true)
        {
            updateRoutes();
            updateRoute = false;
        }

        t = (Time.time - startTime) / journeyTime;
        transform.position = Vector3.Slerp(startPos, trs[count].position, t);
        if (t > 1)
        {
            updateRoute = true;
            startTime = Time.time;
            t = 0f;
        }
    }

    void updateRoutes()
    {
        startPos = transform.position;
        endPos = trs[count].position;
        if (count < 3)
        {
            count++;
        }
        else
        {
            count = 0;
        }
    }


}
