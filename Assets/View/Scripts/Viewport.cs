using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace View {
public class Viewport : Singleton<Viewport> {
    public static Vector3 Forward {
        get => Vector3.Scale(new Vector3(1,0,1), Instance.transform.forward).normalized;
    }
    public static Vector3 Right {
        get => Vector3.Scale(new Vector3(1,0,1), Instance.transform.right).normalized;
    }
}
}
