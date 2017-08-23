using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {

	private int mp = 53;//mp

	//magic関数
	public void magic (){

		this.mp -= 5;//mpを減らす

		if (mp > 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);

		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}

	}
}

public class Test : MonoBehaviour {

	void Start () {
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();

		//magic関数を呼び出す
		for (int i = 0; i < 11; i++) {
			lastboss.magic ();
		}
	}
		
	// Update is called once per frame
	void Update () {

	}
}