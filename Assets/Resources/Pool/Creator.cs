using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GameObject go = Resources.Load<GameObject>("Creature");
       for (int i = 0; i < 10; i++)
       {
              GameObject go1 = Instantiate(go);
              go1.transform.position = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
              go1.name = "Creature" + i;
              go1.tag = "Creature";
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
