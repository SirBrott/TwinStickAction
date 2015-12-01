using UnityEngine;
using System.Collections;

/// <summary>
/// General utility settings and methods.
/// </summary>
public class Utility : MonoBehaviour {


	/// <summary>
	/// Global instance.
	/// </summary>
	public static Utility instance;

	/// <summary>
	/// Turn on/off debuging.
	/// </summary>
	public bool isDebuging = false;

	void Start () {
		if (!instance)
			instance = this;
		else
			Debug.LogError ("Utility not an instance");
	}



}
