using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerText : MonoBehaviour
{
    private int num;

    private Text text;

    public static PlayerText Instance { get; private set; }

    private void Awake()
    {
        text = GetComponent<Text>();
        Instance = this;
    }

    public void Add(int value)
    {
        num += value;
        text.text = num.ToString();
    }
}