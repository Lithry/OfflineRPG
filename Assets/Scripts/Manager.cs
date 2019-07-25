using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Entity entity;
    // Start is called before the first frame update
    void Start()
    {
        entity.Init("Prueba", 1, 10, 5, 2, 7, 6, 9, 50);
        PlayerInfoManager.instance.SetTexts(entity.GetName(), entity.GetStats());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
