using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Singleton<T> : MonoBehaviour
where T: MonoBehaviour {
    static T _instance;
    public static T Instance {
        get {
            if (!(_instance as MonoBehaviour)) {
                _instance = GameObject.FindObjectOfType<T>();
            }

            return _instance;
        }
    }
}
