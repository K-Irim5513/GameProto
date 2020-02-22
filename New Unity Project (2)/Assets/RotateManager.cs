using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateManager : MonoBehaviour
{
	
	public GameObject Object;
	public Text rotateText;
	private Transform fieldTrans;
	private float Z = 0;
	// Start is called before the first frame update
	void Start()
    {
		fieldTrans = Object.GetComponent<Transform>();
		rotateText.text = "Z: 0";
	}

    // Update is called once per frame
    void Update()
    {
		Z = fieldTrans.localEulerAngles.z;
	
		// テキストの表示を入れ替える
		rotateText.text = "Z:"+Z.ToString();
	}
}
