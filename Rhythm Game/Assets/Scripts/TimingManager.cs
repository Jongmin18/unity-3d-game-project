﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{

    public List<GameObject> boxNoteList = new List<GameObject>();
    
    [SerializeField] Transform Center = null;

    EffectManager theEffect;
    
        
    // Start is called before the first frame update
    void Start()
    {
               
    }

    public void CheckTiming()
    {
        Debug.Log("Hit");
    }

}
