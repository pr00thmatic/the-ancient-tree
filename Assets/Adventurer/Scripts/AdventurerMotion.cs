using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using View;

namespace Adventurer {
public class AdventurerMotion : MonoBehaviour {
    public float maxSpeed = 10;
    public float currentSpeed = 0;

    Animator _a;
    Animator _Animator { get { if (!_a) _a = _Model.GetComponent<Animator>(); return _a; } }

    CharacterController _c;
    CharacterController _Control { get { if (!_c) _c = GetComponent<CharacterController>(); return _c; } }

    GameObject _m;
    GameObject _Model { get { if (!_m) _m = transform.Find("model").gameObject; return _m; } }

    void Update () {
        Vector3 direction = Input.GetAxis("Horizontal") * Viewport.Right +
             Input.GetAxis("Vertical") * Viewport.Forward;

        _Control.Move(direction * maxSpeed * Time.deltaTime);
        _Animator.SetFloat("speed", _Control.velocity.magnitude);

        Vector3 forward = Vector3.Scale(new Vector3(1,0,1), _Control.velocity);
        currentSpeed = _Control.velocity.magnitude;
        if (_Control.velocity.magnitude > 0.05f) {
            _Model.transform.forward = forward;
        }
    }
}
}
