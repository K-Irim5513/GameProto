using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class slimeControl : MonoBehaviour
{
	public GameObject Manager;
	Manager script;
	
	// Start is called before the first frame update
	void Start()
    {
		script = Manager.GetComponent<Manager>();
	}

    // Update is called once per frame
    void Update()
    {
		float Rotation = script.Rotation;
		this.transform.Rotate(new Vector3(0f, 0f, Rotation) * Time.deltaTime);
		switch (script.GetRotation())
		{
			case 0:
				
				if (transform.position.y>=-3.5)
				{
					transform.Translate(0, -000.1f, 0);
				}
				break;
			case 1:
				if (transform.position.x<=3)
				{
					transform.Translate(000.1f, 0, 0);
				}
				break;
			default:
				break;

		}
	}
}
