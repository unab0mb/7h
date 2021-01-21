using _7thHeaven.Code;
using Iros._7th.Workshop;
using Newtonsoft.Json.Linq;
using SeventhHeaven.Windows;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SeventhHeaven.Classes
{
    class FFNxDriverUpdater
    {
        private FileVersionInfo _currentDriverVersion = null;

        private string GetCurrentDriverVersion()
        {
            return _currentDriverVersion != null ? _currentDriverVersion.FileVersion : "0.0.0.0";
        }

        private string GetUpdateChannel()
        {
            switch(Sys.Settings.FFNxUpdateChannel)
            {
                case FFNxUpdateChannelOptions.Stable:
                    return "https://api.github.com/repos/julianxhokaxhiu/FFNx/releases/latest";
                case FFNxUpdateChannelOptions.Canary:
                    return "https://api.github.com/repos/julianxhokaxhiu/FFNx/releases/tags/canary";
                default:
                    return "";
            }
        }

        private string GetUpdateVersion(string name)
        {
            return name.Replace("FFNx-v", "");
        }

        private string GetUpdateReleaseUrl(dynamic assets)
        {
            for (int i = 0; i < assets.Count - 1; i++)
            {
                string url = assets[i].browser_download_url.Value;

                if (url.Contains("FFNx-FF7_1998"))
                    return url;
            }

            return String.Empty;
        }

        public void CheckForUpdates()
        {
            try
            {
                _currentDriverVersion = FileVersionInfo.GetVersionInfo(
                    Path.Combine(Sys.InstallPath, "FFNx.dll")
                );
            }
            catch (FileNotFoundException ex)
            {
                _currentDriverVersion = null;
            }

            DownloadItem download = new DownloadItem()
            {
                Links = new List<string>() { LocationUtil.FormatHttpUrl(GetUpdateChannel()) },
                SaveFilePath = Path.Combine(Sys.SysFolder, "temp", "ffnxupdateinfo.json"),
                Category = DownloadCategory.AppUpdate,
                ItemName = $"Checking for FFNx Updates using channel {Sys.Settings.FFNxUpdateChannel.ToString()}..."
            };

            download.IProc = new Install.InstallProcedureCallback(e =>
            {
                bool success = (e.Error == null && e.Cancelled == false);

                if (success)
                {
                    try
                    {
                        StreamReader file = File.OpenText(download.SaveFilePath);
                        dynamic release = JValue.Parse(file.ReadToEnd());
                        file.Close();
                        File.Delete(download.SaveFilePath);

                        Version curVersion = new Version(GetCurrentDriverVersion());
                        Version newVersion = new Version(GetUpdateVersion(release.name.Value));

                        switch(newVersion.CompareTo(curVersion))
                        {
                            case 1: // NEWER
                                if (
                                    MessageDialogWindow.Show(
                                        $"New FFNx Update driver found!\n\nCurrent Version: {curVersion.ToString()}\nNew Version: {newVersion.ToString()}\n\nWould you like to update?",
                                        "FFNx Driver Update found!",
                                        System.Windows.MessageBoxButton.YesNo,
                                        System.Windows.MessageBoxImage.Question
                                    ).Result == System.Windows.MessageBoxResult.Yes)
                                        DownloadAndExtract(GetUpdateReleaseUrl(release.assets), newVersion.ToString());
                                break;
                            case 0: // SAME
                                MessageDialogWindow.Show("Your FFNx Driver version seems to be up to date!", "No update found", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
                                break;
                            case -1: // OLDER
                                if (
                                    MessageDialogWindow.Show(
                                        $"Your current FFNx driver versions seems newer to the one currently available.\n\nCurrent Version: {curVersion.ToString()}\nNew Version: {newVersion.ToString()}\n\nWould you like to install it anyway?",
                                        "FFNx Driver Update found!",
                                        System.Windows.MessageBoxButton.YesNo,
                                        System.Windows.MessageBoxImage.Question
                                    ).Result == System.Windows.MessageBoxResult.Yes)
                                        DownloadAndExtract(GetUpdateReleaseUrl(release.assets), newVersion.ToString());
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageDialogWindow.Show("Something went wrong while checking for FFNx updates. Please try again later.", "Could not fetch for updates", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                        Sys.Message(new WMessage() { Text = $"Could not parse the FFNx release json at {GetUpdateChannel()}", LoggedException = e.Error });
                    }
                }
                else
                {
                    MessageDialogWindow.Show("Something went wrong while checking for FFNx updates. Please try again later.", "Could not fetch for updates", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    Sys.Message(new WMessage() { Text = $"Could not fetch for FFNx updates at {GetUpdateChannel()}", LoggedException = e.Error });
                }
            });

            Sys.Downloads.AddToDownloadQueue(download);
        }

        private void DownloadAndExtract(string url, string version)
        {
            if (url != String.Empty)
            {
                DownloadItem download = new DownloadItem()
                {
                    Links = new List<string>() { LocationUtil.FormatHttpUrl(url) },
                    SaveFilePath = Path.Combine(Sys.SysFolder, "temp", url.Substring(url.LastIndexOf("/") + 1)),
                    Category = DownloadCategory.AppUpdate,
                    ItemName = $"Downloading FFNx Update {url}..."
                };

                download.IProc = new Install.InstallProcedureCallback(e =>
                {
                    bool success = (e.Error == null && e.Cancelled == false);

                    if (success)
                    {
                        using (var archive = ZipArchive.Open(download.SaveFilePath))
                        {
                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory(Sys.InstallPath, new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                            }
                        }

                        MessageDialogWindow.Show($"Successfully updated FFNx to version {version}.\n\nRemember to configure again your driver as settings have been resetted.\n\nEnjoy!", "Update successful", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
                        Sys.Message(new WMessage() { Text = $"Successfully updated FFNx to version {version}" });

                        File.Delete(download.SaveFilePath);
                    }
                    else
                    {
                        MessageDialogWindow.Show("Something went wrong while downloading the FFNx update. Please try again later.", "Could not download the update", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                        Sys.Message(new WMessage() { Text = $"Could not download the FFNx update {url}", LoggedException = e.Error });
                    }
                });

                Sys.Downloads.AddToDownloadQueue(download);
            }
            else
            {
                MessageDialogWindow.Show("Something went wrong while downloading the FFNx update. Please try again later.", "Could not download the update", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}
