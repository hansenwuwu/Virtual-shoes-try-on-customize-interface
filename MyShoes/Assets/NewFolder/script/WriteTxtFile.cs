using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using System.IO;

public class WriteTxtFile : MonoBehaviour {

    private int ShoeNumber = 2;
    private int Shoe02_main_color = 0;
    private int Shoe02_part01_color = 0;
    private int Shoe02_part02_color = 0;
    private int Shoe02_part03_color = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // shoe 02 main color part
    public void Shoe02_main_color01()
    {
        Shoe02_main_color = 1;
    }

    public void Shoe02_main_color02()
    {
        Shoe02_main_color = 2;
    }

    public void Shoe02_main_color03()
    {
        Shoe02_main_color = 3;
    }

    public void Shoe02_main_color04()
    {
        Shoe02_main_color = 4;
    }

    public void Shoe02_main_color05()
    {
        Shoe02_main_color = 5;
    }

    // shoe 02 part01 color
    public void Shoe02_part01_color01()
    {
        Shoe02_part01_color = 1;
    }

    public void Shoe02_part01_color02()
    {
        Shoe02_part01_color = 2;
    }

    public void Shoe02_part01_color03()
    {
        Shoe02_part01_color = 3;
    }

    public void Shoe02_part01_color04()
    {
        Shoe02_part01_color = 4;
    }

    public void Shoe02_part01_color05()
    {
        Shoe02_part01_color = 5;
    }

    // shoe 02 part 02 color
    public void Shoe02_part02_color01()
    {
        Shoe02_part02_color = 1;
    }

    public void Shoe02_part02_color02()
    {
        Shoe02_part02_color = 2;
    }

    public void Shoe02_part02_color03()
    {
        Shoe02_part02_color = 3;
    }

    public void Shoe02_part02_color04()
    {
        Shoe02_part02_color = 4;
    }

    public void Shoe02_part02_color05()
    {
        Shoe02_part02_color = 5;
    }

    // shoe 02 part 03 color
    public void Shoe02_part03_color01()
    {
        Shoe02_part03_color = 1;
    }

    public void Shoe02_part03_color02()
    {
        Shoe02_part03_color = 2;
    }

    public void Shoe02_part03_color03()
    {
        Shoe02_part03_color = 3;
    }

    public void Shoe02_part03_color04()
    {
        Shoe02_part03_color = 4;
    }

    public void Shoe02_part03_color05()
    {
        Shoe02_part03_color = 5;
    }

    public void writefile()
    {
        // clean file
        File.WriteAllText("Assets/NewFolder/text file/custom log.txt", "");

        string path = "Assets/NewFolder/text file/custom log.txt";

        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(ShoeNumber + "" + Shoe02_main_color + "" + Shoe02_part01_color + "" + Shoe02_part02_color + "" + Shoe02_part03_color);

        writer.Close();

    }

}
