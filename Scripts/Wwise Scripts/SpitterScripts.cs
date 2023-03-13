using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterScripts : MonoBehaviour
{


    public AK.Wwise.Event chomper_idle_angry_layer;
    public AK.Wwise.Event chomper_idle_growl;
    public AK.Wwise.Event chomper_idle_scratch;
    public AK.Wwise.Event chomper_tail_ready_long;
    public AK.Wwise.Event chomper_tail_ready_short;
    public AK.Wwise.Event chomper_tail_swing;
    public AK.Wwise.Event spitter_attack_short;
    public AK.Wwise.Event chomper_death_spin;
    public AK.Wwise.Event chomper_walk;
    public AK.Wwise.Event chomper_run;
    public AK.Wwise.Event spitter_growl;


    void play_spitter_attack_short ()
    {
        spitter_attack_short.Post(gameObject);
    }

    void play_spitter_growl ()
    {
        spitter_growl.Post(gameObject);
    }

    void play_chomper_death_spin()
    {
        chomper_death_spin.Post(gameObject);
    }

    void play_chomper_run()
    {
        chomper_run.Post(gameObject);
    }

    void play_chomper_idle_angry_layer()
    {
        chomper_idle_angry_layer.Post(gameObject);
    }

    void play_chomper_idle_growl()
    {
        chomper_idle_growl.Post(gameObject);
    }

    void play_chomper_idle_scratch()
    {
        chomper_idle_scratch.Post(gameObject);
    }

    void play_chomper_tail_ready_long()
    {
        chomper_tail_ready_long.Post(gameObject);
    }

    void play_chomper_tail_ready_short()
    {
        chomper_tail_ready_short.Post(gameObject);
    }

    void play_chomper_tail_swing()
    {
        chomper_tail_swing.Post(gameObject);
    }

}