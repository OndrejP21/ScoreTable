using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ScoreTable.Services
{
    class SaveFileService
    {
        public SaveFileService()
        {
        }

        public string GetPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            var show = dialog.ShowDialog();

            if (show == DialogResult.OK)
            {

                return dialog.SelectedPath;

            } else
            {
                return String.Empty;
            }
        }

        public void CreateFile(string path, string[] ArrayToWrite)
        {
            using (FileStream fs = File.Create(path))
            {
                fs.Close();
            }

            File.WriteAllLines(path, ArrayToWrite);
        }

        public string[] ArrayToSave(ScoreTable.Forms.Table table, ScoreTable.Services.ScoreTableService service, DateTime EndDateTime)
        {
            string[] arrayWithScores = table.GetAllScores();

            string[] array = new string[16];
            array[0] = $"Home: {service.GetHomeName()}";
            array[1] = $"Host: {service.GetHostName()}";
            array[2] = $"Time-Start: {service.GetStartDateTime()}    Time-End: {EndDateTime}";
            array[3] = $"{table.GetTotalHome()}:{table.GetTotalHost()} – HOME:HOST";
            array[4] = "First Period";
            array[5] = $"Home: {arrayWithScores[0]}";
            array[6] = $"Host: {arrayWithScores[1]}";
            array[7] = "Second Period";
            array[8] = $"Home: {arrayWithScores[2]}";
            array[9] = $"Host: {arrayWithScores[3]}";
            array[10] = "Third Period";
            array[11] = $"Home: {arrayWithScores[4]}";
            array[12] = $"Host: {arrayWithScores[5]}";
            array[13] = "Fourth Period";
            array[14] = $"Home: {arrayWithScores[6]}";
            array[15] = $"Host: {arrayWithScores[7]}";

            return array;
        }
    }
}
