﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _467_Excuse_UsingDispose
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Result { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            openFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            openFile(fileNames[random.Next(fileNames.Length)]);
        }

        private void openFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            BinaryFormatter formatter = new BinaryFormatter();
            Excuse tempExcuse;

            using (Stream input = File.OpenRead(excusePath))
            {
                tempExcuse = (Excuse)formatter.Deserialize(input);
            }
            Description = tempExcuse.Description;
            Result = tempExcuse.Result;
            LastUsed = tempExcuse.LastUsed;

            /*  
             using (StreamReader sr = new StreamReader(excusePath))
            {
                Description = sr.ReadLine();
                Result = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
            */
        }

        public void Save(string FileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream output = File.Create(FileName))
            {
                formatter.Serialize(output, this);
            }
            
            /*using (StreamWriter sw = new StreamWriter(FileName))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Result);
                sw.WriteLine(LastUsed);
            }
            */
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
