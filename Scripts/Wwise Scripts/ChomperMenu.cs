using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperMenu : MonoBehaviour
{

    public AkEvent chomper_idle_angry_layer;
    public AkEvent chomper_idle_growl;
    public AkEvent chomper_idle_scratch;
    public AkEvent chomper_tail_ready_long;
    public AkEvent chomper_tail_ready_short;
    public AkEvent chomper_tail_swing;

    void play_chomper_idle_angry_layer()
    {
        chomper_idle_angry_layer.HandleEvent(gameObject);
    }

    void play_chomper_idle_growl()
    {
        chomper_idle_growl.HandleEvent(gameObject);
    }

    void play_chomper_idle_scratch()
    {
        chomper_idle_scratch.HandleEvent(gameObject);
    }

    void play_chomper_tail_ready_long()
    {
        chomper_tail_ready_long.HandleEvent(gameObject);
    }

    void play_chomper_tail_ready_short()
    {
        chomper_tail_ready_short.HandleEvent(gameObject);
    }

    void play_chomper_tail_swing()
    {
        chomper_tail_swing.HandleEvent(gameObject);
    }
}
