using ArduinoJukebox.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ArduinoJukebox.MVVM.Model
{
    internal static class SaveHandler
    {
        private static SettingsViewModel? SettingsVM => (MainViewModel.Instance?.VMs[1] as SettingsViewModel);
        private static HomeViewModel? HomeVM => (MainViewModel.Instance?.VMs[0] as HomeViewModel);

        public static DeviceInfo? LastConnectedDevice { get; set; }

        /// <summary>
        /// Save song path file and last used ble device
        /// </summary>
        public static void Save()
        {
            if (SettingsVM != null)
            {


            }
        }

        /// <summary>
        /// load song path file and last used ble device
        /// </summary>
        public static void Load()
        {
            if (SettingsVM != null)
            {

            }
        }


        public static void LoadSongs()
        {
            if (SettingsVM != null && HomeVM != null)
            {
                try
                {
                    string[] files = Directory.GetFiles(SettingsVM.LibraryPath, "*.song8");
                    List<Song> songs = new(files.Length);
                    for (int i = 0; i < files.Length; i++)
                    {
                        Song? song = JsonSerializer.Deserialize<Song>(File.ReadAllText(files[i]), new JsonSerializerOptions() { WriteIndented = true });
                        if (song != null)
                            songs.Add(song);
                    }
                    HomeVM.Songs = new(songs);
                    HomeVM.ActualSong = songs.FirstOrDefault();
                }
                catch (Exception)
                {

                }

            }
        }
    }
}
