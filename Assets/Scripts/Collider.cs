using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {

        // Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

    }
    
    void OnCollisionEnter2D() {
        GameObject gm = GameObject.Find("Finger0");
        Debug.Log("aa");
        Destroy(gameObject);
        GameObject game = (GameObject)Instantiate(gameObject, gm.transform.position, Quaternion.identity);
        game.transform.parent = gm.transform;
        

    }
}
