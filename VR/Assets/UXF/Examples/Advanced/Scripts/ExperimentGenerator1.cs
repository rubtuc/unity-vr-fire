using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

public class ExperimentGenerator1 : MonoBehaviour
{
    // generate the blocks and trials for the session.
    // the session is passed as an argument by the event call.
    public void Generate(Session session)
    {
        // generate a single block with 10 trials.
        int numTrials = 10;
        session.CreateBlock(numTrials);
    }
}
