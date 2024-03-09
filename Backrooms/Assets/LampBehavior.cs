using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBehavior : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] float offRange = 5f;
    [SerializeField] float onRange = 1f;
    float rangeNow = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(rangeNow <= 0)
        {
            if(light.enabled)
                rangeNow = Random.RandomRange(0, offRange);
            else
                rangeNow = Random.RandomRange(0, onRange);
        }
        else
        {
            if (rangeNow > 0)
                rangeNow -= Time.deltaTime;
            if (rangeNow <= 0)
                light.enabled = !light.enabled;
        }
    }
}
