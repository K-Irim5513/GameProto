using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager : MonoBehaviour
{
    public float Rotation=0f;
    public const float AddRotation = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Rotation = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            Rotation -= AddRotation;
        }
        if (Input.GetKeyDown(KeyCode.RightShift)) {
            Rotation += AddRotation;
        }

    }
	public float GetRotation()
	{
		float tmp = Mathf.Abs(Rotation) / 1f;//絶対値を用意して、小数点以下を切る。*自分用メモ　ここで入れる値はRotationではない

		if (tmp > 360f)
			tmp %= 360;

		Debug.Log("Rotate:" + tmp);
		
	
		return tmp / 90;//角度を0,1,2,3で返す


	}
	public bool isRotate()
	{
		float tmp = Mathf.Abs(Rotation) / 1f;
		if (tmp > 360f)
			tmp %= 360;
		switch (tmp)
		{
			case 0:
				return true;
				break;
			case 1f:
			default:
				break;

		}

		return false;
	}
}
