using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text pointsLabel;
    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    public void increasePoints()
    {
        points++;
    }

    public void decreasePoints()
    {
        points--;
    }
    void Update()
    {
        pointsLabel.text = points.ToString();
    }
}
