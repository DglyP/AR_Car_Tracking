using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class GeneralController : MonoBehaviour
{
    private int score = 0;
    private List<SphereBall> children;
    // Start is called before the first frame update
    void Start()
    {
        children = new List<SphereBall>(transform.GetComponentsInChildren<SphereBall>());
        var rnd = new System.Random();
        children = children.OrderBy(item => rnd.Next()).ToList();
        int i = 1;
        foreach (var value in children)
        {
            value.setValue(i);
            ++i;
        }
        children[0].activate();
    }


    public void popBubble(int num)
    {
        ++score;
        if (children.Count > num) children[num].activate();
        Debug.Log(score);
    }
}
