﻿using SeventhHeaven.Classes;
using SeventhHeaven.ViewModels;
using SeventhHeavenUI.ViewModels;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace SeventhHeaven.Windows
{
    /// <summary>
    /// Interaction logic for GeneralSettingsWindow.xaml
    /// </summary>
    public partial class GeneralSettingsWindow : Window
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public GeneralSettingsViewModel ViewModel { get; set; }

        public GeneralSettingsWindow()
        {
            InitializeComponent();

            ViewModel = new GeneralSettingsViewModel();
            this.DataContext = ViewModel;

            ViewModel.LoadSettings();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            bool settingsSaved = ViewModel.SaveSettings();

            if (settingsSaved)
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnFf7Exe_Click(object sender, RoutedEventArgs e)
        {
            string initialDir = "";

            if (File.Exists(ViewModel.FF7ExePathInput))
            {
                initialDir = Path.GetDirectoryName(ViewModel.FF7ExePathInput);
            }

            string exePath = FileDialogHelper.BrowseForFile("exe file (*.exe)|*.exe", "Select FF7.exe", initialDir);

            if (!string.IsNullOrEmpty(exePath))
            {
                ViewModel.FF7ExePathInput = exePath;
            }
        }

        private void btnMovies_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = FileDialogHelper.BrowseForFolder("Select Movies Folder", ViewModel.MoviesPathInput);

            if (!string.IsNullOrEmpty(folderPath))
            {
                ViewModel.MoviesPathInput = folderPath;
            }
        }

        private void btnTextures_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = FileDialogHelper.BrowseForFolder("Select Textures Folder", ViewModel.TexturesPathInput);

            if (!string.IsNullOrEmpty(folderPath))
            {
                ViewModel.TexturesPathInput = folderPath;
            }
        }

        private void btnLibrary_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = FileDialogHelper.BrowseForFolder("Select 7th Heaven Library Folder", ViewModel.LibraryPathInput);

            if (!string.IsNullOrEmpty(folderPath))
            {
                ViewModel.LibraryPathInput = folderPath;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ScrollTextboxesToEnd();
            RecalculateColumnWidths();
        }

        private void ScrollTextboxesToEnd()
        {
            try
            {
                // reference: https://stackoverflow.com/questions/11232438/single-line-wpf-textbox-horizontal-scroll-to-end
                if (!string.IsNullOrWhiteSpace(ViewModel.MoviesPathInput))
                {
                    txtMovies.CaretIndex = ViewModel.MoviesPathInput.Length;
                    var rect = txtMovies.GetRectFromCharacterIndex(txtMovies.CaretIndex);
                    txtMovies.ScrollToHorizontalOffset(rect.Right);
                }

                if (!string.IsNullOrWhiteSpace(ViewModel.TexturesPathInput))
                {
                    txtTextures.CaretIndex = ViewModel.TexturesPathInput.Length;
                    var rect = txtTextures.GetRectFromCharacterIndex(txtTextures.CaretIndex);
                    txtTextures.ScrollToHorizontalOffset(rect.Right);

                }

                if (!string.IsNullOrWhiteSpace(ViewModel.LibraryPathInput))
                {
                    txtLibrary.CaretIndex = ViewModel.LibraryPathInput.Length;
                    var rect = txtLibrary.GetRectFromCharacterIndex(txtLibrary.CaretIndex);
                    txtLibrary.ScrollToHorizontalOffset(rect.Right);

                }

                if (!string.IsNullOrWhiteSpace(ViewModel.FF7ExePathInput))
                {
                    txtFf7Exe.CaretIndex = ViewModel.FF7ExePathInput.Length;
                    var rect = txtFf7Exe.GetRectFromCharacterIndex(txtFf7Exe.CaretIndex);
                    txtFf7Exe.ScrollToHorizontalOffset(rect.Right);
                }
            }
            catch (System.Exception ex)
            {
                Logger.Warn($"Failed to scroll textbox to end: {ex.Message}");
            }
        }

        /// <summary>
        /// Opens 'Edit Subscription' popup
        /// </summary>
        private void btnEditUrl_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.IsSubscriptionPopupOpen)
            {
                return; // dont do anything if popup opened already
            }

            if (lstSubscriptions.SelectedItem == null)
            {
                return; // nothing selected
            }

            ViewModel.EditSelectedSubscription((lstSubscriptions.SelectedItem as SubscriptionSettingViewModel));
        }

        private void btnRemoveUrl_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.IsSubscriptionPopupOpen)
            {
                return; // dont do anything if popup is opened
            }

            ViewModel.RemoveSelectedSubscription((lstSubscriptions.SelectedItem as SubscriptionSettingViewModel));
            RecalculateColumnWidths();
        }

        /// <summary>
        /// Opens 'Add Subscription' popup
        /// </summary>
        private void btnAddUrl_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.IsSubscriptionPopupOpen)
            {
                return; // dont do anything if popup opened already
            }

            ViewModel.AddNewSubscription();
        }

        /// <summary>
        /// Closes 'New/Edit' subscription popup and clears out any entered text
        /// </summary>
        private void btnCancelSubscription_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CloseSubscriptionPopup();
        }

        private void btnSaveSubscription_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SaveSubscription())
            {
                RecalculateColumnWidths();
            }
        }

        private void Window_LocationChanged(object sender, System.EventArgs e)
        {
            ViewModel.IsSubscriptionPopupOpen = false;
            ViewModel.IsProgramPopupOpen = false;
        }

        private void Window_Deactivated(object sender, System.EventArgs e)
        {
            ViewModel.IsSubscriptionPopupOpen = false;
            ViewModel.IsProgramPopupOpen = false;
        }

        internal void RecalculateColumnWidths()
        {
            // trigger columns to auto re-size. https://stackoverflow.com/questions/42676198/gridviewcolumn-autosize-only-work-once
            colName.Width = colName.ActualWidth;
            colName.Width = double.NaN;

            colUrl.Width = colUrl.ActualWidth;
            colUrl.Width = double.NaN;
        }

        private void btnAddProgram_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.IsProgramPopupOpen)
            {
                return; // dont do anything if popup opened already
            }

            ViewModel.AddNewProgram();
        }

        private void btnRemoveProgram_Click(object sender, RoutedEventArgs e)
        {
            if (lstPrograms.SelectedItem == null)
            {
                return; // nothing selected
            }

            ViewModel.RemoveSelectedProgram((lstPrograms.SelectedItem as ProgramToRunViewModel));
        }

        private void btnEditProgram_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.IsProgramPopupOpen)
            {
                return; // dont do anything if popup opened already
            }

            if (lstPrograms.SelectedItem == null)
            {
                return; // nothing selected
            }

            ViewModel.EditSelectedProgram((lstPrograms.SelectedItem as ProgramToRunViewModel));
        }

        private void btnCancelProgramAction_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CloseProgramPopup();
        }

        private void btnSaveProgram_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SaveProgramToRun();
        }

        private void btnBrowseProgram_Click(object sender, RoutedEventArgs e)
        {
            string pathToProgram = FileDialogHelper.BrowseForFile("All files|*.*", "Select a program to run such as an .exe or script", ViewModel.NewProgramPathText);

            ViewModel.IsProgramPopupOpen = true; // opening file dialog closes popup so re-open it

            if (!string.IsNullOrWhiteSpace(pathToProgram))
            {
                ViewModel.NewProgramPathText = pathToProgram;
            }
        }
    }
}
