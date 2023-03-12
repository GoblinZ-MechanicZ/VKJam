using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeLight : MonoBehaviour
{
    [SerializeField] float timerPeriud = 1;
    [SerializeField] GameObject redLight = null;
    [SerializeField] GameObject blueLight = null;
    float curretTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        curretTime = UnityEngine.Random.Range(0.00001f, timerPeriud);
        redLight.SetActive(true);
        blueLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        curretTime -= Time.deltaTime;
        if (curretTime<0) {
            redLight.SetActive(!redLight.activeSelf);
            blueLight.SetActive(!blueLight.activeSelf);
            curretTime = timerPeriud;
        }
        
    }
}
