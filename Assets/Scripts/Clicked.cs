using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clicked : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        PlayerText.Instance.Add(1);

        #region observer
        clicked?.Invoke();
        #endregion
    }
}