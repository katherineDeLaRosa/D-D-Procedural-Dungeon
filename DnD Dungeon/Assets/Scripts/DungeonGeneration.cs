using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DungeonGeneration : MonoBehaviour {
    private Vector2 self_extent;
    private Vector2 other_extent;
    public int rooms_to_create;
    private bool N, S, E, W = false;
    //public string script = "otherRoom";
    //public System.Type script_type = System.Type.GetType(script + ",Assembly-CSharp");

    // Use this for initialization
    void Start () {
        GridLayout gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        Vector3Int cellPosition = gridLayout.WorldToCell(transform.position);
        transform.position = gridLayout.CellToWorld(cellPosition);
        self_extent = (Vector3)transform.GetComponent<TilemapRenderer>().bounds.extents;
    }
	
	// Update is called once per frame
	void Update () {

        //this is supposed to choose the amount of rooms to be made
        rooms_to_create = 10;
        /*for(int i = 0; i < rooms_to_create; i++)
        {

        }*/
        
        if (N == false)
        {
            GameObject room = (GameObject)Instantiate(Resources.Load("SEW"), new Vector3(transform.position.x, (transform.position.y + self_extent.y) * 2, 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            N = true;
            //rooms_to_create--;
        }
        if (S == false)
        {
            GameObject room = (GameObject)Instantiate(Resources.Load("NWS"), new Vector3(transform.position.x, transform.position.y - (self_extent.y * 2), 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            S = true;
            //rooms_to_create--;

        }
        if (E == false)
        {
            GameObject room = (GameObject)Instantiate(Resources.Load("NEW"), new Vector3(transform.position.x + (self_extent.x * 2), transform.position.y, 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            E = true;
            //rooms_to_create--;
        }
        if (W == false)
        {
            GameObject room = (GameObject)Instantiate(Resources.Load("NES"), new Vector3(transform.position.x - (self_extent.x * 2), transform.position.y, 0.0f), Quaternion.identity);
            room.transform.parent = this.gameObject.transform;
            room.AddComponent<otherRoom>();
            W = true;
            //rooms_to_create--;
        }


    }
}
