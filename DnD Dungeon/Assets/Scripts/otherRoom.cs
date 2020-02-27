using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class otherRoom : MonoBehaviour {
    public bool N, S, E, W = false;
    private Vector2 self_extent;

    // Use this for initialization
    void Start () {
        GameObject.Find("NSEW").GetComponent<DungeonGeneration>().rooms_to_create -= 1;
        self_extent = (Vector3)transform.GetComponent<TilemapRenderer>().bounds.extents;
        goto case1;
        case1: if (N == false && this.name.Contains("N"))// && !this.gameObject.transform.parent.name.Contains("N"))
        {
            if (this.transform.parent.position.x == this.transform.position.x && this.transform.parent.position.y > this.transform.position.y)
            {
                goto case2;
            }
            GameObject room = (GameObject)Instantiate(Resources.Load("S"), new Vector3(transform.position.x, (transform.position.y + self_extent.y) * 2, 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            N = true;
            //rooms_to_create--;
            goto case2;
        }
        case2: if (S == false && this.name.Contains("S"))// && !this.gameObject.transform.parent.name.Contains("S"))
        {
            if (this.transform.parent.position.x == this.transform.position.x && this.transform.parent.position.y < this.transform.position.y)
            {
                goto case3;
            }
            GameObject room = (GameObject)Instantiate(Resources.Load("N"), new Vector3(transform.position.x, transform.position.y - (self_extent.y * 2), 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            S = true;
            //rooms_to_create--;
            goto case3;

        }
        case3: if (E == false && this.name.Contains("E"))// && !this.gameObject.transform.parent.name.Contains("E"))
        {
            if (this.transform.parent.position.y == this.transform.position.y && this.transform.parent.position.x > this.transform.position.x)
            {
                goto case4;
            }
            GameObject room = (GameObject)Instantiate(Resources.Load("W"), new Vector3(transform.position.x + (self_extent.x * 2), transform.position.y, 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            E = true;
            //rooms_to_create--;
            goto case4;
        }
        case4: if (W == false && this.name.Contains("W"))// && !this.gameObject.transform.parent.name.Contains("W"))
        {
            if (this.transform.parent.position.y == this.transform.position.y && this.transform.parent.position.x < this.transform.position.x)
            {
                return;
            }
            GameObject room = (GameObject)Instantiate(Resources.Load("E"), new Vector3(transform.position.x - (self_extent.x * 2), transform.position.y, 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            W = true;
            //rooms_to_create--;
        }

    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(GameObject.Find("NSEW").GetComponent<DungeonGeneration>().rooms_to_create);
        


    }
}
