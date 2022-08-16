using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System;

public class StarPlotter
{
    // Start is called before the first frame update
    public void plot()
    {
        foreach(StarData star in StarsList.Stars){
            GameObject obj=(GameObject)Resources.Load("Star");
            GameObject instance = (GameObject)UnityEngine.Object.Instantiate(obj,
                                                CoordToMonitor.angleToVector3(star.RightAscension,star.Declination,100f),
                                                Quaternion.identity);
            instance.name=star.ID.ToString();
        }
    }


}