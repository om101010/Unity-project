using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botai : MonoBehaviour
{
    #region Singleton

    public static botai instance;
    private void Awake()
    {
        instance = this;
    }


    #endregion
    public GameObject player;
}
