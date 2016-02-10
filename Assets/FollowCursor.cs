using UnityEngine;
using System.Collections;

public class FollowCursor : MonoBehaviour {

    public GameObject cam = new GameObject();
    private Vector3 temp;
	
	// Update is called once per frame
	void Update () {
        cam.transform.position = Input.mousePosition;
        cam.transform.Translate(2*cam.transform.position.x, 2 * cam.transform.position.y, -400f);

        if (Input.GetButtonDown("Left Click"))
        {

        }
    }
}
