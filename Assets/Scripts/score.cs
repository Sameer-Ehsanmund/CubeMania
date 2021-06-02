using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform to; //"to" pointing to player
    public Text scoretext;

    void Update()
    {
        scoretext.text = to.position.z.ToString("0");
    }
}
