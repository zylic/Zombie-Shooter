using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieShooter.Properties;

namespace ZombieShooter
{
    public class Player1
    {
        CustomizeMenu customizeMenu;
        public event Action NameChanged;
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Prestige { get; set; }
        public int Level { get; set; }
        public Perks perk1 { get; set; }
        public Perks perk2 { get; set; }
        public Perks perk3 { get; set; }
        public Perks perk4 { get; set; }
        public bool performanceMode { get; set; }


        public Player1()
        {
            Name = "Rookie";

            Experience = 0;
            Prestige = 0;
            Level = 0;

            perk1 = null;
            perk2 = null;
            perk3 = null;
            perk4 = null;

            performanceMode = true;

            customizeMenu = new CustomizeMenu(this);
        }

        public void ChangeName(string name)
        {
            Name = name;
            OnNameChanged();
        }

        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke();
        }

        public void SavePlayerData()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Player Data";
                saveFileDialog.DefaultExt = "txt";

                saveFileDialog.FileName = GetDefaultFileName();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(Name);

                        writer.WriteLine(Experience);
                        writer.WriteLine(Prestige);
                        writer.WriteLine(Level);

                        writer.WriteLine(performanceMode);

                        writer.WriteLine(perk1);
                        writer.WriteLine(perk2);
                        writer.WriteLine(perk3);
                        writer.WriteLine(perk4);
                    }
                }
            }
        }
        public void LoadPlayerData()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Load Player Data";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (File.Exists(filePath))
                    {
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            Name = reader.ReadLine();

                            Experience = int.Parse(reader.ReadLine());
                            Prestige = int.Parse(reader.ReadLine());
                            Level = int.Parse(reader.ReadLine());

                            string performanceModeString = reader.ReadLine();
                            bool performanceModeBool;
                            if (bool.TryParse(performanceModeString, out performanceModeBool))
                            {
                                performanceMode = performanceModeBool;
                                // Conversion successful
                            }
                            else
                            {
                                performanceMode = false;
                            }

                            perk1 = null;
                            perk2 = null;
                            perk3 = null;
                            perk4 = null;

                            List<string> perkNames = new List<string>();
                            while (!reader.EndOfStream)
                            {
                                string perkName = reader.ReadLine();
                                perkNames.Add(perkName);
                            }

                            if (perkNames.Count >= 1)
                            {
                                perk1 = customizeMenu.AvailablePerks.FirstOrDefault(perk => perk.Name == perkNames[0]);
                            }
                            if (perkNames.Count >= 2)
                            {
                                perk2 = customizeMenu.AvailablePerks.FirstOrDefault(perk => perk.Name == perkNames[1]);
                            }
                            if (perkNames.Count >= 3)
                            {
                                perk3 = customizeMenu.AvailablePerks.FirstOrDefault(perk => perk.Name == perkNames[2]);
                            }
                            if (perkNames.Count >= 4)
                            {
                                perk4 = customizeMenu.AvailablePerks.FirstOrDefault(perk => perk.Name == perkNames[3]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Save file does not exist or is corrupted.");
                    }
                }
            }
        }

        private string GetDefaultFileName()
        {
            string baseFileName = "SaveFile";
            int index = 1;
            string defaultFileName;

            do
            {
                defaultFileName = $"{baseFileName}{index}.txt";
                index++;
            } while (File.Exists(defaultFileName));

            return defaultFileName;
        }
    }
}
