using System.Collections;
using UnityEngine;
public class Consumable : MonoBehaviour {
    public void Consume (GameObject target) {
        Feature[] features = GetComponentsInChildren<Feature> ();
        for (int i = 0; i < features.Length; ++i)
            features[i].Apply (target);
    }
}