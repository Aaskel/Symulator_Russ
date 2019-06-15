using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
    public float engine, rudder;

    public float currentSpeed, currentRudder;

    const float T = 48.5f;
    const float K = 0.1232f;
    const float maxSpeed = 21f;

    public float rot = 0;
    public float cog = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentSpeed = Mathf.MoveTowards(currentSpeed, engine*maxSpeed/100, Time.deltaTime);
        currentRudder = Mathf.MoveTowards(currentRudder, rudder, Time.deltaTime * 2.8f);

        rot = (currentSpeed/maxSpeed) * ((K * currentRudder * Time.deltaTime - rot * (Time.deltaTime - T)) / T);
        if (rot > 2) rot = 2;
        else if (rot < -2) rot = -2;

        cog += rot * Time.deltaTime;
        cog %= 360;
        if (cog < 0) cog = 360 + cog;

        float speedInMetersSec = currentSpeed * 0.514444f;

        transform.position = new Vector3(
            transform.position.x + Mathf.Sin(cog * Mathf.Deg2Rad) * speedInMetersSec * Time.deltaTime,
            transform.position.y,
            transform.position.z + Mathf.Cos(cog * Mathf.Deg2Rad) * speedInMetersSec * Time.deltaTime
        );

        transform.rotation = Quaternion.Euler(0, cog, 0);
    }

    public float getDepth()
    {
        return GameObject.Find("echosonda").GetComponent<Echosonda>().depth;
    }
}
