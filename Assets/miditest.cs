using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Multimedia;
using Melanchall.DryWetMidi.Core;
public class miditest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var midiFile = MidiFile.Read("ItNeverRains.mid");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
