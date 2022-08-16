using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterismsDrawer
{
    public void drawAsterism(){
        Debug.Log("Drawing Asterisms");
        
        AsterismData Asterism=new AsterismData(new List<int>{105036, 89715, 90146},new List<List<int>>{new List<int>{0, 1, 1 },new List<int> {0, 1, 1 },new List<int>{1,1,0}});
        List<Vector3> StarsPos=new List<Vector3>();
        foreach(int id in Asterism.Stars){
            StarsPos.Add(GameObject.Find("/" + id.ToString()).transform.position);
        }

		GameObject linePrefab = (GameObject)Resources.Load("Line");
        GameObject AsterismLine=UnityEngine.Object.Instantiate(linePrefab,new Vector3(0,0,0),Quaternion.identity) as GameObject;
        LineRenderer lineRenderer=AsterismLine.GetComponent<LineRenderer>();
        lineRenderer.positionCount=StarsPos.Count;
		lineRenderer.SetPositions(StarsPos.ToArray());

		Debug.Log("end Draw Asterisms");
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
