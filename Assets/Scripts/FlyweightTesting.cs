using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightTesting : MonoBehaviour {

    
    // crea objeto factory
    FlyweightFactory flyweightFactory = new FlyweightFactory();

    Geo geometry = null;

    string geoType = null;

	float rN = 1;
	int rSx = 0;
	int rSz = 0;
	float wallPos = 0;
	public float spawnPeriod;
	private float nextSpawnTime;
	// inisialisacion
	void Start () {
		nextSpawnTime = 1;
		spawnPeriod = 0.1f;
    }
	
	// Update una ves por frame
	void FixedUpdate () {
		//Random rnd = new Random ();
		rN = Random.Range ( 0.0f, 2.0f);
		wallPos = Random.Range ( 0.0f, 2.0f);
		rSx = Random.Range (-45, 45);
		rSz = Random.Range (-25, 25);
		spawnGeo();
        //gathers user input to define the extrinsic state of the object being created (name/type)
    }

	void spawnGeo(){
		float TempR = rN;
		//int TempR = 2;
		if (TempR <=1 && Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + spawnPeriod;
			geoType = "Geo1";
			geometry = flyweightFactory.initGeo(geoType);
			GeoActions(geometry,"Geo1");
			//nextSpawnTime = spawnPeriod;

		} else if (TempR >=1 && Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + spawnPeriod;
            geoType = "Geo2";
			geometry = flyweightFactory.initGeo(geoType);
			GeoActions(geometry,"Geo2");

		} else { }
	}
    // acciones, instanciamiento
	void GeoActions(Geo aFigure, string t) {
        aFigure.getGeo(rSx, rSz, wallPos, t);
        aFigure.geometryAction();
    }
}
