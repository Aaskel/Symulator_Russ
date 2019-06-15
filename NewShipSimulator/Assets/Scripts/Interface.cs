using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Interface : MonoBehaviour {
    public Ship statek;

    public Text EngineText,TextEngine, RudderText,TextRudder, SpeedText, TextSpeed, DepthText, TextDepth,
                HeadingText, TextHeading, RudderAngleText, TextRudderAngle, TimeText, TextTime, ROTText, TextROT;

    public Slider CurrentAngle, ROT;

    public void changeEngine(float value)
    {
        statek.engine = value;
        EngineText.text = "Enigne: "+ string.Format("{0:0.0}", value);
        TextEngine.text = "Enigne: " + string.Format("{0:0.0}", value);
    }

    public void changeRudder(float value)
    {
        statek.rudder = value;
        RudderText.text = "Rudder: " + string.Format("{0:0.0}", value);
        TextRudder.text = "Rudder: " + string.Format("{0:0.0}", value);
    }

    private void Update()
    {
        SpeedText.text = string.Format("{0:0.0}", statek.currentSpeed);
        TextSpeed.text = "Speed:"+string.Format("{0:0.0}", statek.currentSpeed);

        RudderAngleText.text = string.Format("{0:0.0}", statek.currentRudder);
        TextRudderAngle.text = "RudderAngle:" + string.Format("{0:0.0}", statek.currentRudder);
        if (statek.currentRudder == 0) RudderAngleText.color = new Color(0f, 0f, 0f);
        else if (statek.currentRudder < 0) RudderAngleText.color = new Color(1f, 0f, 0f);
        else RudderAngleText.color = new Color(0f, 1f, 0f);
        CurrentAngle.value = statek.currentRudder;

        HeadingText.text = string.Format("{0:000.0}", statek.cog);
        TextHeading.text = "Heading:" + string.Format("{0:000.0}", statek.cog);

        TimeText.text = DateTime.Now.ToString("HH:mm:ss");
        TextTime.text = "Time:" + DateTime.Now.ToString("HH:mm:ss");

        ROTText.text = string.Format("{0:0.0}", statek.rot*60);
        TextROT.text = "Rot (DEG/MIN): " + string.Format("{0:0.0}", statek.rot * 60);
        if (statek.rot == 0) ROTText.color = new Color(0f, 0f, 0f);
        else if (statek.rot < 0) ROTText.color = new Color(1f, 0f, 0f);
        else ROTText.color = new Color(0f, 1f, 0f);
        ROT.value = statek.rot * 60;

        DepthText.text = "Depth: "+ statek.getDepth();
        TextDepth.text = "Depth: " + statek.getDepth();
    }
}