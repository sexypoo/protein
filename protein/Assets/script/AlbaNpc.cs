using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbaNpc : MonoBehaviour
{
    List<string> alba = new List<string>();

    void Update()
    {
        if ((GameObject.Find("Player").GetComponent<Player>().AlbaMod == "Alba" || GameObject.Find("Player").GetComponent<Player>().AlbaMod == "None_ing") && alba.Contains(this.name) == false)
        {
            transform.position = new Vector3(this.transform.position.x, 3.5f, this.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(this.transform.position.x, -10, this.transform.position.z);
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && alba.Contains(this.name) == false)
            {
                StartCoroutine(AlbaCoolTime(30f));
            }
        }
            
    }

    IEnumerator AlbaCoolTime(float cool)
    {
        alba.Add(this.name);
        while (cool > 1.0f)
        {
            cool -= Time.deltaTime;
            yield return new WaitForFixedUpdate();

        }
        alba.Remove(this.name);
    }
}
