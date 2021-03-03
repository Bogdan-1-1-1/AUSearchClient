using System;
using System.IO;

namespace sound_project_app
{
    class StorageManager {
        static string path = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "/storage/";

        public static void saveSample(string gameTitle, string type, string filename, int[] sample) {
            if(!Directory.Exists(path +"samples/"+ gameTitle)) {
                Directory.CreateDirectory(path+ "samples/" + gameTitle);
                Directory.CreateDirectory(path + "samples/" + gameTitle + "/fire_samples");
                Directory.CreateDirectory(path + "samples/" + gameTitle + "/step_samples");
                Directory.CreateDirectory(path + "samples/" + gameTitle + "/explosion_samples");
            }
            if(!File.Exists(path + "samples/" + gameTitle + "/" + type + "/" + filename + ".wav")) {
                 var myFile = File.Create(path + "samples/" + gameTitle + "/" + type + "/" + filename + ".wav");
                 myFile.Close();
                 File.WriteAllBytes(path + "samples/" + gameTitle + "/" + type + "/" + filename + ".wav", intToByte(sample));
            } else Console.Write("такой файл уже существует: " + "\n" + "   type: " + type + "\n" + "   filename: " + filename + "\n");
        }

        public static void saveValues(string gameTitle, double[] values) {
            if(!Directory.Exists(path +"values/"+ gameTitle)) {
                Directory.CreateDirectory(path +"values/"+ gameTitle);
            }
            if(!File.Exists(path + "values/" + gameTitle + "/values.txt")) {
                var myFile = File.Create(path + "values/" + gameTitle + "/values.txt");
                myFile.Close();

                File.WriteAllLines(path + "values/" + gameTitle + "/values.txt", doubleToText(values));
            }
        }
        private static byte[] intToByte(int[] arr) {

            byte[] arr1 = new byte[arr.Length];
            for(int i = 0; i < arr.Length; i++) {
                arr1[i] = (byte) arr[i];
            }
            return arr1;
        }         
        private static string[] doubleToText(double[] arr) {
            string[] arr1 = new string[arr.Length];
            for(int i = 0; i < arr.Length; i++) {
                arr1[i] = arr[i] +"";
            }
            return arr1;
        }

    }

}   