using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{

    GameObject zach, stan;
    int characterSelect;
    GameObject CurrentChar;
    public bool Trigger = false;

    // Use this for initialization
    void Start()
    {
        characterSelect = 1; //current character
        zach = GameObject.Find("hero");
        stan = GameObject.Find("hero2");
        transform.position = new Vector3(3, 5, 0);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position; //current position of Player
        Vector3 oldPos = new Vector3(2, 1, 0); //Empty old position vector


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Trigger = false;
            characterSelect = 1;
            oldPos = pos;
            Debug.Log("1" + oldPos);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Trigger = false;
            characterSelect = 2;
            oldPos = pos;
            Debug.Log("2" + oldPos);
        }

        if (characterSelect == 1)
        {
            if (Trigger == false)
            {
                zach.SetActive(true); //Activate Zach
                stan.SetActive(false);

                GameObject.Find("hero").transform.position = oldPos;

                Trigger = true; //Change trigger back to true so that it doesn't repeat more than once.


            }

        }
        else if (characterSelect == 2)
        {
            if (Trigger == false)
            {
                zach.SetActive(false); //Activate Stan
                stan.SetActive(true);

                GameObject.Find("hero2").transform.position = oldPos; //Set Stan's position to the previous players' old position.

                Trigger = true;


            }

        }
    }
}
