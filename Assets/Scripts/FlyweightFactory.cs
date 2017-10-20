using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightFactory : MonoBehaviour {

    // creacion de objetos
	public Geo initGeo(string geo) {

        Geo geometry = null;

        if (geo.Equals("Geo1")) {
            return new Geo1();
        } else if (geo.Equals("Geo2")) {
            return new Geo2();
        } else {
            return null;
        }
    }

}
