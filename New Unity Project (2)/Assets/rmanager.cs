using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rmanager : MonoBehaviour
{
	public Text Text;
	public GameObject Manager;
	Manager script;

	// Start is called before the first frame update
	void Start()
    {
		Text.text = "r: 0";
		script = Manager.GetComponent<Manager>();
	}

    // Update is called once per frame
    void Update()
    {
		Text.text = "r:" + script.GetRotation().ToString();
	}
}
