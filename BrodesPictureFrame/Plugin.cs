using BepInEx;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.Assertions;

namespace BrodesPictureFrame
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        AssetBundle bundle;

        void Start()
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BrodesPictureFrame.res.mynewbundle");
            bundle = AssetBundle.LoadFromStream(stream);
            if (stream == null)
            {
                Debug.LogError("STREAM IS NULL. NOT LOADING ASSETS");
            }
            stream.Close();

            GameObject untitled0 = Instantiate(bundle.LoadAsset<GameObject>("untitled"));
        }
    }
}