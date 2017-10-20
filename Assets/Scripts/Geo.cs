using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Geo : MonoBehaviour {

    //determina las cualidades compartidas, guarda las cualidades unicas


    private string GeoName;
    

    public string getGeoName() {
        return GeoName;
    }

    public void setGeoName(string input) {
        this.GeoName = input;
    }

    public void geometryAction() {
        Console.WriteLine(getGeoName() + " is performing an action");
    }

	public void getGeo(int rSx, int rSz, float wallPos, String t) {
 		
		//random x and z?
		if(t.Equals("Geo1")){
			 GameObject geom = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Rigidbody rigidbody = geom.AddComponent<Rigidbody> ();
            geom.transform.position = new Vector3(rSx , 0 , rSz);
		}
		else if(t.Equals("Geo2")){
			GameObject geom2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            geom2.transform.localScale += new Vector3(5.0F, 0, 0);
			//if (wallPos >= 1) {
			//ship2.transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
			//}
			Rigidbody rigidbody2 = geom2.AddComponent<Rigidbody> ();
            geom2.transform.position = new Vector3(rSx , 0 , rSz);
		}

    }

	public void followPlayer(){
		
	}
}
