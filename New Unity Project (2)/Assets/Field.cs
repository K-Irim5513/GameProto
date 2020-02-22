using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
   public GameObject Manager;
   Manager script;
    // Start is called before the first frame update
    void Start()
    {
        //Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<Manager>();

    }

	// Update is called once per frame
	void Update()
	{
		float Rotation = script.Rotation;

		this.transform.Rotate(new Vector3(0f, 0f, Rotation) * Time.deltaTime);
	
	}
}
