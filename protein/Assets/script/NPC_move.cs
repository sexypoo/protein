using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_move : MonoBehaviour
{
    public Vector3[] waypoints;
    public float speed = 5f;
    public int setting;
    private Vector3 currPosition;
    private int waypointIndex = 0;

    

    void Start()
    {
        waypoints = new Vector3[4];
        setPos();
    }

    void Update()
    {
        currPosition = transform.position;

        if (waypointIndex < waypoints.Length)
        {
            float step = speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(currPosition, waypoints[waypointIndex], step);

            if (Vector3.Distance(waypoints[waypointIndex], currPosition) == 0f)
                waypointIndex++;

            if (waypointIndex == 4)
                waypointIndex = 0;
        }

       
    }
    private void setPos()
    {
        if (setting == 1)
        {
            waypoints.SetValue(new Vector3(20, 7, 125), 0);
            waypoints.SetValue(new Vector3(20, 7, -150), 1);
            waypoints.SetValue(new Vector3(245, 7, -150), 2);
            waypoints.SetValue(new Vector3(245, 7, 125), 3);

            transform.position = new Vector3(245, 7, 125);
        }
        else if (setting == 2)
        {
            waypoints.SetValue(new Vector3(242, 7, 44), 0);
            waypoints.SetValue(new Vector3(22, 7, 44), 1);
            waypoints.SetValue(new Vector3(22, 7, 122), 2);
            waypoints.SetValue(new Vector3(242, 7, 122), 3);

            transform.position = new Vector3(242, 7, 122);
        }
        else if (setting == 3)
        {
            waypoints.SetValue(new Vector3(22, 7, -31), 0);
            waypoints.SetValue(new Vector3(22, 7, 23), 1);
            waypoints.SetValue(new Vector3(242, 7, 23), 2);
            waypoints.SetValue(new Vector3(242, 7, -31), 3);

            transform.position = new Vector3(242, 7, -31);
        }
        else if (setting == 4)
        {
            waypoints.SetValue(new Vector3(22, 7, -51), 0);
            waypoints.SetValue(new Vector3(242, 7, -51), 1);
            waypoints.SetValue(new Vector3(242, 7, -148), 2);
            waypoints.SetValue(new Vector3(22, 7, -148), 3);

            transform.position = new Vector3(22, 7, -148);
        }
        else if (setting == 5)
        {
            waypoints.SetValue(new Vector3(-248, 7, -90), 0);
            waypoints.SetValue(new Vector3(-19, 7, -90), 1);
            waypoints.SetValue(new Vector3(-19, 7, 125), 2);
            waypoints.SetValue(new Vector3(-248, 7, 125), 3);

            transform.position = new Vector3(-248, 7, 125);
        }
        else if (setting == 6)
        {
            waypoints.SetValue(new Vector3(-24, 7, 122), 0);
            waypoints.SetValue(new Vector3(-24, 7, -7), 1);
            waypoints.SetValue(new Vector3(-163, 7, -7), 2);
            waypoints.SetValue(new Vector3(-163, 7, 122), 3);

            transform.position = new Vector3(-163, 7, 122);
        }
        else if (setting == 7)
        {
            waypoints.SetValue(new Vector3(-177, 7, 122), 0);
            waypoints.SetValue(new Vector3(-242, 7, 122), 1);
            waypoints.SetValue(new Vector3(-242, 7, -7), 2);
            waypoints.SetValue(new Vector3(-177, 7, -7), 3);

            transform.position = new Vector3(-177, 7, -7);
        }
        else if (setting == 8)
        {
            waypoints.SetValue(new Vector3(-242, 7, -85), 0);
            waypoints.SetValue(new Vector3(-23, 7, -85), 1);
            waypoints.SetValue(new Vector3(-23, 7, -26), 2);
            waypoints.SetValue(new Vector3(-242, 7, -26), 3);

            transform.position = new Vector3(-242, 7, -26);
        }


    }
}
