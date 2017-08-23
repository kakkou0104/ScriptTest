using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour {

	void Start () {
		//array配列を宣言
		int[] array = { 10, 20, 30, 40, 50 };

		//配列の各要素を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		Debug.Log ("ここから逆順表示");


		//逆順に表示
		for(int i = array.Length-1; i>=0; i--){
			Debug.Log(array[i]);
		}


	}
		
	// Update is called once per frame
	void Update () {

	}
}