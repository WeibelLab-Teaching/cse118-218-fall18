using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeadPose
{
    public int id;
    public float headx, heady, headz;
}

public class MessageManager : MonoBehaviour {

    public Transform cube;

    public void OnJSONMessage(string msg)
    {
       
        HeadPose head = JsonUtility.FromJson<HeadPose>(msg);
        //Debug.Log("Head " +  head.id + " - " + head.headx + "  " + head.heady + "  " + head.headz);
        if (head != null && head.headx > 0)
        {
            Vector3 newPosition = new Vector3(head.headx, head.heady, head.headz);
            cube.localPosition = newPosition;
        }
 

    }

}
