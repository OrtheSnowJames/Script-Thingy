using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Bolt;
using System;

public class ScriptOk : Bolt.GlobalEventListener
{
    //Just some varables and metadata or whatever

    [SerializeField]
    private string _map = "";
    private static string s_map;

    [SerializeField]
    private string _roomID  ="Test";
    private static string s_roomID;

    [SerializeField]
    private bool _isServer = false;

    public bool isServer {get => _isServer; set => _isServer = value;}

    public static string RoomID()
    {
        return s_roomID;
    }

    public static string Map()
    {
        return s_map;
    }
    private void Awake()
    {
        
    }

    static string GetArg(params string[] names)
    {
        var args = Environment.GetCommandLineArgs();
        return args[0] ;
        for (int i = 0; i < args.Length; i ++)
        {
            foreach (var name in names)
            {
                if (args[i] == name && args.Length > i +1) { return args[i + 1]; }
            }
        }
    }
   
}
