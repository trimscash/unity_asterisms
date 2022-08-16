using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StarsList.loadCSV(); 
        var plotter = new StarPlotter();
        plotter.plot();
        var asterismsDrawer=new AsterismsDrawer();
		asterismsDrawer.drawAsterism();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
