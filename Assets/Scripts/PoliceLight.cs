using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceLight : MonoBehaviour
{
    [SerializeField] float timerPeriud = 1;
    [SerializeField] GameObject redLight = null;
    [SerializeField] GameObject blueLight = null;
    float curretTime = 0;
    bool isRedFirst = false;

    // Start is called before the first frame update
    void Start()
    {
        isRedFirst = Random.Range(0, 100) >= 50f;
        curretTime = UnityEngine.Random.Range(0.00001f, timerPeriud * 10);
        redLight.SetActive(isRedFirst);
        blueLight.SetActive(!isRedFirst);
    }

    // Update is called once per frame
    void Update()
    {
        curretTime -= Time.deltaTime;
        if (curretTime < 0)
        {
            redLight.SetActive(!redLight.activeSelf);
            blueLight.SetActive(!blueLight.activeSelf);
            curretTime = timerPeriud;
        }

    }
}
