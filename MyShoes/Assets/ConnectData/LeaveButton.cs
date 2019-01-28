using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Diagnostics;
using System;

public class LeaveButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void leave() {
        UnityEngine.Debug.Log("leave");

        // open batch file
        try
        {
            Process myProcess = new Process();
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            string path = "C:\\Users\\Hansen\\Desktop\\testshoe\\OpenAR.bat";
            myProcess.StartInfo.Arguments = "/c" + path;
            myProcess.EnableRaisingEvents = true;
            myProcess.Start();
            myProcess.WaitForExit();
            int ExitCode = myProcess.ExitCode;
            //print(ExitCode);
        }
        catch (Exception e)
        {
            print(e);
        }

        // leave application
        Application.Quit();
    }   

}
