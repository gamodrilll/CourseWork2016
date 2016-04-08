using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateElementsScript : MonoBehaviour {

    public delegate Vector3 ReplicationItem(Vector3 vect);

    public List<ReplicationItem> replications = new List<ReplicationItem>();

    void repCreating()
    {
        replications.Add((Vector3 vect) => (new Vector3(vect.x, vect.y, vect.z)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.y,vect.x - vect.y , vect.z)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.x+vect.y,-vect.x ,vect.z )));
        replications.Add((Vector3 vect) => (new Vector3(vect.y,vect.x,-vect.z)));
        replications.Add((Vector3 vect) => (new Vector3(vect.x - vect.y,-vect.y ,-vect.z)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.x,-vect.x+vect.y ,-vect.z)));

        replications.Add((Vector3 vect) => (new Vector3(vect.x + 2.0f / 3, vect.y + 1.0f / 3, vect.z + 1.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.y + 2.0f / 3, vect.x - vect.y + 1.0f / 3, vect.z + 1.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.x + vect.y + 2.0f / 3, -vect.x + 1.0f / 3, vect.z + 1.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(vect.y + 2.0f / 3, vect.x + 1.0f / 3, -vect.z + 1.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(vect.x - vect.y + 2.0f / 3, -vect.y + 1.0f / 3, -vect.z+ 1.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.x + 2.0f / 3, -vect.x + vect.y + 1.0f / 3, -vect.z + 1.0f / 3)));

        replications.Add((Vector3 vect) => (new Vector3(vect.x + 1.0f / 3, vect.y + 2.0f / 3, vect.z + 2.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.y + 1.0f / 3, vect.x - vect.y + 2.0f / 3, vect.z + 2.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.x + vect.y + 1.0f / 3, -vect.x + 2.0f / 3, vect.z + 2.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(vect.y + 1.0f / 3, vect.x + 2.0f / 3, -vect.z + 2.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(vect.x - vect.y + 1.0f / 3, -vect.y + 2.0f / 3, -vect.z + 2.0f / 3)));
        replications.Add((Vector3 vect) => (new Vector3(-vect.x + 1.0f / 3, -vect.x + vect.y + 2.0f / 3, -vect.z + 2.0f / 3)));
    
    }


	// Use this for initialization
	void Start () {
        repCreating();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
