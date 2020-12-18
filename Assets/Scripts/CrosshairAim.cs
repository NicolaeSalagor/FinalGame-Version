using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairAim : MonoBehaviour
{
    public Vector3 target;
    public GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 9f));
        crosshair.transform.position = new Vector3(target.x, target.y, 13.7f);
    }
}
