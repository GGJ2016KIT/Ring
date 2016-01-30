using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {
    public GameObject ring_b;

    /*    public GameObject ring2_b;
        public GameObject ring3_b;
        public GameObject ring4_b;
        public GameObject ring5_b;
        public GameObject ring6_b;
        public GameObject ring7_b;
        public GameObject ring8_b;
        public GameObject ring9_b;
        public GameObject ring10_b;
        */

    // Use this for initialization
    void Start () {
    

    }

    // Update is called once per frame
    void Update() {

    } 
    void OnCollisionEnter2D() {
 
        GameObject[] gm = new GameObject[5];
        gm[0] = GameObject.Find("Finger0");
        gm[1] = GameObject.Find("Finger1");
        gm[2] = GameObject.Find("Finger2");
        gm[3] = GameObject.Find("Finger3");
        gm[4] = GameObject.Find("Finger4");

        int num = Random.Range(0, 4);

        GameObject game;

//        Debug.Log(num);
//
//        Debug.Log("collide.");
        Destroy(gameObject);
        
        game = (GameObject)Instantiate(ring_b, gm[num].transform.position, Quaternion.identity);

        game.transform.parent = gm[num].transform;

        if(ring_b.transform == game.transform)
        {
            Destroy(game);
        }

//        Invoke("destroy", 1f);
    }

    //void destroy(GameObject g)
    //{
    //    Destroy(g);
    //}
}
