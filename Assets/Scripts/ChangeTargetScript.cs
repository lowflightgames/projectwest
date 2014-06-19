using UnityEngine;
using System.Collections;

public class ChangeTargetScript : MonoBehaviour
{

		public Transform[] Targets;
		int targetID = 0;
		int currentTarget = 0;
		AICharacterControl AICOntrolScript;
		Rect labelRect = new Rect (10, Screen.height - 60, 230, 40);
		void Start ()
		{
				AICOntrolScript = gameObject.GetComponent<AICharacterControl> ();
				UpdateTargetAndIncrement ();
		}

		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.N)) {
						UpdateTargetAndIncrement ();
				}
		}
		void OnGUI ()
		{
				if (GUI.Button (labelRect, "Cel: " + Targets [currentTarget].name + "\nAby zmienić cel naciśnik klawisz 'N'")) {
						UpdateTargetAndIncrement ();
				}
		}
		void UpdateTargetAndIncrement ()
		{
				currentTarget = targetID;
				AICOntrolScript.target = Targets [targetID++];
				if (targetID == Targets.Length) {
						targetID = 0;
				}
		}
}
