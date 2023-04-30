using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public  Vector2 v2;
    public Text countText;
    int count = 0;
    

    void Start()
    {
        count = 0;
        countText.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        v2 = transform.position;
        int count = (int)v2.y + 4;
        countText.text = count.ToString();
    }
}
